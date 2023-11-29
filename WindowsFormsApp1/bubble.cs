using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class bubble
    {
        public int[] BubbleSortInAesc(int[] input)
        {
            for (int i = input.Length; i > 0; i--)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        //Swap the numbers
                        input[j] = input[j + 1] + input[j];
                        input[j + 1] = input[j] - input[j + 1];
                        input[j] = input[j] - input[j + 1];
                    }
                }
            }
            return input;
        }
    }
}
