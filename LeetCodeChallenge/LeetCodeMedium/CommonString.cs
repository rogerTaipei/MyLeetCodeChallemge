using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMedium
{
    public static class CommonString
    {
        public static string RemoveNthFromEndDesc
        {
            get { return @"Given a linked list, remove the nth node from the end of list and return its head.

For example,

   Given linked list: 1->2->3->4->5, and n = 2.

   After removing the second node from the end, the linked list becomes 1->2->3->5.
Note:
Given n will always be valid.
Try to do this in one pass."; }
        }

        public static string IntegerToRomanDesc
        {
            get { return @"Given an integer, convert it to a roman numeral.

Input is guaranteed to be within the range from 1 to 3999."; }
        }

        public static string DeleteColumnsMakeSortedDesc
        {
            get { return @"We are given an array A of N lowercase letter strings, all of the same length.

Now, we may choose any set of deletion indices, and for each string, we delete all the characters in those indices.

For example, if we have an array A = ['abcdef','uvwxyz'] and deletion indices {0, 2, 3}, then the final array after deletions is ['bef', 'vyz'], and the remaining columns of A are ['b','v'], ['e','y'], and ['f','z'].  (Formally, the c-th column is [A[0][c], A[1][c], ..., A[A.length-1][c]]).

Suppose we chose a set of deletion indices D such that after deletions, each remaining column in A is in non - decreasing sorted order.

Return the minimum possible value of D.length."; }
        }

        public static string IntegerToRoman = "12. Integer to Roman";
        public static string RemoveNthFromEnd = "19. Remove Nth Node From End of List";
        public static string DeleteColumnsMakeSorted = "944. Delete Columns to Make Sorted";
    }
}
