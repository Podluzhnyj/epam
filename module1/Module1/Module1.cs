using Module1;
using System;

namespace M1
{
    public class Module1
    {
        static void Main(string[] args)
        {
           

        }

        public int[] SwapItems(int a, int b)
        {
            Console.WriteLine($"{a}-{b}");

            int[] SwapItems = new int[] { b, a };
            Console.WriteLine(SwapItems[0] + "-" + SwapItems[1]);
            return SwapItems;
        }

        public int GetMinimumValue(int[] input)
        {
            int min, i;
            min = input[0];
            for (i = 1; i < input.Length; i++)
            {
                if (input[i] < min)
                {
                    min = input[i];
                }
            }
            return min;
        }
    }
}
