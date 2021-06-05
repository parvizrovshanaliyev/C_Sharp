using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SystemIOWinForms
{
    public partial class CreateTextDocForm : Form
    {
        public CreateTextDocForm()
        {
            InitializeComponent();
        }


        private string directory, fileName;
        private StreamWriter streamWriter;

        private void btnChooseDirectory_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                directory = folderBrowserDialog1.SelectedPath.ToString();
                textBoxDirectory.Text = directory;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            fileName = textBoxFileName.Text;
            streamWriter = File.CreateText(directory + "\\" + fileName + ".txt");
            streamWriter.Close();
        }

        private void CreateTextDocForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
