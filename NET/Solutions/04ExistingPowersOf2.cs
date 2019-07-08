using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Solutions
{
    public static class _04ExistingPowersOf2
    {
        public static void Do()
        {
            List<uint> list = new List<uint>();

            string line;
            while (!string.IsNullOrEmpty(line = Console.ReadLine()))
                list.Add(uint.Parse(line));

            SortedSet<uint> set = new SortedSet<uint>(); // add in sorted set does not accept duplicates
            foreach (var item in list)
            {
                for (uint power = 1; power != 0; power <<= 1)
                {
                    if ((item & power) != 0)
                        set.Add(power);
                }
            }

            string result = set.Aggregate(new StringBuilder(), (sb, i) => sb.Append($"{i}, ")).ToString().Trim(',', ' ');
            Console.WriteLine(result);
        }
    }
}
