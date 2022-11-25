using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Interface
{
    /// <summary>
    /// The generic interface for all the Database tables
    /// </summary>
    /// <typeparam name="T"> The current database type to be handle </typeparam>
    public interface IRepository<T>
    {
        IEnumerable<T> GetEntrys();
        T GetEntryById(int entryId);
        void InsertEntry(T entry);
        void UpdateEntry(T entry);
        void DeleteEntry(T entry);
        void Save();
    }


    /// <summary>
    /// Interface for the order as it needs more functions than the other classes
    /// </summary>
    public interface IOrderItem
    {
        IEnumerable<Database.OrderItem> GetItemsByOrderId(int orderId);
        IEnumerable<Database.OrderItem> GetItemsByItemId(int itemId);
    }

}
