using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Interface
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetEntry();
        T GetEntryById(int entryId);
        void InsertEntry(T entry);
        void UpdateEntry(T entry);
        void DeleteEntry(T entry);
        void Save();
    }
}
