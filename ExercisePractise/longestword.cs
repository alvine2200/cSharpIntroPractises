using System;

namespace Abso;
class AbsoluteValues
{
    public static void Main(string[] args)
    {
        string line = "Write a C# Sharp Program to display the following pattern using the alphabet.";

        Console.WriteLine("The Result is : " + checkLongestWord(line));
    }

    static string checkLongestWord(string line)
    {

        string[] words = line.Split(new[] { ' ' }, StringSplitOptions.None);

        string word = "";
        int ctr = 0;

        foreach (String s in words)
        {
            if (s.Length > ctr)
            {
                word = s;
                ctr = s.Length;
            }
        }

        return word;
    }
}
