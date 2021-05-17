
namespace ToDoList
{
    partial class GetAllForm
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
            this.grpOperationsMenu = new System.Windows.Forms.GroupBox();
            this.btnInCompleted = new System.Windows.Forms.Button();
            this.btnCanceled = new System.Windows.Forms.Button();
            this.btnCompleted = new System.Windows.Forms.Button();
            this.btnAll = new System.Windows.Forms.Button();
            this.grpList = new System.Windows.Forms.GroupBox();
            this.dataGrdGetAll = new System.Windows.Forms.DataGridView();
            this.grpOperationsMenu.SuspendLayout();
            this.grpList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdGetAll)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOperationsMenu
            // 
            this.grpOperationsMenu.Controls.Add(this.btnInCompleted);
            this.grpOperationsMenu.Controls.Add(this.btnCanceled);
            this.grpOperationsMenu.Controls.Add(this.btnCompleted);
            this.grpOperationsMenu.Controls.Add(this.btnAll);
            this.grpOperationsMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpOperationsMenu.Location = new System.Drawing.Point(0, 0);
            this.grpOperationsMenu.Name = "grpOperationsMenu";
            this.grpOperationsMenu.Size = new System.Drawing.Size(184, 596);
            this.grpOperationsMenu.TabIndex = 0;
            this.grpOperationsMenu.TabStop = false;
            this.grpOperationsMenu.Text = "Operations Menu";
            // 
            // btnInCompleted
            // 
            this.btnInCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInCompleted.Location = new System.Drawing.Point(3, 128);
            this.btnInCompleted.Name = "btnInCompleted";
            this.btnInCompleted.Size = new System.Drawing.Size(178, 35);
            this.btnInCompleted.TabIndex = 0;
            this.btnInCompleted.Text = "InCompleted";
            this.btnInCompleted.UseVisualStyleBackColor = true;
            this.btnInCompleted.Click += new System.EventHandler(this.btnInCompleted_Click);
            // 
            // btnCanceled
            // 
            this.btnCanceled.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCanceled.Location = new System.Drawing.Point(3, 93);
            this.btnCanceled.Name = "btnCanceled";
            this.btnCanceled.Size = new System.Drawing.Size(178, 35);
            this.btnCanceled.TabIndex = 0;
            this.btnCanceled.Text = "Canceled";
            this.btnCanceled.UseVisualStyleBackColor = true;
            this.btnCanceled.Click += new System.EventHandler(this.btnCanceled_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompleted.Location = new System.Drawing.Point(3, 58);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(178, 35);
            this.btnCompleted.TabIndex = 0;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.UseVisualStyleBackColor = true;
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnAll
            // 
            this.btnAll.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAll.Location = new System.Drawing.Point(3, 23);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(178, 35);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // grpList
            // 
            this.grpList.Controls.Add(this.dataGrdGetAll);
            this.grpList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpList.Location = new System.Drawing.Point(184, 0);
            this.grpList.Name = "grpList";
            this.grpList.Size = new System.Drawing.Size(970, 596);
            this.grpList.TabIndex = 0;
            this.grpList.TabStop = false;
            this.grpList.Text = "List";
            // 
            // dataGrdGetAll
            // 
            this.dataGrdGetAll.AllowUserToAddRows = false;
            this.dataGrdGetAll.AllowUserToDeleteRows = false;
            this.dataGrdGetAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrdGetAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrdGetAll.Location = new System.Drawing.Point(3, 23);
            this.dataGrdGetAll.Name = "dataGrdGetAll";
            this.dataGrdGetAll.ReadOnly = true;
            this.dataGrdGetAll.RowHeadersWidth = 51;
            this.dataGrdGetAll.RowTemplate.Height = 29;
            this.dataGrdGetAll.Size = new System.Drawing.Size(964, 570);
            this.dataGrdGetAll.TabIndex = 0;
            // 
            // GetAllForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 596);
            this.Controls.Add(this.grpList);
            this.Controls.Add(this.grpOperationsMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GetAllForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Get All";
            this.Load += new System.EventHandler(this.GetAllForm_Load);
            this.grpOperationsMenu.ResumeLayout(false);
            this.grpList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrdGetAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOperationsMenu;
        private System.Windows.Forms.Button btnInCompleted;
        private System.Windows.Forms.Button btnCanceled;
        private System.Windows.Forms.Button btnCompleted;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.GroupBox grpList;
        private System.Windows.Forms.DataGridView dataGrdGetAll;
    }
}