#nullable enable
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
    public partial class Home : Form
    {
        public Home(string? username)
        {
            InitializeComponent();
            label1.Text = username;
        }
    }
}
