using Utilities;
using Utilities.Contracts;

namespace Chapter_7_Arrays
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