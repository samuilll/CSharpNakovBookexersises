using Utilities;

namespace Chapter_5_ConditionalStatements.Problems
{
    class Problem_08 : Problem
    {
        public override void Run()
        {
            Writer.WriteLine("Please insert int, double or string value");

            object obj = this.Reader.ReadLine();

            bool isInteger = int.TryParse(obj.ToString(), out int integerNumber);
            bool isDouble = double.TryParse(obj.ToString(), out double doubleNumber);
            bool isNumber = isInteger || isDouble;

            string result = obj.ToString();

            if (isNumber)
            {
                result = (doubleNumber + 1).ToString();
            }
            else
            {
                result = result + "*";
            }

            Writer.WriteLine("Output:");
            Writer.WriteLine(result);
        }
    }
}