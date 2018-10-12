using System.Collections.Generic;

namespace Chapter_14_DefiningClasses.Problem23.Commands
{
    class AddCommand : Command
    {
        private const string Success = "Element {0} was added!";
        private GenericList<string> data;

        public AddCommand(GenericList<string> data, List<string> args)
            : base(args)
        {
            this.data = data;
        }

        public override string Execute()
        {
            string element = this.Arguments[0];

            this.data.Add(element);

            return string.Format(Success, element);
        }
    }
}