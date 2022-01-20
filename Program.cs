using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep
{
//1. Прочитать с клавиатуры массив строк.
//Перечислить их длины.Вывести на экран
//первую и последнюю буквы самой длинной строки.

    class Program
    {
        static void Main(string[] args)
        {
            int arrayLength;


            Console.Write("Количество строк в массиве: ");

            bool isLength = int.TryParse(Console.ReadLine(), out arrayLength); //Проверяем введено ли число в качестве количества элементов массива
            string[] arrayElements = new string[arrayLength]; //Выделяем место под будущий массив

            for (int i = 0; i < arrayLength; i++)  //Цикл с заполнением массива элементами 
            {
                Console.Write("Введите строку {0}: ", i + 1);
                arrayElements[i] = Console.ReadLine();
            }

            for (int i = 0; i < arrayLength; i++) //Цикл для вывода элементов массива в консоль (для удобства)
            {
                Console.WriteLine($"Элемент №{i}: {arrayElements[i]} | Длина эелмента: {arrayElements[i].Length}");
            }


            int maxLength = arrayElements[0].Length;
            string maxElement = arrayElements[0];
            foreach (string s in arrayElements)
            {
                if (s.Length > maxLength)
                {
                    maxLength = s.Length;
                    maxElement = s;
                }
            }
            Console.WriteLine($"Размер самой длинной строки: {maxLength} | Строка: {maxElement}");
            char[] charArrayMaxElement = maxElement.ToCharArray();
            Console.WriteLine($"Первый символ: {charArrayMaxElement[0]} | Последний символ: {charArrayMaxElement[charArrayMaxElement.Length - 1]}");
        }
    }
}
