using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep
{
//2. Заполнить массив случайными числами.
//Найти сумму элементов массива.
//Может ли при сложении потребоваться checked?

    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int arraySumm = 0;

            int arrayLength;
            Console.Write("Количество элементов в массиве: ");

            bool isLength = int.TryParse(Console.ReadLine(), out arrayLength); //Проверяем введено ли число в качестве количества элементов массива

            int[] arrayElements = new int[arrayLength]; //Выделяем место под будущий массив

            for (int i = 0; i < arrayLength; i++)  //Заполнение массива
            {
                arrayElements[i] = random.Next(1, 2147483647);
                Console.WriteLine($"Элемент {i} равен {arrayElements[i]}");

            }

            try //ловим ошибку на переполнении или нам везет
            {
                foreach (int i in arrayElements)
                {
                    arraySumm = checked(arraySumm + i);
                    Console.WriteLine(arraySumm);
                }
               
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
