namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem08.Models.Accounts
{
    using Clients;
    using Contracts;

    class DepositAccount:Account,IWithdrawable
    {
        public DepositAccount()
        {

        }

        public DepositAccount(Client client, decimal ballance, decimal interestRate)
           : base(client, ballance, interestRate)
        {
        }

        public override decimal EvaluateRate(int months)
        {
            decimal rate = 0;

            if (this.Ballance<=0 || this.Ballance>=100)
            {
                rate = months*this.InterestRate;
            }

            return rate;
        }

        public void WithdrawMoney(decimal amount)
        {
            this.Ballance -= amount;
        }
    }
}
