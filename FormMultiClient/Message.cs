using System.Collections.Generic;

namespace FormMultiClient
{
    class Message
    {
        public List<Room> Rooms { get; set; }
        public Player PlayerData { get; set; }
    }
}
