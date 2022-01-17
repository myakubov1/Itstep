using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep
{
    //Задание 3.
    //Числовые значения символов нижнего регистра в коде ASCII
    //отличаются от значений символов верхнего регистра на постоянную
    //величину.Как её узнать?
    //Написать программу, которая считывает с клавиатуры и конвертирует
    //все символы нижнего регистра в символы верхнего регистра и наоборот.
    class Program
    {
        static void Main(string[] args)
        {
            int e; //введеный код символа
            char i;
            Console.WriteLine("Введите символ(ы) латинского алфавита: ");

            do
            {                
                do  //ввод символов, пока не будет перенос строки или возврата каретки
                {

                    e = Console.Read();
                    i = (char)e;
                } while (i == '\n' | i == '\r');

                //проверка на регистр
                if (e >= 65 && e <= 90) //верхний регистр
                {
                    e += 32;
                    i = (char)e;
                    Console.WriteLine(i);
                }
                else if (e >= 97 && e <= 122) //нижний регистр
                {
                    e -= 32;
                    i = (char)e;
                    Console.WriteLine(i);
                }
                else //символы, отличие от латинского алфавита
                {
                    i = (char)e;
                    Console.WriteLine($"Не латинский символ \"{i}\"");
                }
            } while (true);
        }
    }
}
