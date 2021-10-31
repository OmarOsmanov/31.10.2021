using System;

namespace Task1
{
    public class Teacher : Person
    {
        public Teacher(int age) : base(age)
        {
        }

        public void Explain()
        {
            Console.WriteLine("I'm explaining");
        }
    }
}