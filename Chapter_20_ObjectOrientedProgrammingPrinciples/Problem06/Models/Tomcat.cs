namespace Chapter_20_ObjectOrientedProgrammingPrinciples.Problem06.Models
{
    using Enums;

    class Tomcat:Cat
    {
        public Tomcat()
        {

        }
        public Tomcat(int age, string name, GenderType gender)
            : base(age, name, gender)
        {
        }
        public Tomcat(int age, string name)
            : base(age,name)
        {

        }

        public override string Sound()
        {
            return "I am tomcat";
        }
    }
}
