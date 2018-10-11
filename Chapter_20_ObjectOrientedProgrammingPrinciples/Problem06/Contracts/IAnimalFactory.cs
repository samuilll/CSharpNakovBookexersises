using System;

namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem06.Contracts
{
    interface IAnimalFactory
    {
        IAnimal Create(Type type,params string[] args);
    }
}
