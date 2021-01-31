using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        #endregion

    }
}
