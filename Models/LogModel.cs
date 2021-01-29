using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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



        #region Properties


        public static List<LogModel> LogList = new List<LogModel>();
        public object Type { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }

        #endregion
    }
}
