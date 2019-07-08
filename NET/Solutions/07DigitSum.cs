using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class _07DigitSum
    {
        public static void Do()
        {
            int N = int.Parse(Console.ReadLine());  // length of array

            if (N < 1) return;

            string line = Console.ReadLine(); // array of integers
            string[] array = line.Split(' ');

            if (array.Length != N) return;

            (int index, int value) result = (0, GetDigitSum(array[0]));
            for (int i = 1; i < array.Length; i++)
            {
                int sum = GetDigitSum(array[i]);
                if (sum >= result.value)
                    result = (i, sum);
            }

            Console.WriteLine(result.index);
        }

        private static int GetDigitSum(string v)
        {
            return v.Aggregate(0, (sum, letter) => sum += int.Parse(letter.ToString())); 
        }
    }
}
