using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_14_DefiningClasses.Problem23.Commands
{
    class RemoveCommand : Command
    {
        private const string Success = "Item at index {0} was removed!";

        private GenericList<string> data;

        public RemoveCommand(GenericList<string> data, List<string> args)
            : base(args)
        {
            this.data = data;
        }
        public override string Execute()
        {
            int index = int.Parse(this.Arguments[0]);

            this.data.RemoveAt(index);

            return string.Format(Success,index);
        }
    }
}
