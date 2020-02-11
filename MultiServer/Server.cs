using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace GameServer
{
    public class StateObject
    {
        public Socket workSocket = null;
        public const int BufferSize = 1024;
        public byte[] buffer = new byte[BufferSize];
        public StringBuilder sb = new StringBuilder();
    }
    class Server
    {
        private static readonly Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static readonly List<Socket> clientSockets = new List<Socket>();
        private static readonly List<Player> players = new List<Player>();
        private static readonly List<Room> rooms = new List<Room>();
        private static byte[] buffer = new byte[BUFFER_SIZE];
        private const int BUFFER_SIZE = 2048;
        private const int PORT = 15153;

        static void Main()
        {
            Console.Title = "Server";
            SetupServer();
            GameStart();
            Console.ReadLine(); 
            CloseAllSockets();  //closing the server and the clients if enter is pressed
        }

        private static void GameStart()
        {
            byte[] sendBuffer = new byte[1024];
            string message = JsonConvert.SerializeObject("this is a message");
            sendBuffer = Encoding.ASCII.GetBytes(message);

            foreach (Room room in rooms)
            {
                List<Player> roomPlayers = room.getPlayers();
                foreach (Player player in roomPlayers)
                {
                    player.clientSocket.BeginSend(sendBuffer, 0, sendBuffer.Length, SocketFlags.None, SendMesageCallback, player.clientSocket);
                }
            }
        }

        private static void SendMesageCallback(IAsyncResult ar)
        {
            StateObject state = (StateObject)ar.AsyncState;
            Socket current = state.workSocket;
            current.EndSend(ar);
            Console.WriteLine("message has been sent to the player");

            return;
            //current.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, RecevieRoomCallback, state);
        }

        private static void SetupServer()
        {
            Console.WriteLine("Starting Server...");
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
            serverSocket.Listen(0);
            //createUsers();

            serverSocket.BeginAccept(AcceptClientCallback, null); //Begin Accepting clients
            Console.WriteLine("Server is Listening...");
        }

        public static void createUsers()
        {
            Player player1 = new Player();
            player1.userName = "danger";
            Player player2 = new Player();
            player2.userName = "black dragon";
            Player player3 = new Player();
            player3.userName = "sour";
            Player player4 = new Player();
            player4.userName = "dark desert";

            Room room1 = new Room();
            room1.RoomNo = 1;
            Room room2 = new Room();
            room2.RoomNo = 2;
            Room room3 = new Room();
            room3.RoomNo = 3;
            Room room4 = new Room();
            room4.RoomNo = 4;

            room1.AddPlayer(player1);
            room1.AddPlayer(player2);
            room1.AddPlayer(player3);
            room1.AddPlayer(player4);
            room1.status = "watch";

            room2.AddPlayer(player1);
            room2.AddPlayer(player2);
            room2.AddPlayer(player3);
            room2.AddPlayer(player4);
            room2.status = "watch";

            room3.AddPlayer(player1);
            room3.AddPlayer(player2);
            room3.AddPlayer(player3);
            room3.AddPlayer(player4);
            room3.status = "watch";

            room4.AddPlayer(player1);
            room4.AddPlayer(player2);
            room4.AddPlayer(player3);
            room4.AddPlayer(player4);
            room4.status = "play";

            rooms.Add(room1);
            rooms.Add(room2);
            rooms.Add(room3);
            rooms.Add(room4);

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);

        }

        private static void AcceptClientCallback(IAsyncResult AR)
        {
            Socket client;

            try
            {
                client = serverSocket.EndAccept(AR); //casting the IAsyncResult object to a client socket (get the client)
            }
            catch (ObjectDisposedException) //on exit when properly closing sockets
            {
                return;
            }

            StateObject state = new StateObject();
            state.workSocket = client;
            
            client.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, ReceiveUserNameCallback, state);

            clientSockets.Add(client);
            Console.WriteLine("Client connected, waiting for request...");
            serverSocket.BeginAccept(AcceptClientCallback, null);
        }

        private static void ReceiveUserNameCallback(IAsyncResult AR)
        {
            StateObject state = (StateObject)AR.AsyncState;
            Socket current = state.workSocket;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                Console.WriteLine("Client forcefully disconnected");
                // Don't shutdown because the socket may be disposed and its disconnected anyway.
                current.Close();
                clientSockets.Remove(current);
                return;
            }

            //Receiving userName from client and displaying it
            string recievedString = Encoding.ASCII.GetString(state.buffer, 0, received);
            Player recievedMessage = JsonConvert.DeserializeObject<Player>(recievedString);
            Console.WriteLine("Received Text: " + recievedMessage.userName);

            //sending list of rooms to client
            byte[] sendBuffer = new byte[1024];
            string message = JsonConvert.SerializeObject(rooms);
            sendBuffer = Encoding.ASCII.GetBytes(message);
            current.BeginSend(sendBuffer, 0, sendBuffer.Length, SocketFlags.None, SendRoomsCallback, state);
        }

        private static void SendRoomsCallback(IAsyncResult AR)
        {
            StateObject state = (StateObject)AR.AsyncState;
            Socket current = state.workSocket;
            current.EndSend(AR);
            Console.WriteLine("rooms has been sent to the player ");

            current.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, RecevieRoomCallback, state);
        }

        private static void RecevieRoomCallback(IAsyncResult ar)
        {
            StateObject state = (StateObject)ar.AsyncState;
            Socket current = state.workSocket;
            int received;

            try
            {
                received = current.EndReceive(ar);
            }
            catch (Exception)
            {
                Console.WriteLine("Client forcefully disconnected");
                current.Close();
                clientSockets.Remove(current);
                return;
            }

            //Receiving room number from client and displaying it
            string recievedString = Encoding.ASCII.GetString(state.buffer, 0, received);
            Player recievedMessage = JsonConvert.DeserializeObject<Player>(recievedString);
            Console.WriteLine("Received Text: " + recievedMessage.roomNo);

            Player newPlayer = new Player();
            newPlayer.clientSocket = current;
            newPlayer.id = players.Count + 1;
            players.Add(newPlayer);

            if(recievedMessage.status == "creating room")
            {
                Room newRoom = new Room();
                newRoom.AddPlayer(newPlayer);
                newRoom.RoomNo = rooms.Count + 1;
                newRoom.status = "play";
                rooms.Add(newRoom);
                Console.WriteLine($"playerNumber {newPlayer.id} has created room number {newRoom.RoomNo}");

            }
            else
            {
                int roomNumber = recievedMessage.roomNo;
                foreach (Room room in rooms)
                {
                    if (room.RoomNo == roomNumber)
                    {
                        room.AddPlayer(newPlayer);
                        Console.WriteLine($"playerNumber {newPlayer.id} has joind room number {roomNumber}");
                    }
                }
            }

            return;

            //sending player data back to client
            //byte[] sendBuffer = new byte[1024];
            //string message = JsonConvert.SerializeObject(newPlayer.id);
            //sendBuffer = Encoding.ASCII.GetBytes(message);
            //current.BeginSend(sendBuffer, 0, sendBuffer.Length, SocketFlags.None, SendBackPlayerCallback, state);
        }

        private static void SendBackPlayerCallback(IAsyncResult ar)
        {
            StateObject state = (StateObject)ar.AsyncState;
            Socket current = state.workSocket;
            current.EndSend(ar);
            Console.WriteLine("player data has been sent back to the player ");
            return;
        }

        //=========================================================================================================
        private static void RecieveChoiceCallback(IAsyncResult AR)
        {
            Socket current = (Socket)AR.AsyncState;
            int received;

            try
            {
                received = current.EndReceive(AR);
            }
            catch (SocketException)
            {
                Console.WriteLine("Client forcefully disconnected");
                // Don't shutdown because the socket may be disposed and its disconnected anyway.
                current.Close();
                clientSockets.Remove(current);
                return;
            }

            //byte[] buffer = new byte[BUFFER_SIZE];
            byte[] recievedBuffer = new byte[received];
            Array.Copy(buffer, recievedBuffer, received);
            string recievedString = Encoding.ASCII.GetString(recievedBuffer);
            Player recievedMessage = JsonConvert.DeserializeObject<Player>(recievedString);
            Console.WriteLine("Received Text: " + recievedMessage.roomNo);
        }

        //private static void ReceiveCallback(IAsyncResult AR)
        //{
        //    Socket current = (Socket)AR.AsyncState;
        //    int received;

        //    try
        //    {
        //        received = current.EndReceive(AR);
        //    }
        //    catch (SocketException)
        //    {
        //        Console.WriteLine("Client forcefully disconnected");
        //        // Don't shutdown because the socket may be disposed and its disconnected anyway.
        //        current.Close();
        //        clientSockets.Remove(current);
        //        return;
        //    }

        //    byte[] buffer = new byte[BUFFER_SIZE];
        //    byte[] recievedBuffer = new byte[received];
        //    Array.Copy(buffer, recievedBuffer, received);
        //    string recievedString = Encoding.ASCII.GetString(recievedBuffer);
        //    Message recievedMessage = JsonConvert.DeserializeObject<Message>(recievedString);

        //    Console.WriteLine("Received Text: " + recievedMessage.PlayerData.userName);
        //    Console.WriteLine("Length of recieved Message is: " + received);

        //    Message sendMessage;
        //    Player newPlayer;
        //    string message;
        //    byte[] sendBuffer;
        //    int roomNumber;
        //    switch (recievedMessage.PlayerData.status)
        //    {
        //        case 1: //create room
        //            newPlayer = recievedMessage.PlayerData;
        //            newPlayer.clientSocket = current;
        //            Room NewRoom = new Room();
        //            NewRoom.RoomNo = (rooms.Count)+1;
        //            recievedMessage.PlayerData.roomNo = (rooms.Count) + 1;
        //            NewRoom.AddPlayer(newPlayer);
        //            rooms.Add(NewRoom);

        //            sendMessage = new Message();
        //            //sendMessage.PlayerData = newPlayer;
        //            sendMessage.Rooms = rooms;

        //            message = JsonConvert.SerializeObject(sendMessage);
        //            sendBuffer = Encoding.ASCII.GetBytes(message);
        //            current.Send(sendBuffer, 0, sendBuffer.Length, SocketFlags.None);
        //            Console.WriteLine("new Player has joined and room number " + NewRoom.RoomNo + " is created.");
        //            break;
        //        case 2: //Join room
        //            newPlayer = recievedMessage.PlayerData;
        //            newPlayer.clientSocket = current;

        //            sendMessage = new Message();
        //            roomNumber = newPlayer.roomNo;
        //            rooms[roomNumber].AddPlayer(newPlayer);
        //            //sendMessage.PlayerData = newPlayer;
        //            sendMessage.Rooms = rooms;

        //            message = JsonConvert.SerializeObject(sendMessage);
        //            sendBuffer = Encoding.ASCII.GetBytes(message);
        //            current.Send(sendBuffer, 0, sendBuffer.Length, SocketFlags.None);
        //            Console.WriteLine("new Player has joined room number " + roomNumber);
        //            break;
        //        case 3: //Join room
        //            newPlayer = recievedMessage.PlayerData;
        //            newPlayer.clientSocket = current;

        //            sendMessage = new Message();
        //            roomNumber = newPlayer.roomNo;
        //            rooms[roomNumber].AddPlayer(newPlayer);
        //            //sendMessage.PlayerData = newPlayer;
        //            sendMessage.Rooms = rooms;

        //            message = JsonConvert.SerializeObject(sendMessage);
        //            sendBuffer = Encoding.ASCII.GetBytes(message);
        //            current.Send(sendBuffer, 0, sendBuffer.Length, SocketFlags.None);
        //            Console.WriteLine("new Player has joined room number " + roomNumber);
        //            break;
        //    }
            #region
            //if (text.ToLower() == "get time") // Client requested time
            //{
            //    Console.WriteLine("Text is a get time request");
            //    byte[] data = Encoding.ASCII.GetBytes(DateTime.Now.ToLongTimeString());
            //    current.Send(data);
            //    Console.WriteLine("Time sent to client");
            //}
            //else if (text.ToLower() == "exit") // Client wants to exit gracefully
            //{
            //    // Always Shutdown before closing
            //    current.Shutdown(SocketShutdown.Both);
            //    current.Close();
            //    clientSockets.Remove(current);
            //    Console.WriteLine("Client disconnected");
            //    return;
            //}
            //else
            //{
            //    Console.WriteLine("Text is an invalid request");
            //    byte[] data = Encoding.ASCII.GetBytes("Invalid request");
            //    current.Send(data);
            //    Console.WriteLine("Warning Sent");
            //}
            #endregion
        //    current.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, ReceiveCallback, current);
        //}

        // Close all connected client (we do not need to shutdown the server socket as its connections are already closed with the clients).
        private static void CloseAllSockets()
        {
            foreach (Socket socket in clientSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            serverSocket.Close();
        }
    }
}
