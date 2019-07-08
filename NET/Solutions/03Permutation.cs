using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions
{
    public static class _03Permutation
    {
        public static void Do()
        {
            int n = 11; // from task

            string firstArr = Console.ReadLine();
            string secondArr = Console.ReadLine();

            var firstSorted = firstArr.Split(' ').Select(s => int.Parse(s)).OrderBy(i => i).ToArray();
            var secondSorted = secondArr.Split(' ').Select(s => int.Parse(s)).OrderBy(i => i).ToArray();

            for (int i = 0; i < n; i++)
            {
                if (firstSorted[i] != secondSorted[i])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
