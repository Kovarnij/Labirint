using Labirint.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    internal class Game
    {
        public Game()
        {
            Player player = new Player(FillingRoom.CreateRooms());
            GameContext context = new GameContext(new LookUpState());

            while (true)
            {
                context.HandleState(player);
            }
        }
    }
}