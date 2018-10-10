using Chapter_14_DefiningClasses.Problem23.Core;
using Chapter_14_DefiningClasses.Problem23.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Chapter_14_DefiningClasses.Problem23
{
    class Problem_23 : Problem
    {
        private CommandInterpreter interpreter;

        public Problem_23(IServiceProvider provider)
        {
            this.interpreter = new CommandInterpreter(provider);
        }
        public override void Run()
        {
            DisplayMenu();

            int choice = 0;

            while ((CommandsEnum)choice != CommandsEnum.Exit)
            {
                try
                {
                    choice = int.Parse(Reader.ReadLine());

                    string commandString = ((CommandsEnum)choice).ToString();

                    List<string> args = new List<string>();

                    args.Add(commandString);

                    if (choice != 6 && choice != 4)
                    {
                        args.AddRange(Reader.ReadLine().Split().ToList());
                    }

                    string result = this.interpreter.ProcessCommand(args);
                    Writer.WriteLine(result);
                }
                catch (Exception e)
                {
                    Writer.WriteLine(e.Message);
                }
            }
        }

        private void DisplayMenu()
        {
            Writer.WriteLine("Please choose one of the folloing options");
            Writer.WriteLine("1. Add item (enter '1', press 'enter' and after that enter the item)");
            Writer.WriteLine("2. Remove at index (enter '2', press 'enter' and after that enter index)");
            Writer.WriteLine("3. Insert element at index (enter '3', press 'enter' and after that enter element and index)");
            Writer.WriteLine("4. Clear data (enter '4')");
            Writer.WriteLine("5. View item (index) (enter '5', press 'enter' and after that enter index)");
            Writer.WriteLine("6. View the whole sequence (enter '6')");
            Writer.WriteLine("7. Exit (enter 7)");
        }
    }
}
