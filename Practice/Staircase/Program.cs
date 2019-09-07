﻿using System;

namespace Staircase
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);
        }

        static void staircase(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 1; j < n - i; j++)
                {
                    Console.Write(" ");
                   
                }

                for (int k = 0; k <= i ; k++)
                {
                    
                    Console.Write("#");
                }

                Console.WriteLine();
            }

        }
    }
}
