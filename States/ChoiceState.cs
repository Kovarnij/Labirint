using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint.States
{
    internal class ChoiceState : IState
    {
        public void Interact(GameContext context, Player player)
        {
            Menu menu = new Menu();
            menu.AddEntry("Перейти в другую комнату", () => context.State = new ChangeRoomState(), new List<ConsoleKey> { menu.GetConsoleKey(), menu.GetConsoleKey() });

            if (player.Room.Chest > 0)
            {
                menu.AddEntry("Открыть сундук", () => context.State = new OpenChestState(), new List<ConsoleKey> { menu.GetConsoleKey(), menu.GetConsoleKey() });
            }

            if (player.Room.Monsters.Count > 0)
            {
                menu.AddEntry("Сразиться с монстром", () => context.State = new BattleState(), new List<ConsoleKey> { menu.GetConsoleKey(), menu.GetConsoleKey() });
            }

            menu.SetConsoleKey();

            Console.WriteLine("\nЧто будете делать?");

            for (int i = 0; i < menu.Entries.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {menu.Entries[i].Header}");
            }

            menu.GetAction(Console.ReadKey().Key)?.Invoke();

            Console.Clear();
        }
    }
}
