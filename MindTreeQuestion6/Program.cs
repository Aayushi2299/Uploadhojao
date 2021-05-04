using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion6
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Program Obj = new Program();
            Obj.Print(s);
            
        }
        public void Print(string s )
        {
            Console.WriteLine("Hello, " + s + "!");
            Console.ReadLine();
        }
    }
}
