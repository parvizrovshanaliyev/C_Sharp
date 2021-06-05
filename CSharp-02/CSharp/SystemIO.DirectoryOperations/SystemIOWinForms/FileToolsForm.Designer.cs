
namespace SystemIOWinForms
{
    partial class FileToolsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.btnSavaeFileDialog = new System.Windows.Forms.Button();
            this.btnFolderBrowserDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(268, 62);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(171, 29);
            this.btnOpenFileDialog.TabIndex = 0;
            this.btnOpenFileDialog.Text = "Open File Dialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // btnSavaeFileDialog
            // 
            this.btnSavaeFileDialog.Location = new System.Drawing.Point(268, 120);
            this.btnSavaeFileDialog.Name = "btnSavaeFileDialog";
            this.btnSavaeFileDialog.Size = new System.Drawing.Size(171, 29);
            this.btnSavaeFileDialog.TabIndex = 0;
            this.btnSavaeFileDialog.Text = "Save File Dialog";
            this.btnSavaeFileDialog.UseVisualStyleBackColor = true;
            this.btnSavaeFileDialog.Click += new System.EventHandler(this.btnSavaeFileDialog_Click);
            // 
            // btnFolderBrowserDialog
            // 
            this.btnFolderBrowserDialog.Location = new System.Drawing.Point(268, 186);
            this.btnFolderBrowserDialog.Name = "btnFolderBrowserDialog";
            this.btnFolderBrowserDialog.Size = new System.Drawing.Size(171, 29);
            this.btnFolderBrowserDialog.TabIndex = 0;
            this.btnFolderBrowserDialog.Text = "Folder Browser Dialog";
            this.btnFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.btnFolderBrowserDialog.Click += new System.EventHandler(this.btnFolderBrowserDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FileToolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnFolderBrowserDialog);
            this.Controls.Add(this.btnSavaeFileDialog);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Name = "FileToolsForm";
            this.Text = "FileToolsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.Button btnSavaeFileDialog;
        private System.Windows.Forms.Button btnFolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}