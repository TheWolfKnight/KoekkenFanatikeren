using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KøkkenFanatikeren.Src.Models;

namespace KøkkenFanatikeren.Src.Services
{
    public class FilterService
    {
        public List<TestItem> SortItemsByPrice(List<TestItem> listToSort)
        {
            List <TestItem> SortedList = listToSort.OrderBy(o => o.UnitPrice).ToList();
            return SortedList;
        }
    }
}
