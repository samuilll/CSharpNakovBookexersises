using Utilities;
using Utilities.Contracts;

namespace Chapter_22_LambdaExpressionsandLINQ
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