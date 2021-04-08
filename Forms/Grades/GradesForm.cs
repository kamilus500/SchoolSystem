
using SchoolSystem.Entities;
using SchoolSystem.Entities.SchoolDataSetTableAdapters;
using SchoolSystem.ExtensionsMethod;
using SchoolSystem.Helpers;
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

namespace SchoolSystem.Forms.Grades
{
    public partial class GradesForm : Form
    {
        private static GradesForm _instance = null;

        public SchoolDataSet db = new SchoolDataSet();
        public static GradesForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GradesForm();
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

        public GradesForm()
        {
            InitializeComponent();
        }

        private void GradesForm_Load(object sender, EventArgs e)
        {
            this.show_GradesWithSubjectTableAdapter1.Fill(this.schoolDataSet1.Show_GradesWithSubject);
        }

        private void GradesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnAddGrade_Click(object sender, EventArgs e)
        {
            AddGradeForm form = new AddGradeForm();
            form.ShowDialog();
            Methods.RefreshDataGrid(dataGridGrades, "select * from dbo.Show_GradesWithSubject; ");
        }

        private void btnRemoveGrade_Click(object sender, EventArgs e)
        {
            if (dataGridGrades.CurrentCell != null)
            {
                int tmp = Convert.ToInt32(dataGridGrades.CurrentRow.Index);
                int nrIndeks = Convert.ToInt32(dataGridGrades.Rows[tmp].Cells[2].Value);
                int idOceny = db.FindIdGrade(nrIndeks);

                try
                {
                    QueriesTableAdapter tableAdapter = new QueriesTableAdapter();
                    tableAdapter.RemoveGrade(nrIndeks, idOceny);
                    Methods.RefreshDataGrid(dataGridGrades, "select * from dbo.Show_GradesWithSubject; ");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnej oceny");
            }
        }
    }
}
