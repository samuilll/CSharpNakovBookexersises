using Utilities;
using Utilities.Contracts;

namespace Chapter_14_DefiningClasses
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