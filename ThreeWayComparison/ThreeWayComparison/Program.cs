﻿using System;

namespace ThreeWayComparison
{
    class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine(1);
            }
            else if (a < b)
            {
                Console.WriteLine(-1);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}