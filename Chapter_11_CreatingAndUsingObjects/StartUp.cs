using Utilities;
using Utilities.Contracts;

namespace Chapter_11_CreatingAndUsingObjects
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