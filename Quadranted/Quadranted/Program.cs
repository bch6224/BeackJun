﻿using System;

namespace Quadranted
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a >= 0 && b >= 0)
            {
                Console.WriteLine(1);
            }
            else if (a < 0 && b >= 0)
            {
                Console.WriteLine(2);
            }
            else if (a < 0 && b < 0)
            {
                Console.WriteLine(3);
            }
            else if (a >= 0 && b < 0)
            {
                Console.WriteLine(4);
            }
        }
    }
}