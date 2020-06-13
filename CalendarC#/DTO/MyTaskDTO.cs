using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MyTaskDTO
    {

        public int TaskId { get; set; }
        public int UserId { get; set; }
        public string TaskTitle { get; set; }
        public string TaskContent { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public System.TimeSpan AdvanceAlertTime { get; set; }
        public int TaskTypeId { get; set; }

    }
}
