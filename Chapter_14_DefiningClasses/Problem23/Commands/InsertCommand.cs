using System.Collections.Generic;

namespace Chapter_14_DefiningClasses.Problem23.Commands
{
    class InsertCommand : Command
    {
        private const string Success = "Item {0} was added at index {1}";
        private GenericList<string> data;

        public InsertCommand(GenericList<string> data, List<string> args)
            : base(args)
        {
            this.data = data;
        }
        public override string Execute()
        {
            string element = this.Arguments[0];

            int index = int.Parse(this.Arguments[1]);

            this.data.Insert(element,index);

            return string.Format(Success,element,index);
        }
    }
}
