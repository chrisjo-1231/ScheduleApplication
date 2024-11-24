using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleApplication.Models;

namespace ScheduleApplication.Forms
{
    public partial class UpdateScheduleForm : Form
    {
        private Schedule schedule;

        public event Action<Schedule> ScheduleUpdated;
        public UpdateScheduleForm()
        {
            InitializeComponent();
        }

        public UpdateScheduleForm(Schedule schedule)
        {
            InitializeComponent();
            this.schedule = schedule;

            // Populate the form with the note's data
           txtclassname.Text = schedule.ClassName;
            txtsection.Text = schedule.Section;
           txtcourse.Text = schedule.Course;
            txtroom.Text = schedule.Room;
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            schedule.ClassName = txtclassname.Text;
            schedule.Section = txtsection.Text;
            schedule.Course = txtcourse.Text;
            schedule.Room = txtroom.Text;

            // Trigger the NoteUpdated event
            ScheduleUpdated?.Invoke(schedule);

            // Close the form after updating
            this.DialogResult = DialogResult.OK;
            Close();
        }
    }
}
