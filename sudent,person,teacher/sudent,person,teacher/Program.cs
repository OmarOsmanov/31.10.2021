using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(18);
            student.Study();

            var person = new Person(34);
            person.SetAge(20);

            var teacher = new Teacher(24);
            teacher.Explain();

            student.ShowAge();
            Console.WriteLine(person.GetAge());


        }
    }
}
