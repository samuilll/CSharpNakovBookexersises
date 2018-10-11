namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem06.Models
{
    using Enums;

    class Cat:Animal
    {
        private int age;
        private string name;

        public Cat()
        {

        }

        public Cat(int age, string name)
            :base(age,name)
        {
        }

        public Cat
            (int age, string name, GenderType gender)
            : base(age, name, gender)
        {
        }

        public  override  string Sound()
        {
            return "Oh";
        }
    }
}
