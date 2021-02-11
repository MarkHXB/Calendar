using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarLibrary.Models
{
    public class MainFormModel
    {
        public static int Year { get; set; } = DateTime.Now.Year;
        public static int Month { get; set; } = DateTime.Now.Month;
        public static int Day { get; set; } = DateTime.Now.Year;
        public static Form form { get; set; }
    }
}
