using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Labirint
{
    internal class MenuEntry
    {
        public string Header { get; init; }
        public Action Action { get; init; }
        public List<ConsoleKey> Keys { get; init; }

        public MenuEntry(string header, Action action, List<ConsoleKey> keys)
        {
            Header = header;
            Action = action;
            Keys = keys;

        }
    }
}
