using System;
using Yaratdigim_class_library;

namespace _03._11._2021
{
    class Program
    {
        static void Main(string[] args)
        {
            LibraryninIcindeYaratdigim library = new LibraryninIcindeYaratdigim();
            Console.WriteLine(library.add(4.6M, 5.6M));
            Console.WriteLine(library.ferqi(6.789M, 2.456M));
            Console.WriteLine(library.power(8, 3));
            Console.WriteLine(library.UcbucaginSahesi(6, 5));
        }
    }
}