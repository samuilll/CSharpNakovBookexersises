using System;
using System.Text;
namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem06
{
    using Utilities;
    using Factories;
    using Models;
    using Contracts;
    using Enums;
    using System;

    class Problem_06 : Problem
    {
        public override void Run()
        {
            AnimalFactory animalFactory = new AnimalFactory();

            IAnimal[] animals = new IAnimal[]
                {
                    animalFactory.Create(typeof(Tomcat),"12","Tom","Male"),
                    animalFactory.Create(typeof(Cat),"9","Tom","Male"),
                    animalFactory.Create(typeof(Tomcat)),
                    animalFactory.Create(typeof(Tomcat),"7","Jerry"),
                    animalFactory.Create(typeof(Dog),"6","Lalo","Female"),
                    animalFactory.Create(typeof(Tomcat),"8","Tom","Male"),
                    animalFactory.Create(typeof(Kitten),"12","Tom"),
                    animalFactory.Create(typeof(Frog),"12","Fro","Female"),
                    animalFactory.Create(typeof(Dog))
                };

            Writer.WriteLine(string.Join(Environment.NewLine,(object[])animals));

        }
    }
}
