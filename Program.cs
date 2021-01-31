using Calendar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            TaskModel.Read();

            DataModel.Task one_task = TaskModel.SelectTaskByDayNumber_Row(2,26, true);

            Console.WriteLine(one_task.Content);
            
            Console.ReadLine();
        }
    }
}
