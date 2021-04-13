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
    public partial class AddTeacherForm : Form
    {
        public SchoolDataSet db = new SchoolDataSet();
        private List<SubjectModel> listsOfSubjects = new List<SubjectModel>();
        public AddTeacherForm()
        {
            InitializeComponent();
            listsOfSubjects = Methods.LoadSubjects();
        }
        private void AddTeacherForm_Load(object sender, EventArgs e)
        {
            foreach (var item in listsOfSubjects)
            {
                comboxSubjects.Items.Add(item.Name);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (boxImie.Text != "" || boxNazwisko.Text != "" || comboxSubjects.SelectedItem != null)
            {
                try
                {
                    string przedmiot = comboxSubjects.SelectedItem.ToString();
                    int id = db.FindIdSubject(przedmiot);
                    string imie = boxImie.Text;
                    string nazwisko = boxNazwisko.Text;
                    if (imie == "" && nazwisko == "" && przedmiot == "")
                    {
                        MessageBox.Show("Proszę wypełnić wymagane pola");
                    }
                    else if (id == 0)
                    {
                        MessageBox.Show("Nie ma przedmiotu o takiej nazwie.");
                    }
                    else if (imie == "" && nazwisko == "")
                    {
                        MessageBox.Show("Proszę podać imię oraz nazwisko nauczyciela.");
                    }
                    else
                    {
                        QueriesTableAdapter tableAdapter = new QueriesTableAdapter();
                        tableAdapter.AddTeacher(id, imie, nazwisko);

                        this.Close();
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
                MessageBox.Show("Proszę wypełnić podane pola.");
            }
        }
    }
}
