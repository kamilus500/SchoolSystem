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
        public static void RefreshDataGrid(DataGridView dataGrid,string query)
        {

            string connectionString = SchoolSystem.Properties.Settings.Default.SchoolConnectionString.ToString();
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

        public static string filePath = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Icons");
        public const string nameCloseButton = "close_16.png";

    }
}
