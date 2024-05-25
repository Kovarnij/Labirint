using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint.Monsters
{
    internal class TrollFactory : IMonsterFactory
    {
        private static Random rng = new Random();
        public IMonster GetInstance()
        {
            return new Troll(rng.Next(6, 10), rng.Next(50, 100));
        }
    }
}
