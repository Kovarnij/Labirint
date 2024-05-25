using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint.States
{
    internal class LookUpState : IState
    {
        public void Interact(GameContext context, Player player)
        {
            player.LookAround();
            context.State = new ChoiceState();
        }
    }
}
