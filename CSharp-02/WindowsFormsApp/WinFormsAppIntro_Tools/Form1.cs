using System;
using System.Windows.Forms;

namespace WinFormsAppIntro_Tools
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void submitBTN_Click(object sender, EventArgs e)
        {
            label4.Text = NameTextBox.Text;
            label5.Text = SurnameTextBox.Text;
            label6.Text = AgeTextBox.Text;
        }

        
    }
}
