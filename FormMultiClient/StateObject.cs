﻿using System.Text;
using System.Net.Sockets;

namespace FormMultiClient
{
    public class StateObject
    {
        public Socket workSocket = null;
        public const int BufferSize = 1024;
        public byte[] buffer = new byte[BufferSize];
        public int roomNo;
    }
}
