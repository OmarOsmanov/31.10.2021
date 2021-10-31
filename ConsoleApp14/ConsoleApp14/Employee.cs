using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Employee
    {
        public string name;
        public string surname;
        public string position;
        public int dailySalary;

        public Employee(string Name, string Surname, string Position, int DailySalary)
        {
            name = Name;
            surname = Surname;
            position = Position;
            dailySalary = DailySalary;


        }

        public int monthlySalary(int dailySalary, int ayingunleri)
        {

            int total = dailySalary * ayingunleri;
            return total;
        }
    }
}
