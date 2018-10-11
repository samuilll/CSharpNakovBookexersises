namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem08.Models.Contracts
{
    using Clients;

     interface IAccount:IDepositable
    {
         Client Client { get;}

        decimal Ballance { get; }

        decimal InterestRate { get;}

        decimal EvaluateRate(int months);
    }
}
