using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint.Monsters
{
    internal class GoblinFactory : IMonsterFactory
    {
        private static Random rng = new Random();
        public IMonster GetInstance()
        {
            return new Goblin(rng.Next(4, 5), rng.Next(10, 30));
        }
    }
}
