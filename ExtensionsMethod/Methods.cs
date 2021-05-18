using SchoolSystem.Entities;
using SchoolSystem.Entities.SchoolDataSetTableAdapters;
using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.ExtensionsMethod
{
    public static class Methods
    {
        public static SchoolDataSet db = new SchoolDataSet();
        public static void RefreshDataGrid(DataGridView dataGrid,string query)
        {
            string connectionString = SchoolSystem.Properties.Settings.Default.SchoolConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGrid.DataSource = dt;

            con.Close();
        }

        public static void ShowFormInTabPage(TabControl mainTabControl,TabPage tpTab, Form frm)
        {
            mainTabControl.Controls.Add(tpTab);
            tpTab.Text = frm.Text;
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tpTab.Controls.Add(frm);
            mainTabControl.SelectedTab = tpTab;
        }

        public static List<SubjectModel> LoadSubjects()
        {
            List<SubjectModel> list = new List<SubjectModel>();
            PrzedmiotTableAdapter tableAdapter = new PrzedmiotTableAdapter();

            var tmp2 = tableAdapter.GetData();

            foreach (var item in tmp2)
            {
                list.Add(new SubjectModel { Name = item.Name});
            }

            return list;
        }

        public static string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Icons");
        public const string nameCloseButton = "close_16.png";

    }
}
