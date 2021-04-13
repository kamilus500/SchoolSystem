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

namespace SchoolSystem.Forms.Teachers
{
    public partial class EditTeacherForm : Form
    {
        public DataGridView dataGridTeachersForm;
        public SchoolDataSet db = new SchoolDataSet();
        private List<SubjectModel> listsOfSubjects = new List<SubjectModel>();
        public EditTeacherForm(DataGridView dataGrid)
        {
            InitializeComponent();
            dataGridTeachersForm = dataGrid;
            listsOfSubjects = Methods.LoadSubjects();
        }

        private void EditTeacherForm_Load(object sender, EventArgs e)
        {

            int tmp = Convert.ToInt32(dataGridTeachersForm.CurrentRow.Index);
            comboBoxSubjects.SelectedItem = dataGridTeachersForm.Rows[tmp].Cells[3].Value.ToString();
            boxImieEdit.Text = dataGridTeachersForm.Rows[tmp].Cells[1].Value.ToString();
            boxNazwiskoEdit.Text = dataGridTeachersForm.Rows[tmp].Cells[2].Value.ToString();

            foreach (var item in listsOfSubjects)
            {
                comboBoxSubjects.Items.Add(item.Name);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int idPrzedmiot;

            int tmp = Convert.ToInt32(dataGridTeachersForm.CurrentRow.Index);
            int idNauczyciala = Convert.ToInt32(dataGridTeachersForm.Rows[tmp].Cells[0].Value);
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
            string przedmiot = string.Empty;
            if(comboBoxSubjects.SelectedItem == null)
            {
                przedmiot = comboBoxSubjects.SelectedItem.ToString();
            }
            if (przedmiot != null)
            {
                idPrzedmiot = db.FindIdSubject(przedmiot);
                if (idPrzedmiot == 0)
                {
                    MessageBox.Show("Nie ma przedmiotu o podanej nazwie");
                }
                else
                {
                    QueriesTableAdapter tableAdapter = new QueriesTableAdapter();

                    try
                    {
                        tableAdapter.EditTeacher(idNauczyciala, idPrzedmiot, imie, nazwisko);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        throw;
                    }
                }
            }

        }
    }
}
