using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinderaCodeChallenge
{
    public class MinderaCodeChallenge
    {
        static void Main(string[] args)
        {
            var ccs1 = new ChallengeClusterSolution();
            var arr1 = ccs1.Group(new int[] { 16, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 67 }, 3);
            PrintArrArr(arr1);

            var ccs2 = new ChallengeClusterSolution();
            var arr2 = ccs2.Group(new int[] { 16, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 670 }, 3);
            PrintArrArr(arr2);

            var ccs3 = new ChallengeClusterSolution();
            var arr3 = ccs3.Group(new int[] { 160, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 670 }, 4);
            PrintArrArr(arr3);

            var ccs4 = new ChallengeClusterSolution();
            var arr4 = ccs4.Group(new int[] { 16, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 67 }, 5);
            PrintArrArr(arr4);

            Console.ReadKey();
        }

        private static void PrintArrArr(int[][] matrix)
        {
            var sb = new StringBuilder();
            sb.Append(@"[");
            for (int i = 0; i < matrix.Length; i++)
            {
                Array.Sort(matrix[i]);
                sb.Append(@"[");
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    sb.Append(matrix[i][j]);
                    if(j!= matrix[i].Length - 1)
                    {
                        sb.Append(@", ");
                    }
                }
                sb.Append(@"]");
                if (i != matrix.Length-1)
                {
                    sb.Append($",{Environment.NewLine}");
                }
            }
            sb.Append(@"]");
            Console.WriteLine(sb.ToString());
            Console.WriteLine(Environment.NewLine);
        }

        
    }

    
}
