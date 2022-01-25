using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itstep
{

    class Program
    {
        static void Main(string[] args)
        {
            student student;   
            student.name = "Макс";
            student.age = 18;

            student student2 = new student("Коля", 20);  
            student = student2;
            student2.name = "Андрей";
            student2.age = 19;


            /* ============================================= */

            Stud stud = new Stud();
            stud.name = "Макс";
            stud.age = 18;

            Stud stud2 = new Stud();
            stud = stud2;
            stud2.name = "Андрей";
            stud2.age = 19;

        }
    }


    struct student
    {
        public string name;   
        public int age;     
        
        public student(string Name, int Age)  
        {
            name = Name;
            age = Age;   
        }
    }

    class Stud
    {
        public string name;
        public byte age;

       
    }
}

