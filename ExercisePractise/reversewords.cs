using System;

namespace ReverseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "The quick brown fox jumps over the lazy dog";
            string reversedSentence = ReverseWords(sentence);
            Console.WriteLine(reversedSentence);
        }

        static string ReverseWords(string sentence)
        {
            string[] words = sentence.Split(' ');
            string reversedWords = "";

            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedWords += words[i] + " ";
            }

            return reversedWords;
        }
    }
}