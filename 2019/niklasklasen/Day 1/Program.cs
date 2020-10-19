using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task
            //Fuel required to launch a given module is based on its mass. 
            //Specifically, to find the fuel required for a module, take its mass, divide by three, round down, and subtract 2.

            // Calculation
            var mass = 12;
            int fuel = (mass / 3) - 2;

            // Output
            Console.WriteLine($"module mass: {mass}");
            Console.WriteLine($"Fuel requierd: {fuel}");
        }
    }
}
