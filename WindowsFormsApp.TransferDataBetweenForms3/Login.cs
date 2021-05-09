using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.TransferDataBetweenForms3;

namespace WindowsFormsApp.TransferDataBetweenForms3
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object? sender, EventArgs e)
        {
            string username = usernameTxt.Text;
            string password = passwordTxt.Text;


            var user = VirtualDatabase.userList.Find(i => i.Username == username && i.Password == password);

            if (user != null)
            {
                UpdateUserForm home = new UpdateUserForm(user);
                home.Show();
            }
            else
            {
                MessageBox.Show("daxil edilen melumatlar dogru deyil", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
