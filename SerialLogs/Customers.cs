using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialLogs
{
    public partial class Customers : Form
    {
        

        public Customers()
        {
            InitializeComponent();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnExit, "Exit!");
            
        }

        public void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Please enter a value to search for!", "Empty search box", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // Clears DataGrid
                    CustomerDataGridSearch.DataSource = null;
                }
                else
                {
                    string customerName = txtSearch.Text.ToUpper();
                    SearchCustomers(customerName);
                }
            }
            catch (Exception)
            {
                CustomerDataGridSearch.DataSource = null;

                MessageBox.Show("Sorry that entry doesn't exist!", "Doesn't Exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        // Method to search customers database
        public void SearchCustomers(string customerName)
        {
            this.customersTableAdapter.Fill(this.appData.Customers);
            var query = from o in this.appData.Customers
                        where o.Customer.Contains(customerName)
                        select o;

            //this.CustomerDataGridSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Fill data grid for me
            CustomerDataGridSearch.DataSource = query.CopyToDataTable();
        }
    }
}
