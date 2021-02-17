using Calendar.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarLibrary.Models.Alarm
{
    public class AlarmModel
    {
        //for testing
        private static string version = "";


        //Alarm algorithm
        public static DateTime[] CalculateAlarm(UserInformationModel User,DataModel.Task task)
        {
            int alarmPerDay = User.AlarmPerDay;
            DateTime warnTime = task.Alarm_Date;

            DateTime[] output = new DateTime[alarmPerDay];
            DateTime now = DateTime.Now;

            const int minuteInHour = 60;
            const int monthInYear = 12;
            int daysInYear = DateTime.IsLeapYear(warnTime.Year) ? 366 : 365;

            /* if ((warnTime.Year < now.Year || warnTime.Month < now.Month ||warnTime.Day < now.Day)
                 || (warnTime.Year == now.Year &&warnTime.Month == warnTime.Month&&warnTime.Day == now.Day && warnTime.Hour < now.Hour)
                 || (warnTime.Year == now.Year && warnTime.Month == warnTime.Month && 
                 warnTime.Day == now.Day && warnTime.Hour == now.Hour && warnTime.Minute < now.Minute))
             {
                 output = null;
             }*/
            const string path = @"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\User\Alarms\";

            string fileName = path + task.Id.ToString() + ".txt";

            if (File.Exists(fileName))
            {
                output=null;
            }
            else
            {

                if (now.Hour - 1 <= warnTime.Hour && now.Day == warnTime.Day && warnTime.Month == now.Month)
                {
                    version = "first";
                    int currentMinute = DateTime.Now.Minute;
                    int hasTime = minuteInHour - currentMinute;

                    int _hourFirst = 0;
                    int _minuteFirst = 0;

                    int _hourSecond = 0;
                    int _minuteSecond = 0;

                    //first
                    if(warnTime.Hour >= now.Hour)
                    {
                        _hourFirst = warnTime.Hour - 1;
                    }
                    if(warnTime.Minute >5)
                    {
                        _minuteFirst = Convert.ToInt32(warnTime.Minute / 4);
                    }
                    if (warnTime.Minute < 5)
                    {
                        _minuteFirst = warnTime.Minute;
                    }
                    
                    //ToDo: Javítani ezt mert még buggos
                   
                    //second
                    if(warnTime.Minute < 10 && warnTime.Hour+1 == now.Hour)
                    {
                        _hourSecond = warnTime.Hour - 1;

                    }

                    DateTime firstAlarmDate = new DateTime(warnTime.Year, warnTime.Month, warnTime.Day, _hourFirst, _minuteFirst, 0);
                    DateTime secondAlarmDate = new DateTime(warnTime.Year, warnTime.Month, warnTime.Day, warnTime.Hour, hasTime / 2, 0);
                    DateTime thirdAlarmDate = new DateTime(warnTime.Year, warnTime.Month, warnTime.Day, warnTime.Hour, warnTime.Minute, 0);

                    DateTime[] _alarms =
                    {
                        firstAlarmDate,secondAlarmDate,thirdAlarmDate
                    };
                   
                    for (int i = 0; i < _alarms.Length; i++)
                    {
                        output[i] = _alarms[i];
                    }
                }
                else if (now.Month == warnTime.Month)
                {
                    version = "second";
                    int currentMonth = DateTime.Now.Month;
                    int dayInMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    int between = dayInMonth - warnTime.Day;

                    int first = DateTime.Now.Day + between / 4;
                    int second = DateTime.Now.Day + between / 2;

                    //first Alarm
                    DateTime firstAlarmDate = new DateTime(warnTime.Year, warnTime.Month, first);

                    //second Alarm
                    DateTime secondAlarmDate = new DateTime(warnTime.Year, warnTime.Month, second);

                    //third Alarm=
                    DateTime thirdAlarmDate = new DateTime(warnTime.Year, warnTime.Month, warnTime.Day, warnTime.Hour, warnTime.Minute / 2, 0);

                    

                    DateTime[] _alarms =
                    {
                        firstAlarmDate,secondAlarmDate,thirdAlarmDate
                    };

                    for (int i = 0; i <alarmPerDay; i++)
                    {
                        output[i] = _alarms[i];
                        Console.WriteLine(output[i].Hour);
                    }
                }
                else
                {
                    version = "third";
                    int currentMonth = DateTime.Now.Month;
                    //first Alarm
                    DateTime firstAlarmDate = new DateTime(warnTime.Year, warnTime.Month / 4, warnTime.Day);

                    //second Alarm
                    DateTime secondAlarmDate = new DateTime(warnTime.Year, warnTime.Month / 2, warnTime.Day);

                    //third Alarm=
                    DateTime thirdAlarmDate = new DateTime(warnTime.Year, warnTime.Month, warnTime.Day, warnTime.Hour, warnTime.Minute / 2, 0);

                    //2x elvétve szóljon és 1x aznap
                    int daysLeftInYear = daysInYear - warnTime.Day; // Result is in range 0-365.

                    DateTime[] _alarms =
                    {
                        firstAlarmDate,secondAlarmDate,thirdAlarmDate
                    };

                    for (int i = 0; i < alarmPerDay; i++)
                    {
                        output[i] = _alarms[i];
                    }
                }
            }
            Console.WriteLine(version);
            return output;
        }
        
        public static void MakeAlarm(DateTime[] alarms)
        {
            DateTime now = DateTime.Now;

            bool alarm = false;

            for (int i = 0; i < alarms.Length; i++)
            {
                if (alarms[i] <= now)
                {
                    alarm = true;
                }
            }

            if (alarm)
            {
                for (int i = 0; i < alarms.Length; i++)
                {
                    
                }
            }
        }

        public static void WriteToFile(DataModel.Task task,DateTime[]alarms)
        {
            if (alarms == null)
            {
                //Console.WriteLine("Nulla volt ezért nem írtam");
                return;
            }
            else
            {

                const string path = @"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\User\Alarms\";

                string fileName = path + task.Id.ToString() + ".txt";

                 
                if (File.Exists(fileName))
                {
                    return;
                }

                string[] formattedAlarmText = new string[alarms.Length];

                for (int i = 0; i < alarms.Length; i++)
                {
                    formattedAlarmText[i] = alarms[i].Year + " " + alarms[i].Month + " " + alarms[i].Day + " " + alarms[i].Hour + " " + alarms[i].Minute;
                }

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    //List<bool> values = new List<bool>(task.Alarm_Check.Values);
                    for (int i = 0; i < formattedAlarmText.Length; i++)
                    {
                        string text = "";

                        text = formattedAlarmText[i] + " " + "n";

                        sw.WriteLine(text);
                    }

                    sw.Close();
                }

                /*catch (Exception x)
                {
                    LogModel.Error err = new LogModel.Error(x.Message+"\n"+"[AlarmModel]"+" "+"WriteToFile Method");
                }*/
            }
        }
      

        public static Dictionary<DateTime,bool> CompleteAlert(DataModel.Task AlertTasks)
        {
            Dictionary<DateTime, bool> Alarms = new Dictionary<DateTime, bool>();

            const string path = @"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\User\Alarms\";


            string fileName = path + AlertTasks.Id.ToString() + ".txt";

            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(' ');

                        if (sor[5].Contains("n"))
                        {
                            DateTime date = new DateTime(Convert.ToInt32(sor[0]), Convert.ToInt32(sor[1]), Convert.ToInt32(sor[2]), Convert.ToInt32(sor[3]),
                                Convert.ToInt32(sor[4]), 0);
                            Alarms.Add(date, false);
                        }
                        if (sor[5].Contains("i"))
                        {
                            DateTime date = new DateTime(Convert.ToInt32(sor[0]), Convert.ToInt32(sor[1]), Convert.ToInt32(sor[2]), Convert.ToInt32(sor[3]),
                                Convert.ToInt32(sor[4]), 0);
                            Alarms.Add(date, true);
                        }
                    } 
                }
            }
            catch (Exception x)
            {
                LogModel.Error err = new LogModel.Error(x.Message);

                err.GetErrors();
            }

            return Alarms;

        }

        public static void TestAlarm(UserInformationModel User, DataModel.Task task)
        {
            DateTime[] alarms=CalculateAlarm(User,task);

            WriteToFile(task, alarms);
        }

        public static List<DataModel.Task> Alarm(UserInformationModel User)
        {
            List<DataModel.Task> output =new List<DataModel.Task>();

            const string path = @"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\User\Alarms\";
            foreach (var task in TaskModel.Task_Table)
            {
                string fileName = path + task.Id.ToString() + ".txt";
                if (File.Exists(fileName))
                {

                    using (StreamReader sr = new StreamReader(fileName))
                    {
                        string line;

                        DataModel.Task currentTask = task;

                        Dictionary<DateTime, bool> currentAlarmList = new Dictionary<DateTime, bool>();

                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] words = line.Split(' ');

                            int year = 0;
                            int month = 0;
                            int day = 0;
                            int hour = 0;
                            int minute = 0;
                            bool alarmed = false;

                            year = Convert.ToInt32(words[0]); month = Convert.ToInt32(words[1]); day = Convert.ToInt32(words[2]);
                            hour = Convert.ToInt32(words[3]); minute = Convert.ToInt32(words[4]); alarmed = (words[5] == "n" ? false : true);

                            DateTime date = new DateTime(year, month, day, hour, minute, 0);

                            currentAlarmList.Add(date, alarmed);
                        }

                        currentTask.Alarm_Check = currentAlarmList;
                        output.Add(currentTask);
                    }
                    /*
                    catch (FileNotFoundException lackOfFile)
                    {

                    }
                    catch (Exception x)
                    {
                        LogModel.Error err = new LogModel.Error(x.Message);
                    }*/
                }
            }
            

            return output;
        }







        public static void WriteToFile(DataModel.Task task, DateTime[] alarms, int modifyId)
        {
            if (alarms == null)
            {
                //Console.WriteLine("Nulla volt ezért nem írtam");
                return;
            }
            else
            {

                const string path = @"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\User\Alarms\";

                string fileName = path + task.Id.ToString() + ".txt";

                string[] formattedAlarmText = new string[alarms.Length];

                for (int i = 0; i < alarms.Length; i++)
                {
                    formattedAlarmText[i] = alarms[i].Year + " " + alarms[i].Month + " " + alarms[i].Day + " " + alarms[i].Hour + " " + alarms[i].Minute;
                }

                List<string> old_Lines = new List<string>();

                using(StreamReader sr=new StreamReader(fileName))
                {
                    while (!sr.EndOfStream)
                    {
                        old_Lines.Add(sr.ReadLine());
                    }
                }

                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    //List<bool> values = new List<bool>(task.Alarm_Check.Values);
                    for (int i = 0; i < formattedAlarmText.Length; i++)
                    {
                        string text = "";

                        if (i == modifyId)
                        {
                            text = formattedAlarmText[i] + " " + "i";
                        }
                        else
                        {
                            text = old_Lines[i];
                        }

                        sw.WriteLine(text);

                    }

                    sw.Close();
                }

                /*catch (Exception x)
                {
                    LogModel.Error err = new LogModel.Error(x.Message+"\n"+"[AlarmModel]"+" "+"WriteToFile Method");
                }*/
            }
        }




        public static void CompleteTaskAlert(DataModel.Task task, DateTime dateTime)
        {
            const string path = @"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\User\Alarms\";

            string fileName = path + task.Id.ToString() + ".txt";


            List<DateTime> keys = new List<DateTime>(task.Alarm_Check.Keys);
            List<bool> values = new List<bool>(task.Alarm_Check.Values);

            int index = 0;

            foreach (KeyValuePair<DateTime, bool> item in task.Alarm_Check)
            {
                if (item.Key == dateTime)
                {
                    break;
                }
                index++;
            }
            for (int i = 0; i < values.Count; i++)
            {
                if (i == index)
                {
                    values[i] = true;
                }
            }


            DateTime[] alarms = new DateTime[3];

            for (int i = 0; i < values.Count; i++)
            {
                DateTime _ = new DateTime(keys[i].Year, keys[i].Month, keys[i].Day, keys[i].Hour, keys[i].Minute, 0);
                alarms[i] = _;
            }

            Console.WriteLine("Index: "+index);

            WriteToFile(task, alarms,index);

        }
    }
}
