using System;
using System.Collections.Generic;
using System.Text;

namespace BattleShipXamarin.Model
{
    internal class BattleShipModel
    {
        public int length { get; set; }
        public int hits { get; set; }   

        public List<string> coordinates { get; set; }
        
        public bool isSunk()
        {
            return length == hits;
        }

        public void hit(string location)
        {
            if (coordinates.Contains(location))
            {
                hits= hits + 1;
            }
        }





    }
}
