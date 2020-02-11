using System.Collections.Generic;

namespace GameServer
{
    class Room
    {
        public string status;
        List<Player> players = new List<Player>();
        public List<string> names = new List<string>();
        public string userMessage;
        public int RoomNo { get; set; }

        //public readonly int RoomID;
        //public Player Player1;
        //public Player Player2;
        //public Player Word;
        //public List<Player> Watchers;

        public void AddPlayer(Player player)
        {
            players.Add(player);
            names.Add(player.userName);
        }

        public List<Player> getPlayers()
        {
            return players;
        }

        
        //public Room(int RoomID, Player Player1)
        //{
        //    this.RoomID = RoomID;
        //    this.Player1 = Player1;
        //    Watchers = new List<Player>();
        //}

        //public void AddClient(Player _client)
        //{
        //    if (Player2 == null)
        //    {
        //        Player2 = _client;
        //        StartGame();
        //    }
        //    else
        //    {
        //        Watchers.Add(_client);
        //    }
        //}

        //private void StartGame()
        //{
        //    //first send the length of the created word



        //    //char s =  Player1.tcp.GetChar();
        //}
    }

    
}
