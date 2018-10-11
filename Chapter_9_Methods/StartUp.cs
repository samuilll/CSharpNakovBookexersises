using Utilities;
using Utilities.Contracts;

namespace Chapter_9_Methods
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
