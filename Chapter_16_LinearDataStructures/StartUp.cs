using Utilities;
using Utilities.Contracts;

namespace Chapter_16_LinearDataStructures
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