using CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeEasy
{
    public class Entry : CommonBase.EntryBase
    {
        public Entry()
            :base()
        {
            integerReverse = new IntegerReverse();
            palindromeNumber = new PalindromeNumber();

            FuncTable.Add((int)FunctionIndex.IntegerReverse, integerReverse);
            FuncTable.Add((int)FunctionIndex.PalindromeNumber, palindromeNumber);
        }

        public object ExecuteCommand(object input, FunctionIndex index)
        {
            ICommonFunc func = FuncTable[(int)index];
            return func.ExecuteCommand(input);
        }
        
        IntegerReverse integerReverse;
        PalindromeNumber palindromeNumber;
    }

    public enum FunctionIndex
    {
        IntegerReverse = 0,
        PalindromeNumber = 1
    }
}
