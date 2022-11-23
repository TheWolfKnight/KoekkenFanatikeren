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
        /// <summary>
        /// Sorts all items by the given minimum and maximum price and ordered by ascending bool
        /// </summary>
        /// <param name="min"> Minimum int to search for </param>
        /// <param name="max"> Maximum int to search for </param>
        /// <param name="Ascending"> Orderby bool </param>
        public List<Models.Item> SortByPrice(int min, int max, bool Ascending)
        {
           Repository.FilterRepository filterRepository = new FilterRepository();
            return filterRepository.SortByPrice(min, max, Ascending);
        }

        /// <summary>
        /// Sorts all items by quantitiy in order by given ascending bool
        /// </summary>
        /// <param name="Ascending"> Orderby bool </param>
        public List<Models.Item> SortByQuantity(bool Ascending)
        {
            Repository.FilterRepository filterRepository = new FilterRepository();
            return filterRepository.SortByQuantity(Ascending);
        }

        /// <summary>
        /// retrieves all items in the database
        /// </summary>
        public List<Models.Item> GetAllItems()
        {
            Repository.FilterRepository filterRepository = new FilterRepository();
            return filterRepository.GetAllItems();
        }

        /// <summary>
        /// Sorts all items by the categoryId, which determines material. 
        /// </summary>
        /// <param name="CategoryId"> Int CategoryId (foreign key) </param>
        public List<Models.Item> SortByCategory(int CategoryId)
        {
            Repository.FilterRepository filterRepository = new FilterRepository();
            return filterRepository.SortByCategory(CategoryId);
        }


    }
}
