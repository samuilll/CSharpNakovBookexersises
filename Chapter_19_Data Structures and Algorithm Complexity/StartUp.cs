using Utilities;
using Utilities.Contracts;

namespace Chapter_19_Data_Structures_and_Algorithm_Complexity
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