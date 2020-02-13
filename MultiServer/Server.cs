using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;

namespace GameServer
{
    class Server
    {
        private static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static List<Socket> clientSockets = new List<Socket>();
        private static List<Player> players = new List<Player>();
        private static List<Room> rooms = new List<Room>();
        private static byte[] buffer = new byte[BufferSize];
        private const int BufferSize = 1024;
        private const int PORT = 15153;

        static void Main()
        {
            Console.Title = "Server";
            SetupServer();
            Console.ReadLine(); 
            CloseAllSockets();  //closing the server and the clients if enter is pressed
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
                        
                        if(room.status == "waiting")
                        {
                            room.AddPlayer(newPlayer);
                            GameStart(roomNumber);
                        }
                        else
                        {
                            room.AddPlayer(newPlayer);
                        }
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

        private static void SendMesageCallback(IAsyncResult ar)
        {
            //StateObject state = (StateObject)ar.AsyncState;
            Socket current = (Socket)ar.AsyncState;
            current.EndSend(ar);
            Console.WriteLine("message has been sent to the player");

            return;
            //current.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, RecevieRoomCallback, state);
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

        //*****************************************************************************************

        private static void firstReceive(int roomNumber)
        {
            StateObject state = new StateObject();

            //byte[] sendBuffer = new byte[1024];
            //string message = JsonConvert.SerializeObject("this is a message");
            //sendBuffer = Encoding.ASCII.GetBytes(message);

            foreach (Room room in rooms)
            {
                if (room.RoomNo == roomNumber)
                {
                    state.workSocket = room.player1.clientSocket;
                    state.roomNo = room.RoomNo;
                    state.workSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, RecevieLoopCallback, state);
                }
            }
        }

        //use
        private static void RecevieLoopCallback(IAsyncResult ar)
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

            //recieve from player
            string recievedString = Encoding.ASCII.GetString(state.buffer, 0, received);
            Player recievedMessage = JsonConvert.DeserializeObject<Player>(recievedString);
            Console.WriteLine("Received Text from player: " + recievedMessage);

            foreach (Room room in rooms)
            {
                if (room.RoomNo == state.roomNo)
                {
                    if (room.player1.message == "from 1")
                    {
                        SendToAll(room.RoomNo, room.player1.message);
                        room.player1.clientSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, RecevieRoomCallback, state);
                    }
                    else if (room.player2.message == "from 2")
                    {
                        SendToAll(room.RoomNo, room.player2.message);
                        room.player2.clientSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, RecevieRoomCallback, state);
                    }

                    //call this function again
                    state.workSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, RecevieLoopCallback, state);
                }
            }
        }

        private static void SendToAll(int roomNo, string msg)
        {
            StateObject state = new StateObject();

            byte[] sendBuffer = new byte[1024];
            string message = JsonConvert.SerializeObject(msg);
            sendBuffer = Encoding.ASCII.GetBytes(message);

            foreach (Room room in rooms)
            {
                if (room.RoomNo == roomNo)
                {
                    foreach (Player player in room.players)
                    {
                        state.workSocket = player.clientSocket;
                        state.workSocket.BeginSend(sendBuffer, 0, sendBuffer.Length, SocketFlags.None, SendToAllPlayersCallback, player.clientSocket);
                    }
                }
            }
        }

        private static void SendToAllPlayersCallback(IAsyncResult ar)
        {
            StateObject state = (StateObject)ar.AsyncState;
            Socket current = state.workSocket;
            current.EndSend(ar);
            Console.WriteLine("message has been sent to all players");

            return;
        }










        

        private static void RecieveFromPlayer(int roomNumber)
        {
            foreach (Room room in rooms)
            {
                if (room.RoomNo == roomNumber)
                {
                    StateObject state = new StateObject();
                    state.workSocket = room.player1.clientSocket;
                    state.roomNo = room.RoomNo;
                    room.player1.clientSocket.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, RecevieGameDataCallback, state);
                }
            }
        }

        private static void RecevieGameDataCallback(IAsyncResult ar)
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

            string recievedString = Encoding.ASCII.GetString(state.buffer, 0, received);
            string recievedMessage = JsonConvert.DeserializeObject<string>(recievedString);
            Console.WriteLine("Received Text: " + recievedMessage);
        }

    }
}
