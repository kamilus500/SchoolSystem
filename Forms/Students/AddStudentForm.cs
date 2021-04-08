using SchoolSystem.Entities;
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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(boxIndex.Text);
                string firstName = boxImie.Text;
                string lastName = boxNazwisko.Text;
                DateTime date = dtPickerStudent.Value;
                QueriesTableAdapter tableAdapter = new QueriesTableAdapter();
                tableAdapter.AddStudent(index, firstName, lastName, date);

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }
    }
}
