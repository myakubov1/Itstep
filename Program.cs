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
            Console.Write("Введите последовательность: ");
            int[] binarySequence = Console.ReadLine().ToCharArray().Select(i => int.Parse(i.ToString())).ToArray();  //Кастим введенную последовательность в массив символов

            int endPos = 0;
            int startPos = 0;
            int maxLength = 0;
            int counter = 0;
            for (int i = 0; i < binarySequence.GetLength(0); i++)
            {
                if (binarySequence[i] == 1)
                {
                    counter++;
                }
                else
                {
                    if (counter > maxLength)
                    {
                        maxLength = counter;
                    }
                    counter = 0;
                }
            }
        }
    }
}
