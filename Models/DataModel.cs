using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models
{
    public class DataModel
    {
        public class Date
        {
            public int Task_ID { get; set; }
            public int Date_ID { get; set; }
            public int Month_ID { get; set; }
        }
        public class Task
        {
            public int Id { get; set; }
            public int Level { get; set; }
            public DateTime Alarm_Date { get; set; }
            public string Content { get; set; }
            public int IsComplete { get; set; }
        }
    }
}
