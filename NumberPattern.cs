using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCode
{
    internal class NumberPattern
    {

        public void RunPattern(int num)
        {
            int saved = num;
            while (num > 0)
            {
                List<char> temp = new List<char>();
                  
                for (int i = num; i < saved; i++)
                {
                    temp.Add(Convert.ToChar(i + '0'));
                }

                if (temp.Count > 0)
                {
                    Console.WriteLine($"{new string(temp.ToArray())}{saved}{new string(temp.AsEnumerable().Reverse().ToArray())}");
                }
                else
                {
                    Console.WriteLine(num);
                }

                num--;
            }
        }
    }
}
