using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SerialLogs
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'appData.Antennas' table. You can move, or remove it, as needed.
            antennasTableAdapter.Fill(appData.Antennas);
            // TODO: This line of code loads data into the 'appData.Customers' table. You can move, or remove it, as needed.
            customersTableAdapter.Fill(appData.Customers);

            
            // Sets Customers and Antenna comboboxes to empty
            editcomboBoxCustomer.SelectedValue = 0;
            editcomboAntenna.SelectedValue = 0;

            // Editing
            AllowEdit(false);
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            // Tool tips
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(btnHelp, "Help!");
            
        }
        

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {

                try
                {
                    
                    serial_LogBindingSource.EndEdit();
                    serial_LogTableAdapter.Update(appData.Serial_Log);
                    EditDataGridView.Refresh();

                    MessageBox.Show("Serial Log information for\n\n" + "Serial Number: " + lblSerialNumber.Text + "\nCustomer: " + editcomboBoxCustomer.Text +
                        "\nAntenna: " + editcomboAntenna.Text + "\n" + "Job Number: " + maskedJobNumber.Text +
                        "\n\nhas been updated!", "Information updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AllowEdit(false);
                    EnableControls();                    
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("A concurrency error occurred. " + "Serial Log information for\n\n" + "Serial Number: " + lblSerialNumber.Text + "\nCustomer: " + editcomboBoxCustomer.Text +
                        "\nAntenna: " + editcomboAntenna.Text + "\n" + "Job Number: " + maskedJobNumber.Text +
                        "\n\nwas not updated!", "Information NOT Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    EditDataGridView.DataSource = null;
                    lblSerialNumber.Text = "";
                    maskedJobNumber.Clear();
                    edittxtNotes.Clear();
                    editcomboAntenna.SelectedValue = 0;
                    editcomboBoxCustomer.SelectedValue = 0;
                    EnableControls();
                    btnEdit.Enabled = false;
                    AllowEdit(false);
                }
                catch (DataException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Server error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
                }
            }

        }

        private bool IsValidData()
        {
            return
                // Validate Customer, antenna, Job and # of Serials to issue boxes
                Validators.IsPresentMask(maskedJobNumber) &&
                Validators.IsPresentCombo(editcomboBoxCustomer) &&
                Validators.IsPresentCombo(editcomboAntenna);

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure you want to delete this record?", "Confirm delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                try
                {
                    AllowEdit(false);
                    EnableControls();

                    int rows = EditDataGridView.RowCount;
                    for (int i = rows - 1; i >= 0; i--)
                    {
                        if (EditDataGridView.Rows[i].Selected)
                        {
                            serial_LogBindingSource.RemoveAt(EditDataGridView.Rows[i].Index);
                            serial_LogBindingSource.EndEdit();
                            serial_LogTableAdapter.Update(appData);

                        }
                    }
                    checkDelete.Checked = false;
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("A concurrency error occurred. " + "The row/rows were deleted.", "Concurrency Exeption", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (DataException ex)
                {
                    MessageBox.Show(ex.Message, ex.GetType().ToString());
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Server error # " + ex.Number + ": " + ex.Message, ex.GetType().ToString());
                }
            }
            else
            {
                checkDelete.Checked = false;
                AllowEdit(false);
                EnableControls();
            }
            //EditDataGridView.DataSource = serial_LogBindingSource;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DisableControls(); // Disable controls
            txtSearch.Clear();
            AllowEdit(true);
            
        }
            

        // Allow for edit!
        private void AllowEdit(bool value)
        {
            //btnDelete.Enabled = value;
            btnCancel.Enabled = value;
            btnSave.Enabled = value;
            editcomboAntenna.Enabled = value;
            editcomboBoxCustomer.Enabled = value;
            maskedJobNumber.Enabled = value;
            edittxtNotes.Enabled = value;
            editdateTimePicker1.Enabled = value;
            
        }

        private void DisableControls()
        {
            groupBox1.Enabled = false;
            btnEdit.Enabled = false;
            EditDataGridView.Enabled = false;
            btnSearch.Enabled = false;
            txtSearch.Enabled = false;
        }

        private void EnableControls()
        {
            groupBox1.Enabled = true;
            btnEdit.Enabled = true;
            EditDataGridView.Enabled = true;
            btnSearch.Enabled = true;
            txtSearch.Enabled = true;
            txtSearch.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            serial_LogBindingSource.CancelEdit();
            EnableControls();
            AllowEdit(false);
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            MessageBox.Show(HelpClass.EditPageHelpButton(), "Help!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            #region Marked for Delete!
            //MessageBox.Show("Search by Serial or Customer in the top menu\n" +
            //    "If you would like to edit the log you searched\n\n" +
            //    "-With the row selected, push the Edit button\n" +
            //    "-When finished editing, push the Save button\n\n" +
            //    "If you would like to delete a serial log\n" +
            //    "***WARRNING DELETING A SERIAL LOG CAN'T BE UNDONE***\n\n" +
            //    "-Select the row you would like to delte and push Edit then Delete buttons\n\n" +
            //    "If you need any more help please Contact Murray Duke @ murrayduke@rogers.com", "HELP!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            #endregion
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (rdoCustomer.Checked)
            {
                SearchingCustomers();
            }
            if (rdoSerial.Checked)
            {
                SearchingSerial();
            }
        }

        // Method for searching serial numbers
        private void SearchingSerial()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Sorry you need to enter a value to search for", "Empty Search!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnEdit.Enabled = true;
                    this.serial_LogTableAdapter.SerialSearch(this.appData.Serial_Log, txtSearch.Text);
                    if (serial_LogBindingSource.Count == 0)
                    {
                        MessageBox.Show("Serial matching " + txtSearch.Text +
                            " doesn't exist in the data base, Please try again", "No Matching Serail exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnEdit.Enabled = false;
                        btnCancel.Enabled = false;
                        txtSearch.Focus();
                    }
                        
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Serial Id must be an number.", "Entry Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server error # " + ex.Number + ";" + ex.Message, ex.GetType().ToString());
            }
        }
        // Method for searching Customers

        private void SearchingCustomers()
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    MessageBox.Show("Sorry you need to enter a value to search for", "Empty Search!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    btnEdit.Enabled = true;
                    this.serial_LogTableAdapter.SearchCustomer(this.appData.Serial_Log, txtSearch.Text);
                    if (serial_LogBindingSource.Count == 0)
                    {
                        MessageBox.Show("Customer matching " + txtSearch.Text +
                            " doesn't exist in the data base, please try again", "No Matching Customer exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnEdit.Enabled = false;
                        btnCancel.Enabled = false;
                        txtSearch.Focus();
                    }
                        
                }
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Customer must be an name.", "Entry Error");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Server error # " + ex.Number + ";" + ex.Message, ex.GetType().ToString());
            }
        }

        // Brings focus to Search text box if radio button changes
        private void rdoFocusTxtBxSearch_CheckedChanged(object sender, EventArgs e)
        {
            txtSearch.Focus();
            txtSearch.Clear();
        }

        // Sets the job number to upper case only when editing
        private void maskedJobNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLower(e.KeyChar))
            {
                maskedJobNumber.SelectedText = Char.ToUpper(e.KeyChar).ToString();
            }

        }

        // trying to set up a display for customer info for one row ****** NEEDS WORK
        private void EditDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                customersTableAdapter.Fill(appData.Customers);
                string customerName = EditDataGridView.SelectedCells[1].Value.ToString();

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

        private void checkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDelete.Checked)
            {
                DisableControls();
                btnDelete.Enabled = true;
            }
            else
            {
                EnableControls();
                btnDelete.Enabled = false;
            }
        }
    } 
}
