using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Contracts
{
   public interface IProblem:IRunnable
    {
         Writer Writer { get; set; }

         Reader Reader { get; set; }
    }
}
