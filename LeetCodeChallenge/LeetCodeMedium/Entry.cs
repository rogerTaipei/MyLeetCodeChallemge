using CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMedium
{
    public class Entry : CommonBase.EntryBase
    {
        public Entry()
            : base()
        {
            removeNthFromEnd = new RemoveNthFromEnd();
            integerToRoman = new IntegerToRoman();

            FuncTable.Add((int)FunctionIndex.RemoveNthFromEnd, removeNthFromEnd);
            FuncTable.Add((int)FunctionIndex.IntegerToRoman, integerToRoman);
        }

        public object ExecuteCommand(object input, FunctionIndex index)
        {
            ICommonFunc func = FuncTable[(int)index];
            return func.ExecuteCommand(input);
        }

        RemoveNthFromEnd removeNthFromEnd;
        IntegerToRoman integerToRoman;
    }

    public enum FunctionIndex
    {
        RemoveNthFromEnd = 0,
        IntegerToRoman = 1
    }
}
