using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScheduleApplication.Data;
using ScheduleApplication.Models;

namespace ScheduleApplication.DAO
{
    public class ScheduleRepository
    {
        private readonly ScheduleDbContext _context;

        public ScheduleRepository(ScheduleDbContext context)
        {
            _context = context;
        }

        public List<Schedule> GetAllSchedule()
        {
            return _context.schedule.ToList(); // Changed NotesItems to Schedules
        }

        public Schedule GetScheduleById(int id)
        {
            return _context.schedule.Find(id); // Changed NotesItems to Schedules
        }

        public void AddSchedule(Schedule schedule)
        {
            _context.schedule.Add(schedule); // Changed NotesItems to Schedules
            _context.SaveChanges();
        }

        public void UpdateSchedule(Schedule schedule)
        {
            _context.schedule.Update(schedule); // Changed NotesItems to Schedules
            _context.SaveChanges();
        }

        public void DeleteSchedule(int id)
        {
            var schedule = _context.schedule.Find(id); // Changed NotesItems to Schedules
            if (schedule != null)
            {
                _context.schedule.Remove(schedule); // Changed NotesItems to Schedules
                _context.SaveChanges();
            }
        }

    }
}