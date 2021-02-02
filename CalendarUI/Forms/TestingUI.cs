using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Calendar.Models;

namespace Forms.Form1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        private static List<Panel> dayPanels = new List<Panel>();

        public Form1()
        {
            InitializeComponent();
        }
        private void LoadCalendar_OnLoad()
        {
            //1.: Generate Calendar
            GenerateCalendarTemplate();

            //2.: Position that
            SizeModified();

            //3.: Load the data
            LoadUserData_OnLoad();
        }
        private void GenerateCalendarTemplate()
        {
            #region PANELS

            int rows = tableLayoutPanel1.RowCount;
            int columns = tableLayoutPanel1.ColumnCount;
            int day = 1;

            string[] days =
            {
                "Hétfő","Kedd","Szerda","Csütörtök","Péntek","Szombat","Vasárnap"
            };

            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < columns; i++)
                {
                    //THIS ROW IS THE TITLE ROW
                    if (j == 0)
                    {
                        Label title = new Label()
                        {
                            Anchor = AnchorStyles.None,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Text = days[i],
                            Name = "daysTitle" + i.ToString()
                        };
                        tableLayoutPanel1.Controls.Add(title, i, j);
                    }
                    else
                    {
                        Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                        Panel panel = new Panel()
                        {
                            Name = "dayPanel" + day.ToString(),
                            BackColor = randomColor,
                            Dock = DockStyle.Fill
                        };
                        Label dayNumber = new Label()
                        {
                            Text = day.ToString(),
                            Anchor = AnchorStyles.None,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Name = "dayNumber" + day.ToString()
                        };

                        //this needed for anchor left corner EZZEL MÉG VALAMIT KEZDENI KELL
                        //dayNumber.Location = new Point(dayNumber.Location.X, dayNumber.Location.Y - dayNumber.Size.Height);
                        panel.Controls.Add(dayNumber);

                        panel.Click += dayPanel_Click;

                        tableLayoutPanel1.Controls.Add(panel, i, j);

                        day++;

                        dayPanels.Add(panel);
                    }
                }
            }

            #endregion
        }
        
        private void SizeModified()
        {
            int rows = tableLayoutPanel1.RowCount;
            int columns = tableLayoutPanel1.ColumnCount;

            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel1.ColumnStyles[i].Width = (float)tableLayoutPanel1.Width / columns;

                for (int j = 0; j < rows; j++)
                {
                    tableLayoutPanel1.RowStyles[j].Height = (float)tableLayoutPanel1.Height / rows - 1;
                }
            }
        }

        private void LoadUserData_OnLoad()
        {
            //VALUES
            List<int> daysNumber = new List<int>();


            //1.: RestoreDB
            TaskModel.CheckGlobalDbIntegrity();

            //2.: Convert DayPanels name into number
            daysNumber =CollectDaysNumber();

            //3.: Seeking unfinishedTasks in DB
            Dictionary<DataModel.Task, int> unFinishedTasks = CollectUnfinishedTasks(daysNumber);

            //4.: Fill the root panels( day panels ) with subpanels
            DrawTasksPanel(unFinishedTasks, daysNumber);
            
        }
        #region LoadUserData_OnLoad SUB functions

        private List<int> CollectDaysNumber()
        {
            List<int> days = new List<int>();

            for (int i = 0; i < dayPanels.Count; i++)
            {
                days.Add(InputModel.Int(dayPanels[i].Name));
            }

            return days;
        }

        private Dictionary<DataModel.Task, int> CollectUnfinishedTasks(List<int>daysNumber)
        {
            Dictionary<DataModel.Task,int> unFinishedTasks =new Dictionary<DataModel.Task, int>();

            for (int i = 0; i < daysNumber.Count; i++)
            {
                int taskNumber = 0;
                for (int j = 0; j < TaskModel.Date_Table.Count; j++)
                {
                    if (daysNumber[i] == TaskModel.Date_Table[j].Date_ID && TaskModel.Task_Table[j].IsComplete == 1)
                    {
                        taskNumber++;

                        unFinishedTasks.Add(TaskModel.SelectTaskByDayNumber_Row(taskNumber,
                            daysNumber[i], false),daysNumber[i]);
                    }
                }
            }

            return unFinishedTasks;
        }

        private void DrawTasksPanel(Dictionary<DataModel.Task, int> unFinishedTasks,List<int>daysNumber)
        {
            for (int i = 0; i < daysNumber.Count; i++)
            {
                foreach (KeyValuePair<DataModel.Task,int> item in unFinishedTasks)
                {
                    //day equals to the dayPanel ID( name )
                    if(item.Value == daysNumber[i])
                    {
                        dayPanels[i].Controls.AddRange(GenerateFlagPanel(daysNumber[i]));
                    }
                }
            }
        }

        private Control[] GenerateFlagPanel(int dayNumber)
        {
            //It is to get labeled the upper panel in the root panel
            Panel titlePanel = new Panel()
            {
                Name="titlePanel"+dayNumber.ToString(),
                Dock=DockStyle.Top,
                BackColor=Color.Pink,

            };
            titlePanel.Size = new Size(titlePanel.Width, 33);

            //Place for task's flags
            Panel flagPanel = new Panel()
            {
                Name = "flagPanel" + dayNumber.ToString(),
                Dock = DockStyle.Top,
                BackColor = Color.Green
            };
            flagPanel.Size = new Size(flagPanel.Width, 37);

            Control[] ctl =
            {
                titlePanel,flagPanel
            };

            return ctl;
        }
        #endregion

        #region Form_Events

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadCalendar_OnLoad();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SizeModified();
        }

        #endregion

        #region Click_Events

        #region DayPanel

        private void dayPanel_Click(object sender, EventArgs e)
        {
            Panel rootPanel = (Panel)sender;
            int selectDayNumber = InputModel.Int(rootPanel.Name);

            TaskModel.Selected_Tasks = TaskModel.SelectTaskByDayNumber_List(selectDayNumber, false);

            try
            {
                MessageBox.Show(TaskModel.Selected_Tasks[0].Content);
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        #endregion

        #endregion
    }
}
