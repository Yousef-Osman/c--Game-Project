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
            Console.ReadLine(); 
            CloseAllSockets();  //closing the server and the clients if enter is pressed
        }

        

        private static void SendMesageCallback(IAsyncResult ar)
        {
            //StateObject state = (StateObject)ar.AsyncState;
            Socket current = (Socket)ar.AsyncState;
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

            Room room1 = new Room(player1);
            room1.RoomNo = 1;
            Room room2 = new Room(player2);
            room2.RoomNo = 2;
            Room room3 = new Room(player3);
            room3.RoomNo = 3;
            Room room4 = new Room(player4);
            room4.RoomNo = 4;

            room1.AddPlayer(player2);
            room1.AddPlayer(player3);
            room1.AddPlayer(player4);

            room4.AddPlayer(player4);

            rooms.Add(room1);
            rooms.Add(room2);
            rooms.Add(room3);
            rooms.Add(room4);

            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            Console.WriteLine("rooms count is" + rooms.Count);
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
                Room newRoom = new Room(newPlayer);
                newRoom.RoomNo = rooms.Count + 1;
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
                        GameStart(roomNumber);
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

        private static void GameStart(int roomNumber)
        {
            StateObject state = new StateObject();

            byte[] sendBuffer = new byte[1024];
            string message = JsonConvert.SerializeObject("this is a message");
            sendBuffer = Encoding.ASCII.GetBytes(message);

            foreach (Room room in rooms)
            {
                if (room.RoomNo == roomNumber)
                {
                    foreach (Player player in room.players)
                    {
                        //state.workSocket = player.clientSocket;
                        player.clientSocket.BeginSend(sendBuffer, 0, sendBuffer.Length, SocketFlags.None, SendMesageCallback, player.clientSocket);
                    }
                }
            }
        }

        // Close all connected client (server connections gets closed with the clients).
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
