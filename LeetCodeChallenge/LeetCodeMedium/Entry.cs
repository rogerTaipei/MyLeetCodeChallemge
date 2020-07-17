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
            deleteColumnsMakeSorted = new DeleteColumnsMakeSorted();

            FuncTable.Add((int)FunctionIndex.RemoveNthFromEnd, removeNthFromEnd);
            FuncTable.Add((int)FunctionIndex.IntegerToRoman, integerToRoman);
            FuncTable.Add((int)FunctionIndex.DeleteColumnsMakeSorted, deleteColumnsMakeSorted);
        }

        public object ExecuteCommand(object input, FunctionIndex index)
        {
            ICommonFunc func = FuncTable[(int)index];
            return func.ExecuteCommand(input);
        }

        RemoveNthFromEnd removeNthFromEnd;
        IntegerToRoman integerToRoman;
        DeleteColumnsMakeSorted deleteColumnsMakeSorted;
    }

    public enum FunctionIndex
    {
        RemoveNthFromEnd = 0,
        IntegerToRoman = 1,
        DeleteColumnsMakeSorted = 2
    }
}
