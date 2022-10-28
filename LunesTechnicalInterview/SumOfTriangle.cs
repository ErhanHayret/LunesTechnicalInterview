using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunesTechnicalInterview
{
    public class SumOfTriangle
    {
        public int Func(int[] input, int row = 1)
        {
            int mostBiggest = 0;
            int result = 0;
            int count = 0;
            for (int i = row; i > 0; i--)
            {
                count += i;
            }
            if (count <= input.Length)
            {
                mostBiggest = input[0];
                for (int i = 0; i < row; i++)
                    if (input[i] >= mostBiggest)
                        mostBiggest = input[i];
                for (int i = row, j = 0; i < input.Length; i++, j++)
                {
                    input[j] = input[i];
                }
                row++;
                result = Func(input, row);
            }
            return result + mostBiggest;
        }
    }
}
