using System;
using System.Linq;

//Question 5

namespace CIS122_HW4
{
    public class Program
    {
        public static string Move(string str)
        {
            string result = "";

            foreach (char c in str)
            {
                if (Char.IsLetter(c))  // Only modify letters
                {
                    result += (char)(c + 1);  // Move to the next letter
                }
            }

            return result;
        }
    }
}
