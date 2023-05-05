using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCode
{
    internal class Triplets
    {
        public void RunTriplets()
        {
            List<int[]> triplets = new List<int[]>();
            int iterations = 0;

            for (int a = 3; a < 30; a++)
            {
                if (triplets.Count >= 10) break;
                
                for (int b = 4; b < 30; b++)
                {
                    if (triplets.Count >= 10) break;

                    int total = (a * a) + (b * b);
                    double c = Math.Sqrt(total);
                    if (c == Math.Truncate(c))
                    {
                        Console.WriteLine($"{a},{b},{c} => {a * a} + {b * b} = {c * c} @ Iteration {iterations}");
                        triplets.Add(new int[] { a, b, (int)c });
                    }

                    iterations++;
                }
            }
        }
    }
}
