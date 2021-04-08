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

namespace SchoolSystem.Forms.Teachers
{
    public partial class AddTeacherForm : Form
    {
        public SchoolDataSet db = new SchoolDataSet();
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string przedmiot = boxPrzedmiot.Text;
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
