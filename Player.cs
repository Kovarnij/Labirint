using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    public class Player
    {
        private int Health = 20;
        private int Strength = 10;
        public Room Room { get; private set; }
        public Player(Room room)
        {
            Room = room;
        }
        public void MoveLeftRoom()
        {
            if (Room.Left != null) 
                Room = Room.Left;
        }
        public void MoveRightRoom() 
        {
            if (Room.Right != null)
                Room = Room.Right;
        }
        public void MoveRootRoom()
        {
            if (Room.Root != null)
                Room = Room.Root;
        }

        public void LookAround()
        {
            if (Room.Left != null)
                Console.WriteLine("Вы видите дверь слева");
            if (Room.Right != null)
                Console.WriteLine("Вы видите дверь справа");
            if (Room.Root != null)
                Console.WriteLine("Вы видите дверь сзади");
            if (Room.Monsters.Count > 0)
            {
                for (int i = 0; i < Room.Monsters.Count; i++)
                {
                    Console.WriteLine($"Вы видите {Room.Monsters[i]}");
                }
            }
            if (Room.Chest > 0)
            {
                Console.WriteLine($"Вы видите {Room.Chest} сундуков");
            }
        }
    }
}
