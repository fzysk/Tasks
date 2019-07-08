using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class _02Palindrome
    {
        public static void Do()
        {
            string input = Console.ReadLine();
            int n = input.Length;

            for (int i = 0, j = n - 1; i < n / 2; i++, j--)
            {
                if (input[i] != input[j])
                {
                    Console.WriteLine("NO");
                    return;
                }
            }

            Console.WriteLine("YES");
        }
    }
}
