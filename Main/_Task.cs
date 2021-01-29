using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Calendar.Main
{
    //DATABASE * FUNCTIONS *
    interface IDBfunctions
    {
        void Insert(int level,DateTime alarm,string content);
        void Edit(int Task_ID);
        void Edit(int Task_ID, int Level, DateTime Alarm, string TaskContent);
        void Delete(int Task_ID);
        void Read();
    }
    public class Task:IDBfunctions
    {
        //Properties
        public static List<Task> DbContent = new List<Task>();
        public int Date_Id { get; set; }
        public int Task_Id_Dates { get; set; }
        public int Task_Id_Tasks { get; set; }
        public int TaskLevel { get; set; }
        public DateTime Alarm { get; set; }
        public string TaskContent { get; set; }
        public bool TaskComplete { get; set; }


        //ezt majd valahová lehet ellehet pakolni
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Datas.mdf;Integrated Security=True";
        SqlConnection sqlCon = new SqlConnection(connectionString);

        //IDBfunctions
        public void Insert(int level,DateTime alarm,string content)
        {
            string insertQuery = "insert into Dates(Date_ID) values(@dateid)";
            try
            {
                //Date Table
                sqlCon.Open();
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, sqlCon))
                {
                    insertCommand.Parameters.AddWithValue("@dateid", Calendar.choosedDay);

                    insertCommand.ExecuteNonQuery();
                }
                Console.WriteLine("[Date] insertation is complete");


                //Task Table
                insertQuery = "insert into Tasks(Level,Alarm,TaskContent) values(@level,@alarm,@taskcontent)";
                using (SqlCommand insertCommand = new SqlCommand(insertQuery, sqlCon))
                {
                    insertCommand.Parameters.AddWithValue("@level",level);
                    insertCommand.Parameters.AddWithValue("@alarm", alarm);
                    insertCommand.Parameters.AddWithValue("@taskcontent", content);

                    insertCommand.ExecuteNonQuery();
                }
                Console.WriteLine("[Task] insertation is complete");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            
        }

        //IsJustFor => Complete TASK
        public void Edit(int Task_ID)
        {
            string editQuery = "update Tasks set Complete = 1 where Id=@taskid";
            try
            {
                //Date Table
                sqlCon.Open();
                using (SqlCommand insertCommand = new SqlCommand(editQuery, sqlCon))
                {
                    insertCommand.Parameters.AddWithValue("@taskid", Task_ID);

                    insertCommand.ExecuteNonQuery();
                }
                Console.WriteLine("[Task] edit is complete");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }

        //IsJustFor => Edit TASK
        public void Edit(int Task_ID,int Level,DateTime Alarm,string TaskContent)
        { 
            string editQuery = "update Tasks set Level='"+Level+"', Alarm='"+Alarm.Date.ToString("yyyy-MM-dd")+"', TaskContent='"+ TaskContent + "' where Id=@taskid";
            try
            {
                //Date Table
                sqlCon.Open();
                using (SqlCommand insertCommand = new SqlCommand(editQuery, sqlCon))
                {
                    Console.WriteLine("ss");

                    insertCommand.Parameters.AddWithValue("@taskid", Task_ID);

                    insertCommand.ExecuteNonQuery();
                }
                Console.WriteLine("[Task] edit is complete");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
        public void Delete(int Task_ID)
        {
            //DELETE FROM DATES

            string deleteQuery = "delete from Dates where Task_ID='"+Task_ID+"'";
            try
            {
                //Date Table
                sqlCon.Open();
                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlCon))
                {
                    deleteCommand.ExecuteNonQuery();
                }
                Console.WriteLine("[Dates] delete is complete");

                deleteQuery = "delete from Tasks where Id='" + Task_ID + "'";

                using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlCon))
                {
                    deleteCommand.ExecuteNonQuery();
                }
                Console.WriteLine("[Tasks] delete is complete");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {
                sqlCon.Close();
            }
        }
        public void Read()
        {
           
        }
        public static void ReadOnLoad()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Datas.mdf;Integrated Security=True";
            SqlConnection sqlCon = new SqlConnection(connectionString);

            string readQuery = "select * from Dates";
            try
            {
                //DATE table
                sqlCon.Open();
                using (SqlCommand readCommand = new SqlCommand(readQuery, sqlCon))
                {
                    SqlDataReader reader = readCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        DbContent.Add(new Task()
                        {
                            Task_Id_Dates = Convert.ToInt32(reader["Task_ID"]),
                            Date_Id= Convert.ToInt32(reader["Date_ID"])
                        });
                    }

                    reader.Close();
                }
                Console.WriteLine("[Date] table read complete");


                //TASK Table
                readQuery = "select * from Tasks";
                using (SqlCommand readCommand = new SqlCommand(readQuery, sqlCon))
                {
                    SqlDataReader reader = readCommand.ExecuteReader();

                    int count = 0;

                    while (reader.Read())
                    {
                        foreach (var item in DbContent)
                        {
                            if (item.Task_Id_Dates == Convert.ToInt32(reader["Id"]))
                            {
                                item.Task_Id_Tasks = Convert.ToInt32(reader["Id"]);
                                item.TaskLevel = Convert.ToInt32(reader["Level"]);
                                item.Alarm = Convert.ToDateTime(reader["Alarm"]);
                                item.TaskContent = reader["TaskContent"].ToString();
                                item.TaskComplete = Convert.ToBoolean(reader["Complete"]);
                            }
                        }
                    }

                    reader.Close();
                }
                Console.WriteLine("[Task] table read complete");
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
                sqlCon.Close();
            }
            finally
            {
                sqlCon.Close();
            }
        }
        public static void testData()
        {
            if(DbContent.Count == 0)
            {
                ReadOnLoad();
            }

            foreach (var item in DbContent)
            {
                Console.WriteLine(item.TaskComplete);
            }
        }
    }
    public class NonSqlTask
    {
        public static bool Part1 = false;
        public static bool Part2 = false;
        public static bool Part3 = false;

        public int Level { get; set; }
        public DateTime Alarm { get; set; }
        public string Content { get; set; }
        public static int SelectedButtonIndex = 0;


        //NOTIFICATIONS
        public static void Warning()
        {
            if (!Part1)
            {
                MessageBox.Show("Jelölj be legalább egy figyelmeztetési szintet!");
            }
            if (!Part2)
            {
                MessageBox.Show($"Próbálj meg egy normális formátumú dátumot megadni." +
                    $"\nPéldául: {DateTime.Now.ToString("G")}");
            }
            if (!Part3)
            {
                MessageBox.Show("Figyelj arra, hogy legalább 3 karakternyi szöveget adj meg " +
                    "\nés ne használj különleges szimbólumokat!");
            }
        }


        //MAKING
        public static int MakeTaskLevel(RadioButton checkedButton)
        {
            int output = 0;

            if(checkedButton==null&& SelectedButtonIndex == 0)
            {
                Part1 = false;
            }
            else if (checkedButton == null)
            {
                output = SelectedButtonIndex;
                Part1 = true;
            }
            else
            {
                string text = checkedButton.Name;
                string value = "";

                for (int i = 0; i < text.Length; i++)
                {
                    if (Char.IsDigit(text[i]))
                        value += text[i];
                }

                if (value.Length > 0)
                    output = int.Parse(value);

                Part1 = true;
            }

            return output;
        }
        public static DateTime MakeTaskAlarm(TextBox textBox)
        {
            DateTime output=new DateTime();
            try
            {
                output = Convert.ToDateTime(textBox.Text);

                Check_Date();

                Part2 = true;
            }
            catch(Exception x)
            {
                Part2 = false;
            }
            
            return output;
        }
        public static string MakeTaskContent(TextBox textBox)
        {
            string output = "";

            output = textBox.Text;

            Check_Content(output);

            return output;
        }


        //CHECKING
        private static void Check_Content(string output)
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

            string CheckString = output.Replace("'", "''");

            for (int i = 0; i <= sqlCheckList.Length - 1; i++)
            {
                if ((CheckString.IndexOf(sqlCheckList[i],

                    StringComparison.OrdinalIgnoreCase) >= 0))

                { isSqlInjection = true; }
            }

            try
            {
                if (isSqlInjection && output.Length>3) { Part3 = false; ; throw new Exception("Ez a tevékenység naplózva lett."); }
                else
                {
                    Part3 = true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
        private static void Check_Date()
        {
            
        }

    }
    class InsertTaskInformations
    {
        public int Level { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }
        public static InsertTaskInformations insertTaskInfo = new InsertTaskInformations();
    }
}

