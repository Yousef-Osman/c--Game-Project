﻿using System.Net.Sockets;

namespace GameServer
{
    class Player
    {
        public int id { get; set; }
        public string userName { get; set; }
        public int status { get; set; }
        public int roomNo { get; set; }
        public bool connected { get; set; }
        public Socket client { get; set; }
    }
}