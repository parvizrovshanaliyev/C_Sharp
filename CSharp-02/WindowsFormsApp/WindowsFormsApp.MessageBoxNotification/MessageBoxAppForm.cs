using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp.MessageBoxNotification
{
    public partial class MessageBoxAppForm : Form
    {
        public MessageBoxAppForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result=Add(new Customer
            {
                Name = txtBoxName.Text,
                Surname = txtBoxSurname.Text,
                Email = txtBoxEmail.Text,
                Number = txtBoxNumber.Text,
            });

            if (result)
            {
                DialogResult dialogResult = MessageBox.Show("success, yeni musteri elave etmek isteyirsinizmi", "Info",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult== DialogResult.Yes)
                {

                    notification = new NotifyIcon
                    {
                        BalloonTipText = "Toplam musteri sayi :" + VirtualDB.Customers.Count.ToString(),
                        BalloonTipTitle = "Information",
                        Icon = SystemIcons.Information,
                        Visible = true
                    };
                    notification.ShowBalloonTip(2000);

                }else if(dialogResult == DialogResult.No)
                {


                }
                ClearTextBox();
                UpdateCustomerList();
            }
            else
            {
                MessageBox.Show("xeta");
            }
        }

        private void UpdateCustomerList()
        {
            listBoxCustomer.DataSource = VirtualDB.Customers;
        }
        private void ClearTextBox()
        {
            txtBoxEmail.Text = string.Empty;
            txtBoxName.Text = string.Empty;
            txtBoxNumber.Text = string.Empty;
            txtBoxSurname.Text = string.Empty;
        }

        private bool Add(Customer data)
        {
            VirtualDB.Customers.Add(data);

            return true;
        }
    }
}
