using System;
using Chapter_22_LambdaExpressionsandLINQ.Problem6;
using Chapter_22_LambdaExpressionsandLINQ.Problem7;
using Utilities;

namespace Chapter_22_LambdaExpressionsandLINQ
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Problem problem6 = new Problem_6();
             problem6.Run();

            Problem problem7 = new Problem_7();
           // problem7.Run();
        }
    }
}
