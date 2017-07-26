using CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEasy
{
    public class ValidParentheses : ICommonFunc
    {
        public object ExecuteCommand(object obj)
        {
            string input = (string)obj;
            return (object)IsValid(input);
        }

        public string GetFuncDescription()
        {
            return CommonString.ValidParenthesesDesc;
        }

        public string GetFuncTitle()
        {
            return CommonString.ValidParentheses;
        }

        public object GetUI()
        {
            return null;
        }

        Stack<char> LeftStack;
        public bool IsValid(string str)
        {
            bool result = true;
            LeftStack = new Stack<char>();
            char[] charArray = str.ToArray();

            for (int i = 0; i < charArray.Length; ++i)
            {
                char nowChar = charArray[i];
                if (nowChar == '{' || nowChar == '[' || nowChar == '(')
                {
                    LeftStack.Push(nowChar);
                }
                else if (nowChar == '}' || nowChar == ']' || nowChar == ')')
                {
                    result = IsLeftMatched(nowChar);

                    if (!result)
                        break;
                }
            }

            if (LeftStack.Count != 0)
                result = false;

            return result;
        }

        private bool IsLeftMatched(char charRight)
        {
            if (LeftStack.Count == 0) return false;

            char charLeft = LeftStack.Peek();

            bool isMatch =
                (charLeft == '(' && charRight == ')') ||
                (charLeft == '{' && charRight == '}') ||
                (charLeft == '[' && charRight == ']');

            if (isMatch) LeftStack.Pop();

            return isMatch;
        }
    }
}
