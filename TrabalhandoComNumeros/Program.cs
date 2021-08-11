﻿using static System.Console;
using System;
using System.Numerics;

namespace TrabalhandoComNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            var maior = ulong.MaxValue;
            WriteLine($"{maior,40:NO}");

            var atomsInTheUniverse = BigInteger.Parse("123456789012345678901234567890");
            WriteLine($"{atomsInTheUniverse,40:N0}");

            var c1 = new Complex(4, 2);
            var c2 = new Complex(3, 7);
            var c3 = c1 + c2;
            WriteLine($"{c1} added to {c2} is {c3}");

        }
    }
}
