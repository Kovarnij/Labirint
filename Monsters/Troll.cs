using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint.Monsters
{
    internal class Troll : IMonster
    {
        public int Strength { get; private set; }
        public int Health { get; private set; }

        public Troll(int strength, int health)
        {
            Strength = strength;
            Health = health;
        }
    }
}
