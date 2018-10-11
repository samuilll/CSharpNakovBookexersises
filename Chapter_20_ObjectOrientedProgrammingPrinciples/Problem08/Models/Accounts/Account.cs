using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem08.Models.Accounts
{
    using Chapter_20_ObjectOrientedProgrammingPrinciples.Problem08.Models.Clients;
    using Models.Contracts;

    abstract class Account : IAccount
    {
        public Account()
        {

        }

        protected Account(Client client, decimal ballance, decimal interestRate)
        {
            this.Client = client;
            this.Ballance = ballance;
            this.InterestRate = interestRate;
        }

        public Client Client { get; }

        public decimal Ballance { get; protected set; }

        public decimal InterestRate { get; protected set; }

        public void DepositMoney(decimal amount)
        {
            throw new NotImplementedException();
        }

        public abstract decimal EvaluateRate(int months);

    }
}
