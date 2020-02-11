using System.Net.Sockets;

namespace GameServer
{
    class Player
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string status { get; set; }
        public int roomNo { get; set; }
        public bool connected { get; set; }
        public Socket clientSocket { get; set; }
    }
}
