using System.Collections.Generic;
using System;

namespace FormMultiClient
{
    class Room
    { 
        public string status;
        public string Word;
        public Player player1;
        public Player player2;
        public int RoomNo { get; set; }
        public List<Player> players { get; }
        public List<string> names = new List<string>();


        public Room(Player player)
        {
            players = new List<Player>();
            player1 = player;
            players.Add(player);
            status = "waiting";
        }

        public void AddPlayer(Player player)
        {
            players.Add(player);
            names.Add(player.userName);

            if(players.Count == 2)
            {
                player2 = player;
                status = "watch";
            }
        }

        public void StartGame()
        {
            Console.WriteLine("Game has statrted...");
        }
    }
}
