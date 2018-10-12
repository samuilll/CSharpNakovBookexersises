using System;
using Utilities;

namespace Chapter_2_PrimitiveTypesAndVariables.Problem11
{
    class Problem_11 : Problem
    {
        public override void Run()
        {
            DrawIsoscelesTriangle('@', 15);
        }

        private void DrawIsoscelesTriangle(char repeatChar, int peak)
        {
            int current = 0;

            for (int i = 0; i < peak; i++)
            {
                Writer.WriteLine(new String(repeatChar, current++));
            }

            for (int i = current; i > 0; i--)
            {
                Writer.WriteLine(new String(repeatChar, current--));
            }
        }
    }
}