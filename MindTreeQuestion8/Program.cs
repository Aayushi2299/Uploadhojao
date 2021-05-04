using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Program Obj = new Program();
            Obj.Reverse(num);

        }
        public void Reverse(int num)
        {
            int n = num;
            int sum = 0;
            while(n!=0)
            {
                int r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();

        }

    }
}
