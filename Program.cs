using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Itstep
{
//    Задание 5
//Пользователь с клавиатуры вводит в строку арифметическое выражение.Приложение должно посчитать
//его результат. Необходимо поддерживать только две
//операции: + и –.
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Выражение: ");
            string myExpression = Console.ReadLine();

            Console.WriteLine($"ОПН: {GetExpression(myExpression)}");

        }

        static private string GetExpression(string expression)
        {
            string outString = "";
            Stack<char> myStack = new Stack<char>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (char.IsDigit(expression[i]))
                {
                    outString += expression[i];
                }
                else
                {
                    if (myStack.Count > 0)
                    {
                        outString += myStack.Pop();
                    }
                    myStack.Push(expression[i]);
                }
                Console.WriteLine(outString);
            }

            while (myStack.Count > 0)
            {
                outString += myStack.Pop();
            }
            return outString;
        }

    }

}


