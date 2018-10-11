using Utilities.Contracts;

namespace Chapter_1_IntroductionToProgramming
{
    using Utilities;
    using Problem10;
    using Problem11;

    class StartUp
    {
        static void Main(string[] args)
        {
            IMenu menu = new Menu();
            menu.Display();
        }
    }
}
