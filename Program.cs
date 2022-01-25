using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep
{
    //Умножение матрицы на число;
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Количество строк матрицы A: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов матрицы A: ");
            int c = int.Parse(Console.ReadLine());
            Console.Write("На что умножаем?: ");
            int k = int.Parse(Console.ReadLine());

            double[,] A = new double[r, c];

            for (var i = 0; i < r; i++)
            {
                for (var j = 0; j < c; j++)
                {
                    Console.Write("[{0}][{1}] = ", i, j);
                    A[i, j] = double.Parse(Console.ReadLine());
                }
            }

            var B = new double[A.GetLength(0), A.GetLength(1)];

            for (var i = 0; i < A.GetLength(0); i++)
            {
                for (var j = 0; j < A.GetLength(1); j++)
                {
                    B[i, j] = A[i, j] * k;
                }
            }

            for (var i = 0; i < B.GetLength(0); i++)
            {
                for (var j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }

        }

    }

}


