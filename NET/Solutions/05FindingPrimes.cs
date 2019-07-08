using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class _05FindingPrimes
    {
        public static void Do()
        {
            int N = int.Parse(Console.ReadLine());  // number of test cases
            List<(ulong m, ulong n)> paramList = new List<(ulong m, ulong n)>();

            for (int i = 0; i < N; i++)
            {
                ulong m, n;
                string line = Console.ReadLine();
                var splitted = line.Split(' ');

                if (splitted.Length != 2) return;

                m = ulong.Parse(splitted[0]);
                n = ulong.Parse(splitted[1]);

                paramList.Add((m, n));
            }

            foreach (var item in paramList)
            {
                int result = 0;
                for (ulong prime = item.m; prime < item.n; prime++)
                {
                    if (IsPrime(prime)) result++;
                }

                Console.WriteLine(result);
            }
        }

        private static bool IsPrime(ulong number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;

            var limit = (ulong)Math.Ceiling(Math.Sqrt(number));

            for (ulong prime = 2; prime <= limit; prime++)
            {
                if (number % prime == 0)
                    return false;
            }

            return true;
        }
    }
}
