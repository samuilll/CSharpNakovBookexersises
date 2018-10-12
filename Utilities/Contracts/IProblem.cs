namespace Utilities.Contracts
{
    public interface IProblem : IRunnable
    {
        Writer Writer { get; set; }

        Reader Reader { get; set; }
    }
}