using System.Collections.Generic;

namespace GameServer
{
    class Message
    {
        public List<Room> Rooms { get; set; }
        public Player PlayerData { get; set; }
    }
}
