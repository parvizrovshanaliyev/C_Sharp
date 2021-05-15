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
            updateBtn.Tag = user.Id;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            int userId = (int)button.Tag;

            var userIndex = VirtualDatabase.userList.FindIndex(i => i.Id == userId);
            VirtualDatabase.userList[userIndex].Name = nameTextBox.Text;
            VirtualDatabase.userList[userIndex].Surname = surnameTextBox.Text;
            VirtualDatabase.userList[userIndex].Password = passwordTextBox.Text;
            VirtualDatabase.userList[userIndex].Desc = descTextArea.Text;

            MessageBox.Show("Ugurla redakte edildi", "good", MessageBoxButtons.OK);
            Close();

        }
    }
}
