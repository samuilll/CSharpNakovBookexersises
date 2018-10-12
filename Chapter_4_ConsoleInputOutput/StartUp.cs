using Utilities;
using Utilities.Contracts;

namespace Chapter_4_ConsoleInputOutput
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