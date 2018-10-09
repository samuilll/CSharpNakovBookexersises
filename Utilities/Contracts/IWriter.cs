using System;
using System.Collections.Generic;
using System.Text;

namespace Utilities.Contracts
{
  public  interface IWriter
    {
        void WriteLine(object obj);

        void Write(object obj);
    }
}
