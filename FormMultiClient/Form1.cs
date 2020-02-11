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

        private void SendRoomNumberCallback(IAsyncResult ar)
        {
            Socket current = (Socket)ar.AsyncState;
            current.EndSend(ar);

            StateObject state = new StateObject();
            state.workSocket = current;
            current.BeginReceive(state.buffer, 0, StateObject.BufferSize, SocketFlags.None, ReceiveMessageCallback, state);
        }

        private void ReceiveMessageCallback(IAsyncResult ar)
        {
            StateObject state = (StateObject)ar.AsyncState;
            Socket client = state.workSocket;
            int received = client.EndReceive(ar);

            string recievedString = Encoding.ASCII.GetString(state.buffer, 0, received);
            string recievedObject = JsonConvert.DeserializeObject<string>(recievedString);
            MessageBox.Show(recievedObject);
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

        private void WatchBtn_Click(object sender, EventArgs e)
        {
            ChoicePanal.Visible = false;
            WatchPanal.Visible = true;
            StartWatchingBtn.Visible = true;

            foreach (Room room in serverRooms)
            {
                if (room.status == "watch")
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

            StartPlayingLB.Items.Clear();
            foreach (Room room in serverRooms)
            {
                if (room.status == "play")
                {
                    StartPlayingLB.Items.Add($"Room Number: {room.RoomNo}");
                }
            }
        }

        private void RoomNumber(object sender, EventArgs e)
        {
            Button bb = (Button)sender;
            string roomString;
            if (bb.Text == "Start Watching")
            {
                roomString = StartWatchLB.SelectedItem.ToString();
                var numberString = roomString.Split(' ');
                playerData.roomNo = Convert.ToInt32(numberString[2]);
            }
            else if (bb.Text == "Start Playing")
            {
                roomString = StartPlayingLB.SelectedItem.ToString();
                var numberString = roomString.Split(' ');
                playerData.roomNo = Convert.ToInt32(numberString[2]);
            }

            playerData.status = "join room";
            string message = JsonConvert.SerializeObject(playerData);
            byte[] sendBuffer = Encoding.ASCII.GetBytes(message);
            ClientSocket.BeginSend(sendBuffer, 0, sendBuffer.Length, SocketFlags.None, SendRoomNumberCallback, ClientSocket);
        }

        private void CreateRoomBtn_Click(object sender, EventArgs e)
        {
            ChoicePanal.Visible = false;
            CreateRoomPanel.Visible = true;

            playerData.status = "creating room";
            string message = JsonConvert.SerializeObject(playerData);
            byte[] sendBuffer = Encoding.ASCII.GetBytes(message);
            ClientSocket.BeginSend(sendBuffer, 0, sendBuffer.Length, SocketFlags.None, SendRoomNumberCallback, ClientSocket);
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

        private void StartWatchLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //StartWatchingBtn.Visible = true;
            //int index = StartWatchLB.SelectedIndex;
            //if (index >= 0)
            //{
            //    Room SelectedRoom = serverRooms[index];
            //    StartWatchLB.Items.Clear();

            //    foreach (string item in SelectedRoom.names)
            //    {
            //        StartWatchLB.Items.Add(item);
            //    }
            //}
        }

    }
}
