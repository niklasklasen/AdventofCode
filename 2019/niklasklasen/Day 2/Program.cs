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

        public static void Main(string[] args)
        {
            var numbs = Optcode();
            foreach (var item in numbs)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}