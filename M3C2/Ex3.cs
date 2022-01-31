using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep.M3C2
{
    class Ex3
    {
        public static void Exercise3()
        {
            List<InternalPassport> passports = new List<InternalPassport>();

            while (true)
            {
                Console.WriteLine("Выберите опцию: ");
                Console.WriteLine("Добавить паспорт: 1");
                Console.WriteLine("Вывести список все паспортов: 2");
                var choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        passports.Add(AddNewPerson());
                        break;
                    case "2":
                        ShowAllPersons(passports);
                        break;
                    default:
                        Console.WriteLine("Нету такой опции!");
                        break;
                }

            }

        }

        public static void ShowAllPersons(List<InternalPassport> allPersons)
        {
            foreach (InternalPassport person in allPersons)
            {
                Console.WriteLine($"Имя: {person.name}, Номер паспорта: {person.passportNumber}, Дата рождения: {person.dateOfBirth}, Дата выдачи: {person.dateOfIssue}, Пол: {person.gender}");
            }
        }

        public static InternalPassport AddNewPerson()
        {
            InternalPassport internalPassport = new InternalPassport();
            try
            {
                Console.Write("Введите имя: ");
                internalPassport.name = Console.ReadLine();

                Console.Write("Введите номер паспорта: ");
                internalPassport.passportNumber = int.Parse(Console.ReadLine());

                Console.Write("Введите дату рождения: ");
                internalPassport.dateOfBirth = DateTime.Parse(Console.ReadLine());

                Console.Write("Введите дату выдачи: ");
                internalPassport.dateOfIssue = DateTime.Parse(Console.ReadLine());

                Console.Write("Введите пол: ");
                internalPassport.gender = Console.ReadLine();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return internalPassport;
        }
    }


    class InternalPassport
    {
        public int passportNumber;
        public string name;
        public DateTime dateOfBirth;
        public DateTime dateOfIssue;
        public string gender;
    }
}
