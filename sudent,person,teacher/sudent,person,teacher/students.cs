using System;

namespace Task1
{
    public class Student : Person
    {
        public Student(int age) : base(age)
        {
        }

        public void Study()
        {
            Console.WriteLine("I'am studying");
        }
        public void ShowAge()
        {
            Console.WriteLine($"My age is: {GetAge()} years old");
        }
    }
}