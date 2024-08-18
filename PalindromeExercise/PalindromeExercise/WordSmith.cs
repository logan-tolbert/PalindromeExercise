using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string input)
        {
            int start = 0;
            int end = input.Length - 1;
            while (start < end)
            {
                if (input[start] != input[end])
                {
                    return false;
                }
                start++;
                end--;
            }
            return true;
        }
    }
}
