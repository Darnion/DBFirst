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
    public partial class UserView : UserControl
    {
        public Users User { get; set; }
        public UserView(Users user)
        {
            InitializeComponent();
            this.User = user;
            Initialize(user);
        }

        public void Initialize(Users user)
        {
            labelEmail.Text = user.Email;
            labelPassword.Text = user.Password;
            labelFullname.Text = user.Fullname;
            labelGender.Text = user.Genders.Title;
            labelRole.Text = user.Roles.Title;
            if (user.ImagePath != null)
            {
                var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "materials", user.ImagePath);

                if (File.Exists(path))
                {
                    pictureBox1.Image = Image.FromFile(path);
                }
                else 
                { 
                    pictureBox1.Image = Properties.Resources.image; 
                }
                
            }
        }
    }
}
