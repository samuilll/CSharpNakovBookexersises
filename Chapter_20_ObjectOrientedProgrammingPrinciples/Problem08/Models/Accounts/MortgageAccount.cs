using System;

namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem08.Models.Accounts
{ 
    using Clients;

    class MortgageAccount:Account
    {       
        private const string IndividualClient = "IndividualClient";
        private const string CompanyClient = "ComapnyClient";

        public MortgageAccount()
        {

        }

        public MortgageAccount(Client client, decimal ballance, decimal interestRate)
           : base(client, ballance, interestRate)
        {
        }

        public override decimal EvaluateRate(int months)
        {
            string typeOfClient = this.Client.GetType().Name;

            if (months < 0)
            {
                throw new ArgumentException(ExceptionMessages.MonthsMustBeAPositiveNumber);
            }

            int halfRateMonths = typeOfClient == IndividualClient ? 6 : 12;

            decimal rate = 0;

            if (months<=6)
            {
                halfRateMonths = months;
            }
            else if (months<=12)
            {
                if (typeOfClient==CompanyClient)
                {
                    halfRateMonths = months;
                }

                rate = halfRateMonths * this.InterestRate / 2;

                return rate;
            }

            rate = (months-halfRateMonths)*this.InterestRate +halfRateMonths * this.InterestRate / 2;

            return rate;

        }
    }
}
