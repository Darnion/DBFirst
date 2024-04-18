using DBFirst.Context.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFirst.UI
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            InitControls();
        }

        public void InitControls()
        {
            using(var db = new DBFirstEntities())
            {
                var users = db.Users
                    .Include(x => x.Roles)
                    .Include(x => x.Genders).ToList();
                foreach (var user in users)
                {
                    var control = new UserView(user);
                    control.Parent = flowLayoutPanel1;
                }

                comboBoxGender.Items.Clear();
                comboBoxGender.Items.AddRange(db.Genders.ToArray());
                comboBoxGender.Items.Insert(0, new Genders() {
                    Id = -1,
                    Title = "Все гендеры"
                });
                comboBoxGender.DisplayMember = nameof(Genders.Title);

                comboBoxRole.Items.Clear();
                comboBoxRole.Items.AddRange(db.Roles.ToArray());
                comboBoxRole.Items.Insert(0, new Roles()
                {
                    Id = -1,
                    Title = "Все роли"
                });
                comboBoxRole.DisplayMember = nameof(Roles.Title);

                comboBoxGender.SelectedIndex = 0;
                comboBoxRole.SelectedIndex = 0;
            }
        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            var gender = ((Genders)comboBoxGender.SelectedItem);
            var role = ((Roles)comboBoxRole.SelectedItem);
            if (gender == null || role == null)
            {
                return;
            }
            foreach(var control in flowLayoutPanel1.Controls)
            {
                if (control is UserView userView)
                {
                    var visible = true;

                    if (gender.Id != -1 && userView.User.GenderId != gender.Id)
                    {
                        visible = false;
                    }

                    if (role.Id != -1 && userView.User.RoleId != role.Id)
                    {
                        visible = false;
                    }

                    if (!string.IsNullOrWhiteSpace(textBoxName.Text) && !userView.User.Fullname.Contains(textBoxName.Text))
                    {
                        visible = false;
                    }

                    userView.Visible = visible;
                }
            }
        }

        private void checkBoxDesc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDesc.Checked)
            {
                var list = new List<UserView>(flowLayoutPanel1.Controls.Cast<UserView>().OrderByDescending(x => x.User.Fullname));
                flowLayoutPanel1.Controls.Clear();
                foreach (var item in list)
                {
                    item.Parent = flowLayoutPanel1;
                    item.Visible = true;
                }
            }
            else
            {
                var list = new List<UserView>(flowLayoutPanel1.Controls.Cast<UserView>().OrderBy(x => x.User.Fullname));
                flowLayoutPanel1.Controls.Clear();
                foreach (var item in list)
                {
                    item.Parent = flowLayoutPanel1;
                    item.Visible = true;
                }
            }
            Filter();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
