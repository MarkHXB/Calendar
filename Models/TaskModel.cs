using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar.Models
{
    interface IDbFunctions
    {
        void Read(DataModel.Date date, DataModel.Task task);
        void Edit();
        void Insert(DataModel.Task task);
        void Delete();
    }
    public class TaskModel
    {
        #region Constructors

        public TaskModel(int selectedDayNumber)
        {

        }

        public TaskModel(DataModel.Date date, DataModel.Task task)
        {
            Insert(date, task);
        }

        #endregion

        #region SQLfunctions
        public static void Delete(DataModel.Task task)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            //OCCURS WHEN Date MODIFDY REQUIRED
            if (task != null)
            {
                //Firstly delete the row from tasks table

                string deleteQuery = "delete from Dates where Task_ID=@taskid";
                try
                {
                    //Date Table
                    sqlCon.Open();
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlCon))
                    {
                        deleteCommand.Parameters.AddWithValue("@taskid", task.Id);

                        deleteCommand.ExecuteNonQuery();
                    }
                    Console.WriteLine("[Table] row delete is complete");

                    deleteQuery = "delete from Tasks where Id=@taskid";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlCon))
                    {
                        deleteCommand.Parameters.AddWithValue("@taskid", task.Id);

                        deleteCommand.ExecuteNonQuery();
                    }
                    Console.WriteLine("[Date] row delete is complete");
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
        }

        public static void Delete(DataModel.Date date)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            //OCCURS WHEN Date MODIFDY REQUIRED
            if (date != null)
            {
                //Firstly delete the row from tasks table

                string deleteQuery = "delete from Tasks where Id=@taskid";
                try
                {
                    //Date Table
                    sqlCon.Open();
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlCon))
                    {
                        deleteCommand.Parameters.AddWithValue("@taskid", date.Task_ID);

                        deleteCommand.ExecuteNonQuery();
                    }
                    Console.WriteLine("[Table] row delete is complete");

                    deleteQuery = "delete from Dates where Task_ID=@taskid";
                    using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, sqlCon))
                    {
                        deleteCommand.Parameters.AddWithValue("@taskid", date.Task_ID);

                        deleteCommand.ExecuteNonQuery();
                    }
                    Console.WriteLine("[Date] row delete is complete");
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
        }
        public static void Edit(DataModel.Date date, DataModel.Task task)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            //OCCURS WHEN Date MODIFDY REQUIRED
            if (date != null)
            {
                string editQuery = "update Dates set Date_ID = @dateid, Month_ID = @monthid where Task_ID = @taskid";
                try
                {
                    //Date Table
                    sqlCon.Open();
                    using (SqlCommand editCommand = new SqlCommand(editQuery, sqlCon))
                    {
                        editCommand.Parameters.AddWithValue("@dateid", date.Date_ID);
                        editCommand.Parameters.AddWithValue("@monthid", date.Month_ID);
                        editCommand.Parameters.AddWithValue("@taskid", date.Task_ID);

                        editCommand.ExecuteNonQuery();
                    }
                    Console.WriteLine("[Date] modify is complete");
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

            //OCCURS WHEN TASK MODIFDY REQUIRED
            if (task != null)
            {
                string editQuery = "update Tasks set Alarm = @alarm, TaskContent=@content where Id = @taskid";
                try
                {
                    //Task Table
                    sqlCon.Open();
                    using (SqlCommand editCommand = new SqlCommand(editQuery, sqlCon))
                    {
                        editCommand.Parameters.AddWithValue("@alarm", task.Alarm_Date);
                        editCommand.Parameters.AddWithValue("@content", task.Content);
                        editCommand.Parameters.AddWithValue("@taskid", task.Id);

                        editCommand.ExecuteNonQuery();
                    }
                    Console.WriteLine("[Task] modify is complete");
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
        }
        /// <summary>
        /// ~ successfully worked ~
        /// </summary>
        /// <param name="date"></param>
        /// <param name="task"></param>
        public static void Insert(DataModel.Date date, DataModel.Task task)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            if (task != null)
            {
                string insertQuery = "insert into Dates(Date_ID,Month_ID) values(@dateid,@monthid)";

                try
                {
                    //Date Table
                    sqlCon.Open();
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, sqlCon))
                    {
                        insertCommand.Parameters.AddWithValue("@dateid", task.Alarm_Date.Day);
                        insertCommand.Parameters.AddWithValue("@monthid", task.Alarm_Date.Month);

                        insertCommand.ExecuteNonQuery();
                    }
                    Console.WriteLine("[Date] insertation is complete");


                    //Task Table
                    insertQuery = "insert into Tasks(Level,Alarm,TaskContent) values(@level,@alarm,@taskcontent)";
                    using (SqlCommand insertCommand = new SqlCommand(insertQuery, sqlCon))
                    {
                        insertCommand.Parameters.AddWithValue("@level", task.Level);
                        insertCommand.Parameters.AddWithValue("@alarm", task.Alarm_Date);
                        insertCommand.Parameters.AddWithValue("@taskcontent", task.Content);

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

            
        }

        /// <summary>
        /// ~ successfully worked ~
        /// </summary>
        public static void Read()
        {
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
                        Date_Table.Add(new DataModel.Date
                        {
                            Date_ID = (int)reader["Date_ID"],
                            Task_ID = (int)reader["Task_ID"],
                            Month_ID = (int)reader["Month_ID"]
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

                    while (reader.Read())
                    {
                        Task_Table.Add(new DataModel.Task
                        {
                            Id = (int)(reader["Id"]),
                            Level = (int)(reader["Level"]),
                            Alarm_Date = (DateTime)reader["Alarm"],
                            Content = (string)reader["TaskContent"],
                            IsComplete = (int)reader["Complete"]
                        });
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

        public static void Complete(DataModel.Date date)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);

            //OCCURS WHEN Date MODIFDY REQUIRED
            if (date != null)
            {
                string editQuery = "update Tasks set Complete = 1 where Id = @taskid";
                try
                {
                    //Date Table
                    sqlCon.Open();
                    using (SqlCommand editCommand = new SqlCommand(editQuery, sqlCon))
                    {
                        editCommand.Parameters.AddWithValue("@taskid", date.Task_ID);

                        editCommand.ExecuteNonQuery();
                    }
                    Console.WriteLine("[Date] modify [Complete] is complete");
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
        }

        /*
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
        public void Edit(int Task_ID, int Level, DateTime Alarm, string TaskContent)
        {
            string editQuery = "update Tasks set Level='" + Level + "', Alarm='" + Alarm.Date.ToString("yyyy-MM-dd") + "', TaskContent='" + TaskContent + "' where Id=@taskid";
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

            string deleteQuery = "delete from Dates where Task_ID='" + Task_ID + "'";
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
        */

        #endregion

        #region Functions

        /// <summary>
        /// Collect all the tasks about that day and return a Task List which contains the data.
        /// usage ==> List.DataModel.Task. task_list = TaskModel.SelectTaskByDayNumber_List(26, true);
        /// </summary>
        /// <param name="dayNumber"></param>
        /// <param name="checkIsComplete"></param>
        /// <returns></returns>
        public static List<DataModel.Task> SelectTaskByDayNumber_List(int dayNumber, int monthNumber, bool checkIsComplete)
        {
            List<DataModel.Task> selectedTask = new List<DataModel.Task>();
            List<int> Task_ids = new List<int>();

            #region CHECK_LISTS_CONTENT

            bool isTableListEmpty = !Date_Table.Any();
            if (isTableListEmpty) { Read(); }

            #endregion

            foreach (var item in Date_Table)
            {
                if (dayNumber == item.Date_ID && monthNumber == item.Month_ID)
                {
                    Task_ids.Add(item.Task_ID);
                }
            }

            for (int i = 0; i < Task_ids.Count; i++)
            {
                foreach (var item in Task_Table)
                {
                    if (checkIsComplete == true && item.IsComplete == 0)
                    {
                        if (Task_ids[i] == item.Id)
                        {
                            selectedTask.Add(new DataModel.Task
                            {
                                Id = item.Id,
                                Level = item.Level,
                                Alarm_Date = item.Alarm_Date,
                                Content = item.Content,
                                IsComplete = item.IsComplete
                            });
                        }
                    }
                    else if (checkIsComplete == false && item.IsComplete == 1)
                    {
                        if (Task_ids[i] == item.Id)
                        {
                            selectedTask.Add(new DataModel.Task()
                            {
                                Id = item.Id,
                                Level = item.Level,
                                Alarm_Date = item.Alarm_Date,
                                Content = item.Content,
                                IsComplete = item.IsComplete
                            });
                        }
                    }
                }
            }


            return selectedTask;
        }
        public static List<DataModel.Task> SelectTaskByDayNumber_List(int dayNumber, int monthNumber)
        {
            List<DataModel.Task> selectedTask = new List<DataModel.Task>();
            List<int> Task_ids = new List<int>();

            #region CHECK_LISTS_CONTENT

            bool isTableListEmpty = !Date_Table.Any();
            if (isTableListEmpty) { Read(); }

            #endregion

            List<int> selectedTaskID = new List<int>();

            foreach (var item in Date_Table)
            {
                if (item.Date_ID == dayNumber && item.Month_ID == monthNumber)
                {
                    selectedTaskID.Add(item.Task_ID);
                }
            }

            for (int i = 0; i < selectedTaskID.Count; i++)
            {
                foreach (var item in Task_Table)
                {
                    if (item.Id == selectedTaskID[i])
                    {
                        selectedTask.Add(new DataModel.Task
                        {
                            Id = item.Id,
                            Level = item.Level,
                            Alarm_Date = item.Alarm_Date,
                            Content = item.Content,
                            IsComplete = item.IsComplete
                        });
                    }
                }
            }


            return selectedTask;
        }

        /// <summary>
        /// ~ successfully worked ~
        /// usage ==> DataModel.Task one_task = TaskModel.SelectTaskByDayNumber_Row(2,26, true);
        /// </summary>
        /// <param name="rowNumber"></param>
        /// <param name="dayNumber"></param>
        /// <param name="checkIsComplete"></param>
        /// <returns></returns>
        public static DataModel.Task SelectTaskByDayNumber_Row(int rowNumber, int dayNumber, int monthNumber, bool checkIsComplete)
        {
            DataModel.Task selectedTask = new DataModel.Task();
            List<int> Task_ids = new List<int>();

            #region CHECK_LISTS_CONTENT

            bool isTableListEmpty = !Date_Table.Any();
            if (isTableListEmpty) { Read(); }

            #endregion

            foreach (var item in Date_Table)
            {
                if (dayNumber == item.Date_ID && monthNumber == item.Month_ID)
                {
                    Task_ids.Add(item.Task_ID);
                }
            }
            bool emptyTaskList = !Task_ids.Any();
            if (emptyTaskList)
            {
                return new DataModel.Task();
            }
            else
            {
                foreach (var item in Task_Table)
                {
                    if (checkIsComplete == true && item.IsComplete == 0)
                    {
                        if (Task_ids[rowNumber - 1] == item.Id)
                        {
                            selectedTask.Id = item.Id;
                            selectedTask.Level = item.Level;
                            selectedTask.Alarm_Date = item.Alarm_Date;
                            selectedTask.Content = item.Content;
                            selectedTask.IsComplete = item.IsComplete;
                        }
                    }
                    else if (checkIsComplete == false && item.IsComplete == 1)
                    {
                        if (Task_ids[rowNumber - 1] == item.Id)
                        {
                            selectedTask.Id = item.Id;
                            selectedTask.Level = item.Level;
                            selectedTask.Alarm_Date = item.Alarm_Date;
                            selectedTask.Content = item.Content;
                            selectedTask.IsComplete = item.IsComplete;
                        }
                    }
                }
            }


            return selectedTask;
        }

        /// <summary>
        /// A function to get the number of tasks about a day [Completed].
        /// </summary>
        /// <returns></returns>
        public static int GetCurrentDayTaskNumber_Completed(int MonthNumber, int DayNumber)
        {
            int output = 0;
            int index = 0;

            foreach (var item in Date_Table)
            {
                if (item.Month_ID == MonthNumber && item.Date_ID == DayNumber)
                {
                    if (Task_Table[index].IsComplete == 1)
                    {
                        output++;
                    }
                }

                index++;
            }

            return output;
        }

        /// <summary>
        /// A function to get the number of tasks about a day [NotCompleted].
        /// </summary>
        /// <returns></returns>
        public static int GetCurrentDayTaskNumber_Not_Completed(int MonthNumber, int DayNumber)
        {
            int output = 0;
            int index = 0;

            foreach (var item in Date_Table)
            {
                if (item.Month_ID == MonthNumber && item.Date_ID == DayNumber)
                {
                    if (Task_Table[index].IsComplete == 0)
                    {
                        output++;
                    }
                }

                index++;
            }

            return output;
        }

        /// <summary>
        /// If edit,read,delete and insert sql functions occurs when program is running.
        /// </summary>
        public static void RefreshDbLists_Insert(DataModel.Date date_model, DataModel.Task task_model)
        {

            bool isAvaliableTask = true;
            foreach (var item in Date_Table)
            {
                if (item.Task_ID == date_model.Task_ID)
                {
                    isAvaliableTask = false;
                    return;
                }
            }
            if (isAvaliableTask)
            {
                //DATE TABLE

                Date_Table.Add(new DataModel.Date
                {
                    Date_ID = date_model.Date_ID,
                    Task_ID = date_model.Task_ID
                });

                //TASK TABLE

                Task_Table.Add(new DataModel.Task
                {
                    Level = task_model.Level,
                    Alarm_Date = task_model.Alarm_Date,
                    Content = task_model.Content,
                    IsComplete = task_model.IsComplete
                });
                Console.WriteLine(task_model.Id + " successfully refreshed the local lists.");
            }
            else
            {
                Console.WriteLine(task_model.Id + " is already in database.");
                return;
            }
        }
        public static void RefreshDbLists_Edit(DataModel.Date date_model, DataModel.Task task_model)
        {
            bool thereIsData = false;

            //DATE table
            foreach (var item in Date_Table)
            {
                if (item.Date_ID == date_model.Date_ID) { thereIsData = true; }
            }

            //TASK table
            if (thereIsData)
            {
                foreach (var item in Task_Table)
                {
                    if (item.Id == task_model.Id)
                    {
                        item.Level = task_model.Level;
                        item.Alarm_Date = task_model.Alarm_Date;
                        item.Content = task_model.Content;
                        item.IsComplete = task_model.IsComplete;
                    }
                }
            }
        }
        public static void RefreshDbLists_Delete(DataModel.Date date_model, DataModel.Task task_model)
        {
            //DATE TABLE
            bool isInList_1 = Date_Table.Any(item => item.Task_ID == date_model.Task_ID);

            if (isInList_1 == true)
            {
                Date_Table.Remove(date_model);
            }


            //TASK TABLE
            bool isInList_2 = Task_Table.Any(item => item.Id == task_model.Id);

            if (isInList_2 == true)
            {
                Task_Table.Remove(task_model);
            }
        }

        

        public static void CheckGlobalDbIntegrity()
        {
            if (Date_Table.Count == 0) { Read(); }
        }
        public static void RefreshLocalDB()
        {
            Date_Table = new List<DataModel.Date>();
            Task_Table = new List<DataModel.Task>();

            Read();
        }

        #endregion

        #region Properties

        #region Database


        private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Data\CalendarDB.mdf;Integrated Security=True";


        #endregion


        #region SelectFor_RowProp

        private int readed_Row = 0;

        #endregion

        public static List<DataModel.Date> Date_Table = new List<DataModel.Date>();
        public static List<DataModel.Task> Task_Table = new List<DataModel.Task>();

        public static List<DataModel.Task> Selected_Tasks = new List<DataModel.Task>();

        #endregion
    }
}
