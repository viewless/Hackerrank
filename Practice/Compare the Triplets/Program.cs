using System.Collections.Generic;
using System.Linq;
using System;
using System.IO;

namespace Compare_the_Triplets
{
    class Program
    {
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            var aliceCount = 0;
            var bobCount = 0;

            for (int i = 0; i < a.Count; i++)
            {

                if (a[i] > b[i])
                {
                    aliceCount++;
                   
                }
                else if (a[i] < b[i])
                {
                    bobCount++;
                }

            }

            var result = new List<int>() { aliceCount, bobCount };

            return result;

        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@"C:\Users\Acer\test.txt", true);

            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            //List<int> alice = Console.ReadLine().Split().Select(int.Parse).ToList();
            //List<int> bob = Console.ReadLine().Split().Select(int.Parse).ToList();


            List<int> result = compareTriplets(a, b);

            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
