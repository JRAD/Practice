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
    }
}
