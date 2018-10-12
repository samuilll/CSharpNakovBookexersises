using Utilities;
using Utilities.Contracts;

namespace Chapter_13_StringAndTextProceesing
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