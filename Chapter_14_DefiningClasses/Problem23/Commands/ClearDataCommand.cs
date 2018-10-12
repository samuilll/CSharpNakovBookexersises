using System.Collections.Generic;

namespace Chapter_14_DefiningClasses.Problem23.Commands
{
    class ClearDataCommand : Command
    {
        private const string Success = "List was cleared!";
        private GenericList<string> data;

        public ClearDataCommand(GenericList<string> data, List<string> args)
            : base(args)
        {
            this.data = data;
        }

        public override string Execute()
        {
            this.data.Clear();

            return Success;
        }
    }
}