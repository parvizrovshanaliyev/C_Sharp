
namespace ToDoList
{
    partial class NewTodoForm
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
            this.lblImportanceLevel = new System.Windows.Forms.Label();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.lblShortDesc = new System.Windows.Forms.Label();
            this.txtBoxShortDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cmbBoxStatus = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblImportanceLevel
            // 
            this.lblImportanceLevel.AutoSize = true;
            this.lblImportanceLevel.Location = new System.Drawing.Point(13, 378);
            this.lblImportanceLevel.Name = "lblImportanceLevel";
            this.lblImportanceLevel.Size = new System.Drawing.Size(123, 20);
            this.lblImportanceLevel.TabIndex = 0;
            this.lblImportanceLevel.Text = "Importance Level";
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.Location = new System.Drawing.Point(160, 375);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(293, 27);
            this.txtBoxTitle.TabIndex = 3;
            this.txtBoxTitle.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxTitle.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(51, 204);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(85, 20);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "Description";
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.Location = new System.Drawing.Point(160, 204);
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.Size = new System.Drawing.Size(293, 134);
            this.txtBoxDesc.TabIndex = 2;
            this.txtBoxDesc.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxDesc.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // lblShortDesc
            // 
            this.lblShortDesc.AutoSize = true;
            this.lblShortDesc.Location = new System.Drawing.Point(13, 89);
            this.lblShortDesc.Name = "lblShortDesc";
            this.lblShortDesc.Size = new System.Drawing.Size(124, 20);
            this.lblShortDesc.TabIndex = 0;
            this.lblShortDesc.Text = "Short Description";
            // 
            // txtBoxShortDesc
            // 
            this.txtBoxShortDesc.Location = new System.Drawing.Point(160, 86);
            this.txtBoxShortDesc.Multiline = true;
            this.txtBoxShortDesc.Name = "txtBoxShortDesc";
            this.txtBoxShortDesc.Size = new System.Drawing.Size(293, 100);
            this.txtBoxShortDesc.TabIndex = 1;
            this.txtBoxShortDesc.Enter += new System.EventHandler(this.txtBox_Enter);
            this.txtBoxShortDesc.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(160, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(293, 27);
            this.textBox3.TabIndex = 0;
            this.textBox3.Enter += new System.EventHandler(this.txtBox_Enter);
            this.textBox3.Leave += new System.EventHandler(this.txtBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Status";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(160, 477);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(293, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbBoxStatus
            // 
            this.cmbBoxStatus.FormattingEnabled = true;
            this.cmbBoxStatus.Location = new System.Drawing.Point(160, 423);
            this.cmbBoxStatus.Name = "cmbBoxStatus";
            this.cmbBoxStatus.Size = new System.Drawing.Size(293, 28);
            this.cmbBoxStatus.TabIndex = 4;
            // 
            // NewTodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 562);
            this.Controls.Add(this.cmbBoxStatus);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxShortDesc);
            this.Controls.Add(this.txtBoxDesc);
            this.Controls.Add(this.lblShortDesc);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.lblImportanceLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewTodoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Todo";
            this.Load += new System.EventHandler(this.NewTodoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblImportanceLevel;
        private System.Windows.Forms.TextBox txtBoxTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.Label lblShortDesc;
        private System.Windows.Forms.TextBox txtBoxShortDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cmbBoxStatus;
    }
}