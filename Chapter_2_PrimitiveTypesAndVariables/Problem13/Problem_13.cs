using Utilities;

namespace Chapter_2_PrimitiveTypesAndVariables.Problem13
{
    class Problem_13:Problem
    {
        public override void Run()
        {
                Writer.WriteLine("Please enter one number:");
                int firstNum = int.Parse(Reader.ReadLine());
                Writer.WriteLine("Please enter one more number:");
                int secondNum = int.Parse(Reader.ReadLine());

                int temp = firstNum;
                firstNum = secondNum;
                secondNum = temp;

                Writer.WriteLine($"First number is changed to: {firstNum}");
                Writer.WriteLine($"Second number is changed to: {secondNum}");

        }
    }
}
