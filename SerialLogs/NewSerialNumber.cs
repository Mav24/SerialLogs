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
    public partial class NewSerialNumber : Form
    {
        public NewSerialNumber()
        {
            InitializeComponent();
        }
        // Creating list to host serials that are created and skipped if they exist.
        List<int> serialList = new List<int>();
        List<int> serialsSkippedList = new List<int>();
        #region This is for the array list, Marked for delete
        //int totalIndex = 0;
        //int[] serialsSkippedList; 
        #endregion


        private void NewSerialNumber_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = Convert.ToDateTime(DateTime.Today.ToShortDateString());
            // TODO: This line of code loads data into the 'appData.Antennas' table. You can move, or remove it, as needed.
            this.antennasTableAdapter.Fill(this.appData.Antennas);
            // TODO: This line of code loads data into the 'appData.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.appData.Customers);
            // TODO: This line of code loads data into the 'appData.Serial_Log' table. You can move, or remove it, as needed.
            this.serial_LogTableAdapter.LimitFill(this.appData.Serial_Log);

            progressBar1.Visible = false; // sets progressbar to invisible until need

            maskedSerial.ReadOnly = true; // this makes the serial box read only

            // Sets Customers and Antenna comboboxes to empty
            comboAntenna.SelectedValue = 0;
            comboCustomer.SelectedValue = 0;

            // tool tips
            ToolTip toolTips = new ToolTip();
            // Set button for tool tips
            toolTips.SetToolTip(btnChangeYear, "ONLY CLICK THIS \nIF YOU ARE SURE YOU \nWANT TO START A NEW YEAR");
            toolTips.SetToolTip(btnAddAntenna, "Click here to add \nnew antenna to drop down list");
            toolTips.SetToolTip(btnAddNewCust, "Click here to add \nnew customer to drop down list");
            toolTips.SetToolTip(btnHelp, "HELP!");

        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            // loads a fresh copy of the dataset
            serial_LogTableAdapter.Fill(appData.Serial_Log);
            
            try
            {
                if (IsValidData())
                {
                    
                    int serialStart = int.Parse(maskedSerial.Text.Remove(2, 1));
                    int serialEnd = int.Parse(txtCount.Text);
                    
                    // Sets progressbar to visible..
                    progressBar1.Visible = true; 
                    progressBar1.Maximum = serialEnd;
                    
                    for (int i = 0; i < serialEnd; i++)
                    {
                        progressBar1.Value++;
                        progressBar1.Update();

                        int answer = serialStart++;
                        
                        bool serialExist = appData.Serial_Log.Any(SerialLogs => SerialLogs.Serial.Contains(answer.ToString("00-0000")));  // Checks to see if serial exist

                        if (serialExist)
                        {
                            #region Array list of serials exist, Marked for delete
                            // Add total to array (and update index)
                            //serialsSkippedList[totalIndex] = answer;
                            //totalIndex++;
                            #endregion

                            // Create list of serials that exist
                            serialsSkippedList.Add(answer);
                            
                            // Sets count back by 1 each time a serial number exist
                            i--; 

                            progressBar1.Value--;
                            progressBar1.Update();
                            continue;
                        }
                        else
                        {
                            // Create a new Entry object
                            AppData.Serial_LogRow newEntry = appData.Serial_Log.NewSerial_LogRow();

                            // Set field values for this new entry
                            newEntry.Serial = answer.ToString("00-0000"); // Adds dash back in to serial number to be entered in to database
                            newEntry.Customer = comboCustomer.Text.ToUpper();
                            newEntry.Antenna = comboAntenna.Text.ToUpper();
                            newEntry.JobNumber = maskedJobNumber.Text.ToUpper();
                            newEntry.Notes = txtNotes.Text;
                            newEntry.Date = dateTimePicker1.Value;

                            // Add the row to the database
                            appData.Serial_Log.AddSerial_LogRow(newEntry);

                            // Update the serialsTableAdapter object
                            //serial_LogTableAdapter.Update(newEntry);
                            serial_LogTableAdapter.Update(appData.Serial_Log);
                            // Close the form

                            // Create list of serial that are issued
                            serialList.Add(answer);
                            this.Close();
                        }
                    }
                    #region Array list of serial exist method, Marked for delete

                    //if (totalIndex > 0)
                    //{

                    //    Array.Sort(serialsSkippedList);
                    //    string messageExist = "Sorry these serial numbers existed in the database already, so they were skipped \n\n";
                    //    foreach (int serialExist in serialsSkippedList)
                    //    {

                    //        messageExist += serialExist.ToString("00-0000") + ", ";
                    //    }
                    //    MessageBox.Show(messageExist, "Serial numbers already exist", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //}
                    #endregion *Marked for Delete


                    // Message box list of serials skipped because they already exist
                    if (serialsSkippedList.Count != 0)
                    {
                        serialsSkippedList.Sort();
                        string messageExist = "Sorry these serial numbers existed in the database already, so they were skipped \n\n";
                        foreach (int serialExist in serialsSkippedList)
                        {
                            messageExist += serialExist.ToString("00-0000") + ", ";
                        }
                        // Display message box for skipped serials
                        MessageBox.Show(messageExist, "Serial numbers already exist", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                    }

                    // Message box list of serial numbers that are issued
                    serialList.Sort();
                    string message = "New serial numbers have been successfully entered in the data base, here is a list of issued serial numbers\n\n" +
                        "Customer: " + comboCustomer.Text.ToUpper() +
                        "\nAntenna: " + comboAntenna.Text.ToUpper() +
                        "\nJob Number: " + maskedJobNumber.Text.ToUpper() + "\n" + "Serial/Serials Issued: ";
                    foreach (int serialsIssued in serialList)
                    {
                        message += serialsIssued.ToString("00-0000") + ", ";
                    }
                    // Display message box for the list
                    MessageBox.Show(message, "New Serial Numbers issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("A concurrency error occurred. " + "The row was not upddated.", "Concurrency Exeption", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }

        
        }

        // Check if data is valid
        // Validate Customer, antenna, Job and # of Serials to issue boxes
        private bool IsValidData()
        {
            
            return
                Validators.IsPresentMask(maskedSerial) &&
                Validators.IsPresentCombo(comboCustomer) &&
                Validators.IsPresentCombo(comboAntenna) &&
                Validators.IsPresent(txtCount) &&
                Validators.IsInt32(txtCount) &&
                Validators.IsPresentMask(maskedJobNumber);

        }
       
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            NewCustomer newCustomer = new NewCustomer();
            newCustomer.ShowDialog();
            this.customersTableAdapter.Fill(appData.Customers);
            comboCustomer.SelectedValue = 0;
        }

        private void btnAddAntenna_Click(object sender, EventArgs e)
        {
            NewAntenna newAntenna = new NewAntenna();
            newAntenna.ShowDialog();
            this.antennasTableAdapter.Fill(this.appData.Antennas);
            comboAntenna.SelectedValue = 0;
        }

        private void btnChangeYear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("You are about to start a new year!", "Starting new Serial Year", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                maskedSerial.ReadOnly = false;
                maskedSerial.Focus();
                maskedSerial.Clear();
            }
            else if (result == DialogResult.No)
            {
                maskedSerial.ReadOnly = true;
                txtCount.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
           
            serial_LogTableAdapter.LimitFill(appData.Serial_Log);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            MessageBox.Show(HelpClass.NewSerialNumberHelp(), "Need Help?", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //MessageBox.Show("Quick help options!\n\n" +
            //    "1. If there is no serial number in the serial number box\n" +
            //    "or if you need to start a new year. Then click the \n" +
            //    "Start new year button in the top left!\n" +
            //    "this will allow you to enter a new serial year\n\n" +
            //    "WARNING!!! Serial numbers are auto incremented, so if\n" +
            //    "if there is a serial number in the serial box. Do NOT\n" +
            //    "push the start new year unless you are starting a new year.\n\n" +
            //    "Any other issue please forward them to\n" +
            //    "Murray Duke @ murrayduke@rogers.com", "Need help!", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
