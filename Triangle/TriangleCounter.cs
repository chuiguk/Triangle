using System;
using System.Linq;

namespace Triangle
{
    static class TriangleCounter
    {
        public static int FindMaxSum(int[][] array)
        {
            if (!array.Any() || array[0].Count() == 0)
            {
                return 0;
            }

            for (int i = array.Length - 1; i > 0; i--)
            {
                for (int j = 0; j < array[i].Length - 1; j++)
                {
                    int a = Int32.MinValue;
                    int b = array[i][j];
                    int c = array[i][j + 1];

                    if (j >= 1)
                    {
                        a = array[i][j - 1];
                    }

                    var biggest = new[] { a, b, c }.Max();
                    array[i - 1][j] += biggest;
                }
            }

            return array[0][0];
        }
    }
}

