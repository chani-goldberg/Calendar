using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MyMemoDTO
    {
        public int MyMemoId { get; set; }
        public int MemoId { get; set; }
        public int UserId { get; set; }
        public System.TimeSpan AdvanceAlertTime { get; set; }
        public string AlertName { get; set; }

    }
}
