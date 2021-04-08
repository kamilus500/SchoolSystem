
using SchoolSystem.Entities;
using SchoolSystem.Entities.SchoolDataSetTableAdapters;
using SchoolSystem.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.Forms.Grades
{
    public partial class AddGradeForm : Form
    {
        public SchoolDataSet db = new SchoolDataSet();
        public AddGradeForm()
        {
            InitializeComponent();
        }

        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            this.studentTableAdapter1.Fill(this.schoolDataSet1.Student);
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(dgStudentsInGrades.CurrentRow != null)
            {
                try
                {
                    int tmp = Convert.ToInt32(dgStudentsInGrades.CurrentRow.Index);
                    int nrIndeks = Convert.ToInt32(dgStudentsInGrades.Rows[tmp].Cells[0].Value);
                    int grade = Convert.ToInt32(boxGrade.Text);

                    if (boxPrzedmiot.Text == "")
                    {
                        MessageBox.Show("Proszę podać nazwę przedmiotu");
                    }
                    else
                    {
                        int idPrzedmiot = db.FindIdSubject(boxPrzedmiot.Text);
                        if (idPrzedmiot == 0)
                        {
                            MessageBox.Show("Nie ma przedmiotu o takiej nazwie");
                        }
                        else
                        {
                            QueriesTableAdapter tableAdapter = new QueriesTableAdapter();
                            tableAdapter.AddGrade(idPrzedmiot, nrIndeks, grade);
                            this.Close();

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Nie wybrano żadnego studenta.");
            }
        }
    }
}
