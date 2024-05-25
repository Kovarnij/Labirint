using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint.Monsters
{
    internal interface IMonsterFactory
    {
        IMonster GetInstance();
    }
}
