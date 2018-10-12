using Utilities;
using Utilities.Contracts;

namespace Chapter_12_ExceptionHandling
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