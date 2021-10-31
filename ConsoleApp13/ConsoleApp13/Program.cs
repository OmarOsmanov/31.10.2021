// qutu taski

using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Program.VolumeOfBox(2, 3, 4));
        }

        public static int VolumeOfBox(int height, int length, int width)
        {
            return height * length * width;
        }
    }
}
