using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep
{
    //Пользователь вводит строку с клавиатуры.Необходимо зашифровать данную строку используя шифр Цезаря.
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            string fullAlphabet = alphabet + alphabet.ToLower();

            Console.Write("Сообщение для шифровки (расшифровки): ");
            string message = Console.ReadLine();
            Console.Write("Ключ для шифровки (расшифровки): ");
            int key = int.Parse(Console.ReadLine());
            int alphabetLength = fullAlphabet.Length;

            /*===============================================================*/

            string outMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                int index = fullAlphabet.IndexOf(c);
                if (index < 0)
                {
                    outMessage += c.ToString();
                }
                else
                {
                    int codeIndex = (alphabetLength + index + key) % alphabetLength;
                    outMessage += fullAlphabet[codeIndex];
                }
            }
            Console.WriteLine($"Зашифрованное сообщение: {outMessage}");

            /*===============================================================*/

            outMessage = "";
            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                int index = fullAlphabet.IndexOf(c);
                if (index < 0)
                {
                    outMessage += c.ToString();
                }
                else
                {
                    int codeIndex = (alphabetLength + index - key) % alphabetLength;
                    outMessage += fullAlphabet[codeIndex];
                }
            }
            Console.WriteLine($"Расшифрованное сообщение: {outMessage}");

        }

    }

}


