namespace ToDoList
{
    partial class ToDoListForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlOperationList = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpBoxOperations = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.pnlOperationList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpBoxOperations.SuspendLayout();
            this.pnlDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOperationList
            // 
            this.pnlOperationList.Controls.Add(this.grpBoxOperations);
            this.pnlOperationList.Controls.Add(this.pictureBox1);
            this.pnlOperationList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOperationList.Location = new System.Drawing.Point(0, 0);
            this.pnlOperationList.Name = "pnlOperationList";
            this.pnlOperationList.Size = new System.Drawing.Size(240, 750);
            this.pnlOperationList.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 150);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // grpBoxOperations
            // 
            this.grpBoxOperations.Controls.Add(this.btnExit);
            this.grpBoxOperations.Controls.Add(this.btnGetAll);
            this.grpBoxOperations.Controls.Add(this.btnNew);
            this.grpBoxOperations.Location = new System.Drawing.Point(6, 186);
            this.grpBoxOperations.Name = "grpBoxOperations";
            this.grpBoxOperations.Size = new System.Drawing.Size(219, 356);
            this.grpBoxOperations.TabIndex = 3;
            this.grpBoxOperations.TabStop = false;
            this.grpBoxOperations.Text = "Operations Menu";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(6, 43);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(207, 42);
            this.btnNew.TabIndex = 0;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(6, 100);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(207, 42);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Get All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 163);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 42);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.Controls.Add(this.lblDateTime);
            this.pnlDateTime.Location = new System.Drawing.Point(1066, 711);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(215, 38);
            this.pnlDateTime.TabIndex = 2;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateTime.Location = new System.Drawing.Point(21, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(179, 31);
            this.lblDateTime.TabIndex = 0;
            this.lblDateTime.Text = "15.05.2021 12:43";
            // 
            // ToDoListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 750);
            this.Controls.Add(this.pnlDateTime);
            this.Controls.Add(this.pnlOperationList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.Name = "ToDoListForm";
            this.Text = "ToDoList";
            this.pnlOperationList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpBoxOperations.ResumeLayout(false);
            this.pnlDateTime.ResumeLayout(false);
            this.pnlDateTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlOperationList;
        private System.Windows.Forms.GroupBox grpBoxOperations;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlDateTime;
        private System.Windows.Forms.Label lblDateTime;
    }
}

