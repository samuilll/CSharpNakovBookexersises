﻿namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem06.Contracts
{
    using Enums;

    interface IAnimal
    {
        int Age { get; }

        string Name { get; }

        GenderType? Gender { get; }

        string Sound();
    }
}
