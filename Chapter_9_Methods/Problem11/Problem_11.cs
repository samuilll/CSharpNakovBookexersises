using System;
using Chapter_9_Methods.Problem11.Services;
using Utilities.Contracts;

namespace Chapter_9_Methods.Problem11
{
     class Problem_11 : IRunnable
    {
      public  void Run()
        {
            int choice = ChooseAnOption();

            switch (choice)
            {
                case 1:
                    {
                        ReverseNumService reverseManager = new ReverseNumService();
                        reverseManager.Run();
                        break;
                    }
                case 2:
                    {
                        ArrayService averageManager = new ArrayService();
                        averageManager.Run();
                        break;
                    }
                case 3:
                    {
                        LinealEquationService equationManager = new LinealEquationService();
                        equationManager.Run();
                        break;
                    }
            }

        }

        private static int ChooseAnOption()
        {
            Console.WriteLine("Please choose one of the possible options:");

            Console.WriteLine("1. For reverse the digits of a number press \"1\"");
            Console.WriteLine("2. For evaluation of the average arithmetic value of an array of integers press \"2\"");
            Console.WriteLine("3. For solve a linear equation press \"3\"");

            int choice;
            string input = Console.ReadLine();

            while (!int.TryParse(input,out choice)||choice<1||choice>3)
            {
                try
                {
                    input = Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            return choice;
        }

   
    }
}
