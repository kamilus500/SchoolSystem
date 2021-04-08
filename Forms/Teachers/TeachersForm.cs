using SchoolSystem.Entities.SchoolDataSetTableAdapters;
using SchoolSystem.ExtensionsMethod;
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

namespace SchoolSystem.Forms.Teachers
{
    public partial class TeachersForm : Form
    {
        private static TeachersForm _instance = null;

        public static TeachersForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new TeachersForm();
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

        public TeachersForm()
        {
            InitializeComponent();
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {

            this.show_TeachersTableAdapter.Fill(this.schoolDataSet.Show_Teachers);
        }

        private void TeachersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddTeacherForm form = new AddTeacherForm();
            form.ShowDialog();
            Methods.RefreshDataGrid(dataGridTeachers, "select * from dbo.Show_Teachers");
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            if (dataGridTeachers.CurrentRow != null)
            {
                EditTeacherForm form = new EditTeacherForm(dataGridTeachers);
                form.ShowDialog();
                Methods.RefreshDataGrid(dataGridTeachers, "select * from dbo.Show_Teachers");
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego studenta z listy.");
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (dataGridTeachers.CurrentRow != null)
            {
                int tmp = Convert.ToInt32(dataGridTeachers.CurrentRow.Index);
                int id = Convert.ToInt32(dataGridTeachers.Rows[tmp].Cells[0].Value);
                try
                {
                    QueriesTableAdapter tableAdapter = new QueriesTableAdapter();
                    tableAdapter.RemoveTeacher(id);
                    Methods.RefreshDataGrid(dataGridTeachers, "select * from dbo.Show_Teachers");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego nauczyciela z listy.");
            }
        }
    }
}
