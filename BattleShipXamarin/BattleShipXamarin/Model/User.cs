using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipXamarin.Model
{
    internal class User
    {
        public string Name { get; set; }
        public string ConnectionId { get; set; }
        public Room Room {get; set;}



        public User(string name, string ConnectionID)
        {
            this.Name = name;   
            this.ConnectionId = ConnectionID;

        }


    }
}
