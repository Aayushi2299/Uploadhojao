using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion24
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string target = Console.ReadLine();
            Console.WriteLine(PrintFrequency(target));
            Console.ReadLine();
        }

        private static string PrintFrequency(string target)
        {
            string frequency = "";
            char x;
            for (int i = 0; i < target.Length; i++)
            {
                if ((int)target[i] >= 97 && (int)target[i] <= 122)
                {
                     x = target[i];
                }
                else
                {
                    x = (char)((int)target[i] - 32);
                }

                if (frequency != "")
                {
                    if (frequency[frequency.Length - 2] == x)
                    {
                        int count = Convert.ToInt32(frequency[frequency.Length - 1]) - 48;
                        count++;
                        frequency = frequency.Substring(0, frequency.Length - 1) + count;
                    }
                    else
                        frequency += x + "1";
                }
                else
                    frequency += x + "1";
            }

            return frequency.Length < target.Length ? frequency : target;
        }
    }

}
