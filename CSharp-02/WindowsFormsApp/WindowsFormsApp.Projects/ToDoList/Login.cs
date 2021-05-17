using System;
using System.Drawing;
using System.Windows.Forms;
using ToDoList.Business.Abstract;
using ToDoList.Business.Concrete;
using ToDoList.DataAccess.Concrete;

namespace ToDoList
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox) sender;
            textBox.BackColor=Color.DarkGray;
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxUsername.Text) && !string.IsNullOrEmpty(txtBoxPassword.Text))
            {
                IUserService userService = new UserService(new InMemoryUserDal());
                var user = userService.GetUser(txtBoxUsername.Text, txtBoxPassword.Text);

                if (user != null)
                {
                    // left sideBar buttons enabled=true
                    Form todoListForm = Application.OpenForms["ToDoListForm"];
                    Panel leftSideBarPanel = (Panel) todoListForm.Controls["pnlOperationList"];
                    GroupBox operationsGroupBox = (GroupBox) leftSideBarPanel.Controls["grpBoxOperations"];

                    foreach (Control control in operationsGroupBox.Controls)
                    {
                        if (control is Button)
                        {
                            control.Enabled = true;
                        }
                    }

                    MessageBox.Show($"HI {user.Username}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username/password !", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Username and password Required !", "Info", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //this.CenterToParent();
        }
    }
}
