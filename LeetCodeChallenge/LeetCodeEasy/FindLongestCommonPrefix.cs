using CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEasy
{
    public class FindLongestCommonPrefix : ICommonFunc
    {
        /// <param name="obj">input string, return int</param>
        public object ExecuteCommand(object obj)
        {
            string[] input = (string[])obj;
            return (object)FindLongestPrefix(input);
        }

        public string GetFuncDescription()
        {
            return CommonString.LongestCommonPrefixDesc;
        }

        public string GetFuncTitle()
        {
            return CommonString.LongestCommonPrefix;
        }

        public object GetUI()
        {
            return null;
        }

        public string FindLongestPrefix(string[] input)
        {
            StringBuilder sb = new StringBuilder();
            if (input.Length < 1) return "";

            string shortestStr = GetShortestStr(input);
            char[] shortChArray = shortestStr.ToArray();
            
            for (int i = 0; i < shortChArray.Length; ++i)
            {
                if (!SearchAllStr(shortChArray[i], i, input))
                    break;

                sb.Append(shortChArray[i]);
            }

            return sb.ToString();
        }

        private bool SearchAllStr(char myChar, int index, string[] input)
        {
            bool result = true;
            foreach (var str in input)
            {
                char[] arrayOfStr = str.ToArray();
                if (arrayOfStr[index] != myChar) { 
                    result = false;
                    break;
                }
            }
            return result;
        }

        private string GetShortestStr(string[] input)
        {
            string result = input[0];
            foreach (string val in input)
            { 
                if (val.Length < result.Length)
                    result = val;
            }

            return result;
        }
    }
}

