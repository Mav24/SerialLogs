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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.appData.Customers);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                bool customerExist = appData.Customers.Any(CustomerLogs => CustomerLogs.Customer.Equals(txtCustomerName.Text.ToUpper()));  // Checks to see if Customer exist
                
                if (customerExist)
                {
                    MessageBox.Show("Sorry Customer " + txtCustomerName.Text + 
                        " Exist already!", "Already Exist", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    customersBindingSource.MoveLast();
                    // Create object for new entry
                    AppData.CustomersRow newEntry = appData.Customers.NewCustomersRow();

                    newEntry.Customer = txtCustomerName.Text.ToUpper();
                    newEntry.Email = txtCustomerEmail.Text;
                    newEntry.Phone = txtCustomerNumber.Text;

                    // Add new row to data base
                    appData.Customers.AddCustomersRow(newEntry);

                    // Update Database
                    customersTableAdapter.Update(newEntry);

                    // Pop up message
                    MessageBox.Show(newEntry.Customer + " \n\nhas been added as a new Customer!", 
                        "Added new Customer", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.serial_LogTableAdapter.Fill(this.appData.Serial_Log); // See if i need this!
                    this.customersTableAdapter.Fill(this.appData.Customers);

                    this.Close();
                }
            }
            
        }
        
        // validate Customer name and email
        private bool IsValidData()
        {
            return
                Validators.IsPresent(txtCustomerName) &&
                Validators.IsValidEmail(txtCustomerEmail);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            appData.Customers.RejectChanges();
            this.customersTableAdapter.Fill(this.appData.Customers);
            Close();
        }
    }
}
