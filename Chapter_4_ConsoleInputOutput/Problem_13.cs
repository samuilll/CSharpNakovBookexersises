using Utilities;

namespace Chapter_4_ConsoleInputOutput
{
    class Problem_13:Problem
    {
        public override void Run()
        {
            double oldSum = 0;
            double newSum = 0;
            double difference = 0;

                int index = 2;

                do
                {
                    oldSum = newSum;
                    newSum += 1.0 / index;
                    difference = newSum - oldSum;

                    index++;

                } while (difference > 0.001);
            
            Writer.WriteLine("The sum of the sequence 1/2 + 1/3 + 1/4...with accuracy of 0.001 is:");
            Writer.WriteLine(newSum);
        }
    }
}
