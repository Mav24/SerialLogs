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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void serial_LogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serial_LogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.appData);

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'appData.Antennas' table. You can move, or remove it, as needed.
            this.antennasTableAdapter.Fill(this.appData.Antennas);
            // TODO: This line of code loads data into the 'appData.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.appData.Customers);
            // TODO: This line of code loads data into the 'appData.Serial_Log' table. You can move, or remove it, as needed.
            this.serial_LogTableAdapter.Fill(this.appData.Serial_Log);

        }
    }
}
