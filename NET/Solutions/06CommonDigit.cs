using System;
using System.Collections.Generic;
using System.Text;

namespace Solutions
{
    public static class _06CommonDigit
    {
        public static void Do()
        {
            int N = int.Parse(Console.ReadLine());  // length of array

            if (N < 1) return;

            string line = Console.ReadLine(); // array of integers
            string[] array = line.Split(' ');

            if (array.Length != N) return;

            Dictionary<char, int> dict = new Dictionary<char, int>();
            foreach (var word in array)
            {
                foreach (var letter in word)
                {
                    try
                    {
                        dict.Add(letter, 1);
                    }
                    catch (ArgumentException )
                    {
                        dict[letter]++;
                    }
                }
            }

            // find max value
            (char letter, int value) result = ('\n', int.MinValue);
            foreach (var item in dict)
            {
                if (item.Value > result.value || 
                    (item.Value == result.value && item.Key > result.letter))
                {
                    result = (item.Key, item.Value);
                }
            }

            Console.WriteLine(result.letter);
        }
    }
}
