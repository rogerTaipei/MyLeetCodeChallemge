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
            FuncTable.Add((int)FunctionIndex.RemoveNthFromEnd, removeNthFromEnd);
        }

        public object ExecuteCommand(object input, FunctionIndex index)
        {
            ICommonFunc func = FuncTable[(int)index];
            return func.ExecuteCommand(input);
        }

        RemoveNthFromEnd removeNthFromEnd;
    }

    public enum FunctionIndex
    {
        RemoveNthFromEnd = 0
    }
}
