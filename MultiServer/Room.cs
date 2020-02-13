using System.Collections.Generic;
using System;

namespace GameServer
{
    class Room
    {
        public string status;
        public string Word;
        public bool p1flag;
        public bool p2flag;

        public int RoomNo { get; set; }
        public List<Player> players { get; }
        public List<string> names = new List<string>();
        

        public Room(Player player)
        {
            players = new List<Player>();
            players.Add(player);
            status = "waiting";
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
            names.Add(player.userName);

            if(players.Count > 1)
            {
                status = "watch";
            }
        }

        public void StartGame()
        {
            Console.WriteLine("Game has statrted...");
        }
    }
}
