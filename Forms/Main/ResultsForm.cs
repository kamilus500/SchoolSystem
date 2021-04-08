using SchoolSystem.ExtensionsMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.Forms.Main
{
    public partial class ResultsForm : Form
    {
        private static ResultsForm _instance = null;

        public static ResultsForm Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ResultsForm();
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

        public ResultsForm()
        {
            InitializeComponent();
        }

        private void ResultsForm_Load(object sender, EventArgs e)
        {
            this.show_StudentsWithGradesTableAdapter.Fill(this.schoolDataSet.Show_StudentsWithGrades);
        }

        private void ResultsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _instance = null;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Methods.RefreshDataGrid(dataGridAll, "select * from dbo.Show_StudentsWithGrades");
        }
    }
}
