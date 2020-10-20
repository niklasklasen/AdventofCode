using System;
using System.IO;

namespace _2019_12_01
{
    class Program
    {

        static public int CalcFuel(int mass)
        {
            return (int)(Math.Floor((double)(mass / 3)) - 2);
        }


        static public int CalcFuel2(int mass)
        {
            int result = 0;
            int c = CalcFuel(mass);
            result += c;
            Console.WriteLine(mass + " Required Fuel: " + c);
            Console.WriteLine("Total: " + result + "\n");

            while ( c > 0)
            {
                Console.WriteLine("Required Fuel: " + c);
                Console.WriteLine("Total: " + result + "\n");
                c = CalcFuel(c);
                if(c > 0)
                    result += c;
            }

            Console.WriteLine(mass + " Required Fuel: " + c);
            Console.WriteLine("Total: " + result + "\n");
            return result;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World! 2019-12-01");

            string line;
            int sum = 0;
            StreamReader file = new StreamReader(@"input.txt");
            while ((line = file.ReadLine()) != null)
            {
                
                //Console.WriteLine(line);
                int tal = int.Parse(line);
                //Console.WriteLine(tal);

                int result = CalcFuel2(tal);
                sum += result;

                //Console.WriteLine(tal + " / 3 - 2 = " + result);

            }

            Console.WriteLine("Sum of all fuel required for the modules: " + sum);
        }
    }
}
