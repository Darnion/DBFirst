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
    public partial class EventsForm : Form
    {
        public EventsForm()
        {
            InitializeComponent();
            dataGridView.AutoGenerateColumns = false;
        }

        private void authToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var authForm = new AuthForm();
            authForm.Show();
            authForm.FormClosed += (object s, FormClosedEventArgs ev) => { this.Show(); };
            this.Hide();
        }

        private void EventsForm_Load(object sender, EventArgs e)
        {
            using (var db = new DBFirstEntities())
            {
                //dataGridView.DataSource = db.Activities.ToList().Join(db.Users, a => a.ModeratorId, u => u.Id, (a, u) => new { a, u })
                //    .Join(db.Events, au => au.a.EventId, ev => ev.Id, (au, ev) => new { au, ev })
                //    .Join(db.Directions, aue => aue.au.u.DirectionId, d => d.Id, (aue, d) => new {
                //        Title = aue.au.a.Title,
                //        Direction = d.Title,
                //        StartDate = aue.ev.StartDate.AddDays(aue.au.a.DayNumber - 1),
                //    }).ToList();

                comboBoxDirection.Items.Clear();
                comboBoxDirection.Items.AddRange(db.Directions.ToArray());
                comboBoxDirection.DisplayMember = nameof(Directions.Title);
                comboBoxDirection.Items.Insert(0, new Directions()
                {
                    Id = -1,
                    Title = "Все типы",
                });
                comboBoxDirection.SelectedIndex = 0;

                monthCalendar.MinDate = db.Events.Min(x => x.StartDate).UtcDateTime;
                monthCalendar.MaxDate = db.Events.Max(x => x.StartDate).UtcDateTime;
                monthCalendar.SelectionStart = monthCalendar.MinDate;
                monthCalendar.SelectionEnd = monthCalendar.MaxDate;

                FilterCancel();
            }
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            using (var db = new DBFirstEntities())
            {
                //dataGridView.DataSource = db.Activities.ToList().Join(db.Users, a => a.ModeratorId, u => u.Id, (a, u) => new { a, u })
                //    .Join(db.Events, au => au.a.EventId, ev => ev.Id, (au, ev) => new { au, ev })
                //    .Join(db.Directions, aue => aue.au.u.DirectionId, d => d.Id, (aue, d) => new {
                //        Title = aue.au.a.Title,
                //        Direction = d.Title,
                //        StartDate = aue.ev.StartDate.AddDays(aue.au.a.DayNumber - 1)
                //    }).Where(x => x.StartDate >= monthCalendar.SelectionStart && x.StartDate <= monthCalendar.SelectionEnd).ToList();

                if (((Directions)comboBoxDirection.SelectedItem).Id == -1)
                {
                    dataGridView.DataSource = db.Activities.ToList().Select(x => new
                    {
                        Title = x.Title,
                        Direction = db.Directions.FirstOrDefault(y => y.Id == db.Users.FirstOrDefault(z => z.Id == x.ModeratorId).DirectionId).Title,
                        StartDate = db.Events.FirstOrDefault(y => y.Id == x.EventId).StartDate.AddDays(x.DayNumber - 1),
                    }).Where(x => x.StartDate >= monthCalendar.SelectionStart
                    && x.StartDate <= monthCalendar.SelectionEnd).ToList();
                }
                else
                {
                    dataGridView.DataSource = db.Activities.ToList().Select(x => new
                    {
                        Title = x.Title,
                        Direction = db.Directions.FirstOrDefault(y => y.Id == db.Users.FirstOrDefault(z => z.Id == x.ModeratorId).DirectionId).Title,
                        StartDate = db.Events.FirstOrDefault(y => y.Id == x.EventId).StartDate.AddDays(x.DayNumber - 1),
                    }).Where(x => x.StartDate >= monthCalendar.SelectionStart
                    && x.StartDate <= monthCalendar.SelectionEnd
                    && x.Direction == ((Directions)comboBoxDirection.SelectedItem).Title).ToList();
                }
            }
        }

        private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void buttonFilterCancel_Click(object sender, EventArgs e)
        {
            FilterCancel();
        }

        private void FilterCancel()
        {
            comboBoxDirection.SelectedIndex = 0;
            monthCalendar.SelectionStart = monthCalendar.MinDate;
            monthCalendar.SelectionEnd = monthCalendar.MaxDate;

            using (var db = new DBFirstEntities())
            {
                dataGridView.DataSource = db.Activities.ToList().Select(x => new
                {
                    Title = x.Title,
                    Direction = db.Directions.FirstOrDefault(y => y.Id == db.Users.FirstOrDefault(z => z.Id == x.ModeratorId).DirectionId).Title,
                    StartDate = db.Events.FirstOrDefault(y => y.Id == x.EventId).StartDate.AddDays(x.DayNumber - 1),
                }).ToList();
            }
        }
    }
}
