using System;
using System.Drawing;
using System.Windows.Forms;
using ToDoList.Business.Abstract;
using ToDoList.Business.Concrete;
using ToDoList.Constants;
using ToDoList.DataAccess.Concrete;

namespace ToDoList
{
    public partial class ToDoListForm : Form
    {
        #region fields

        private Form _form;
        private readonly ITodoService _todoService;
        #endregion
        #region ctor

        public ToDoListForm()
        {
            InitializeComponent();

            _todoService = new TodoService(new InMemoryTodoDal());
        }

        #endregion

        #region methods

        private void ToDoListForm_Load(object sender, EventArgs e)
        {
            // timer
            GetDateTime();

            // login
            Login loginForm = new Login();

            CenterParent(this, loginForm);

            // sideBar
            GrpBoxOperationButtonsEnableDisable(false);
        }

        #region menu

        #region 1.New

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["NewTodoForm"] != null)
            {
                _form = Application.OpenForms["NewTodoForm"];
                _form.Focus();
            }
            else
            {
                _form = new NewTodoForm();
                _form.MdiParent = Application.OpenForms["ToDoListForm"];
                _form.StartPosition = FormStartPosition.CenterScreen;
                _form.Show();
            }
        }

        #endregion
        #region 2. getAll

        private void btnGetAll_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms["GetAllForm"] != null)
            {
                _form = Application.OpenForms["GetAllForm"];
                _form.Focus();
            }
            else
            {
                if (_todoService.Count() > 0)
                {
                    GetAllForm getAllForm = new GetAllForm();
                    getAllForm.MdiParent = Application.OpenForms["ToDoListForm"];
                    getAllForm.StartPosition = FormStartPosition.CenterScreen;
                    getAllForm.Show();
                }
                else
                {
                    MessageBox.Show(GlobalConstants.EmptyList, GlobalConstants.CaptionInfo, MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            
        }

        #endregion
        #region 3. exit

        /// <summary>
        /// Application Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #endregion

        #region helper methods
        private void TimerDateTime_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("g");
        }
        private void GetDateTime()
        {
            timerDateTime.Interval = 15000;
            timerDateTime.Tick += TimerDateTime_Tick;
            timerDateTime.Start();
        }
        private void CenterParent(Form parentForm, Form childForm)
        {
            childForm.MdiParent = parentForm;
            childForm.StartPosition = FormStartPosition.Manual;
            childForm.Left = childForm.Parent.Width - ((childForm.Parent.Width - childForm.Width) / 2);
            childForm.Top = childForm.Parent.Height - ((childForm.Parent.Height - childForm.Height) / 2);
            childForm.Show();
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
        #endregion

        #endregion


    }
}
