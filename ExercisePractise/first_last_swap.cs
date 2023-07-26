// using System.Reflection.Metadata.Ecma335;
// using System;

// public class SwapLetters
// {

//     public static void Main(string[] args)
//     {

//         Console.WriteLine("Write The sentence: ");
//         string word = Console.ReadLine();

//         string newWord = addCharactersToFirstAndLastOfSentence(word);

//         Console.WriteLine("After Swapping The Word Is : " + newWord);

//     }
//     //get first character of a sentence, add it to the frot and back of a sentence

//     static string addCharactersToFirstAndLastOfSentence(string sentence)
//     {
//         char firstChar = sentence[0];
//         string remainingSentenceAfterRemovingIndex0 = sentence.Substring(1, sentence.Length - 2);

//         return firstChar + sentence + firstChar;
//     }

//     static string getFirstWordOfTheSentence(string sentence)
//     {
//         string firstWord = sentence.Split(' ')[0];
//         return firstWord;
//     }

//     //swapping first and last characters of a word

//     // static string swapFirstAndLast(string str)
//     // {
//     //     if (str.Length <= 1)
//     //     {
//     //         return str;
//     //     }

//     //     char firstString = str[0];
//     //     char lastString = str[str.Length - 1];

//     //     string middleString = str.Substring(1, str.Length - 2);

//     //     return lastString + middleString + firstString;

//     // }

// }