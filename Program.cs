using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep
{
    //   Задание 5.
    //Дано целое число N, найти число, полученное при
    //прочтении числа N справа налево.Например, если было
    //введено число 345, то программа должна вывести число 543.
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                int checkInt;
                string inputString = Console.ReadLine(); //ввод строки в консоль
                bool isParseble = int.TryParse(inputString, out checkInt); //проверка на то, является ли введеная строка натуральным числом

                if (isParseble == true)
                {
                    //Создаем два массива.
                    //Второму массиву присваиваем значения первого (итерация в обрватном порядке).
                    char[] beforeReverse = inputString.ToCharArray(); 
                    char[] afterReverse = new char[beforeReverse.Length];
                    int count = 0;

                    for (int i = beforeReverse.Length - 1; i >= 0; i--)
                    {
                        afterReverse[count] = beforeReverse[i];
                        count++;
                    }
                    Console.WriteLine(afterReverse);
                }
                else  //если не является натуральным числом
                {
                    Console.WriteLine("Введенная строка не является натуральным числом");
                }

            } while (true);
        }
    }
}
