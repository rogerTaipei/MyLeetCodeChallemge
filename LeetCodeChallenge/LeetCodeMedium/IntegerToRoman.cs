using CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMedium
{
    public class IntegerToRoman : ICommonFunc
    {
        /// <param name="obj">input Integer, return Roman number</param>
        public object ExecuteCommand(object obj)
        {
            int input = (int)obj;
            return DoIntegerToRoman(input);
        }

        public string GetFuncDescription()
        {
            return CommonString.IntegerToRomanDesc;
        }

        public string GetFuncTitle()
        {
            return CommonString.IntegerToRoman;
        }

        public object GetUI()
        {
            return null;
        }

        public string DoIntegerToRoman(int input)
        {
            if (input > 3999 || input < 1) return string.Empty;
            string[] M = { "", "M", "MM", "MMM" };
            string[] C = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] X = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] I = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            return M[input / 1000] + C[(input % 1000) / 100] + X[(input % 100) / 10] + I[input % 10];
        }
    }
}
