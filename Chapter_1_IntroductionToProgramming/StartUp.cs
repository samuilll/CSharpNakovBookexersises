using Utilities.Contracts;

namespace Chapter_1_IntroductionToProgramming
{
    using Utilities;

    class StartUp
    {
        static void Main(string[] args)
        {
            IMenu menu = new Menu();
            menu.Display();
        }
    }
}