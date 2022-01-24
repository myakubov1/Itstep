using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep
{
//4. Создать массив. Пройти по нему циклом.
//Для каждого числа создать строку из этих цифр этой длины.


    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Random random1 = new Random();

            int[] arrayElements = new int[random1.Next(1,10)]; 

            for (int i = 0; i < arrayElements.Length; i++)  //Заполнение массива
            {
                arrayElements[i] = random.Next(1, 9);

            }
            int k = 0;
            for (int i = 0; i < arrayElements.Length; i++)  
            {
                do
                {
                    Console.Write(arrayElements[i]);
                    k++;
                    
                }
                while (k<arrayElements[i]);
                k = 0;
                Console.WriteLine("");
            }

           
            

        }
    }
}
