using Utilities.Contracts;

namespace Utilities
{
    public abstract class Problem : IProblem
    {
        public Problem()
        {
            this.Writer = new Writer();
            this.Reader = new Reader();
        }

        public Writer Writer { get; set; }
        public Reader Reader { get; set; }

        public abstract void Run();
    }
}