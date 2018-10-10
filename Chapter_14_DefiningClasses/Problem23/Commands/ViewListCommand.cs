using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_14_DefiningClasses.Problem23.Commands
{
    class ViewListCommand : Command
    {
        private GenericList<string> data;

        public ViewListCommand(GenericList<string> data, List<string> args)
            : base(args)
        {
            this.data = data;
        }

        public override string Execute()
        {
            return this.data.ToString();
        }
    }
}
