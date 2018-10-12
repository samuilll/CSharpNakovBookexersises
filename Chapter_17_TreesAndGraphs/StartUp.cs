using System;
using Utilities;
using Utilities.Contracts;

namespace Chapter_17_TreesAndGraphs
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IMenu menu = new Menu();
            menu.Display();
        }
    }
}
