namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem06.Models
{
    using Enums;

    class Kitten:Cat
    {
        public Kitten()
        {

        }

        public Kitten(int age, string name, GenderType gender)
            : base(age, name, gender)
        {
        }
        public Kitten(int age, string name)
    : base(age, name)
        {

        }

        public override string Sound()
        {
            return "I am kitten!";
        }
    }
}
