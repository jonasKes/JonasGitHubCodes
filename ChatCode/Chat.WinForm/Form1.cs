using DataLayer;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DataLayer.Migrations;

namespace Chat.WinForm
{
    public partial class Form1 : Form
    {
        private Context context = new Context();
        public Form1()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Configuration>());
            //Database.SetInitializer<Context>(null);
            InitializeComponent();
            LoadDB();
            boxUser.DataSource = context.Users.ToList();
           
        }

        public void LoadDB()
        {
            using (Context context = new Context())
            {
                User newPerson = new User
             {
                 UserName = "hello",
                 FirstName = "He",
                 LastName = "Llo",
                 Password = "123",
             };
                context.Users.Add(newPerson);
                context.SaveChanges();
            }

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    bool UserExists = context.Users.FirstOrDefault(UserExists.)
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //     bool UserExists = context.Users.FirstOrDefault(users => user.UserName)

        //    foreach (var user in context.Users)
        //    {

        //        if  textBoxUserName.Text == person.UserName && textBoxPassword.Text == person.Password)
        //        {

        //            MessageBox.Show("Gratz Man");
        //            break;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Wrong Dude!");
        //            break;
        //        }
        // }
        //}
    }
}
