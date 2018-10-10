using System;
using Chapter_1_IntroductionToProgramming.Problem10;
using Chapter_1_IntroductionToProgramming.Problem11;
using Utilities;

namespace Chapter_1_IntroductionToProgramming
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Problem problem10 = new Problem_10();
            problem10.Run();

            Problem problem11 = new Problem_11();
            //problem11.Run();
        }
    }
}
