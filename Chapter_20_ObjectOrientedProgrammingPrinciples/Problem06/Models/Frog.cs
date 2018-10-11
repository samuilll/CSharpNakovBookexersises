namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem06.Models
{
    using Enums;

    class Frog:Animal
    {
        public Frog()
        {

        }
        public Frog(int age, string name, GenderType gender)
            : base(age, name, gender)
        {
        }

        public override string Sound()
        {
            return "Muuuuu";
        }
    }
}
