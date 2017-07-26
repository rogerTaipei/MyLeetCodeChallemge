using CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEasy
{
    public class RomanToInteger : ICommonFunc
    {
        /// <param name="obj">input string, return int</param>
        public object ExecuteCommand(object obj)
        {
            string input = (string)obj;
            return (object)GetInteger(input);
        }

        public string GetFuncDescription()
        {
            return CommonString.RomanToIntegerDesc;
        }

        public string GetFuncTitle()
        {
            return CommonString.RomanToInteger;
        }

        public object GetUI()
        {
            return null;
        }

        public int GetInteger(string str)
        {
            int result = 0;
            char[] chArray = str.ToArray();
            int preVal = 0;

            for (int i = chArray.Length - 1;  i >=0 ; --i)
            {
                char nowChar = chArray[i];
                int nowVal = RomanTable[nowChar];

                if (nowVal >= preVal)
                    result += nowVal;
                else result -= nowVal;
                
                preVal = nowVal;
            }

            return result;
        }

        private Dictionary<char, int> _romanTable = null;
        public Dictionary<char, int> RomanTable
        {
            get {
                if (_romanTable == null) { 
                    _romanTable = new Dictionary<char, int>();
                    _romanTable.Add('I', 1);
                    _romanTable.Add('V', 5);
                    _romanTable.Add('X', 10);
                    _romanTable.Add('L', 50);
                    _romanTable.Add('C', 100);
                    _romanTable.Add('D', 500);
                    _romanTable.Add('M', 1000);
                }
                return _romanTable; }
            set { _romanTable = value; }
        }
    }
}
