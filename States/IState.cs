using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint.States
{
    public interface IState
    {
        void Interact(GameContext context, Player player);
    }
}
