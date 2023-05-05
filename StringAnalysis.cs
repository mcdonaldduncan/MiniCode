using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCode
{
    internal class StringAnalysis
    {
        public void AnalyzeString(string toAnalyze)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            foreach (var ch in toAnalyze)
            {
                if (counts.ContainsKey(ch))
                {
                    counts[ch]++;
                }
                else
                {
                    counts.Add(ch, 1);
                }
            }

            char max = counts.OrderByDescending(x => x.Value).FirstOrDefault().Key;
            char min = counts.OrderBy(x => x.Value).FirstOrDefault().Key;

            Console.WriteLine($"Maximum occuring char: {max}");
            Console.WriteLine($"Minimum occuring char: {min}");
        }

    }
}
