using System;
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
