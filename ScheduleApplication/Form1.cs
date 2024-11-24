using ScheduleApplication.Controllers;
using ScheduleApplication.DAO;
using ScheduleApplication.Models;
using ScheduleApplication.Services;
using ScheduleApplication.Data;
using ScheduleApplication.Forms;




namespace ScheduleApplication
{
    public partial class Form1 : Form
    {
        public readonly ScheduleControllers _scheduleControllers;
        public Form1()
        {
            InitializeComponent();
            var context = new ScheduleDbContext();
            var scheduleRepository = new ScheduleRepository(context);
            var scheduleServices = new ScheduleServices(scheduleRepository);
            _scheduleControllers = new ScheduleControllers(scheduleServices);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSchedule();
        }

        private void LoadSchedule()
        {
            panelSchedule.Controls.Clear();
            panelSchedule.AutoScroll = true;   // Enable scrolling if the content overflows
            panelSchedule.Size = new Size(this.ClientSize.Width - 40, this.ClientSize.Height - 100); // Dynamic width & height
            panelSchedule.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

            var schedules = _scheduleControllers.GetAllSchedule();
            foreach (var schedule in schedules)
            {
                AddScheduleCard(schedule);
            }
        }
        private void AddScheduleCard(Schedule schedule)
        {
            // Define a modern color palette
            Color cardBackgroundColor = Color.FromArgb(33, 150, 243); // Light blue
            Color titleColor = Color.FromArgb(255, 255, 255); // White
            Color contentColor = Color.FromArgb(230, 230, 230); // Light gray for content
            Color dateColor = Color.FromArgb(200, 200, 200); // Slightly darker gray for date
            Color actionColor = Color.FromArgb(244, 67, 54); // Red for delete, Gold for edit
            Color buttonBackgroundColor = Color.FromArgb(0, 123, 255); // Darker blue for button
            Color buttonTextColor = Color.White; // White text for button

            // Card Panel setup
            var cardPanel = new Panel
            {
                Size = new Size(370, 160),
                BackColor = cardBackgroundColor,
                Margin = new Padding(10),
                Padding = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Delete Icon
            var deleteIcon = new Label
            {
                Text = "✖",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = actionColor,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 30, 5),
                AutoSize = true
            };
            deleteIcon.Click += (sender, e) => DeleteSchedule(schedule);
            cardPanel.Controls.Add(deleteIcon);

            // Edit Icon
            var editIcon = new Label
            {
                Text = "✏",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.Gold,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 60, 5),
                AutoSize = true
            };
            editIcon.Click += (sender, e) => UpdateSchedule (schedule);
            cardPanel.Controls.Add(editIcon);

            // Title Label
            var ClassNameLabel = new Label
            {
                Text = schedule.ClassName,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = titleColor,
                Location = new Point(10, 10),
                AutoSize = true
            };
            cardPanel.Controls.Add(ClassNameLabel);

            // Content Label
            var SectionLabel = new Label
            {
                Text = schedule.Section,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = contentColor,
                Location = new Point(10, 40),
                Size = new Size(350, 50),
                AutoSize = false
            };
            cardPanel.Controls.Add(SectionLabel);

            var CourseLabel = new Label
            {
                Text = schedule.Course,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = contentColor,
                Location = new Point(10, 40),
                Size = new Size(350, 50),
                AutoSize = false
            };
            cardPanel.Controls.Add(CourseLabel);

            var RoomLabel = new Label
            {
                Text = schedule.Room,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                ForeColor = contentColor,
                Location = new Point(10, 40),
                Size = new Size(350, 50),
                AutoSize = false
            };
            cardPanel.Controls.Add(RoomLabel);
           
            // Date Label
            var dateLabel = new Label
            {
                Text = schedule.UpdatedDate != default(DateTime)
            ? $"Last updated on: {schedule.UpdatedDate:MMMM dd, yyyy hh:mm tt}"
            : $"Added on: {schedule.createdDate:MMMM dd, yyyy hh:mm tt}",
                Font = new Font("Segoe UI", 9, FontStyle.Italic),
                ForeColor = Color.White,
                Location = new Point(10, 90),
                AutoSize = true
            };
            cardPanel.Controls.Add(dateLabel);

            // View Details Button
            var viewDetailsButton = new Button
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = buttonBackgroundColor,
                ForeColor = buttonTextColor,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(100, 30),
                Location = new Point(cardPanel.Width - 120, cardPanel.Height - 40)
            };
            viewDetailsButton.FlatAppearance.BorderSize = 0;
            viewDetailsButton.Click += (sender, e) => ShowScheduleDetails(schedule);
            cardPanel.Controls.Add(viewDetailsButton);

            panelSchedule.Controls.Add(cardPanel);
        }






        private void ShowScheduleDetails(Schedule schedule)
        {
            string details = $"Class Name: {schedule.ClassName}\n\n" +
                   $"Section: {schedule.Section}\n\n" +
                   $"Course: {schedule.Course}\n\n" +
                   $"Room: {schedule.Room}\n\n" +
                   $"Time: {schedule.Time:MMMM dd, yyyy hh:mm tt}";

            MessageBox.Show(details, "Schedule Details", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void UpdateSchedule(Schedule schedule)
        {
            var updateScheduleForm = new UpdateScheduleForm(schedule);


            updateScheduleForm.ScheduleUpdated += (updatedSchedule) =>
            {

                _scheduleControllers.UpdateSchedule(updatedSchedule);
                LoadSchedule();
                MessageBox.Show("Note updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            updateScheduleForm.ShowDialog();
        }


        private void DeleteSchedule(Schedule schedule) 
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete {schedule.ClassName}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _scheduleControllers.DeleteNotes(schedule.Id);
                LoadSchedule();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addScheduleForm = new AddScheduleForm();
            addScheduleForm.ScheduleAdded += LoadSchedule;
            addScheduleForm.ShowDialog();
        }
    }
}
