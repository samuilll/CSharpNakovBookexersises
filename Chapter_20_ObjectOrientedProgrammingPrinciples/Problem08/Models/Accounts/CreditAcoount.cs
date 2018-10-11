namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem08.Models.Accounts
{
    using Clients;
    using System;

    class CreditAcoount:Account
    {
        private const string IndividualClient = "IndividualClient";
        private const string CompanyClient = "ComapnyClient";

        public CreditAcoount()
        {

        }

        public CreditAcoount(Client client, decimal ballance, decimal interestRate)
            :base(client,ballance,interestRate)
        {        
        }

        public override decimal EvaluateRate(int months)
        {
            string typeOfClient = this.Client.GetType().Name;

            if (months<0)
            {
                throw new ArgumentException(ExceptionMessages.MonthsMustBeAPositiveNumber);
            }

            int gratisMonths = typeOfClient == IndividualClient ? 3 : 2;

            if (months<=2)
            {
                gratisMonths = months;
            }

            decimal rate = (months-gratisMonths)*this.InterestRate;

            return rate;

        }
    }
}
