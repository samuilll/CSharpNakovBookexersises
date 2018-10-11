using Utilities;
using Utilities.Contracts;

namespace Chapter_20_ObjectOrientedProgrammingPrinciples
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
