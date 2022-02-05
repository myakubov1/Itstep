using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep.M5C0
{



    class Matrix
    {
        int Rows { get; set; }
        int Columns { get; set; }
        int[,] MatrixValues { get; set; }

        public Matrix(int countRows, int countColumns)
        {
            this.Rows = countRows;
            this.Columns = countColumns;
            MatrixValues = new int[countRows, countColumns];

        }

        public static void ShowExercise()
        {
            Console.WriteLine("Введите количество строк: ");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов: ");
            int c = int.Parse(Console.ReadLine());

            Matrix A = new Matrix(r, c);
            A.Create();
            A.Print();

            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            Matrix B = new Matrix(r, c);
            B.Create();
            B.Print();

            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            Matrix C = A + B;
            C.Print();

            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            C = A - B;
            C.Print();

            Console.WriteLine("|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");

            C = A * B;
            C.Print();
        }

        public void Create()
        {
            Random rnd = new Random();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    MatrixValues[i, j] = rnd.Next(1000000, 1000000) + rnd.Next(1000000, 1000000);
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    Console.Write(MatrixValues[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.Rows, B.Columns);


            if ((A.Columns != B.Columns) || (A.Rows != B.Rows))
            {
                throw new Exception("Для матриц с разным размером сложение не возможно!");
            }

            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < B.Columns; j++)
                {
                    C.MatrixValues[i, j] = A.MatrixValues[i, j] + B.MatrixValues[i, j];
                }
            }

            return C;
        }


        public static Matrix operator -(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.Rows, B.Columns);


            if ((A.Columns != B.Columns) || (A.Rows != B.Rows))
            {
                throw new Exception("Для матриц с разным размером вычитание не возможно!");
            }

            for (int i = 0; i < A.Rows; i++)
            {
                for (int j = 0; j < B.Columns; j++)
                {
                    C.MatrixValues[i, j] = A.MatrixValues[i, j] - B.MatrixValues[i, j];
                }
            }

            return C;
        }


        public static Matrix operator *(Matrix A, Matrix B)
        {
            Matrix C = new Matrix(A.Rows, B.Columns);


            if (A.Columns != B.Rows)
            {
                throw new Exception("Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }

            for (var i = 0; i < A.Rows; i++)
            {
                for (var j = 0; j < B.Columns; j++)
                {
                    C.MatrixValues[i, j] = 0;
                    try
                    {
                        for (int k = 0; k < A.Columns; k++)
                        {
                            checked
                            {
                                C.MatrixValues[i, j] += A.MatrixValues[i, k] * B.MatrixValues[k, j];
                            }
                        }
                    }
                    catch (OverflowException ex)
                    {
                        throw new Exception($"{ex.Message} в матрице С [{i}] [{j}]");
                    }
                }
            }

            return C;
        }
    }
}
