using System;
using Chapter_15_TextFiles.Problem12;
using Chapter_15_TextFiles.Problem13;
using Utilities;

namespace Chapter_15_TextFiles
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Problem problem12 = new Problem_12();
           // problem12.Run();

            Problem problem13 = new Problem_13();
            problem13.Run();
        }
    }
}
