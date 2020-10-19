using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() {12, 14, 1969, 100756};
            
            // Calculation
            var mass = 100756;
            int fuel = (mass / 3) - 2;

            // Output
            Console.WriteLine($"module mass: {mass}");
            Console.WriteLine($"Fuel requierd: {fuel}");

            int ans = 2 + 2 + 654 + 33583;
            Console.WriteLine($"Fuel requierd should be {ans}");
        }
    }
}
