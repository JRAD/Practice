using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[,] { {1,0,3}, {4,5,6}, {7,8,0} };
            int[,] result = ZeroOut(matrix);
            int rowLength = result.GetLength(0);
            int colLength = result.GetLength(1);

            for (int i = 0; i < rowLength; i++)
            {
                for (int j = 0; j < colLength; j++)
                {
                    Console.Write(string.Format("{0} ", result[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }

            int n = 3;
            int[][] derp = new int[][] {new int[] {11, 2, 4}, new int[] {4, 5, 6}, new int[] {10, 8, -12}};
            int sum = computeDifference(n, derp);
            Console.WriteLine("Sum = " + sum);

            Console.ReadLine();
        }

        public static int[,] ZeroOut(int [,] matrix)
        {
            int foundx = 0;
            int foundy = 0;
            int xindex = matrix.GetLength(0);
            int yindex = matrix.GetLength(1);
            bool found = false;

            if(matrix.Equals(null) )
            { return matrix; }
            //probably need an empty check too

            for (int i = 0; i < xindex; i++)
            {
                for (int j = 0; j < yindex; j++)
                {
                    if (matrix.GetValue(i, j).Equals(0))
                    {
                        foundx = i;
                        foundy = j;
                        found = true;
                        Console.WriteLine("zero located: " + foundx + "," + foundy);
                    }
                }
            }

            if (found)
            {
                for (int i = 0; i < xindex; i ++)
                {
                    for (int j = 0; j < yindex; j++)
                    {
                        if (i == foundx || j == foundy)
                        {
                            matrix.SetValue(0, i,j);
                        }
                    }
                }
            }
            return matrix;
        }

        public static int computeDifference(int rows, int[][] diagonal)
        {
            List<int> diagonal1 = new List<int>();
            List<int> diagonal2 = new List<int>();
            int j = 0;

            for (int i = 0; i < rows; i++)
            {
                diagonal1.Add(diagonal[i][j]);
                j++;
            }
            j = 0;
            for (int i = rows-1; i >= 0; i--)
            {
                diagonal2.Add(diagonal[i][j]);
                j++;
            }
            int sum1 = 0;
            foreach (var i in diagonal1)
            {
                sum1 += i;
            }
            int sum2 =0;
            foreach (var i in diagonal2)
            {
                sum2 += i;
            }

            return Math.Abs(sum1 - sum2);
        }
    }
}
