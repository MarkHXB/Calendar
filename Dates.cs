using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar
{
    public class Dates
    {
        public int DayID { get; set; }

        public string DayName { get; set; }
        public int DayOfTheMonth { get; set; }
        public List<Tasks> mainTasks;
        public Dates(int _dayId,string _dayName,int _dayOfTheMonth)
        {
            this.DayID = _dayId;
            this.DayName = _dayName;
            this.DayOfTheMonth = _dayOfTheMonth;
            this.mainTasks = new List<Tasks>();
        }
    }
    public class Tasks
    {
        public int TaskID { get; set; }
        public List<string> subTasks;
        public Tasks() { subTasks = new List<string>(); }
    }
}
