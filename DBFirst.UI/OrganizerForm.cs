using DBFirst.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirst.UI
{
    public partial class OrganizerForm : Form
    {
        public OrganizerForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if(CurrentUser.User.ImagePath != null)
            {
                try
                {
                    var url = Path.Combine("materials", CurrentUser.User.ImagePath);
                    pictureBox1.Image = Image.FromFile(url);
                }
                catch
                {

                }
            }

            var hour = DateTime.Now.Hour;

            if (hour >= 9 && hour < 11)
            {
                labelHello.Text = "Доброе утро!";
            }
            else if (hour >= 11 && hour < 18)
            {
                labelHello.Text = "Добрый день!";
            }
            else if (hour >= 18 && hour < 24)
            {
                labelHello.Text = "Добрый вечер!";
            }

            labelFullname.Text = CurrentUser.User.Genders.Title == "мужской"
                ? "Мистер "
                : "Миссис ";
            labelFullname.Text += CurrentUser.User.Fullname;
        }

        private void buttonJuries_Click(object sender, EventArgs e)
        {
            var juriesEditForm = new JuriesEditForm();
            juriesEditForm.Show();
            juriesEditForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            this.Hide();
        }

        private void buttonEvents_Click(object sender, EventArgs e)
        {

        }

        private void buttonParticipants_Click(object sender, EventArgs e)
        {
            var usersForm = new UsersForm();
            usersForm.Show();
            usersForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            this.Hide();
        }
    }
}
