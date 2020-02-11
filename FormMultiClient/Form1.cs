using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace FormMultiClient
{
    public partial class Form1 : Form
    {
        Socket ClientSocket;
        int PORT = 15153;
        List<Room> serverRooms = new List<Room>();
        Player playerData;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            playerData = new Player();
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                ClientSocket.Connect(IPAddress.Loopback, PORT);
                Connect.Visible = false;
                logInPanal.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("server not connected");
            }
        }

        private void LogInBtn_Click(object sender, EventArgs e)
        {
            string userName;
            userName = UserNameTB.Text;

            logInPanal.Visible = false;
            ChoicePanal.Visible = true;

            playerData.userName = userName;
            string message = JsonConvert.SerializeObject(playerData);
            byte[] sendBuffer = Encoding.ASCII.GetBytes(message);
            ClientSocket.BeginSend(sendBuffer, 0, sendBuffer.Length, SocketFlags.None, SendUserNameCallback, ClientSocket);
        }

        private void SendUserNameCallback(IAsyncResult ar)
        {
            Socket current = (Socket)ar.AsyncState;
            current.EndSend(ar);
            Console.WriteLine("Username has been sent to server");

            StateObject state = new StateObject();
            state.workSocket = current;
            current.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, ReceiveRoomsCallback, state);
        }

        private void ReceiveRoomsCallback(IAsyncResult ar)
        {
            StateObject state = (StateObject)ar.AsyncState;
            Socket client = state.workSocket;
            int received = client.EndReceive(ar);

            string recievedString = Encoding.ASCII.GetString(state.buffer, 0, received);
            List<Room> recievedObject = JsonConvert.DeserializeObject<List<Room>>(recievedString);
            serverRooms = recievedObject;
        }
        //===========================================================================================================





        //===========================================================================================================
        

        private void RequestLoop(int roomOption, int roomNumber)
        {
            SendRequest(roomOption, roomNumber);
            ReceiveResponse();
        }
        private void SendRequest(int roomOption, int roomNumber)
        {
            playerData.status = roomOption;
            playerData.roomNo = roomNumber;
            Message sendMessage = new Message();
            sendMessage.PlayerData = playerData;

            string message = JsonConvert.SerializeObject(sendMessage);
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            ClientSocket.Send(buffer, 0, buffer.Length, SocketFlags.None);
        }

        private void ReceiveResponse()
        {
            var buffer = new byte[2048];
            int received = ClientSocket.Receive(buffer);
            if (received == 0) return;
            
            byte[] RecieveBuffer = new byte[received];
            Array.Copy(buffer, RecieveBuffer, received);
            string text = Encoding.ASCII.GetString(RecieveBuffer);
            Message recievedMessage = JsonConvert.DeserializeObject<Message>(text);
            //playerData = recievedMessage.PlayerData;
            serverRooms = recievedMessage.Rooms;
        }
        #region
        /// Close socket and exit program.
        private void Exit()
        {
            //SendString("exit"); // Tell the server we are exiting
            ClientSocket.Shutdown(SocketShutdown.Both);
            ClientSocket.Close();
            Environment.Exit(0);
        }
        #endregion


        private void ShowRooms()
        {
            RoomsListLB.Items.Clear();
            foreach (Room item in serverRooms)
            {
                RoomsListLB.Items.Add($"Room Number: {item.RoomNo}");
            }
        }

        //private void RoomOption(object sender, EventArgs e)
        //{
        //    int roomOption;
        //    Button btn = (Button)sender;
        //    if(btn.Name == "CreateRoomBtn")
        //    {
        //        roomOption = 1;
        //        //RequestLoop(roomOption);
        //        ChoicePanal.Visible = false;
        //        CreateRoomPanel.Visible = true;
        //    }
        //    else if (btn.Name == "JoinRoomBtn")
        //    {
        //        roomOption = 2;
        //        //RequestLoop(roomOption);
        //        ChoicePanal.Visible = false;
        //        RoomsPanel.Visible = true;
        //        ShowRooms();
        //    }
        //}

        private void RoomsListLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            BackBtn.Visible = true;
            ConnectBtn.Visible = true;
            int index = RoomsListLB.SelectedIndex;
            if (index >= 0)
            {
                Room SelectedRoom = serverRooms[index];
                RoomsListLB.Items.Clear();

                foreach (string item in SelectedRoom.names)
                {
                    RoomsListLB.Items.Add(item);
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BackBtn.Visible = false;
            ConnectBtn.Visible = false;
            ShowRooms();
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are connected");
        }


        //===========================================================================================================





        //===========================================================================================================
        private void WatchBtn_Click(object sender, EventArgs e)
        {
            ChoicePanal.Visible = false;
            WatchPanal.Visible = true;

            foreach (Room room in serverRooms)
            {
                if(room.status == "watch")
                {
                    StartWatchLB.Items.Add($"Room Number: {room.RoomNo}");
                }
            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            ChoicePanal.Visible = false;
            StartPlayPanel.Visible = true;
            StartPlayingBtn.Visible = true;

            PlayRoomsLB.Items.Clear();
            foreach (Room room in serverRooms)
            {
                if (room.status == "play")
                {
                    PlayRoomsLB.Items.Add($"Room Number: {room.RoomNo}");
                }
            }
        }

        private void StartWatchLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            StartWatchingBtn.Visible = true;
            int index = StartWatchLB.SelectedIndex;
            if (index >= 0)
            {
                Room SelectedRoom = serverRooms[index];
                StartWatchLB.Items.Clear();

                foreach (string item in SelectedRoom.names)
                {
                    StartWatchLB.Items.Add(item);
                }
            }
        }

        private void CreateRoomBtn_Click(object sender, EventArgs e)
        {

            ChoicePanal.Visible = false;
            CreateRoomPanel.Visible = true;
            //int index = -1;
            //int choise = 1;
            //RequestLoop(choise, index);

        }

        private void StartWatchingBtn_Click(object sender, EventArgs e)
        {
            //int index = StartWatchLB.SelectedIndex;
            //int choise = 2;
            //RequestLoop(choise, index);
        }

        private void StartPlayingBtn_Click(object sender, EventArgs e)
        {
            //int index = PlayRoomsLB.SelectedIndex;
            //int choise = 3;
            //RequestLoop(choise, index);
        }
    }
}
