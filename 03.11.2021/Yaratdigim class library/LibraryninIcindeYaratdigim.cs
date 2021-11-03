using System;

namespace Yaratdigim_class_library
{
    public class LibraryninIcindeYaratdigim
    {

        public int add(int a, int b)
        {
            int total = (a * a * a) + (b * b * b);
            return total;
        }
        public decimal add(decimal a, decimal b)
        {
            decimal total = (a * a * a) + (b * b * b);
            return total;
        }
        public decimal ferqi(decimal a, decimal b)
        {
            decimal total = a - b;
            return total;
        }

        public int power(int a, byte b)
        {
            int pow = 1;
            for (int i = 0; i < b; i++)
            {
                pow *= b;
            }
            return pow;
        }

        public int UcbucaginSahesi(int a,int h)
        {
            int total = (a * h) / 2;
            return total;
        }

    }

}

