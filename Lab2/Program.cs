using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Matrix
    {
        private byte[,] matrix;
        int M, N;
        public Matrix(byte[,] matrix,int M,int N)
        {
            this.M = M;
            this.N = N;
            this.matrix = matrix;
        }
        public byte[,] Transponate()
        {
            byte[,] matrix = new byte[N, M];
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    matrix[j, i] = this.matrix[i, j];
                }
            }
            return matrix;
        }
        public double GetMiddleValue()
        {
            double result = 0;
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    result += matrix[i, j];
                }
            }
            return result / (N * M);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int M = 5;
            int N = 9;
            byte[,] matrix = new byte[M, N];
            string[,] matrixStr = new string[M, N];

            while (true)
            {
                Console.WriteLine("Fill matrix:");
                for (int i = 0; i < M; i++)
                {
                    string[] help = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < N; j++)
                    {
                        try
                        {
                            matrixStr[i, j] = help[j];
                        }
                        catch (IndexOutOfRangeException)
                        {
                            break;
                        }
                    }
                }
                try
                {
                    for (int i = 0; i < M; i++)
                    {
                        for (int j = 0; j < N; j++)
                        {
                            matrix[i, j] = Convert.ToByte(matrixStr[i, j]);
                        }
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid data! Try again!");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("You entered too big or too small number! Try again!");
                    continue;
                }
                break;
            }
            Matrix instMatrix = new Matrix(matrix, M, N);
            double middle = instMatrix.GetMiddleValue();
            byte[,] transMatrix = instMatrix.Transponate();
            Console.WriteLine(middle);
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write("{0} ",transMatrix[i,j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
