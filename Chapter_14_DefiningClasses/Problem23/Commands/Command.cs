using System.Collections.Generic;

namespace Chapter_14_DefiningClasses.Problem23.Commands
{
    public abstract class Command
    {
        protected List<string> Arguments { get; set; }

        public Command(List<string> arguments)
        {
            this.Arguments = arguments;
        }

        public abstract string Execute();
    }
}