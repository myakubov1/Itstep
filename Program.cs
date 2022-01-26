using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Itstep
{
//    Дан двумерный массив размерностью 5×5, заполненный случайными числами из диапазона от –100 до 100.
//Определить сумму элементов массива, расположенных
//между минимальным и максимальным элементами.
    class Program
    {

        static void Main(string[] args)
        {
            int[,] A = new int[5, 5];
            int summValue = 0;
            int maxValue = A[0, 0];
            int minValue = A[0, 0];

            int maxValueRow = 0, maxValuCol = 0, minValueRow = 0, minValueCol = 0;

            bool marker = false;
            Random random = new Random();
            Console.WriteLine("Массив B");
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int q = 0; q < A.GetLength(1); q++)
                {
                    A[i, q] = random.Next(-100, 100);
                    if (maxValue < A[i, q])
                    {
                        maxValue = A[i, q];
                        maxValueRow = i;
                        maxValuCol = q;
                    }
                    if (minValue > A[i, q])
                    {
                        minValue = A[i, q];
                        minValueRow = i;
                        minValueCol = q;
                    }
                }
            }

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int q = 0; q < A.GetLength(1); q++)
                {
                    if ((i == maxValueRow && q == maxValuCol) || (i == minValueRow && q == minValueCol))
                    {
                        if (marker)
                        {
                            marker = false;
                            continue;
                        }
                        else
                        {
                            marker = true;
                            continue;
                        }
                    }
                    if (marker)
                    {
                        summValue += A[i, q];
                    }
                }
            }

            Console.WriteLine($"Максимальный элемент: {maxValue}");
            Console.WriteLine($"Минимальный элемент: {minValue}");

            Console.WriteLine($"Cуммa между минимальным и максимальным: {summValue}");
        }


    }

}


