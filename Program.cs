using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Itstep
{
//  Задание 6
//Пользователь с клавиатуры вводит некоторый текст.
//Приложение должно изменять регистр первой буквы
//каждого предложения на букву в верхнем регистре.
//ДОМАШНЕЕ ЗАДАНИЕ
//2
//Например, если пользователь ввёл: «today is a good
//day for walking.i will try to walk near the sea».
//Результат работы приложения: «Today is a good day
//for walking.I will try to walk near the sea».
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Текст: ");
            string myText = Console.ReadLine();
            myText = "." + myText;

            string[] arrayOfSentences = myText.Split(new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < arrayOfSentences.Length; i++)
            {
                arrayOfSentences[i] = arrayOfSentences[i].Trim();
                char[] ch = arrayOfSentences[i].ToCharArray();
                ch[0] = char.ToUpper(ch[0]);
                arrayOfSentences[i] = string.Join("", ch);
            }
            string outputText = string.Join(". ", arrayOfSentences);
            Console.WriteLine(outputText);

        }
    }

}


