using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.TransferDataBetweenForms2
{
    #region dataTransferBetweeenForms

    /*
     * bir login form dizayn edeceyik, istifadeci username ve password daxil edib
     * login btn-e click edecek.
     *
     * ** Tab order
     */

    #endregion
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;

            if (username == "Admin" && password == "1234")
            {
                Home home = new Home(username);

                home.Show();
            }
            else
            {
                MessageBox.Show("Daxil edilen melumatlar dogru deyil!");
            }
        }
    }
}
