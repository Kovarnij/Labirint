using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    static class FillingRoom
    { 
        private static Random random = new Random();
        private static void AddRightRoom(Room room)
    {
        if (10 > random.Next(100))
        {
            room.AddRight(0, random.Next(5, 6));
        }
    }
        private static void AddLeftRoom(Room room)
    {
        if (10 > random.Next(100))
        {
            room.AddLeft(0, random.Next(5, 6));
        }
    }
        public static Room CreateRooms()
        {
            Room rooms = new Room(0,0);
            Room root = rooms;

            for (int i = 0; i < random.Next(10, 20); i++)
            {
                int rand = 2;

                if (rand > random.Next(5))
                {
                    rooms.AddLeft(random.Next(2), random.Next(2));

                    AddRightRoom(rooms);

                    rooms = rooms.Left;
                }

                else
                {
                    rooms.AddRight(random.Next(2), random.Next(2));

                    AddLeftRoom(rooms);

                    rooms = rooms.Right;
                }
            }

            return root;
        }
    }
    }
