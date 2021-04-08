using SchoolSystem.Entities.SchoolDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.Forms.Subjects
{
    public partial class AddSubjectForm : Form
    {
        public AddSubjectForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {            
            string nazwa = boxName.Text;
            if(nazwa == "")
            {
                MessageBox.Show("Proszę wpisać nazwę przedmiotu");
            }
            else
            {
                try
                {
                    QueriesTableAdapter tableAdapter = new QueriesTableAdapter();
                    tableAdapter.AddSubject(nazwa);
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
