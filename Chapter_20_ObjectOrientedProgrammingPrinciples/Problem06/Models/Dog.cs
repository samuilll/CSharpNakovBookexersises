namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem06.Models
{
    using Enums;

    class Dog : Animal
    {
        public Dog()
        {

        }
        public Dog(int age, string name, GenderType gender)
            :base(age,name,gender)
        {
        }

        public override string Sound()
        {
            return "Bau";
        }
    }
}
