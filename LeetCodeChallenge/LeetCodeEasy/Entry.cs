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
            validParentheses = new ValidParentheses();
            findLongestCommonPrefix = new FindLongestCommonPrefix();
            mergeTwoSortedArray = new MergeTwoSortedArray();

            FuncTable.Add((int)FunctionIndex.IntegerReverse, integerReverse);
            FuncTable.Add((int)FunctionIndex.PalindromeNumber, palindromeNumber);
            FuncTable.Add((int)FunctionIndex.RomanToInteger, romanToInteger);
            FuncTable.Add((int)FunctionIndex.ValidParentheses, validParentheses);
            FuncTable.Add((int)FunctionIndex.FindLongestCommonPrefix, findLongestCommonPrefix);
            FuncTable.Add((int)FunctionIndex.MergeTwoSortedArray, mergeTwoSortedArray);
        }

        public object ExecuteCommand(object input, FunctionIndex index)
        {
            ICommonFunc func = FuncTable[(int)index];
            return func.ExecuteCommand(input);
        }
        
        IntegerReverse integerReverse;
        PalindromeNumber palindromeNumber;
        RomanToInteger romanToInteger;
        ValidParentheses validParentheses;
        FindLongestCommonPrefix findLongestCommonPrefix;
        MergeTwoSortedArray mergeTwoSortedArray;
    }

    public enum FunctionIndex
    {
        IntegerReverse = 0,
        PalindromeNumber = 1,
        RomanToInteger = 2,
        ValidParentheses = 3,
        FindLongestCommonPrefix = 4,
        MergeTwoSortedArray = 5
    }
}
