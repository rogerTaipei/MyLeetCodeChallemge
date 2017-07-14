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

            Funcs.Add(integerReverse);
        }



        IntegerReverse integerReverse;
    }
}
