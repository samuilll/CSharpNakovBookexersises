using System;
using Chapter_12_ExceptionHandling.Problem11;
using Chapter_12_ExceptionHandling.Problem12;
using Utilities;

namespace Chapter_12_ExceptionHandling
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Problem problem12 = new Problem_12();
            problem12.Run();

            Problem problem11 = new Problem_11();
           // problem11.Run();
        }
    }
}
