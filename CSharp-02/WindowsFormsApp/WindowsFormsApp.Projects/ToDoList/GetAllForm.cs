using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoList.Business.Abstract;
using ToDoList.Business.Concrete;
using ToDoList.DataAccess.Concrete;
using ToDoList.Enums;

namespace ToDoList
{
    public partial class GetAllForm : Form
    {
        #region fields
        private ITodoService _todoService;
        #endregion
        public GetAllForm()
        {
            InitializeComponent();
            _todoService = new TodoService(new InMemoryTodoDal());
        }

        #region methods

        private void GetAllForm_Load(object sender, EventArgs e)
        {
            dataGrdGetAll.DataSource = _todoService.GetAll();
            dataGrdGetAll.Columns["Id"].Visible = false;
        }
        private void btnCompleted_Click(object sender, EventArgs e)
        {
            dataGrdGetAll.DataSource = _todoService.GetAllByStatus(Status.Completed);
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            dataGrdGetAll.DataSource = _todoService.GetAll();
        }

        private void btnCanceled_Click(object sender, EventArgs e)
        {
            dataGrdGetAll.DataSource = _todoService.GetAllByStatus(Status.Canceled);
        }

        private void btnInCompleted_Click(object sender, EventArgs e)
        {
            dataGrdGetAll.DataSource = _todoService.GetAllByStatus(Status.InCompleted);
        }
        #endregion


    }
}
