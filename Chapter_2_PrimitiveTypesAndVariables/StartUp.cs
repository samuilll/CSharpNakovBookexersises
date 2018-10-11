using Utilities;
using Utilities.Contracts;

namespace Chapter_2_PrimitiveTypesAndVariables
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
