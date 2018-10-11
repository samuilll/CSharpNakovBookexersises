using Utilities;
using Utilities.Contracts;

namespace Chapter_6_Loops
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
