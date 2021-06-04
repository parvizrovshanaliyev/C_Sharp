using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOWinForms
{
    public partial class SystemIOForm : Form
    {
        Data data;
        private List<Employer> employers;
        public SystemIOForm()
        {
            InitializeComponent();
            data = new Data();
        }

        private void btnGet_Click(object sender, EventArgs e)
        {
            employers = data.GetAll(150);
            employerListBox.DataSource = employers;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            data.SaveData(@"c:\test",employers);
        }

        

        private void employerListBox_DoubleClick(object sender, EventArgs e)
        {
            Employer employer = (Employer)employerListBox.SelectedItem;
            textBox1.Text = employer.Name;
            textBox2.Text = employer.Surname;
            textBox3.Text = employer.Email;
            textBox4.Text = employer.Company;
            textBox5.Text = employer.Country;
        }
    }
}
