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

            //Get the type of the command
            Type type = Assembly.GetExecutingAssembly().GetTypes().First(t => t.Name == commandName + CommandString);

            //Get parameters of the first constructor of the type
            var ctorParams = type.GetConstructors().First().GetParameters();

            //Initialize a container where constructor parameters will be placed
            var objectsParams = new object[ctorParams.Length];

            //Fill the container from service
            for (int i = 0; i < ctorParams.Length - 1; i++)
            {
                objectsParams[i] = this.service.GetService(ctorParams[i].ParameterType);
            }

            //Fill the last cell of the container with user data
            objectsParams[objectsParams.Length - 1] = args.Skip(1).ToList();

            //Creeate an instance of the command
            Command command = (Command)Activator.CreateInstance(type, objectsParams);

            //Execute command and return the result
            return command.Execute();
        }
    }
}
