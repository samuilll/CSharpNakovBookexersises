using Utilities;
using Utilities.Contracts;

namespace Chapter_3_OperatorsAndExpressions
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
