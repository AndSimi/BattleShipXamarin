using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipXamarin.Model
{
    internal class Room
    {
        public string Name { get; set; }
        public User GameOwner { get; set; } 
        public User Enemy { get; set; }    



        public Room(string name, User GameOwner)
        {
                
            this.Name = name;
            this.GameOwner = GameOwner;


        }







    }
}
