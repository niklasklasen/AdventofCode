﻿using System;
using System.Collections.Generic;

namespace Day_2
{
    class Program
    {
       public static int[] Optcode()
        {
            int[] array = new int[] {1,0,0,3,1,1,2,3,1,3,4,3,1,5,0,3,2,6,1,19,1,5,19,23,1,13,23,27,1,6,27,31,2,31,13,35,1,9,35,39,2,39,13,43,1,43,10,47,1,47,13,51,2,13,51,55,1,55,9,59,1,59,5,63,1,6,63,67,1,13,67,71,2,71,10,75,1,6,75,79,1,79,10,83,1,5,83,87,2,10,87,91,1,6,91,95,1,9,95,99,1,99,9,103,2,103,10,107,1,5,107,111,1,9,111,115,2,13,115,119,1,119,10,123,1,123,10,127,2,127,10,131,1,5,131,135,1,10,135,139,1,139,2,143,1,6,143,0,99,2,14,0,0};
            array[1] = 12;
            array[2] = 2;
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
                if (optcode[i] == 2)
                {
                    optcode[optcode[i+3]] = optcode[optcode[i+1]] * optcode[optcode[i+2]];
                }
                if (optcode[i] == 99)
                {
                    break;
                }
                i = i + 4;
            }
            return optcode; 
        }
        public static void Main(string[] args)
        {
            var numbs = Intcode();
            Console.WriteLine(numbs[0]);
        }
    }
}