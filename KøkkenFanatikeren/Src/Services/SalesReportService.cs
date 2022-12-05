/*
    Skrevet af: Philip Knudsen
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KøkkenFanatikeren.Src.Services
{
    public class SalesReportService
    {
        private readonly Repository.CustomerRepository CustomerRepo;


        /// <summary>
        /// Creates an instance of the SalesReportService class
        /// </summary>
        /// <param name="ctx"></param>
        public SalesReportService(Database.KitchenFanaticDataContext ctx)
        {
            CustomerRepo = new Repository.CustomerRepository(ctx);
        }


        /// <summary>
        /// Generates a sales report from the given orders
        /// </summary>
        /// <param name="orders"> The orders for the sales report </param>
        /// <returns> An List of strings to be writen to a file </returns>
        public List<string> GenerateReport( IEnumerable<Models.Order> orders )
        {
            // creates variables to store the date of the report in
            DateTime minDate = DateTime.MaxValue, maxDate = DateTime.MinValue;
            double totalPrice = 0.0d;
            List<string> result = new List<string>();

            // loops over all the orders in the input list
            foreach (Models.Order order in orders)
            {
                // adds to the total price of the order set
                totalPrice += order.TotalPrice;

                // finds the upper and lower bounds of the order set
                if (order.Creation <= minDate)
                    minDate = order.Creation;
                if (order.Status == Models.OrderStatus.Done && order.Completion > maxDate)
                    maxDate = order.Completion;

                // compiles the order data down to a string for the report
                string holder = ComplieOrderDate(order);
                result.Add(holder);
            }

            // complies the headers and puts them in place in the list
            string[] headersAndFooters = GenerateFileHeadersAndFooter(minDate, maxDate, totalPrice);
            result.Insert(0, headersAndFooters[0]);
            result.Insert(1, headersAndFooters[1]);
            result.Add(headersAndFooters[2]);

            // returns the results
            return result;
        }


        /// <summary>
        /// Creates the data string for each order, for the report to display
        /// </summary>
        /// <param name="order"> The order from which the data will be used </param>
        /// <returns> The string representation for the report </returns>
        private string ComplieOrderDate( Models.Order order )
        {
            // Gets the customer of the order from the database
            Models.Customer customer = new Models.Customer(CustomerRepo.GetEntryById(order.CustomerId));

            // Parse the data into a string
            string result = $"{customer.Id}\t\t{customer.FullName}\t\t{order.Creation:d}\t\t{order.TotalPrice}";

            // Returns the result
            return result;
        }


        /// <summary>
        /// Generates the headers and footer for the report file
        /// </summary>
        /// <param name="start"> The earliest date in the order enumerator </param>
        /// <param name="end"> The lates date in the order enumerator </param>
        /// <param name="totalPrice"> The total price of all the orders </param>
        /// <returns></returns>
        private string[] GenerateFileHeadersAndFooter(DateTime start, DateTime end, double totalPrice)
        {
            // Writes the file header, data header, and file footer into the respective variables
            string fileHeader = $"SALGSTATISTIK {DateTime.Now.Year}\tfra dato {start:d} til dato {end:d}";
            string dataHeader = "KUNDENUMMER\t\tNAVN\t\tDATO\t\tPRIS";
            string fileFooter = $"i alt {totalPrice}";

            // Returns the header and footer as the function result
            return new string[] { fileHeader, dataHeader, fileFooter };
        }

    }
}
