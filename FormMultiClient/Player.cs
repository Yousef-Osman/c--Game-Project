using System.Net.Sockets;

namespace FormMultiClient
{
    class Player
    {
        public int id { get; set; }
        public string userName { get; set; }
        public string status { get; set; }
        public int roomNo { get; set; }
        public bool connected { get; set; }
        public Socket client { get; set; }
    }
}
