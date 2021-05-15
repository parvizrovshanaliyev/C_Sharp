using System;
using System.Drawing;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDoListForm : Form
    {
        #region fields

        private Form form;
        #endregion
        #region ctor

        public ToDoListForm()
        {
            InitializeComponent();
        }

        #endregion

        #region methods

        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            // timer
            GetDateTime();

            // login
            Login loginForm = new Login();
            //loginForm.MdiParent = this;
            //loginForm.StartPosition = FormStartPosition.CenterParent;
            ////loginForm.StartPosition = FormStartPosition.Manual;
            ////loginForm.Location = new Point((this.ClientSize.Width - loginForm.Width) / 2,
            ////    (this.ClientSize.Height - this.Height) / 2);
            //loginForm.Show();

            #region MyRegion
            //Set location by manually to set modless dialog(form)center of the parent form(parent)

            //form.StartPosition = FormStartPosition.Manual;
            //form.Location = new Point(parent.Location.X + (parent.Width - form.Width) / 2, parent.Location.Y + (parent.Height - form.Height) / 2);
            //form..Show(parent);

            //In dot net 4.0 - User remove control box and FormBorderStyle not sizable
            //    along with the set location manually:
            //form.ControlBox = false;
            //form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;

            //problem is:
            //In dot net version 4.0 it is problem of cutoff the dialog from bottom(lower part of dialog not show when run)

            //solution is
            //    Set Localizable property of the form as true
            loginForm.MdiParent = this;
            loginForm.StartPosition = FormStartPosition.CenterScreen;
            //loginForm.Location = new Point(this.Location.X + (this.Width - loginForm.Width) / 2, this.Location.Y + (this.Height - loginForm.Height) / 2);
            loginForm.Show();
            loginForm.ControlBox = false;
            loginForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            #endregion

            // sideBar
            GrpBoxOperationButtonsEnableDisable(false);
        }

        private void GetDateTime()
        {
            timerDateTime.Interval = 15000;
            timerDateTime.Tick += TimerDateTime_Tick;
            timerDateTime.Start();
        }

        /// <summary>
        /// Todolist form icerisindeki emeliyyatlarin form acilarken deaktiv edilmesi
        /// </summary>
        /// <param name="control"></param>
        private void GrpBoxOperationButtonsEnableDisable(bool control)
        {
            foreach (var item in grpBoxOperations.Controls)
            {
                if (item is Button operationButton)
                {
                    operationButton.Enabled = control;
                }
            }
        }

        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("g");
        }
        /// <summary>
        /// Application Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewTodoForm"] != null)
            {
                form = Application.OpenForms["NewTodoForm"];
                form.Focus();
            }
            else
            {
                form = new NewTodoForm {MdiParent = this};
                form.Show();
            }
        }
        #endregion


    }
}
