using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mass input
            List<int> massInput = new List<int>();
            massInput.Add(12);
            massInput.Add(14);
            massInput.Add(1969);
            massInput.Add(100756);
            
            var fuelTotal = new List<decimal>();

            // Calculation
            for(int i = 0; i < massInput.Count; i++)
            {
                int fuel = (massInput[i] / 3) - 2;
                fuelTotal.Add(fuel);
            };
            int sum = fuelTotal.Sum();

            // Output
            Console.WriteLine(sum);
            int ans = 2 + 2 + 654 + 33583;
            Console.WriteLine($"Fuel requierd should be {ans}");
        }
    }
}
