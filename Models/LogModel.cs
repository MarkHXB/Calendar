using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar.Models
{
    public class LogModel
    {
        #region Constructor

        public LogModel(object type,string message,DateTime time)
        {
            Type = type;
            Message = message;
            Time = time;

            if(type is Debugging)
            {
                Debugging deb = new Debugging(Message);
            }
            if (type is Warning)
            {
                Warning warn = new Warning(Message);
            }
            if (type is Error)
            {
                Error err = new Error(Message);
            }
        }

        #endregion


        #region SubClasses

        public class Debugging
        {
            public Debugging(string message)
            {
                LogList.Add(new LogModel(this,message,DateTime.Now));
            }
            
            public List<LogModel> GetDebugs()
            {
                List<LogModel> listOfDebugs = new List<LogModel>();

                foreach (var item in LogList)
                {
                    if(item.Type is Debugging) 
                    {
                        listOfDebugs.Add(item); 
                    }
                }

                return listOfDebugs;
            }
        }
        public class Warning
        {
            public Warning(string message)
            {
                LogList.Add(new LogModel(this, message, DateTime.Now));
            }

            public List<LogModel> GetWarnings()
            {
                List<LogModel> listOfWarnings = new List<LogModel>();

                foreach (var item in LogList)
                {
                    if (item.Type is Warning)
                    {
                        listOfWarnings.Add(item);
                    }
                }

                return listOfWarnings;
            }
        }
        public class Error
        {
            public Error(string message)
            {
                LogList.Add(new LogModel(this, message, DateTime.Now));
            }

            public List<LogModel> GetErrors()
            {
                List<LogModel> listOfErrors = new List<LogModel>();

                foreach (var item in LogList)
                {
                    if (item.Type is Warning)
                    {
                        listOfErrors.Add(item);
                    }
                }

                return listOfErrors;
            }
        }

        #endregion


        #region Functions

        public static string Alert(List<DataModel.Task> UserTasks,MessageBox InfoBox)
        {
            string output = null;

            DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            try
            {
                if (UserTasks[0].Alarm_Date.Year == now.Year&&
                    UserTasks[0].Alarm_Date.Month==now.Month&&
                    UserTasks[0].Alarm_Date.Day==now.Day)
                {
                    output=AlarmUser(UserTasks,InfoBox);
                }
            }
            catch(Exception x)
            {

            }

            return output;
        }

        private static string AlarmUser(List<DataModel.Task>UserTasks,MessageBox box)
        {
            string output = "";

            if (box == null)
            {
                string text = $"Mára még hátravan: {UserTasks.Count} feladatod" +
                    $"\n Feladatok: \n";

                foreach (var item in UserTasks)
                {
                    string taskTitle = $"\n - {item.Content}\n";
                    text += taskTitle;
                }

                output = text;
            }

            return output;
        }

        #endregion


        #region Properties


        public static List<LogModel> LogList = new List<LogModel>();
        public object Type { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }

        #endregion
    }
}
