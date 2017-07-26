using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEasy
{
    public static class CommonString
    {
        public static string IntegerReverseDesc
        {
            get { return @"Reverse digits of an integer.

Example1: x = 123, return 321
Example2: x = -123, return -321

click to show spoilers.

Have you thought about this?
Here are some good questions to ask before coding. Bonus points for you if you have already thought through this!

If the integer's last digit is 0, what should the output be? ie, cases such as 10, 100.

Did you notice that the reversed integer might overflow? Assume the input is a 32-bit integer, then the reverse of 1000000003 overflows. How should you handle such cases?

For the purpose of this problem, assume that your function returns 0 when the reversed integer overflows.

Note:
The input is assumed to be a 32-bit signed integer. Your function should return 0 when the reversed integer overflows."; }
        }
        public static string PalindromeNumberDesc
        {
            get { return @"Determine whether an integer is a palindrome. Do this without extra space.

click to show spoilers.

Some hints:
Could negative integers be palindromes? (ie, -1)

If you are thinking of converting the integer to string, note the restriction of using extra space.

You could also try reversing an integer. However, if you have solved the problem 'Reverse Integer', you know that the reversed integer might overflow. How would you handle such case?

There is a more generic way of solving this problem."; }
        }
        public static string RomanToIntegerDesc
        {
            get { return @"Given a roman numeral, convert it to an integer. Input is guaranteed to be within the range from 1 to 3999."; }
        }
        public static string LongestCommonPrefixDesc
        {
            get { return @"Write a function to find the longest common prefix string amongst an array of strings."; }
        }
        public static string ValidParenthesesDesc
        {
            get { return @"Given a string containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.
                    The brackets must close in the correct order, '()' and '()[]{ }' are all valid but '(]' and '([)]' are not."; }
        }

        public static string IntegerReverseTitle = "7 Reverse Integer";
        public static string PalindromeNumberTitle = "Palindrome Number";
        public static string RomanToInteger = "13. Roman to Integer";
        public static string LongestCommonPrefix = "14. Longest Common Prefix";
        public static string ValidParentheses = "20. Valid Parentheses";
    }
}
