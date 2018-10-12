using System;
using System.Linq;
using System.Reflection;
using Utilities.Contracts;

namespace Utilities
{
    public class Menu : IMenu
    {
        private const string TypeKeyWord = "Problem";

        private Writer Writer = new Writer();

        private Reader Reader = new Reader();

        public void Display()
        {
            Assembly assembly = Assembly.GetCallingAssembly();

            //Get "Problem" types and sort them by the number of the problem in the end of it's name; Example problem name: "Problem_22"
            //Options in the menu will be assotiated with the order
            Type[] types = assembly
                .GetTypes()
                .Where(t => t.Name.Contains(TypeKeyWord))
                .OrderBy(t => int.Parse(t.Name.Split("_").Last()))
                .ToArray();

            Type firstProblem = types[0];
            Type secondProblem = types[1];

            string firstProblemName = types[0].Name;
            string secondProblemName = types[1].Name;


            Writer.WriteLine("Please choose one of the options:");
            Writer.WriteLine($"1.To start {firstProblemName} please press \"1\"");
            Writer.WriteLine($"2.To start {secondProblemName} please press \"2\"");
            Writer.WriteLine($"3.To exit the program press \"3\"");

            try
            {
                int choice = int.Parse(Reader.ReadLine());

                switch (choice)
                {
                    case 1:
                    {
                        var problem = (Problem) Activator.CreateInstance(firstProblem);
                        problem.Run();
                        Writer.WriteLine();
                        break;
                    }
                    case 2:
                    {
                        var problem = (Problem) Activator.CreateInstance(secondProblem);
                        problem.Run();
                        Writer.WriteLine();
                        break;
                    }
                    case 3:
                    {
                        Environment.Exit(1);
                        break;
                    }
                    default:
                    {
                        Writer.WriteLine("Input must be in  range [1,3] ");
                        Writer.WriteLine();
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}