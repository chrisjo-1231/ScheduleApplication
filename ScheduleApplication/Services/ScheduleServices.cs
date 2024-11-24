using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleApplication.DAO;
using ScheduleApplication.Models;
namespace ScheduleApplication.Services
{
    public class ScheduleServices
    {
        private readonly ScheduleRepository _scheduleRepository;
        public ScheduleServices(ScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public List<Schedule> GetAllSchedule()
        {
            return _scheduleRepository.GetAllSchedule();
        }
        public Schedule GetScheduleById(int id)
        {
            return _scheduleRepository.GetScheduleById(id);
        }
        public void AddSchedule(Schedule Schedule)
        {
            _scheduleRepository.AddSchedule(Schedule);
        }
        public void DeleteNotes(int id)
        {
            _scheduleRepository.DeleteSchedule(id);
        }
        public void UpdateNotes(Schedule Schedule)
        { 
            _scheduleRepository.UpdateSchedule(Schedule);
        }
    }
}

