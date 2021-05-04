using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindtreeQuestion2
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            Program Obj = new Program();
            Obj.PrintTable(Num);
        }
       public void PrintTable(int Num)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine(Num + " * " + i + " = " + Num * i);
            }
            Console.ReadLine();
        }

    }
}
