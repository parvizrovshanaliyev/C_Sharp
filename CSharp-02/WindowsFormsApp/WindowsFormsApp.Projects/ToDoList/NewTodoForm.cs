using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Entities.Concrete;
using ToDoList.Enums;
using ToDoList.Extensions;

namespace ToDoList
{
    public partial class NewTodoForm : Form
    {
        public NewTodoForm()
        {
            InitializeComponent();

            cmbBoxStatus.DataSource = Enum.GetValues(typeof(Status));

        }
        #region methods
        private void txtBox_Enter(object sender, EventArgs e)
        {
            (sender as TextBox).EnterEvent();
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
            (sender as TextBox).LeaveEvent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            Status status=(Status) cmbBoxStatus.SelectedItem;
        }
        #endregion

        private void NewTodoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
