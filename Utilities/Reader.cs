using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Contracts;

namespace Utilities
{
   public  class Reader:IReader
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
