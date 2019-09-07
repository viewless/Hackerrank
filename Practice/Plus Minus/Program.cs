using System;

namespace Plus_Minus
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }

        static void plusMinus(int[] arr)
        {
            int counterPositive = 0;
            int counterNegative = 0;
            int counterZero = 0;
           
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    counterPositive++;
                }
                else if (arr[i] < 0)
                {
                    counterNegative++;
                }
                else
                {
                    counterZero++;
                }
            }

            double positive = (double)counterPositive / arr.Length;
            double negative = (double)counterNegative / arr.Length;
            double zero = (double)counterZero / arr.Length;

            double[] result = { positive, negative, zero };

            foreach (var item in result)
            {
                Console.WriteLine($"{item :F6}");
            }
        }
    }
}
