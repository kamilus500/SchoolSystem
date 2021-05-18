using SchoolSystem.Entities;
using SchoolSystem.Entities.SchoolDataSetTableAdapters;
using SchoolSystem.Forms;
using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystem.Helpers
{
    public static class Helpers
    {
        public static void createTabPage(this TabControl mainTabControl,string text)
        {
            try
            {
                var tabPage = new TabPage {Text = text};
                mainTabControl.TabPages.Add(tabPage);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public static List<UserModel> LoadUsers(this SchoolDataSet db)
        {
            var usersTable = new UsersTableAdapter();
            var users = usersTable.GetData();

            return users.Select(user => new UserModel() {Login = user.Login, Password = user.Haslo}).ToList();
        }

        public static bool FindUserInDatabase(this List<UserModel> list,UserModel userModel)
        {
            return list.Any(user => user.Login == userModel.Login && user.Password == userModel.Password);
        }

        public static int FindIdSubject(this SchoolDataSet db,string name)
        {
            var tableAdapter = new PrzedmiotTableAdapter();
            var list = tableAdapter.GetData();

            return (from przedmiot in list where przedmiot.Name == name select przedmiot.Id_Przedmiot).FirstOrDefault();
        }

        public static int FindIdGrade(this SchoolDataSet db,int indeks)
        {
            var tableAdapter = new OcenyTableAdapter();
            var list = tableAdapter.GetData();

            return (from ocena in list where ocena.Nr_indeks == indeks select ocena.Id_oceny).FirstOrDefault();
        }

    }
}
