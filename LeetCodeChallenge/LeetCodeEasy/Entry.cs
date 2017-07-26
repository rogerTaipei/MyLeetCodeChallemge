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
            romanToInteger = new RomanToInteger();

            FuncTable.Add((int)FunctionIndex.IntegerReverse, integerReverse);
            FuncTable.Add((int)FunctionIndex.PalindromeNumber, palindromeNumber);
            FuncTable.Add((int)FunctionIndex.RomanToInteger, romanToInteger); 
        }

        public object ExecuteCommand(object input, FunctionIndex index)
        {
            ICommonFunc func = FuncTable[(int)index];
            return func.ExecuteCommand(input);
        }
        
        IntegerReverse integerReverse;
        PalindromeNumber palindromeNumber;
        RomanToInteger romanToInteger;
    }

    public enum FunctionIndex
    {
        IntegerReverse = 0,
        PalindromeNumber = 1,
        RomanToInteger = 2
    }
}
