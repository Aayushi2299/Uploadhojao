using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name of student 1");
            string Student1 = Console.ReadLine();

            Console.WriteLine("Enter name of student 2");
            string Student2 = Console.ReadLine();

            var ExchangedNames = ExchangeNames(Student1, Student2);

            foreach (var name in ExchangedNames)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }

        private static List<string> ExchangeNames(string student1, string student2)
        {
            if (student1 is null || student2 is null)
                return new List<string>() { student1, student2 };

            string student1LastName = FindLastName(student1);
            string student2LastName = FindLastName(student2);

            string exchangedstudent1 = ExchangeLastName(student1, student2LastName);
            string exchangedstudent2 = ExchangeLastName(student2, student1LastName);

            return new List<string>() { exchangedstudent1, exchangedstudent2 };
        }

        private static string ExchangeLastName(string student, string otherStudentLastName)
        {
            string exchangedstudent = "";

            for (int i = student.Length - 1; i >= 0; i--)
            {
                if (student[i] == ' ' || student[i] == '-')
                {
                    exchangedstudent = student.Substring(0, i + 1);
                }
            }
            return exchangedstudent + otherStudentLastName;
        }

        private static string FindLastName(string name)
        {
            if (name is null) return null;

            string LastName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                if ((name[i] == ' ' || name[i] == '-') && (i != name.Length - 1))
                {
                    LastName = name.Substring(i + 1);
                }
            }

            return LastName;
        }
    }

}
