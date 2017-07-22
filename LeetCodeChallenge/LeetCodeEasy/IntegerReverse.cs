using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonBase;

namespace LeetCodeEasy
{
    public class IntegerReverse : ICommonFunc
    {
        /// <param name="obj">input int, return int (reversed integer)</param>
        public object ExecuteCommand(object obj)
        {
            int input = (int)obj;
            return (object)Reverse(input);
        }

        public string GetFuncDescription()
        {
            return CommonString.IntegerReverseDesc;
        }

        public string GetFuncTitle()
        {
            return CommonString.IntegerReverseTitle;
        }

        public object GetUI()
        {
            return null;
        }

        public int Reverse(int x)
        {
            int input = x;
            int result = 0;

            try
            {
                while (true)
                {
                    int theLastNum = input % 10;
                    result += theLastNum;

                    input -= theLastNum;
                    input = input / 10;

                    if (input == 0) break;

                    checked
                    {
                        result *= 10;
                    }
                }
            }
            catch (OverflowException oex)
            {
                return 0;
            }
            return result;
        }
    }
}
