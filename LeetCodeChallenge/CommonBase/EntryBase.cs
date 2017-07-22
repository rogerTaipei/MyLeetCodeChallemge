
using System.Collections.Generic;
using System.Linq;

namespace CommonBase
{
    public class EntryBase
    {
        protected Dictionary<int, ICommonFunc> FuncTable = null;

        public EntryBase()
        {
            FuncTable = new Dictionary<int, ICommonFunc>();
        }

        public Dictionary<int, ICommonFunc> GetAllFunTable()
        {
            return FuncTable;
        }

        public List<string> GetAllFuncTitle()
        {
            return FuncTable.Select(_=>_.Value.GetFuncTitle()).ToList();
        }

        public List<string> GetAllFuncDesc()
        {
            return FuncTable.Select(_ => _.Value.GetFuncDescription()).ToList();
        }
    }
}