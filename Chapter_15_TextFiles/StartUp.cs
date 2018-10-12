using Utilities;
using Utilities.Contracts;

namespace Chapter_15_TextFiles
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