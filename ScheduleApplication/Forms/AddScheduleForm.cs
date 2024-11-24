using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleApplication.Controllers;
using ScheduleApplication.DAO;
using ScheduleApplication.Models;
using ScheduleApplication.Services;
using ScheduleApplication.Data;
using ScheduleApplication.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ScheduleApplication.Forms
{
    public partial class AddScheduleForm : Form
    {
        private readonly ScheduleControllers _scheduleController;
        private DateTime createdDate;

        public event Action ScheduleAdded;

        public AddScheduleForm()
        {
            InitializeComponent();
            var context = new ScheduleDbContext();
            var notesRepository = new ScheduleRepository(context);
            var notesServices = new ScheduleServices(notesRepository);
            _scheduleController = new ScheduleControllers(notesServices);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string classname = txtClassName.Text;
            string section = txtSection.Text;
            string course = txtCourse.Text;
            string room = txtroom.Text;
            DateTime createdDate = DateTime.Now;

            _scheduleController.AddSchedule(classname, section, course, room, createdDate);

            MessageBox.Show("Added Successfully", "Information");

            ScheduleAdded?.Invoke();
            this.Close();
        }
    }
}
