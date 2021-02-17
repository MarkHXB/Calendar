using CalendarLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calendar.Models
{
    public class InputModel
    {

        #region FUNCTIONS

        public static bool checkSqlInjection(string input)
        {
            //SQL check list
            string[] sqlCheckList = { "--",

                                       ";--",

                                       ";",

                                       "/*",

                                       "*/",

                                        "@@",

                                        "@",

                                        "char",

                                       "nchar",

                                       "varchar",

                                       "nvarchar",

                                       "alter",

                                       "begin",

                                       "cast",

                                       "create",

                                       "cursor",

                                       "declare",

                                       "delete",

                                       "drop",

                                       "end",

                                       "exec",

                                       "execute",

                                       "fetch",

                                            "insert",

                                          "kill",

                                             "select",

                                           "sys",

                                            "sysobjects",

                                            "syscolumns",
                                           "table", "update"
                                       };
            bool isSqlInjection = false;

            string CheckString = input.Replace("'", "''");

            for (int i = 0; i <= sqlCheckList.Length - 1; i++)
            {
                if ((CheckString.IndexOf(sqlCheckList[i],

                    StringComparison.OrdinalIgnoreCase) >= 0))

                { isSqlInjection = true; }
            }

            //More parameter goes here...

            return isSqlInjection;
        }

        public static int Int(string text)
        {
            string val = "";
            int output = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsDigit(text[i]))
                {
                    val += text[i];
                }
            }
            if (val.Length > 0)
            {
                output = int.Parse(val);
            }

            return output;
        }

        public static string GetMonthName(int MonthNumber)
        {
            string output = "";
            DateTime time = new DateTime(DateTime.Now.Year, MonthNumber, DateTime.Now.Day);

            output = time.ToString("MMMM");

            return output;
        }

        public static string GetMonthDayName(int MonthNumber, int DayNumber)
        {
            string output = "";
            DateTime time = new DateTime(DateTime.Now.Year, MonthNumber, DayNumber);

            output = time.ToString("dddd");

            return output;
        }

        public static DateTime ConvertStringToDateTime(string text)
        {
            DateTime output = new DateTime();
            bool _empty = false;

            try
            {

                string[] Months = new string[]
                {
                    "szeptember","október","november","december","január",
                    "február","március","április","május","június","július",
                    "agusztus"
                };
                int[] Days = Enumerable.Range(1, 31).ToArray();

                string _m = "";
                int _d = 0;

                foreach (string month in Months)
                {
                    foreach (int day in Days)
                    {
                        if (text.Contains(month) && text.Contains(day.ToString()))
                        {
                            _m = month;
                            _d = day;
                        }
                    }
                }

                if (_m == "" || _d == 0) { _empty = true; }
                else
                {
                    int Year = (MainFormModel.Year != 0 ? MainFormModel.Year : DateTime.Now.Year);
                    int Month = Convert.ToInt32(_m);
                    int Day = Convert.ToInt32(_d);

                    output = new DateTime(Year, Month, Day);
                }

            }
            catch (Exception x)
            {
                LogModel.Warning warn = new LogModel.Warning(x.Message);
            }

            if (_empty)
            {
                DateTime _date= new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);
                string _o = _date.ToString("yyyy-M-dd");
                return Convert.ToDateTime(_o);
            }
            else
            {
                return output;
            }

            #endregion

        }
    }
}
