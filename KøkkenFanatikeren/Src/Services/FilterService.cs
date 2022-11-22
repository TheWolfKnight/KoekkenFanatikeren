using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KøkkenFanatikeren.Src.Models;
using KøkkenFanatikeren.Src.Repository;
using KøkkenFanatikeren.Src.Database;

namespace KøkkenFanatikeren.Src.Services
{
    public class FilterService
    {
        public List<Models.Item> SortByPrice(int min, int max)
        {
           Repository.Repo filterRepository = new Repo();
            return filterRepository.SortByPrice(min, max);
        }

        public List<Models.Item> SortByQuantity(bool Ascending)
        {
            Repository.Repo filterRepository = new Repo();
            return filterRepository.SortByQuantity(Ascending);
        }

        public List<Models.Item> GetAllItems()
        {
            Repository.Repo filterRepository = new Repo();
            return filterRepository.GetAllItems();
        }

    }
}
