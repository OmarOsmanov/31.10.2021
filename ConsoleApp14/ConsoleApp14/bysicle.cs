using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class bysicle:vehicle
    {
        public string brand;
        public string model;
        public string color;
        public int whellSize;


        public bysicle(string Brand,string Model,string Color, int Whellsize)
        {
           
            
            whellSize = Whellsize;
        }



        public void velosiped()
        {
            Console.WriteLine(" velosipedin markasi ; " + brand);
            Console.WriteLine(" velosipedin modeli :"+ model);
        }

    }
}
