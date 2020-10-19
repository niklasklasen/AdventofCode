using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calculation
            var mass = 100756;
            int fuel = (mass / 3) - 2;

            // Output
            Console.WriteLine($"module mass: {mass}");
            Console.WriteLine($"Fuel requierd: {fuel}");
        }
    }
}
