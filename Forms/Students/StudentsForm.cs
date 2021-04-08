
using SchoolSystem.Entities.SchoolDataSetTableAdapters;
using SchoolSystem.ExtensionsMethod;
using SchoolSystem.Forms.Students;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.Forms
{
    public partial class StudentsForm : Form
    {
        private static StudentsForm _instance = null;

        public static StudentsForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StudentsForm();
                }
                return _instance;
            }
        }

        public static bool IsNull
        {
            get
            {
                if (_instance == null)
                {
                    return true;
                }
                return false;
            }
        }

        public StudentsForm()
        {
            InitializeComponent();
        }

        private void StudentsForm_Load(object sender, EventArgs e)
        {

            this.show_StudentsTableAdapter.Fill(this.schoolDataSet.Show_Students);

        }
        private void StudentsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            form.ShowDialog();
            Methods.RefreshDataGrid(dataGridStudents, "select * from dbo.Show_Students");
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {

            if (dataGridStudents.CurrentRow != null)
            {
                int tmp = Convert.ToInt32(dataGridStudents.CurrentRow.Index);
                int index = Convert.ToInt32(dataGridStudents.Rows[tmp].Cells[0].Value);
                try
                {
                    QueriesTableAdapter tableAdapter = new QueriesTableAdapter();
                    tableAdapter.RemoveStudent(index);
                    Methods.RefreshDataGrid(dataGridStudents, "select * from dbo.Show_Students");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego studenta z listy.");
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if(dataGridStudents.CurrentRow != null)
            {
                EditStudentForm form = new EditStudentForm(dataGridStudents);
                form.ShowDialog();
                Methods.RefreshDataGrid(dataGridStudents, "select * from dbo.Show_Students");
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego studenta.");
            }

        }

    }
}
