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

        public TaskModel(DataModel.Date date,DataModel.Task task)
        {
            Insert(date,task);
        }

        #endregion

        #region ImplementInterfaces
        public void Delete()
        {
            
        }

        public void Edit()
        {
            
        }

        public static void Insert(DataModel.Date date,DataModel.Task task)
        {
            
        }

        public static void Read(DataModel.Date date, DataModel.Task task)
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
                            Date_ID = Convert.ToInt32(reader["Date_ID"]),
                            Task_ID = Convert.ToInt32(reader["Task_ID"])
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
                            Alarm_Date = (string)reader["Alarm"],
                            Content=(string)reader["Content"],
                            IsComplete=(int)reader["Complete"]
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

        #endregion

        #region Functions

        public List<DataModel.Task> SelectTaskByDayNumber_List(int dayNumber,bool checkIsComplete)
        {
            List<DataModel.Task> selectedTask = new List<DataModel.Task>();
            List<int> Task_ids = new List<int>();

            foreach (var item in Date_Table)
            {
                if (dayNumber == item.Date_ID)
                {
                    Task_ids.Add(item.Task_ID);
                }             
            }

            for (int i = 0; i < Task_ids.Count; i++)
            {
                foreach (var item in Task_Table)
                {
                    if(checkIsComplete == true && item.IsComplete == 0)
                    {
                        if (Task_ids[i] == item.Id)
                        {
                            selectedTask.Add(new DataModel.Task
                            {
                                Id = item.Id,
                                Level=item.Level,
                                Alarm_Date=item.Alarm_Date,
                                Content=item.Content,
                                IsComplete=item.IsComplete
                            });
                        }
                    }
                    else if(checkIsComplete == false && item.IsComplete == 1)
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
        public DataModel.Task SelectTaskByDayNumber_Row(int dayNumber, bool checkIsComplete)
        {
            DataModel.Task selectedTask = new DataModel.Task();
            List<int> Task_ids = new List<int>();

            foreach (var item in Date_Table)
            {
                if (dayNumber == item.Date_ID)
                {
                    Task_ids.Add(item.Task_ID);
                }
            }

            for (int i = 0; i < Task_ids.Count-readed_Row; i++)
            {
                foreach (var item in Task_Table)
                {
                    if (checkIsComplete == true && item.IsComplete == 0)
                    {
                        if (Task_ids[i] == item.Id)
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
                        if (Task_ids[i] == item.Id)
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
        /// If edit,read,delete and insert sql functions occurs when program is running.
        /// </summary>
        public static void RefreshDbLists_Insert(DataModel.Date date_model, DataModel.Task task_model)
        {
            //DATE TABLE

            Date_Table.Add(new DataModel.Date
            {
                Date_ID = date_model.Date_ID,
            });



            //TASK TABLE

            Task_Table.Add(new DataModel.Task
            {
                Level = task_model.Level,
                Alarm_Date = task_model.Alarm_Date,
                Content = task_model.Content,
                IsComplete = task_model.IsComplete
            });

        }
        public static void RefreshDbLists_Edit(DataModel.Date date_model, DataModel.Task task_model)
        {
            //DATE table


            //TASK table
            //ezt még valahogy javítanom kell
            foreach (var item in Task_Table)
            {
                if (item.Level == task_model.Level &&
                    item.Alarm_Date == task_model.Alarm_Date &&
                    item.Content == task_model.Content)
                {
                    item.Level = task_model.Level;
                    item.Alarm_Date = task_model.Alarm_Date;
                    item.Content = task_model.Content;
                }
            }
        }
        public static void RefreshDbLists_Delete(DataModel.Date date_model, DataModel.Task task_model)
        {
            //DATE TABLE
            bool isInList_1 = Date_Table.Any(item => item.Task_ID == date_model.Date_ID);

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

        #endregion

        #region Properties

            #region Database

         
            private static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Datas.mdf;Integrated Security=True";


            #endregion


        #region SelectFor_RowProp
        private int readed_Row = 0;
        #endregion

        public static List<DataModel.Date> Date_Table = new List<DataModel.Date>();
        public static List<DataModel.Task> Task_Table = new List<DataModel.Task>();

        #endregion
    }
}
