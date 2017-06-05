using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinderaCodeChallenge
{
    public class MinderaCodeChallenge
    {
        public static readonly ChallengeInput input1 = new ChallengeInput(new int[] { 16, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 67 }, 3);
        public static readonly ChallengeInput input2 = new ChallengeInput(new int[] { 16, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 670 }, 3);
        public static readonly ChallengeInput input3 = new ChallengeInput(new int[] { 160, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 670 }, 4);
        public static readonly ChallengeInput input4 = new ChallengeInput(new int[] { 16, 15, 14, 13, 34, 23, 24, 25, 26, 28, 45, 34, 23, 29, 12, 23, 45, 67, 23, 12, 34, 45, 23, 67, 23, 67 }, 5);

        static void Main(string[] args)
        {
            var ccs1 = new ChallengeClusterSolution();
            var exampleOutput1 = ccs1.Group(input1.Get_inputArr(), input1._groups);
            Console.WriteLine(nameof(exampleOutput1));
            PrintArrArr(exampleOutput1);

            var exampleOutput2 = new ChallengeClusterSolution();
            var arr2 = exampleOutput2.Group(input2.Get_inputArr(), input2._groups);
            Console.WriteLine(nameof(exampleOutput2));
            PrintArrArr(arr2);

            var ccs3 = new ChallengeClusterSolution();
            var exampleOutput3 = ccs3.Group(input3.Get_inputArr(), input3._groups);
            Console.WriteLine(nameof(exampleOutput3));
            PrintArrArr(exampleOutput3);

            var ccs4 = new ChallengeClusterSolution();
            var exampleOutput4 = ccs4.Group(input4.Get_inputArr(), input4._groups);
            Console.WriteLine(nameof(exampleOutput4));
            PrintArrArr(exampleOutput4);

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

        public class ChallengeInput
        {
            public ChallengeInput(int[] inputArr, int groups)
            {
                _inputArr = inputArr;
                _groups = groups;
            }

            private int[] _inputArr1;


            readonly int[] _inputArr;
            public int[] Get_inputArr()
            {
                int[] copy = new int[_inputArr.Length];
                for (int i = 0; i < _inputArr.Length; i++)
                {
                    copy[i] = _inputArr[i];
                }
                return copy;
            }

            public int _groups { get; }
        }
    }

    
}
