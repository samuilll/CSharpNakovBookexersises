using System.Collections.Generic;

namespace Chapter_14_DefiningClasses.Problem23.Commands
{
    class ViewItemCommand:Command
    {
        private GenericList<string> data;

        public ViewItemCommand(GenericList<string> data, List<string> args)
            : base(args)
        {
            this.data = data;
        }

        public override string Execute()
        {
            int index = int.Parse(this.Arguments[0]);

            return this.data[index].ToString();
        }
    }
}
