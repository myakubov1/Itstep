using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep.M3C2
{
    class Ex1
    {
        public static double BinToDec(string binNumber)
        {
            int power = 0;
            double result = 0;
            try
            {
                for (var i = binNumber.Length - 1; i >= 0; i--)
                {
                    if (binNumber[i] == '1')
                    {
                       checked( result) = result + Convert.ToUInt32(Math.Pow(2, power));
                    }
                    power++;
                }
                return  result;
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
        }

        public static string DecToBin(int decNumber)
        {
            var binNumber = string.Empty;
            while (decNumber > 0)
            {
                binNumber = (decNumber % 2) + binNumber;
                decNumber = decNumber / 2;
            }

            return binNumber;
        }

        public static void Exercise1()
        {




            Console.WriteLine("Из десятичной в двоичную : 1");
            Console.WriteLine("Из двоичной в десятичную: 2");
            string choise = Console.ReadLine();

            Console.Write("Введите число: ");
            string Num = Console.ReadLine();
            switch (choise)
            {
                case "1":
                    Console.WriteLine("В двоичной: {0}", DecToBin(int.Parse(Num)));
                    break;
                case "2":
                    Console.WriteLine("В десятичной: {0}", BinToDec(Num));
                    break;
                default:
                    Console.WriteLine("Нету такого перевода");
                    break;
            }


        }
    }
}
