using Utilities;
using Utilities.Contracts;

namespace Chapter_10_Recusrion
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