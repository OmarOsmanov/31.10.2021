using System;
namespace Task2
{
    public class Student
    {
        public string FullName;
        public int Course;
        public string Subject;
        public string University;
        public string Email;
        public string Telephone;

        public Student(string fullName, int course, string subject, string university, string email, string telephone)
        {
            FullName = fullName;
            Course = course;
            Subject = subject;
            University = university;
            Email = email;
            Telephone = telephone;
        }

        public void ToString()
        {
            Console.WriteLine($"My name is {FullName}.I'm study {University}.My Telephone number is {Email} and Email is {Telephone}");
        }
    }
}