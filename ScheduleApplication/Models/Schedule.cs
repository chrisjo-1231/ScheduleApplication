using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleApplication.Models
{
    public class Schedule
    {
        internal object createdDate;

        public int Id { get; set; }
        public string ClassName { get; set; }
        public string Section { get; set; }
        public string Course { get; set; }
        public string Room { get; set; }

        public DateTime Time { get; set; }

        public DateTime UpdatedDate
        {
            get; set;
        }
    }
}
