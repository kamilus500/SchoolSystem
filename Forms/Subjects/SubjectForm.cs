using SchoolSystem.Entities;
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

namespace SchoolSystem.Forms.Subjects
{
    public partial class SubjectForm : Form
    {
        private static SubjectForm _instance = null;
        private SchoolDataSet db = new SchoolDataSet();

        public static SubjectForm Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SubjectForm();
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

        public SubjectForm()
        {
            InitializeComponent();
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            this.show_SubjectsTableAdapter.Fill(this.schoolDataSet.Show_Subjects);
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            AddSubjectForm form = new AddSubjectForm();
            form.ShowDialog();
            Methods.RefreshDataGrid(dataGridSubjects, "select * from dbo.Show_Subjects");

        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (dataGridSubjects.CurrentRow != null)
            {
                int tmp = Convert.ToInt32(dataGridSubjects.CurrentRow.Index);
                string nazwa = Convert.ToString(dataGridSubjects.Rows[tmp].Cells[0].Value);

                try
                {
                    QueriesTableAdapter tableAdapter = new QueriesTableAdapter();
                    tableAdapter.RemoveSubject(nazwa);
                    Methods.RefreshDataGrid(dataGridSubjects, "select * from dbo.Show_Subjects");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego przedmiotu.");
            }
        }

        private void SubjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }
    }
}
