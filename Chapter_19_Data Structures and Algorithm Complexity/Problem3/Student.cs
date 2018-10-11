using System;

namespace Chapter_19_Data_Structures_and_Algorithm_Complexity.Problem3
{
    class Student:IComparable<Student>
    {
        public Student(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get;private set; }

        public string LastName { get;private set; }

        public int CompareTo(Student other)
        {
          int  result = $"{this.LastName} {this.FirstName}".CompareTo($"{other.LastName} {other.FirstName}");
         
            return result;
        }

        public override string ToString()
        {
            string result = $"{this.FirstName} {this.LastName}";
            return result;
        }
    }
}
