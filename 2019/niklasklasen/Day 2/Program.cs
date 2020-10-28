using System;
using System.Collections.Generic;

namespace Day_2
{
    class Program
    {
       public static int[] Optcode()
        {
            int[] array = new int[] {1,0,0,0,99};
            // array[1] = 12;
            // array[2] = 2;
            return array;
        }

        public static int[] Intcode()
        {
            int[] optcode = Optcode();
            int i = 0;
            while (i < optcode.Length - 1)
            {
                if (optcode[i] == 1)
                {
                    optcode[optcode[i+3]] = optcode[optcode[i+1]] + optcode[optcode[i+2]];
                }
                i = i + 4;
            }
            return optcode; 
        }
        public static void Main(string[] args)
        {
            var numbs = Intcode();
            foreach (var item in numbs)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}