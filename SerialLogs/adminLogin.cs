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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }
        string login = "admin";
        string password = "admin";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text == login && txtPassWord.Text == password)
            {
                this.Close();
                Admin adminPage = new Admin();
                adminPage.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Sorry Login or password wrong!", "Error Login/PassWord");
            }
        }
    }
}
