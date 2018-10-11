using Utilities;
using Utilities.Contracts;

namespace Chapter_5_ConditionalStatements
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
