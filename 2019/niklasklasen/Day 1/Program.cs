﻿using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mass input
            List<int> massinput = new List<int>() {12, 14, 1969, 100756};
            int fueltot = 0;

            // Calculation
            for(int i = 0; i < massinput.conut - 1; i++)
            {
                int fuel = (massinput[i] / 3) - 2;
                int fueltot = fueltot + fuel;
            };

            // Output
            Console.WriteLine($"Fuel requierd: {fueltot}");

            int ans = 2 + 2 + 654 + 33583;
            Console.WriteLine($"Fuel requierd should be {ans}");
        }
    }
}
