using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
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
