using Utilities;

namespace Chapter_16_LinearDataStructures.Problem15
{
    class Problem_15 : Problem
    {
        public override void Run()
        {

            ArrayManager manager = new ArrayManager(this.Writer, this.Reader);

            int[] numbers = manager.InitializeTheArray();

            manager.SortTheArrayWithBubbleMethod(numbers);

            manager.DisplayTheResult(numbers);
        }
    }
}
