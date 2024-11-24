using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleApplication.Models;
using ScheduleApplication.Services;

using ScheduleApplication.DAO;


namespace ScheduleApplication.Controllers
{
    public class ScheduleControllers
    {
        private readonly ScheduleServices _scheduleServices;

        public ScheduleControllers(ScheduleServices scheduleServices)
        {
            _scheduleServices = scheduleServices;
        }
        public List<Schedule> GetAllSchedule()
        {
            return _scheduleServices.GetAllSchedule();
        }

        public Schedule GetScheduleById(int id)
        {
            return _scheduleServices.GetScheduleById(id);
        }

        public void AddSchedule(string ClassName, string Section, string Course, string Room , DateTime Time)
        {
            var schedule = new Schedule
            {
                ClassName = ClassName,
                Section = Section,
                Course = Course,
                Room = Room,
                Time =  Time
        
            };
            _scheduleServices.AddSchedule(schedule);
        }

        public void UpdateSchedule(Schedule updatedSchedule)
        {
            var schedule = _scheduleServices.GetScheduleById(updatedSchedule.Id);
            if (schedule != null)
            {
                schedule.ClassName = updatedSchedule.ClassName;
                schedule.Section = updatedSchedule.Section;
                schedule.Course = updatedSchedule.Course;
                schedule.Room = updatedSchedule.Room;
                schedule.Time = updatedSchedule.Time;
                _scheduleServices.UpdateNotes(schedule);
            }
        }




        public void DeleteNotes(int id)
        {
            _scheduleServices.DeleteNotes(id);
        }
    }
}

