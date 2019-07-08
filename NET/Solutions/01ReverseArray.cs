using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions
{
    public static class _01ReverseArray
    {
        public static void Do()
        {
            string n = Console.ReadLine();      // N
            string arr = Console.ReadLine();    // a1 a2 ... an

            int N = int.Parse(n);
            int[] arrToReverse = arr.Split(' ').Select(i => int.Parse(i)).ToArray();

            for (int i = 0; i < N / 2; i++)
                Swap(arrToReverse, i, N - i - 1);

            string result = arrToReverse.Aggregate(new StringBuilder(), (sb, i) => sb.Append($"{i} ")).ToString();
            Console.WriteLine(result);
        }

        private static void Swap(int[] arrToReverse, int a, int b)
        {
            int tmp = arrToReverse[a];
            arrToReverse[a] = arrToReverse[b];
            arrToReverse[b] = tmp;
        }
    }
}
