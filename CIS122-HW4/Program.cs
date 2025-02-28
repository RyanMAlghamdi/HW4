using System;
using System.Linq;

//Question 1

namespace CIS122_HW4
{
    public class WordCounter
    {
        public static void Main(string[] args)
        {
            // Examples to apply on
            Console.WriteLine(countWords("Just an example here move along"));
            Console.WriteLine(countWords("This is a test"));
            Console.WriteLine(countWords("What an easy task, right"));
            Console.WriteLine(countWords("This is for CIS122"));
        }

        // Method that takes a string and returns the word count
        static int countWords(string sentence)
        {
            // Split the sentence by spaces and count the number of words
            string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }
    }
}