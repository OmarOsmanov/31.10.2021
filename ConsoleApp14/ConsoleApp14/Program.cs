//6 si birinde olan task: isci , masin . velosiped olan task


using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {

            car masin = new car();
            masin.brand = "Audi";
            masin.model = " rs7";
            masin.colur = "red";
            masin.dourCount = 5;
            masin.fuelCapasity = 80;

            masin.masininfo();
            Console.WriteLine("masinin toplam gede bileceyi mesafe:" + masin.consumptions(6, 80));



            
            
            bysicle velo = new bysicle("MaxPower","mmm4","Yellow",28);
            velo.velosiped();




            
            Employee isci = new Employee("rustem","behramov","muhendis",15);
            Console.WriteLine(" iscinin maasi:" + isci.monthlySalary (15,30));
  

        }
    }

}
