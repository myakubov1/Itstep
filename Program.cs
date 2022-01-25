using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep
{
    //Умножение матрицы на матрицу;
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Количество строк матрицы A: ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов матрицы A: ");
            int c = int.Parse(Console.ReadLine());

            int[,] A = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write("[{0}][{1}] = ", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }



            Console.Write("Количество строк матрицы B: ");
            int r2 = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов матрицы B: ");
            int c2 = int.Parse(Console.ReadLine());

            int[,] B = new int[r2, c2];

            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write("[{0}][{1}] = ", i, j);
                    B[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("-----------------------------------------------------");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    Console.Write(A[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
            Console.WriteLine("-----------------------------------------------------");

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }

            if (A.GetLength(0) != B.GetLength(0) || A.GetLength(1) != B.GetLength(1))
            {
                Console.WriteLine("Количество столбцов и строк A должно быть равно количеству стольбцов и строк  B!");
                return;
            }
            else
            {
                int[,] C = new int[A.GetLength(0), B.GetLength(1)];


                for (int i = 0; i < A.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        C[i, j] = A[i, j] + B[i, j];
                    }
                }

                Console.WriteLine("-----------------------------------------------------");
                Console.WriteLine("Итоговая матрица");
                for (int i = 0; i < C.GetLength(0); i++)
                {
                    for (int j = 0; j < C.GetLength(1); j++)
                    {
                        Console.Write(C[i, j].ToString().PadLeft(5));
                    }
                    Console.WriteLine();
                }

            }
        }

    }

}


