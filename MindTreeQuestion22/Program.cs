using System;
using System.Collections.Generic;

namespace MindTreeQuestion22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");

            string sentence = Console.ReadLine();

            List<string> words = ExtractWords(sentence);

            List<string> reversedWords = new List<string>();

            foreach (string word in words)
            {
                if (IsWord(word))
                    reversedWords.Add(Reverse(word));
                else
                    reversedWords.Add(word);
            }

            for (int i = reversedWords.Count - 1; i >= 0; i--)
            {
                Console.Write(reversedWords[i]);
            }

            Console.ReadLine();
        }

        private static string Reverse(string word)
        {
            string reversed = "";
            int i = 0;
            bool hasPunctuation = false;
            char punctuation = ' ';
            if (word[0] == ' ' || word[0] == '.')
            {
                i = 1;
                hasPunctuation = true;
                punctuation = word[0];
            }

            for (; i < word.Length; i++)
            {
                reversed = word[i] + reversed;
            }
            return hasPunctuation ? punctuation + reversed : reversed;
        }

        private static bool IsWord(string word)
        {
            int i = 0;
            if (word[0] == ' ' || word[0] == '.')
                i = 1;

            for (; i < word.Length; i++)
            {
                if (!IsAlphabet(word[i]))
                    return false;
            }
            return true;
        }

        private static bool IsAlphabet(char character)
        {
            int a = (int)character;
            if ((a >= 65 && a <= 90) || (a >= 97 && a <= 122))
                return true;
            return false;
        }

        private static List<string> ExtractWords(string sentence)
        {
            List<string> words = new List<string>();
            string word = "";
            for (int i = sentence.Length - 1; i >= 0; i--)
            {
                if (sentence[i] == ' ' || sentence[i] == '.' || i == 0)
                {
                    words.Add(sentence[i] + word);
                    word = "";
                }
                else
                    word = sentence[i] + word;
            }

            return words;
        }
    }


}
