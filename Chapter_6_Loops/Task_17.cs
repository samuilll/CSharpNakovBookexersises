using System;
using Utilities.Contracts;

namespace Chapter_6
{
    public class Task_17 : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Please insert first number:");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please insert second number:");
            int num2 = int.Parse(Console.ReadLine());

            int result = FindGreatCommonDiviser(num1, num2);

            Console.WriteLine("Output:");
            Console.WriteLine(result);
        }

        private int FindGreatCommonDiviser(int num1, int num2)
        {
                while (num1 != 0 && num2 != 0)
                {
                    if (num1 > num2)
                        num1 %= num2;
                    else
                        num2 %= num1;
                }

                if (num1 == 0)
                    return num2;
                else
                    return num1;            
        }
    }
}
