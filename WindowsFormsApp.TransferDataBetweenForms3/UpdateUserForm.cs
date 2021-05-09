using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.TransferDataBetweenForms3.Models;

namespace WindowsFormsApp.TransferDataBetweenForms3
{
    public partial class UpdateUserForm : Form
    {
        public UpdateUserForm(User user)
        {
            InitializeComponent();

            nameTextBox.Text = user.Name;
            surnameTextBox.Text = user.Surname;
            usernameTextBox.Text = user.Username;
            passwordTextBox.Text = user.Password;
            descTextArea.Text = user.Desc;
        }

       
    }
}
