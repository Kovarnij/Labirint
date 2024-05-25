using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labirint
{
    internal class Menu
    {
        private List<ConsoleKey> consoleKeys = new List<ConsoleKey>{ ConsoleKey.D1, ConsoleKey.NumPad1, ConsoleKey.D2, ConsoleKey.NumPad2, ConsoleKey.D3, ConsoleKey.NumPad3 };

        private int indexConsoleKey = -1;

        private readonly List<MenuEntry> entries = new();
        public IList<MenuEntry> Entries { get => entries; }

        public void AddEntry(string header, Action action, List<ConsoleKey> keys)
        {
            entries.Add(new MenuEntry(header, action, keys));
        }
        public Action? GetAction(ConsoleKey key)
        {
            foreach (var entry in entries)
            {
                if (entry.Keys.Contains(key))
                {
                    return entry.Action;
                }
            }

            return null;
        }

        public ConsoleKey GetConsoleKey()
        {
            indexConsoleKey++;
            return consoleKeys[indexConsoleKey];
        }

        public void SetConsoleKey()
        {
            indexConsoleKey = -1;
        }
    }
}
