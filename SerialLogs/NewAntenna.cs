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
    public partial class NewAntenna : Form
    {
        public NewAntenna()
        {
            InitializeComponent();
        }

        private void NewAntenna_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Antennas' table. You can move, or remove it, as needed.
            this.antennasTableAdapter.Fill(this.appData.Antennas);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                bool antennaExist = appData.Antennas.Any(check => check.Antenna.Equals(txtAntenna.Text.ToUpper()));  // Checks if antenna exist!
            
                if (antennaExist)
                {
                    MessageBox.Show("Sorry Antenna " + txtAntenna.Text.ToUpper() + " is already in the data base!", "Already Exist!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    // Create object for new entry
                    AppData.AntennasRow newEntry = appData.Antennas.NewAntennasRow();

                    newEntry.Antenna = txtAntenna.Text.ToUpper();

                    // Add new row to data base
                    appData.Antennas.AddAntennasRow(newEntry);

                    // Update Database
                    antennasTableAdapter.Update(newEntry);

                    // Pop up message
                    MessageBox.Show(newEntry.Antenna + "\n\n Antenna has been added!", "Added new Antenna", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.antennasTableAdapter.Fill(this.appData.Antennas);
                    //this.serial_LogTableAdapter.Fill(this.appData.Serial_Log); // Might need this.. not sure will test..
                    this.Close();
                }
            }
           
        }

        private bool IsValidData()
        {
            return
                // Validate Antenna name box
                Validators.IsPresent(txtAntenna);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            appData.Antennas.RejectChanges();
            Close();
        }
    }
}
