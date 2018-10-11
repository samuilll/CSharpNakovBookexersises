using System;
using System.Collections.Generic;
using System.Text;
using Utilities.Contracts;

namespace Utilities
{
   public  class Writer :IWriter
    {
        public void WriteLine(object obj = null)
        {
            if (obj==null)
            {
                Console.WriteLine(); 
            }
            else
            {
                Console.WriteLine(obj.ToString());
            }
        }

        public void Write(object obj)
        {
            Console.Write(obj.ToString());
        }
    }
}
