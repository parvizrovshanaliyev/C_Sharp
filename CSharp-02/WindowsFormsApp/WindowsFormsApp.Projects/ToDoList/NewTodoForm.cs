using System;
using System.Windows.Forms;
using ToDoList.Business.Abstract;
using ToDoList.Business.Concrete;
using ToDoList.Constants;
using ToDoList.DataAccess.Concrete;
using ToDoList.Entities.Concrete;
using ToDoList.Enums;
using ToDoList.Extensions;

namespace ToDoList
{
    public partial class NewTodoForm : Form
    {
        #region fields
        private readonly ITodoService _todoService;
        #endregion

        #region ctor

        public NewTodoForm()
        {
            InitializeComponent();
            _todoService = new TodoService(new InMemoryTodoDal());

        }

        #endregion

        #region methods
        private void NewTodoForm_Load(object sender, EventArgs e)
        {
            cmbBoxStatus.DataSource = Enum.GetValues(typeof(Status));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            var result = _todoService.Add(new TodoEntity
            {
                Id = Guid.NewGuid(),
                Title = txtBoxTitle.Text,
                ShortDescription = txtBoxShortDesc.Text,
                Description = txtBoxDesc.Text,
                Status = (Status)cmbBoxStatus.SelectedItem,
                ImportanceLevel = Convert.ToInt32(txtBoxImportanceLevel.Text)
            });

            if (result > 0)
            {
                MessageBox.Show(GlobalConstants.AddSuccess, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult dialogResult = MessageBox.Show(
                        GlobalConstants.AddOperationContinue,
                        GlobalConstants.CaptionQuestion,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                if (dialogResult == DialogResult.Yes)
                {
                    ClearTextBoxesValue();
                }
                else
                {
                    Form getAllForm = Application.OpenForms["GetAllForm"];

                    if (getAllForm == null)
                    {
                        getAllForm = new GetAllForm();
                        getAllForm.MdiParent = Application.OpenForms["ToDoListForm"];
                        getAllForm.StartPosition = FormStartPosition.CenterScreen;
                        getAllForm.Show();
                        this.Close();
                    }
                    else
                    {
                        GroupBox listGroupBox = (GroupBox) getAllForm.Controls["grpList"];
                        DataGridView dataGrid = (DataGridView) listGroupBox.Controls["dataGrdGetAll"];
                        dataGrid.DataSource = null;
                        dataGrid.DataSource = _todoService.GetAll();
                        dataGrid.Columns["Id"].Visible = false;
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show(GlobalConstants.AddError, GlobalConstants.CaptionInfo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        #region helper methods
        private void txtBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).EnterEvent();
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).LeaveEvent();
        }
        private void ClearTextBoxesValue()
        {
            foreach (var item in this.Controls)
            {
                if (item is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }
        #endregion
        #endregion

    }
}
