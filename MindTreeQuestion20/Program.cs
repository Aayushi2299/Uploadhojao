using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion20
{
    class String
    {
        private string value;
       

        public String(string _value)
        {
            value = _value;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter string 1");
            String s1 = new String(Console.ReadLine());

            Console.WriteLine("Enter string 2");
            String anotherString = new String(Console.ReadLine());

            Console.WriteLine(s1.compareTo(anotherString));

            Console.ReadLine();
        }

        public int compareTo(String anotherString)
        {
            int len1 = value.Length;//value is an instance variable
            int len2 = anotherString.value.Length;//anotherString must be an object of this class
            int lim = Math.Min(len1, len2);
            char[] v1 = value.ToCharArray();//ToCharArray method is called to convert string into character array
            char[] v2 = anotherString.value.ToCharArray();

            int k = 0;
            while (k < lim)
            {
                char c1 = v1[k];
                char c2 = v2[k];
                if (c1 != c2)
                {
                    return c1 - c2;
                }
                k++;
            }
            return len1 - len2;
        }
    }

}
