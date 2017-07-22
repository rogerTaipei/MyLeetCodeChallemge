using CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEasy
{
    public class PalindromeNumber : ICommonFunc
    {
        /// <param name="obj">input int, return bool (return true if number is Palindrome Number )</param>
        public object ExecuteCommand(object obj)
        {
            int input = (int)obj;
            return (object)IsPalindrome(input);
        }
        
        public string GetFuncDescription()
        {
            return CommonString.PalindromeNumberDesc;
        }

        public string GetFuncTitle()
        {
            return CommonString.PalindromeNumberTitle;
        }

        public object GetUI()
        {
            return null;
        }

        public bool IsPalindrome(int x)
        {
            if (x < 0 || (x != 0 && x % 10 == 0)) return false;
            int rev = 0;
            while (x > rev)
            {
                rev = rev * 10 + x % 10;
                x = x / 10;
            }
            return (x == rev || x == rev / 10);
        }

        /// <summary>
        /// this is my solution, but the other one is better
        /// </summary>
        public bool _IsPalindrome(int x)
        {
            if (x < 0) return false;
            bool result = true;

            int[] arr = new int[32];

            int index = 0;

            int input = x;
            while (true)
            {
                int theLastNum = input % 10;

                input -= theLastNum;
                input = input / 10;

                arr[index] = theLastNum;
                index++;

                if (input == 0)
                {
                    int i = 0, j = index -1;
                    while (i < j)
                    {
                        if (arr[i] != arr[j])
                        {
                            result = false;
                        }
                        i++;
                        j--;
                    }

                    break;
                }
            }


            return result;
        }
    }
}
