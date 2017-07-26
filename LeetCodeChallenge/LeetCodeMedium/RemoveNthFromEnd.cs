using CommonBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMedium
{
    public class RemoveNthFromEnd : ICommonFunc
    {
        /// <param name="obj">input index you want to remove for, return Struct ListNode</param>
        public object ExecuteCommand(object obj)
        {
            //i have 200 linked list nodes
            int NodeCount = 200;
            for (int i = 1; i <= NodeCount; ++i)
            {
                listnode.Add(new ListNode(i));
            }

            for (int i = 1; i <= NodeCount - 1; ++i)
            {
                listnode[i-1].next = listnode[i];
            }

            int indexWantToRemove = (int)obj;
            ListNode result = DoRemoveNthFromEnd(listnode[0], indexWantToRemove);


            return result;
        }

        List<ListNode> listnode = new List<ListNode>();

        public string GetFuncDescription()
        {
            return CommonString.RemoveNthFromEndDesc;
        }

        public string GetFuncTitle()
        {
            return CommonString.RemoveNthFromEnd;
        }

        public object GetUI()
        {
            return null;
        }

        public ListNode DoRemoveNthFromEnd(ListNode head, int removeIndex)
        {
            ListNode preNode = head;
            ListNode current = head;

            shouldRemove = removeIndex;
            
            
            return DetectRemoveNode(preNode, current);
        }

        int shouldRemove = 0;
        int theEndIndex = 0;
        private ListNode DetectRemoveNode(ListNode preNode, ListNode currentNode)
        {
            if (currentNode.next == null)
            {
                theEndIndex++;
                if (shouldRemove == 1)
                    return null;

                return currentNode;
            }
            else
            {
                ListNode temp = DetectRemoveNode(currentNode, currentNode.next);

                theEndIndex++;
                if (theEndIndex == shouldRemove)
                {
                    preNode= null;
                    return temp;
                }
                
                currentNode.next = temp;
            }

            return currentNode;
        }

        public class ListNode
        {
              public int val;
              public ListNode next;
              public ListNode(int x) { val = x; }
         }
    }
}
