using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KøkkenFanatikeren.Frontend
{
    public partial class Form_Print : Form
    {

        private DateTime FromDate;
        private DateTime ToDate;

        private bool CanPrint;

        private readonly Src.Repository.OrderRepository OrderRepo;
        private Src.Services.FilterService FS;

        public Form_Print(Src.Database.KitchenFanaticDataContext ctx)
        {
            InitializeComponent();

            OrderRepo = new Src.Repository.OrderRepository(ctx);

            FromDate = DateTime.MaxValue;
            ToDate = new DateTime();
            CanPrint = true;
        }

        /// <summary>
        /// Gets the Date from the tb_From textbox
        /// </summary>
        /// <param name="sender"> The caller of the method </param>
        /// <param name="e"> The arguments of the call </param>
        private void tb_From_Change(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = StringToDateTime(tb_From.Text);
                FromDate = fromDate;
            } catch (Exception)
            {
                CanPrint = false;
                return;
            } finally
            {
                if (CanPrint)
                    UpdateDGV();
            }
        }

        /// <summary>
        /// Gets the Date from the tb_To textbox
        /// </summary>
        /// <param name="sender"> The caller of the method </param>
        /// <param name="e"> The arguments of the call </param>
        private void tb_To_Change(object sender, EventArgs e)
        {
            try
            {
                DateTime toDate = StringToDateTime(tb_To.Text);
                ToDate = toDate;
            }
            catch (Exception)
            {
                CanPrint = false;
                return;
            } finally
            {
                if (CanPrint)
                    UpdateDGV();
            }
        }


        /// <summary>
        /// Converts a string in its datetime representation
        /// DD-MM-YYYY
        /// </summary>
        /// <param name="input"> The string to be converted </param>
        /// <returns> A DateTime representation of the string </returns>
        private DateTime StringToDateTime(string input)
        {
            // Splits the string based on the "-"
            string[] parts = tb_From.Text.Split('-');

            // Converts all parst to ints
            int day = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int year = int.Parse(parts[2]);

            // Creates DateTime from the pices and returns it
            DateTime date = new DateTime(year, month, day);
            return date;
        }


        /// <summary>
        /// Updates the DataGridView based on the dates
        /// </summary>
        private void UpdateDGV()
        {
            bool onlyCompleted = cb_Completed.Enabled;

            List<Src.Models.Order> orders = FS.SortOrderByDate(FromDate, ToDate, onlyCompleted);

        }

    }
}
