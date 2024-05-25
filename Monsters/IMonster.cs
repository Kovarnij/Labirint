using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint.Monsters
{
    public interface IMonster
    {
        int Strength { get; }
        int Health { get; }
    }
}
