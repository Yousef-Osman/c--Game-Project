using System.Collections.Generic;

namespace FormMultiClient
{
    class Room
    {
        public string status;
        List<Player> players = new List<Player>();
        public List<string> names = new List<string>();
        public string userMessage;
        public int RoomNo { get; set; }

        public void AddPlayer(Player player)
        {
            players.Add(player);
            names.Add(player.userName);
        }

        public List<Player> getPlayers()
        {
            return players;
        }
    }
}
