using Utilities;

namespace Chapter_22_LambdaExpressionsandLINQ.Problem7
{
    class Problem_7:Problem
    {
        public override void Run()
        {
                Writer.WriteLine("Please enter sentence with lower letters to check the extension method:");
                string sentence = Reader.ReadLine();

                string changedSentence = sentence.ToMakeFirstCharUpper();
                Writer.WriteLine(changedSentence);
        }
    }
}
