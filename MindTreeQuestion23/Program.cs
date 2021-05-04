using System;
using System.Collections.Generic;

namespace MindTreeQuestion23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string s = Console.ReadLine();

            printConsecutiveCharacters(s);

            Console.ReadLine();
        }

        private static void printConsecutiveCharacters(string input)
        {
            if (input.Length >= 2)
            {
                Dictionary<string, int> consecutiveCount = new Dictionary<string, int>();

                for (int i = 0; i < input.Length - 1; i++)
                {
                    char current = input[i];
                    if (!IsAlphabet(current)) continue;

                    char next = FindNextAlphabet(input, i + 1);

                    if (next == ';') break;

                    if (AreConsecutive(current, next))
                    {
                        string consecutiveLetters = current + "" + next;
                        consecutiveLetters = consecutiveLetters.ToUpper();
                        if (consecutiveCount.ContainsKey(consecutiveLetters))
                            consecutiveCount[consecutiveLetters]++;
                        else
                            consecutiveCount.Add(consecutiveLetters, 1);
                        i++;
                    }
                }

                foreach (var keyValuePair in consecutiveCount)
                {
                    Console.WriteLine(keyValuePair.Key + " " + keyValuePair.Value);
                }
            }
        }

        private static char FindNextAlphabet(string input, int x)
        {
            for (int i = x; i < input.Length; i++)
            {
                if (IsAlphabet(input[i]))
                    return input[i];
            }
            return ';';
        }

        private static bool IsAlphabet(char x)
        {
            int a = (int)x;
            if ((a >= 65 && a <= 90) || (a >= 97 && a <= 122))
                return true;
            return false;
        }

        private static bool AreConsecutive(char x, char y)
        {
            int a = (int)x;
            int b = (int)y;
            if (!(a >= 97 && a <= 122))
            {
                x = (char)(a+32);
            }
            if (!(b >= 97 && b <= 122))
            {
                y = (char)( b + 32);
            }
             a = (int)x;
             b = (int)y;
            if (b - a == 1)
                return true;
            return false;
                
        }
    }

}
