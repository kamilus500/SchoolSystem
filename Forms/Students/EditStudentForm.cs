using SchoolSystem.Entities.SchoolDataSetTableAdapters;
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

namespace SchoolSystem.Forms.Students
{
    public partial class EditStudentForm : Form
    {
        private DataGridView dataGridViewStudentsForm;
        public EditStudentForm(DataGridView datagrid)
        {
            InitializeComponent();
            dataGridViewStudentsForm = datagrid;

        }

        private void EditStudentForm_Load(object sender, EventArgs e)
        {
            if (dataGridViewStudentsForm.CurrentRow != null)
            {
                int tmp = Convert.ToInt32(dataGridViewStudentsForm.CurrentRow.Index);
                boxIndexEdit.Text = Convert.ToString(dataGridViewStudentsForm.Rows[tmp].Cells[0].Value);
                boxImieEdit.Text = Convert.ToString(dataGridViewStudentsForm.Rows[tmp].Cells[1].Value);
                boxNazwiskoEdit.Text = Convert.ToString(dataGridViewStudentsForm.Rows[tmp].Cells[2].Value);
                dtPickerStudentEdit.Value = Convert.ToDateTime(dataGridViewStudentsForm.Rows[tmp].Cells[3].Value);
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego studenta z listy.");
            }


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int tmp = Convert.ToInt32(dataGridViewStudentsForm.CurrentRow.Index);
                int actuallyIndex = Convert.ToInt32(dataGridViewStudentsForm.Rows[tmp].Cells[0].Value);
                string tmpIndex = boxIndexEdit.Text;
                int index;
                if (tmpIndex.Equals(""))
                {
                    index = Convert.ToInt32(dataGridViewStudentsForm.Rows[tmp].Cells[0].Value);
                }
                else
                {
                    index = Convert.ToInt32(tmpIndex);
                }
                string imie = boxImieEdit.Text;
                if (imie.Equals(""))
                {
                    imie = null;
                }
                string nazwisko = boxNazwiskoEdit.Text;
                if (nazwisko.Equals(""))
                {
                    nazwisko = null;
                }
                DateTime dataurodzenia = Convert.ToDateTime(dtPickerStudentEdit.Value);
                QueriesTableAdapter tableAdapter = new QueriesTableAdapter();

                tableAdapter.EditStudent(actuallyIndex, index, imie, nazwisko, dataurodzenia);

                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
