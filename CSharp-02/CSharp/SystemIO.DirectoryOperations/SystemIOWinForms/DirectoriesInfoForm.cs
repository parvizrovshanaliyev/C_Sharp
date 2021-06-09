using System;
using System.IO;
using System.Windows.Forms;

namespace SystemIOWinForms
{
    public partial class DirectoriesInfoForm : Form
    {
        #region fields

        private string _path;
        private FileInfo _selectedFileInfo;
        bool isFileOpened, isFileSaved; // determines the selection of the file and it saving
        #endregion

        #region ctor

        public DirectoriesInfoForm()
        {
            InitializeComponent();

            isFileOpened = false; 
            isFileSaved = false;

            lblFileName.Text = "-";
            richTextBoxEditor.Text = "";
        }

        #endregion

        #region methods

        private void btnOpenFolderBrowser_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            this._path = folderBrowserDialog1.SelectedPath;
            lblSelectedPath.Text = this._path;
            IsValidDirectory();
            MessageBox.Show(this._path);

            AddRowToDataGridView();
        }



        private void btnCreateFile_Click(object sender, EventArgs e)
        {
            if (!IsValidDirectory() || !IsValidName("File")) return;
            FileStream fileStream = File.Create(Path.Combine(this._path, textBoxName.Text));
            fileStream.Close();

            AddRowToDataGridView();

        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            if (!IsValidDirectory() || !IsValidName("File")) return;
            DirectoryInfo directoryInfo = Directory.CreateDirectory(Path.Combine(this._path, textBoxName.Text));

            AddRowToDataGridView();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string fileName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

            this._selectedFileInfo = new FileInfo(Path.Combine(this._path, fileName ?? string.Empty));

            if(!IsValidFileExtension()) return;

            AddFormattedTextToRichTextBox();

            #region v2

            //// Create an instance of StreamReader to read from a file.
            //// The using statement also closes the StreamReader.
            //using StreamReader sr = new StreamReader(this._selectedFileInfo.Open(FileMode.Open));

            //// clear the following text in richTextBoxEditor
            //richTextBoxEditor.Clear();
            //string line;
            //// Read and display lines from the file until the end of
            //// the file is reached.
            //while ((line = sr.ReadLine()) != null)
            //{
            //    //richTextBoxEditor.Text += line;

            //    AddFormattedText(line);
            //}
            //sr.Close();

            #endregion
        }

        void AddFormattedTextToRichTextBox()
        {
            // Read the file in richTextBoxEditor
            // clear the following text in richTextBoxEditor
            richTextBoxEditor.Clear();

            //  Create the object of class StreamReader and read data from file
            StreamReader sr = File.OpenText(this._selectedFileInfo.FullName);

            // additional variable for reading of string from the file
            string line = null;

            line = sr.ReadLine(); // reading of first string

            //  The cycle of strings reading from a file
            while (line != null)
            {
                //  Add a string in richTextBoxEditor
                richTextBoxEditor.AppendText(line);

                //  Add a new line
                richTextBoxEditor.AppendText("\r\n");

                // 6.3. Read the previous string
                line = sr.ReadLine();
            }

            // Close the connection to the file
            sr.Close();

            #region v2

            //// clear the following text in richTextBoxEditor
            //richTextBoxEditor.Clear();
            //if (!string.IsNullOrWhiteSpace(richTextBoxEditor.Text))
            //{
            //    richTextBoxEditor.AppendText("\r\n" + output);
            //}
            //else
            //{
            //    richTextBoxEditor.AppendText(output);
            //}
            //richTextBoxEditor.ScrollToCaret();

            #endregion
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //// 1. Check whether the file is opened?
            //if (!f_open) return;

            //// 2. If the file is opened, the checking - whether it is saved.
            //if (f_save) return;

            //// 3. Creating an object of type StreamWriter and getting the string data
            //StreamWriter sw = File.CreateText(openFileDialog1.FileName);

            //// 4. Reading of strings from richTextBox1 and adding their into the file
            //string line;

            //for (int i = 0; i < richTextBox1.Lines.Length; i++)
            //{
            //    // 4.1. Reading the string
            //    line = richTextBox1.Lines[i].ToString();

            //    // 4.2. Adding the string into a file
            //    sw.WriteLine(line);
            //}

            // 5. Close the object sw
            //sw.Close();
        }

        #endregion

        #region helper
        private void AddRowToDataGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (var item in Directory.GetDirectories(this._path))
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(item);
                dataGridView1.Rows.Add("Folder", directoryInfo.Name);
            }


            foreach (var item in Directory.GetFiles(this._path))
            {
                FileInfo fileInfo = new FileInfo(item);
                dataGridView1.Rows.Add("File", fileInfo.Name);
            }
        }
        private bool IsValidName(string type)
        {
            if (!string.IsNullOrEmpty(textBoxName.Text)) return true;
            MessageBox.Show($@"{type} adi daxil edilmeyib");
            return false;
        }

        private bool IsValidDirectory()
        {
            if (!string.IsNullOrEmpty(this._path)) return true;
            MessageBox.Show("Hec bir folder secilmeyib: Open Folder Browser");
            return false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private bool IsValidFileExtension()
        {
            if (this._selectedFileInfo.Extension is ".html"
                or ".css"
                or ".txt"
                or ".cs")
                return true;

            MessageBox.Show(@"secilen file ucun uzanti ancaq,.html,.css,.txt,.cs ola biler");
            return false;
        }
        #endregion


    }
}
