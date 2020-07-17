using CommonBase;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace LeetCodeMedium
{
    public class DeleteColumnsMakeSorted : ICommonFunc
    {
        public object ExecuteCommand(object obj)
        {
            string[] input = (string[])obj;
            return DoIntegerToRoman(input);
        }

        public string GetFuncDescription()
        {
            return CommonString.DeleteColumnsMakeSortedDesc;
        }

        public string GetFuncTitle()
        {
            return CommonString.DeleteColumnsMakeSorted;
        }

        public object GetUI()
        {
            return null;
        }

        public int DoIntegerToRoman(string[] A)
        {
            if (A.Length == 0) return 0;
            int d = 0;
            for (int i = 0; i < A[0].Length; i++)
            {
                for (int j = 1; j < A.Length; j++)
                {
                    var a = A[j][i];
                    var b = A[j-1][i];
                    if (a < b)
                    {
                        d++;
                        break;
                    }
                }
            }
            return d;
        }
    }
}