namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem06.Models
{
    using Chapter_20_ObjectOrientedProgrammingPrinciples.Enums;
    using Contracts;

    abstract class Animal : IAnimal
    {
        private const string DefaultName = "No name";
        private const int DefaultAge = 0;
        private const GenderType DefaultGender = GenderType.NoGender;

        public Animal()
        {
            this.Name = DefaultName;
            this.Age = DefaultAge;
            this.Gender = DefaultGender;
        }

        protected Animal(int age, string name)
        {
            Age = age;
            Name = name;
            this.Gender = DefaultGender;
        }

        protected Animal(int age, string name, GenderType gender)
        {
            Age = age;
            Name = name;
            Gender = gender;
        }

        public int Age { get; private set; }

        public string Name { get; private set; }

        public GenderType? Gender { get; private set; }

        public abstract string Sound();

        public override string ToString()
        {
            return $"{this.Name}, {this.Age} years old,{this.Gender}, says {this.Sound()}";
        }

    }
}
