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
                TabPage tabPage = new TabPage();
                tabPage.Text = text;
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
            List<UserModel> listsOfUsers = new List<UserModel>();
            UsersTableAdapter usersTable = new UsersTableAdapter();
            var users = usersTable.GetData();

            foreach (var user in users)
            {
                UserModel tmp = new UserModel() { Login = user.Login, Password = user.Haslo };
                listsOfUsers.Add(tmp);
            }

            return listsOfUsers;
        }

        public static bool FindUserInDatabase(this List<UserModel> list,UserModel userModel)
        {
            foreach (var user in list)
            {
                if (user.Login == userModel.Login && user.Password == userModel.Password)
                {
                    return true;
                }
            }
            return false;
        }

        public static int FindIdSubject(this SchoolDataSet db,string name)
        {
            PrzedmiotTableAdapter tableAdapter = new PrzedmiotTableAdapter();
            var list = tableAdapter.GetData();

            foreach (var przedmiot in list)
            {
                if(przedmiot.Name == name)
                {
                    return przedmiot.Id_Przedmiot;
                }
            }
            return 0;
        }

        public static int FindIdGrade(this SchoolDataSet db,int indeks)
        {
            OcenyTableAdapter tableAdapter = new OcenyTableAdapter();
            var list = tableAdapter.GetData();

            foreach (var ocena in list)
            {
                if(ocena.Nr_indeks == indeks )
                {
                    return ocena.Id_oceny;
                }
            }
            return 0;
        }

    }
}
