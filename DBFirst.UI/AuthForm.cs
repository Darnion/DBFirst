using DBFirst.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirst.UI
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {
            buttonEntrance.Enabled = !string.IsNullOrEmpty(textBoxLogin.Text)
                && !string.IsNullOrEmpty(textBoxPassword.Text);
        }

        private void buttonEntrance_Click(object sender, EventArgs e)
        {
            using(var db = new DBFirstEntities())
            {
                var user = db.Users.Include(x => x.Genders).Include(x => x.Roles).FirstOrDefault(x => x.Email == textBoxLogin.Text
                && x.Password == textBoxPassword.Text);

                if (user == null)
                {
                    MessageBox.Show("Wrong");
                }
                else if (user.RoleId == 4)
                {
                    var organizerForm = new OrganizerForm();
                    CurrentUser.User = user;
                    organizerForm.Show();
                    organizerForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
                    this.Hide();
                }
            }
        }
    }
}
