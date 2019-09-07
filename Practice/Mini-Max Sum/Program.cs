using System;
using System.Collections.Generic;
using System.Linq;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
            miniMaxSum(arr);
        }

        static void miniMaxSum(int[] arr)
        {
            var list = new List<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                list.Add(arr[i]);
            }

            list.Sort();

            long minSum = 0;
            long maxSum = 0;

            for (int i = 0; i < list.Count - 1; i++)
            {
                minSum += list[i];
            }

            for (int i = 1; i < list.Count; i++)
            {
                maxSum += list[i];
            }

            Console.WriteLine($"{minSum} {maxSum}");
            
        }
    }
}
