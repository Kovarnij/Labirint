using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint.States
{
    internal class ChangeRoomState : IState
    {
        public void Interact(GameContext context, Player player)
        {
            Menu menu = new Menu();

            if (player.Room.Root != null)
            {
                menu.AddEntry("Вернутся назад", () => player.MoveRootRoom(), new List<ConsoleKey> { menu.GetConsoleKey(), menu.GetConsoleKey() });
            }

            if (player.Room.Right != null)
            {
                menu.AddEntry("Пойти направо", () => player.MoveRightRoom(), new List<ConsoleKey> { menu.GetConsoleKey(), menu.GetConsoleKey() });
            }

            if (player.Room.Left != null)
            {
                menu.AddEntry("Пойти налево", () => player.MoveLeftRoom(), new List<ConsoleKey> { menu.GetConsoleKey(), menu.GetConsoleKey() });
            }

            menu.SetConsoleKey();

            for (int i = 0; i < menu.Entries.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {menu.Entries[i].Header}");
            }

            context.State = new LookUpState();

            menu.GetAction(Console.ReadKey().Key)?.Invoke();

            Console.Clear();
        }
    }
}
