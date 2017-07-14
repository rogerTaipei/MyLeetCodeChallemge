
using System.Collections.Generic;
using System.Linq;

namespace CommonBase
{
    public class EntryBase
    {
        protected List<ICommonFunc> Funcs = null;

        public EntryBase()
        {
             Funcs = new List<ICommonFunc>();
        }

        public List<ICommonFunc> GetAllFunc()
        {
            return Funcs;
        }

        public List<string> GetAllFuncTitle()
        {
            return Funcs.Select(_ => _.GetFuncTitle()).ToList();
        }

        public List<string> GetAllFuncDesc()
        {
            return Funcs.Select(_ => _.GetFuncDescription()).ToList();
        }
    }
}