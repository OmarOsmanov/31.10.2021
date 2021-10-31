using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class car:vehicle
    {
       
        public int fuelCapasity;
        public int dourCount;
        public int consumption;



        public void masininfo()
        {
            Console.WriteLine("masinin brandi"+ brand);
            Console.WriteLine("masinin modeli"+ model);
        }

        public int consumptions(int serfiyyat, int fuelCapasity)
        {
            int total = serfiyyat * fuelCapasity;
            return total;
        }
    }
}
