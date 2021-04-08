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
using SchoolSystem.Entities;
using SchoolSystem.ExtensionsMethod;
using SchoolSystem.Forms;
using SchoolSystem.Forms.Grades;
using SchoolSystem.Forms.Main;
using SchoolSystem.Forms.Subjects;
using SchoolSystem.Forms.Teachers;
using SchoolSystem.Helpers;
using SchoolSystem.Models;

namespace SchoolSystem
{
    public partial class MainForm : Form
    { 
        public bool IsLogin = false;
        public SchoolDataSet db = new SchoolDataSet();
        public List<UserModel> listOfUsers = new List<UserModel>();

        private TabPage _tpStudents;
        private TabPage _tpTeachers;
        private TabPage _tpGrades;
        private TabPage _tpSubjects;
        private TabPage _tpAll;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            listOfUsers = db.LoadUsers();
            btnStudents.Enabled = false;
            btnSubjects.Enabled = false;
            btnGrades.Enabled = false;
            btnTeachers.Enabled = false;
            btnAll.Enabled = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserModel user = new UserModel() { Login = loginBox.Text, Password = PasswordBox.Text };
            bool result = listOfUsers.FindUserInDatabase(user);

            if (result)
            {
                IsLogin = true;
                statusLogin.Text = "Zalogowany";
                statusLogin.ForeColor = Color.Green;
                loginBox.Text = string.Empty;
                PasswordBox.Text = string.Empty;
                btnStudents.Enabled = true;
                btnSubjects.Enabled = true;
                btnGrades.Enabled = true;
                btnTeachers.Enabled = true;
                btnAll.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nie znaleziono użytkownika.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (IsLogin != false)
            {
                IsLogin = false;
                statusLogin.Text = "Nie Zalogowany";
                statusLogin.ForeColor = Color.Black;
                btnStudents.Enabled = false;
                btnSubjects.Enabled = false;
                btnGrades.Enabled = false;
                btnTeachers.Enabled = false;
                btnAll.Enabled = false;
                mainTabControl.TabPages.Clear();
            }

        }

        private void btnStudents_Click(object sender, EventArgs e)
        {

            if (StudentsForm.IsNull)
            {
                _tpStudents = new TabPage();
                Methods.ShowFormInTabPage(mainTabControl, _tpStudents, StudentsForm.Instance);
            }
            else
            {
                mainTabControl.SelectedTab = _tpStudents;
            }
        }

        private void btnTeachers_Click(object sender, EventArgs e)
        {
            if(TeachersForm.IsNull)
            {
                _tpTeachers = new TabPage();
                Methods.ShowFormInTabPage(mainTabControl, _tpTeachers, TeachersForm.Instance);
            }
            else
            {
                mainTabControl.SelectedTab = _tpTeachers;
            }
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            if(GradesForm.IsNull)
            {
                _tpGrades = new TabPage();
                Methods.ShowFormInTabPage(mainTabControl, _tpGrades, GradesForm.Instance);
            }
            else
            {
                mainTabControl.SelectedTab = _tpGrades;
            }
        }

        private void btnSubjects_Click(object sender, EventArgs e)
        {
            if(SubjectForm.IsNull)
            {
                _tpSubjects = new TabPage();
                Methods.ShowFormInTabPage(mainTabControl,_tpSubjects, SubjectForm.Instance);
            }
            else
            {
                mainTabControl.SelectedTab = _tpSubjects;
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if(ResultsForm.IsNull)
            {
                _tpAll = new TabPage();
                Methods.ShowFormInTabPage(mainTabControl, _tpAll, ResultsForm.Instance);
            }
            else
            {
                mainTabControl.SelectedTab = _tpAll;
            }
        }

        private void mainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                var tabPage = this.mainTabControl.TabPages[e.Index];
                var tabRect = this.mainTabControl.GetTabRect(e.Index);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{Methods.filePath}\\{Methods.nameCloseButton}");
                e.Graphics.DrawImage(closeImage,
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2);
                TextRenderer.DrawText(e.Graphics, tabPage.Text, tabPage.Font,
                        tabRect, tabPage.ForeColor, TextFormatFlags.Left);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void mainTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = 0; i < this.mainTabControl.TabPages.Count; i++)
            {
                var tabRect = this.mainTabControl.GetTabRect(i);
                tabRect.Inflate(-2, -2);
                var closeImage = new Bitmap($"{Methods.filePath}\\{Methods.nameCloseButton}");
                var imageRect = new Rectangle(
                    (tabRect.Right - closeImage.Width),
                    tabRect.Top + (tabRect.Height - closeImage.Height) / 2,
                    closeImage.Width,
                    closeImage.Height);
                if (imageRect.Contains(e.Location))
                {
                    var frm = mainTabControl.TabPages[i].Controls[0] as Form;
                    frm.Close();

                    this.mainTabControl.TabPages.RemoveAt(i);
                    break;
                }
            }

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(IsLogin == true)
            {
                MessageBox.Show("Aby zamknąć aplikację należy się najpierw wylogować.");
                e.Cancel = true;
            }
        }
    }
}
