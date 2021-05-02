using System;

namespace Bit_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10, z = 15;

            // 0000 1010  >> 75 = 0000 0000 
            x += y >> x++ * z;

            Console.WriteLine($"x = {x}");

            // 0000 0110 & 0011 0010 = 0000 0010
            z = ++x & y * 5;

            Console.WriteLine($"z = {z}");

            //  0000 1111 | 0000 1111
            y /= x + 5 | z;

            Console.WriteLine($"y = {y}");

            //  0000 0101 & 0011 0010 = 0000 0000
            z = x++ & y * 5;

            Console.WriteLine($"z = {z}");

            //0000 1010 << 0000 0101 ^ 0000 1111
            // 0001 1000 0000 ^ 0000 1111
            // 00001 1000 1111
            x = y << x++ ^ z;

            Console.WriteLine($"x = {x}");
        }
    }
}
