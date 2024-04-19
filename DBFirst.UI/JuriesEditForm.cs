using DBFirst.Context.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DBFirst.UI
{
    public partial class JuriesEditForm : Form
    {
        private string photoUrl = null;
        public JuriesEditForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            labelEvent.Visible = comboBoxActivity.Visible = checkBox1.Checked;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "materials", Path.GetFileName(openFileDialog1.FileName));

                if (openFileDialog1.FileName != path)
                {
                    File.Copy(openFileDialog1.FileName, path, true);
                }

                pictureBox1.Image = Image.FromFile(path);
                photoUrl = Path.GetFileName(openFileDialog1.FileName);
            }
        }

        private void JuriesEditForm_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now.AddYears(-18);
            dateTimePicker1.MinDate = DateTime.Now.AddYears(-100);
            using (var db = new DBFirstEntities())
            {
                comboBoxCountry.Items.Clear();
                comboBoxCountry.Items.AddRange(db.Countries.ToArray());
                comboBoxCountry.DisplayMember = nameof(Countries.Title);
                comboBoxCountry.SelectedIndex = 0;

                comboBoxGender.Items.Clear();
                comboBoxGender.Items.AddRange(db.Genders.ToArray());
                comboBoxGender.DisplayMember = nameof(Genders.Title);
                comboBoxGender.SelectedIndex = 0;

                comboBoxRole.Items.Clear();
                comboBoxRole.Items.AddRange(db.Roles.Where(x => x.Id == 3 || x.Id == 5).ToArray());
                comboBoxRole.DisplayMember = nameof(Roles.Title);
                comboBoxRole.SelectedIndex = 0;

                comboBoxDirection.Items.Clear();
                comboBoxDirection.Items.AddRange(db.Directions.ToArray());
                comboBoxDirection.DisplayMember = nameof(Directions.Title);
                comboBoxDirection.SelectedIndex = 0;

                comboBoxActivity.Items.Clear();
                comboBoxActivity.Items.AddRange(db.Activities.ToArray());
                comboBoxActivity.DisplayMember = nameof(Activities.Title);
                comboBoxActivity.SelectedIndex = 0;

                textBox1.Text = db.Users.Max(x => x.Id + 1).ToString();
            }
        }

        private void checkBoxPasswordVisible_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPasswordRepeat.UseSystemPasswordChar = textBoxPassword.UseSystemPasswordChar = !checkBoxPasswordVisible.Checked;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = !string.IsNullOrEmpty(textBox2.Text) 
                && !string.IsNullOrEmpty(textBox3.Text) 
                && maskedTextBox1.MaskFull;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text != textBoxPasswordRepeat.Text)
            {
                MessageBox.Show("Пароли не совпадают");
                return;
            }

            var regEx = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{6,15}$");

            if (!regEx.IsMatch(textBoxPassword.Text))
            {
                MessageBox.Show("Пароль не соответствует условиям");
                return;
            }

            var user = new Users()
            {
                Fullname = textBox2.Text,
                Email = textBox3.Text,
                BirthDate = dateTimePicker1.Value,
                CountryId = ((Countries)comboBoxCountry.SelectedItem).Id,
                GenderId = ((Genders)comboBoxGender.SelectedItem).Id,
                RoleId = ((Roles)comboBoxRole.SelectedItem).Id,
                DirectionId = ((Directions)comboBoxDirection.SelectedItem).Id,
                PhoneNumber = maskedTextBox1.Text,
                Password = textBoxPassword.Text,
                ImagePath = photoUrl,
            };

            using(var db = new DBFirstEntities())
            {
                db.Users.Add(user);
                db.SaveChanges();

                if (checkBox1.Checked)
                {
                    var activity = db.Activities.Include(x => x.Users1).FirstOrDefault(x => x.Id == ((Activities)comboBoxActivity.SelectedItem).Id);
                    if (activity != null)
                    {
                        var userDB = db.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);
                        if (((Roles)comboBoxRole.SelectedItem).Id == 3)
                        {
                            activity.ModeratorId = userDB.Id;
                        }
                        else
                        {
                            activity.Users1.Add(userDB);
                        }

                        db.SaveChanges();
                    }
                }
                else
                {

                }
            }

            Close();
        }
    }
}
