using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCode
{
    internal class BridgeCrossing
    {
        int TimeRemaining = 30;
        int[] Initial = new int[] { 3, 6, 7, 9 };

        public void Cross()
        {
            int[] RightBank = Initial;
            int[] LeftBank = new int[RightBank.Length];
            int speedyBoi = Array.IndexOf(RightBank, RightBank.Min());
            int totalValue = RightBank.Sum();

            while (LeftBank.Sum() < totalValue)
            {
                Console.WriteLine($"Right Bank: {DisplayNames(RightBank)} || Left Bank: {DisplayNames(LeftBank)}");
                int slowestBoi = Array.IndexOf(RightBank, RightBank.Max());

                int[] crossingPair = {speedyBoi, slowestBoi};

                Console.WriteLine($"Friend{speedyBoi} and Friend{slowestBoi} cross to the left bank taking {Initial[speedyBoi]} minutes!");
                TimeRemaining -= Initial[speedyBoi];
                LeftBank[slowestBoi] = RightBank[slowestBoi];
                RightBank[slowestBoi] = 0;
                
                if (RightBank.Sum() == RightBank[speedyBoi])
                {
                    LeftBank[speedyBoi] = RightBank[speedyBoi];
                    RightBank[speedyBoi] = 0;
                }
                else
                {
                    TimeRemaining -= Initial[speedyBoi];
                    Console.WriteLine($"Friend{speedyBoi} crosses back to the right bank taking {Initial[speedyBoi]} minutes!");
                }
                
                Console.WriteLine($"Time Remaining: {TimeRemaining} minutes\n\n");
                
            }

            Console.WriteLine($"Right Bank: {DisplayNames(RightBank)} || Left Bank: {DisplayNames(LeftBank)}");
        }

        string DisplayNames(int[] nums)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;
            foreach (var i in nums)
            {
                if (i != 0)
                {
                    sb.Append($"Friend{index} ");
                }
                index++;
            }

            return sb.ToString();
        }
    }
}
