using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep
{
    class Student
    {
        void Exercise2()
        {
            int[,] A = new int[5, 5];
            Random random = new Random();

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int q = 0; q < A.GetLength(1); q++)
                {
                    A[i, q] = random.Next(-100, 100);
                }
            }


            int minValue = A[0, 0];
            int maxValue = A[0, 0];

            int minValueRow = 0;
            int minValueCol = 0;
            int maxValueRow = 0;
            int maxValueCol = 0;

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int q = 0; q < A.GetLength(1); q++)
                {
                    if (A[i, q] > maxValue)
                    {
                        maxValue = A[i, q];
                        maxValueRow = i;
                        maxValueCol = q;
                    }

                    if (A[i, q] < minValue)
                    {
                        minValue = A[i, q];
                        minValueRow = i;
                        minValueCol = q;
                    }
                }
            }
        }
    }
}
