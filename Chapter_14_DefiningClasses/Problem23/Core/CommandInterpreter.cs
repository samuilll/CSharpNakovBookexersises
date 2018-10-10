using Chapter_14_DefiningClasses.Problem23.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Chapter_14_DefiningClasses.Problem23.Core
{
    class CommandInterpreter
    {
        private const string CommandString = "Command";

        private IServiceProvider service;

        public CommandInterpreter(IServiceProvider service)
        {
            this.service = service;
        }

        public string ProcessCommand(IList<string> args)
        {
            string commandName = args[0];

            Type type = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name == commandName + CommandString);

            var ctorParams = type.GetConstructors().First().GetParameters();

            var objectsParams = new object[ctorParams.Length];

            for (int i = 0; i < ctorParams.Length - 1; i++)
            {
                objectsParams[i] = this.service.GetService(ctorParams[i].ParameterType);
            }

            objectsParams[objectsParams.Length - 1] = args.Skip(1).ToList();

            Command command = (Command)Activator.CreateInstance(type, objectsParams);

            //if (typeof(ICommand).IsAssignableFrom(type))
            //{

            //}

            return command.Execute();
        }
    }
}
