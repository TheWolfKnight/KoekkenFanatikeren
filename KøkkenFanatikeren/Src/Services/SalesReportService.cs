using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Services
{
    public class SalesReportService
    {
        /// <summary>
        /// 
        /// </summary>
        public SalesReportService()
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="orders"></param>
        /// <returns></returns>
        public string[] GenerateReport( List<Models.Order> orders )
        {

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="totalPrice"></param>
        /// <returns></returns>
        public string[] GenerateFileHeadersAndFooter(DateTime start, DateTime end, double totalPrice)
        {
            // Writes the header and footer into the respective variables
            string header = $"SALGSTATISTIK {end.Year}\tfra dato {start:d} til dato {end:d}";
            string footer = $"i alt {totalPrice}";

            // Returns the header and footer as the function result
            return new string[] { header, footer };
        }

    }
}
