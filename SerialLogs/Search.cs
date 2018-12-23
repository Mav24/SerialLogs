using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialLogs
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Please enter a value to search for!", "Empty search box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Clears DataGrid
                    searchDataGridView.DataSource = null;
                }
                else
                {
                    this.serial_LogTableAdapter.Fill(this.appData.Serial_Log);
                    var query = from o in this.appData.Serial_Log
                                where o.Serial.Contains(txtSearch.Text.ToUpper()) || o.Customer.Contains(txtSearch.Text.ToUpper())
                                || o.JobNumber.Contains(txtSearch.Text.ToUpper()) || o.Antenna.Contains(txtSearch.Text.ToUpper())
                                select o;

                    //this.searchDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Fill data grid for me
                    searchDataGridView.DataSource = query.CopyToDataTable();

                }
            }
            catch (Exception)
            {
                searchDataGridView.DataSource = null;
                MessageBox.Show("Sorry that entry doesn't exist!", "Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                customersTableAdapter.Fill(appData.Customers);
                string customerName = searchDataGridView.SelectedCells[1].Value.ToString();
               
                int results = 0;
                DataRow[] returnedRows;

                returnedRows = appData.Tables["Customers"].Select("Customer='" + customerName + "'");
                

                results = returnedRows.Length;

                if (results > 0)
                {
                    DataRow dr1;
                    dr1 = returnedRows[0];
                    MessageBox.Show(dr1["Customer"].ToString() 
                        + "\nEmail: " + dr1["Email"].ToString() 
                        + "\nPhone Number: " 
                        + dr1["Phone"].ToString(), "Customer INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No results found");
                }
            }
            
        }
    }
}
