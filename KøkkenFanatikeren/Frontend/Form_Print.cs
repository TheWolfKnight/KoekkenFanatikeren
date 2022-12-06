/*
    Skrevet af Philip Knudsen
*/
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

        private readonly Src.Services.SalesReportService SalesService;
        private readonly Src.Services.FilterService FilterService;
        private readonly Src.Services.FileService FileService;

        private List<Src.Models.Order> Orders;

        private string Path;

        public Form_Print(Src.Database.KitchenFanaticDataContext ctx)
        {
            InitializeComponent();

            Path = $@"{System.IO.Path.GetTempPath()}\{DateTime.Now.Year}_{DateTime.Now.Month}-SalgsRaport.txt";

            FilterService = new Src.Services.FilterService();
            SalesService = new Src.Services.SalesReportService(ctx);
            FileService = new Src.Services.FileService(Path);

            FromDate = DateTime.MinValue;
            ToDate = DateTime.MaxValue;
            CanPrint = true;

            UpdateDGV();

        }

        /// <summary>
        /// Gets the Date from the tb_From textbox
        /// </summary>
        /// <param name="sender"> The caller of the method </param>
        /// <param name="e"> The arguments of the call </param>
        private void tb_From_Change(object sender, EventArgs e)
        {
            Console.WriteLine(tb_From.Text);
            try
            {
                if (string.IsNullOrEmpty(tb_From.Text))
                {
                    FromDate = DateTime.MinValue;
                }
                else
                {
                    DateTime fromDate = StringToDateTime(tb_From.Text);
                    FromDate = fromDate;
                }
                CanPrint = true;
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
                if (string.IsNullOrEmpty(tb_To.Text))
                {
                    ToDate = DateTime.MaxValue;
                }
                else
                {
                    DateTime toDate = StringToDateTime(tb_To.Text);
                    ToDate = toDate;
                }
                CanPrint = true;
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
            string[] parts = input.Split('-');

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
            bool onlyCompleted = !cb_Completed.Checked;


            List<Src.Models.Order> orders = FilterService.SortOrderByDate(FromDate, ToDate, onlyCompleted);
            Orders = orders;
            dgv_OrderView.DataSource = orders;
        }

        /// <summary>
        /// Gets called when the check box changes states
        /// </summary>
        /// <param name="sender"> The caller of the method </param>
        /// <param name="e"> The parameters of the call </param>
        private void cb_Completed_Changed(object sender, EventArgs e)
        {
            UpdateDGV();
        }


        /// <summary>
        /// Gets called when the Print butten gets clicked
        /// </summary>
        /// <param name="sender"> The caller of the method </param>
        /// <param name="e"> The paramerters of the event </param>
        private void btn_Print_Click(object sender, EventArgs e)
        {
            // Writes the content of the file
            List<string> reportContents = SalesService.GenerateReport(Orders);
            // Writes the contents into a file
            FileService.AppendFile(reportContents);

            // Prompts the user for closure
            if (MessageBox.Show($"Du har skrevet en raport til {Path}, vil du lave en mere?", "Opgave Udført", MessageBoxButtons.YesNo) == DialogResult.Yes)
                this.Close();
        }


    }
}
