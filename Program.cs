using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep
{

    class Program
    {
        static void Main(string[] args)
        {
            double[] A = new double[5];
            double[,] B = new double[3, 4];
            double minRange = -10.0;
            double maxRange = 10.0;
            Random random = new Random();

            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Введите число: ");
                A[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int q = 0; q < B.GetLength(1); q++)
                {
                    B[i, q] = random.NextDouble() * (maxRange - minRange) + minRange;

                }
            }

            /*==========================================================================================================================================  */

            Console.WriteLine($"Одномерный массив: {string.Join(" ", A)}");

            for (int i = 0; i < B.GetLength(0); i++, Console.WriteLine())
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", B[i, j]);
                }
            }

            /*==========================================================================================================================================  */

      

            List<double> genValues = new List<double>();
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int q = 0; q < B.GetLength(0); q++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        if (A[i] == Math.Round(B[q, j]))
                        {
                            genValues.Add(A[i]);
                        }
                    }
                }

            }

            /*==========================================================================================================================================  */

            if (genValues.Count > 0)
            {
                double minValue = genValues[0];
                double maxValue = genValues[0];
                for (int z = 0; z < genValues.Count; z++)
                {
                    if (genValues[z] > maxValue)
                    {
                        maxValue = genValues[z];
                    }

                    if (genValues[z] < minValue)
                    {
                        minValue = genValues[z];
                    }
                }
                Console.WriteLine($"Максимальное общее значение (с округлением): {maxValue}");
                Console.WriteLine($"Минимальное общее значение (с округлением): {minValue}");
            }
            else
            {
                Console.WriteLine($"Общих элементов не найдено");
            }

            /*==========================================================================================================================================  */

            double summValue = 0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                summValue += A[i];
            }

            for (int q = 0; q < B.GetLength(0); q++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    summValue += B[q, j];
                }
            }
            Console.WriteLine($"Сумма значений всех массивов: {summValue}");

            /*==========================================================================================================================================  */

            double multiValue = 1;
            for (int i = 0; i < A.GetLength(0); i++)
            {
                multiValue *= A[i];
            }
            for (int q = 0; q < B.GetLength(0); q++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    multiValue *= B[q, j];
                }
            }
            Console.WriteLine($"Произведение значений всех массивов: {multiValue}");

            /*==========================================================================================================================================  */

            double summEvenA=0;
            for (int i = 0; i < A.GetLength(0); i++)
            {
               if (A[i]%2 ==0)
                {
                    summEvenA += A[i];
                }
            }
            Console.WriteLine($"Сумма четных элементов массива A: {summEvenA}");

            /*==========================================================================================================================================  */

            double summOddColB=0;
            for (int q = 0; q < B.GetLength(0); q++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (j%2 !=0)
                    {
                        summOddColB += B[q, j];
                    }
                }
            }
            Console.WriteLine($"Сумма нечетных столбцов массива B: {summOddColB}");
        }
    }
}