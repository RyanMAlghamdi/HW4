using System;
using System.Linq;

//Question 3

namespace CIS122_HW4
{
    public class Q3
    {
        public static bool IsInOrder(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] > str[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
