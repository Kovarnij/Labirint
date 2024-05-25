using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint.Monsters
{
    internal class MonstersFactory
    {
        private static Random rng = new Random();
        private static List<IMonsterFactory> monstersRegistry = new List<IMonsterFactory> { new TrollFactory(), new GoblinFactory() };

        public static List<IMonster> GetMonsters(int monsterCount)
        {
            var monsters = new List<IMonster>();

            for (int i = 0; i < monsterCount; i++)
            {
                monsters.Add(monstersRegistry[rng.Next(monstersRegistry.Count)].GetInstance());
            }

            return monsters;
        }
    }
}
