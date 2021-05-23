namespace WindowsFormsApp.MessageBoxNotification
{
    partial class MessageBoxAppForm
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
            this.components = new System.ComponentModel.Container();
            this.grpBoxList = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.grpBoxForm = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.listBoxCustomer = new System.Windows.Forms.ListBox();
            this.notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.grpBoxList.SuspendLayout();
            this.grpBoxForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxList
            // 
            this.grpBoxList.Controls.Add(this.listBoxCustomer);
            this.grpBoxList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpBoxList.Location = new System.Drawing.Point(479, 0);
            this.grpBoxList.Name = "grpBoxList";
            this.grpBoxList.Size = new System.Drawing.Size(753, 367);
            this.grpBoxList.TabIndex = 1;
            this.grpBoxList.TabStop = false;
            this.grpBoxList.Text = "Customer List";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 80);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(104, 77);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(309, 27);
            this.txtBoxName.TabIndex = 1;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(12, 123);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(67, 20);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname";
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(104, 123);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(309, 27);
            this.txtBoxSurname.TabIndex = 1;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(12, 181);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(12, 225);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(63, 20);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(104, 181);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(309, 27);
            this.txtBoxEmail.TabIndex = 1;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.Location = new System.Drawing.Point(104, 225);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(309, 27);
            this.txtBoxNumber.TabIndex = 1;
            // 
            // grpBoxForm
            // 
            this.grpBoxForm.Controls.Add(this.btnSave);
            this.grpBoxForm.Controls.Add(this.txtBoxNumber);
            this.grpBoxForm.Controls.Add(this.txtBoxEmail);
            this.grpBoxForm.Controls.Add(this.lblNumber);
            this.grpBoxForm.Controls.Add(this.lblEmail);
            this.grpBoxForm.Controls.Add(this.txtBoxSurname);
            this.grpBoxForm.Controls.Add(this.lblSurname);
            this.grpBoxForm.Controls.Add(this.txtBoxName);
            this.grpBoxForm.Controls.Add(this.lblName);
            this.grpBoxForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpBoxForm.Location = new System.Drawing.Point(0, 0);
            this.grpBoxForm.Name = "grpBoxForm";
            this.grpBoxForm.Size = new System.Drawing.Size(479, 367);
            this.grpBoxForm.TabIndex = 0;
            this.grpBoxForm.TabStop = false;
            this.grpBoxForm.Text = "new customer addition form";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(104, 282);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(309, 29);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // listBoxCustomer
            // 
            this.listBoxCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCustomer.FormattingEnabled = true;
            this.listBoxCustomer.ItemHeight = 20;
            this.listBoxCustomer.Location = new System.Drawing.Point(3, 23);
            this.listBoxCustomer.Name = "listBoxCustomer";
            this.listBoxCustomer.Size = new System.Drawing.Size(747, 341);
            this.listBoxCustomer.TabIndex = 0;
            // 
            // notification
            // 
            this.notification.Visible = true;
            // 
            // MessageBoxAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 367);
            this.Controls.Add(this.grpBoxList);
            this.Controls.Add(this.grpBoxForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MessageBoxAppForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " MessageBox App";
            this.grpBoxList.ResumeLayout(false);
            this.grpBoxForm.ResumeLayout(false);
            this.grpBoxForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBoxList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.GroupBox grpBoxForm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox listBoxCustomer;
        private System.Windows.Forms.NotifyIcon notification;
    }
}

