using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Diagonal_Difference
{
    class Program
    {

        public static int diagonalDifference(List<List<int>> arr)
        {
            int lefDiagonalSum = 0;
            int rightDiagonalSum = 0;

            for (int column = 0; column < arr.Count; column++)
            {
                lefDiagonalSum += arr[column][column];
            }

            for (int row = 0; row < arr.Count; row++)
            {
                rightDiagonalSum +=arr[row][Math.Abs(row - (arr.Count - 1))];
            }

            int result = Math.Abs(lefDiagonalSum - rightDiagonalSum);
            return result;
        }

        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@"C:\Users\Acer\test.txt", true);

            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            int n = int.Parse(Console.ReadLine());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = Program.diagonalDifference(arr);

            Console.WriteLine(result);

            //textWriter.Flush();
            //textWriter.Close();
        }
    }
}
