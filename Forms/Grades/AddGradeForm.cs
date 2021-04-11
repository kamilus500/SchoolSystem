
using SchoolSystem.Entities;
using SchoolSystem.Entities.SchoolDataSetTableAdapters;
using SchoolSystem.ExtensionsMethod;
using SchoolSystem.Helpers;
using SchoolSystem.Models;
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
        public List<SubjectModel> listsOfSubjects = new List<SubjectModel>(); 

        public AddGradeForm()
        {
            InitializeComponent();
            listsOfSubjects = Methods.LoadSubjects();
        }

        private void AddGradeForm_Load(object sender, EventArgs e)
        {
            this.studentTableAdapter1.Fill(this.schoolDataSet1.Student);
            foreach (var item in listsOfSubjects)
            {
                comboBoxofSubjects.Items.Add(item.Name);
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if(dgStudentsInGrades.CurrentRow != null)
            {
                try
                {
                    int tmp = Convert.ToInt32(dgStudentsInGrades.CurrentRow.Index);
                    int nrIndeks = Convert.ToInt32(dgStudentsInGrades.Rows[tmp].Cells[0].Value);
                    string stringGrade = boxGrade.Text;

                    if (boxGrade.Text == "")
                    {
                        MessageBox.Show("Proszę wpisać ocenę.");
                    }
                    else if (comboBoxofSubjects.SelectedItem == null)
                    {
                        MessageBox.Show("Proszę wybrać przedmiot");
                    }
                    else
                    {
                        int intGrade = Convert.ToInt32(stringGrade);
                        int idPrzedmiot = db.FindIdSubject(comboBoxofSubjects.SelectedItem.ToString());
                        if (idPrzedmiot == 0)
                        {
                            MessageBox.Show("Nie ma przedmiotu o takiej nazwie");
                        }
                        else
                        {
                            QueriesTableAdapter tableAdapter = new QueriesTableAdapter();
                            tableAdapter.AddGrade(idPrzedmiot, nrIndeks, intGrade);
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
