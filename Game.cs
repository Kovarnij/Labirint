using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    internal class Game
    {
        public Game()
        {
            Room rooms = new Room(0, 0);
            Room temp = rooms;
            
            temp.AddRight(2, 2);
            temp = temp.Left;
            temp = temp.Root;   
        }
    }
}
