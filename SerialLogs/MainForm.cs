// Program by Murray Duke @ murrayduke@rogers.com
// You need permision to edit this code by its owner Murray Duke
// july 5th 2018 last worked on this

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SerialLogs
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {


            try
            {
                // TODO: This line of code loads data into the 'appData.Antennas' table. You can move, or remove it, as needed.
                this.antennasTableAdapter.Fill(this.appData.Antennas);
                // TODO: This line of code loads data into the 'appData.Customers' table. You can move, or remove it, as needed.
                this.customersTableAdapter.Fill(this.appData.Customers);
                // TODO: This line of code loads data into the 'appData.Serial_Log' table. You can move, or remove it, as needed.
                this.serial_LogTableAdapter.LimitFill(this.appData.Serial_Log);


                #region Tool Tips
                ToolTip toolTip = new ToolTip();

                toolTip.SetToolTip(btnHelp, "Help!");
                toolTip.SetToolTip(btnNew, "Issue new Serial/Serials!");
                toolTip.SetToolTip(btnCustomers, "Search Customers!");
                toolTip.SetToolTip(btnSearch, "Search Serial Logs");
                toolTip.SetToolTip(btnEdit, "Edit Serial Logs!");
                toolTip.SetToolTip(btnAbout, "About!");
                #endregion
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            try
            {

                this.serial_LogTableAdapter.LimitFill(this.appData.Serial_Log);
                this.customersTableAdapter.Fill(this.appData.Customers);
                this.antennasTableAdapter.Fill(this.appData.Antennas);
                serial_LogTableAdapter.GetLastSerialNumber();
                
                int countrows = appData.Serial_Log.Rows.Count;
                
                if (countrows > 0)
                {
                    // Get last serial number in database
                    string lastSerialNumber = serial_LogTableAdapter.GetLastSerialNumber();
                    // Remove dash and convert back to int
                    int serialStart = Convert.ToInt32(lastSerialNumber.Remove(2, 1));

                    // Incrament last serial number by 1
                    int nextSerial = serialStart + 1;


                    NewSerialNumber newSerial = new NewSerialNumber();
                    newSerial.maskedSerial.Text = nextSerial.ToString();
                    newSerial.ShowDialog();
                    
                    this.serial_LogTableAdapter.LimitFill(this.appData.Serial_Log);
                    this.customersTableAdapter.Fill(this.appData.Customers);
                    this.antennasTableAdapter.Fill(this.appData.Antennas);
                }
                else
                {

                    NewSerialNumber newSerial = new NewSerialNumber();
                    newSerial.ShowDialog();
                    this.serial_LogTableAdapter.LimitFill(this.appData.Serial_Log);
                    this.customersTableAdapter.Fill(this.appData.Customers);
                    this.antennasTableAdapter.Fill(this.appData.Antennas);
                }

                #region old get last serail number method Marked for delete
                ///////////////////OLD METHOD///////////////////
                //int totalRows = appData.Serial_Log.Rows.Count;
                //int totalCols = appData.Serial_Log.Columns.Count;

                //string last_order_ID = appData.Serial_Log.Rows[totalRows - 1][totalCols - 6].ToString();
                //int serialStart = int.Parse(last_order_ID.Remove(2, 1)); // This Removes the dash from the serial number then converts it to an int. Ready to be incremented
                //int nextSerial = serialStart + totalRows;

                // Working Auto increment for next serial number
                //dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Ascending);
                //int lastRow = dataGridView1.Rows.Count - 1;
                //string last_order_ID = dataGridView1.Rows[lastRow].Cells[0].Value.ToString();
                //int serialStart = Convert.ToInt32(last_order_ID.Remove(2, 1));
                //int nextSerial = serialStart + 1;


                //NewSerialNumber newSerial = new NewSerialNumber();
                //newSerial.maskedSerial.Text = nextSerial.ToString();

                //newSerial.ShowDialog();
                //dataGridView1.Sort(dataGridView1.Columns[0], ListSortDirection.Descending);
                //this.serial_LogTableAdapter.LimitFill(this.appData.Serial_Log);
                //this.customersTableAdapter.Fill(this.appData.Customers);
                //this.antennasTableAdapter.Fill(this.appData.Antennas);
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.ShowDialog();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            Customers customers = new Customers();
            customers.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show(HelpClass.MainFormHelpButton(), "Need Help?", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit editlog = new Edit();
            editlog.ShowDialog();

            this.serial_LogTableAdapter.LimitFill(this.appData.Serial_Log); // Updates the MainForm DataGridView when you come back from editing.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // This is for the admin login
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminLogin adminLogin = new adminLogin();
            adminLogin.ShowDialog();
        }

        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            frmExportToPDF frmExportToPDF = new frmExportToPDF();
            frmExportToPDF.ShowDialog();
        }
    }
}
