using System;
using System.Linq;

//Question 2

namespace CIS122_HW4
{
    public class Q2
    {
        public static string FlipEndChars(string str)
        {
            if (str.Length < 2)
            {
                return "Incompatible.";
            }

            if (str[0] == str[str.Length - 1])
            {
                return "Two's a pair.";
            }

            char[] charArray = str.ToCharArray();
            char temp = charArray[0];
            charArray[0] = charArray[charArray.Length - 1];
            charArray[charArray.Length - 1] = temp;

            return new string(charArray);
        }
    }
}