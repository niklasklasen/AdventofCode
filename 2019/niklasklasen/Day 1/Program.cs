using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mass input
            var massInput = new List<int>() {12, 14, 1969, 100756};
            
            // Calculation
            var fuel = 0;
            foreach (var module in massInput)
            {
                fuel += (module / 3) -2;
            }
        
            // Output
            Console.WriteLine($"Fuel requierd is {fuel}");
        }
    }
}
