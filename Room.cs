using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Labirint.Monsters;

namespace Labirint
{
    public class Room
    {
        public int Chest { get; private set; }
        public List<IMonster> Monsters { get; private set; }
        public Room? Left { get; private set; } 
        public Room? Right { get; private set; }
        public Room? Root { get; private set; }

        public void AddLeft(int chest, int monster)
        {
            Left = new Room(chest, monster);
            Left.Root = this;
        }

        public void AddRight(int chest, int monster)
        {
            Right = new Room(chest, monster);
            Right.Root = this;
        }

        public Room( int chest, int monsterCount)
        {
            Chest = chest;
            Monsters = MonstersFactory.GetMonsters(monsterCount);
        }
    }
}
