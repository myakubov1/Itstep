using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Itstep
{
    class Program
    {
        //        Создайте приложение, проверяющее текст на недопустимые слова.Если недопустимое слово найдено, оно
        //должно быть заменено на набор символов*. По итогам
        //работы приложения необходимо показать статистику
        //действий. 
        static void Main(string[] args)
        {

            string[] badWords = new string[] { "be", "is", "die" };
            string baseText = "test, and bee be not testing.is. is  is,  But yes to test";
            string regPattern;
            string newValue;
            int counter = 0;


            for (int i = 0; i < badWords.Length; i++)
            {
                Regex regPatter = new Regex(@"\b" + badWords[i] + @"\b");
                MatchCollection matches = regPatter.Matches(baseText);

                if (baseText.IndexOf(badWords[i]) > 0)
                {

                    regPattern = @"\b" + badWords[i] + @"\b";
                    newValue = string.Concat(Enumerable.Repeat("*", badWords[i].Length));
                    baseText = Regex.Replace(baseText, regPattern, newValue, RegexOptions.IgnoreCase);
                    counter += matches.Count;
                }


            }
            Console.WriteLine(baseText);
            Console.WriteLine($"Число замен: {counter}");
        }

    }

}


