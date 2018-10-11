using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem08.Models.Contracts
{
    interface IWithdrawable
    {
        void WithdrawMoney(decimal amount);
    }
}
