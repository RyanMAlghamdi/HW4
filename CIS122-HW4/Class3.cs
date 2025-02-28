using System;
using System.Linq;

//Question 4

namespace CIS122_HW4
{
    public class Q4
    {
        public static string FirstNVowels(string str, int n)
        {
            string vowels = "aeiou";
            string result = "";

            foreach (char c in str)
            {
                if (vowels.Contains(Char.ToLower(c)))  // Check if the character is a vowel
                {
                    result += c;
                }
            }

            if (result.Length < n)
            {
                return "invalid";
            }

            return result.Substring(0, n);
        }
    }
}
