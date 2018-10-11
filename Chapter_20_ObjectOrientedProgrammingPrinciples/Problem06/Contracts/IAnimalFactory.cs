using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem06.Contracts
{
    interface IAnimalFactory
    {
        IAnimal Create(Type type,params string[] args);
    }
}
