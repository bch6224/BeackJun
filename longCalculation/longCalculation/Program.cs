﻿using System;
using System.Numerics;

namespace longCalculation
{
    class Program
    {
        static void Main()
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
        }
    }
}