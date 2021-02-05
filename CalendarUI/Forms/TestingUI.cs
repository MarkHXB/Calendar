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
using CalendarUI.Forms;

namespace Forms.Form1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public List<Panel> dayPanels = new List<Panel>();
        public int MenuOptions = 1;
        public int MenuOptionsRow = 1;


        private int CurrentMonthNumber = 1;



        public Form1()
        {
            InitializeComponent();
        }
        private void LoadCalendar_OnLoad()
        {
            //1.: Set month days
            CalcutaMonthDays(DateTime.Now.Month);

            //2.: Generate Calendar
            GenerateCalendarTemplate();

            //3.: Position that
            SizeModified();

            //4.: Load the data
            LoadUserData_OnLoad();
        }
        private void CalcutaMonthDays(int Month)
        {
            //SET CURRENT Month nUmber
            CurrentMonthNumber = (int)DateTime.Now.Month;

            int monthDaysCount = CurrentMonthDayCount(Month);
            int counter = 0;

            foreach (var item in dayPanels)
            {
                //Label title = item.Controls.OfType<Label>().ToList().Where(x => x.Name.Contains("dayTitle")).First();

                //counter++;                
            }

            Console.WriteLine(monthDaysCount);

            //FEBRUARY
            if(monthDaysCount == 28)
            {
                //2 row is for menu
                //others are for days
                tableLayoutPanel1.RowCount = 2 + 4;
            }
            else if(monthDaysCount == 29)
            {
                //2 row is for menu
                //others are for days
                tableLayoutPanel1.RowCount = 2 + 5;
            }
            //OTHERS
            else if (monthDaysCount == 30)
            {
                //2 row is for menu
                //others are for days
                tableLayoutPanel1.RowCount = 2 + 5;
            }
            else if (monthDaysCount == 31)
            {
                //2 row is for menu
                //others are for days
                tableLayoutPanel1.RowCount = 2 + 5;
            }
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
                    else if (j == MenuOptionsRow && i== MenuOptions-1)
                    {
                        Panel head = new Panel()
                        {
                            BackColor = Color.Beige,
                            Anchor = AnchorStyles.None,
                        };

                        Button prevBtn = new Button()
                        {
                            Name = "prevMonthBtn",
                            Anchor = AnchorStyles.Left,
                            TextAlign= ContentAlignment.MiddleLeft,
                            BackgroundImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\prevBtn.png"),
                            BackgroundImageLayout=ImageLayout.Zoom,
                            Size=new Size(31,25),
                            BackColor = Color.Transparent
                        };
                        
                        Label month = new Label()
                        {
                            Anchor = AnchorStyles.None,
                            Text = CurrentMonthName(),
                            Name = "currentMonthTitle"
                        };

                        Button nextBtn = new Button()
                        {
                            Name="nextMonthBtn",
                            Anchor = AnchorStyles.None,
                            TextAlign = ContentAlignment.MiddleRight,
                            BackgroundImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\nextBtn.png"),
                            BackgroundImageLayout = ImageLayout.Zoom,
                            Size = new Size(31, 25),
                            BackColor=Color.Transparent
                        };

                        //Events
                        prevBtn.Click += prevMonth_Click;
                        nextBtn.Click += nextMonth_Click;

                        //Locations
                        prevBtn.Location = new Point(prevBtn.Location.X,(head.Height/2)-prevBtn.Height/2);
                        
                        month.Location = new Point((head.Width/2)- month.Size.Width/4, (head.Height/2)- month.Size.Height/2);

                       // nextBtn.Location = new Point(nextBtn.Location.X, (head.Height / 2) - nextBtn.Height / 2);

                        //Controls
                        head.Controls.Add(prevBtn);
                        head.Controls.Add(nextBtn);
                        head.Controls.Add(month);
                        tableLayoutPanel1.Controls.Add(head, i, j);
                    }
                    else if(j>1)
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
                            Anchor = AnchorStyles.Left,
                            TextAlign = ContentAlignment.TopLeft,
                            Name = "dayNumber" + day.ToString()
                        };

                        //this needed for anchor left corner EZZEL MÉG VALAMIT KEZDENI KELL
                        //dayNumber.Location = new Point();
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


            //TABLELAYOUTPANEL
            for (int i = 0; i < columns; i++)
            {
                tableLayoutPanel1.ColumnStyles[i].Width = (float)tableLayoutPanel1.Width / columns;

                for (int j = 0; j < rows; j++)
                {
                    tableLayoutPanel1.RowStyles[j].Height = (float)tableLayoutPanel1.Height / rows - 1;
                }
            }

            //DAYPANELS      
            /*foreach (var item in dayPanels)
            {
                Label dayNumber = item.Controls.OfType<Label>().ToList().Where(x => x.Name.Contains("dayNumber")).First();

                dayNumber.Location = new Point(dayNumber.Location.X, dayNumber.Location.Y);
            }
            */
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

            //4.: Fill the root panels( day panels ) with subpanels ( flags )
            DrawTasksPanel(unFinishedTasks, daysNumber);
            
        }


        #region LoadUserData_OnLoad functions

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
                    if (daysNumber[i] == TaskModel.Date_Table[j].Date_ID && TaskModel.Task_Table[j].IsComplete == 0)
                    {
                        taskNumber++;

                        unFinishedTasks.Add(TaskModel.SelectTaskByDayNumber_Row(taskNumber,
                            daysNumber[i], CurrentMonthNumber,true),daysNumber[i]);
                    }
                }
            }

            return unFinishedTasks;
        }

        private void DrawTasksPanel(Dictionary<DataModel.Task, int> unFinishedTasks,List<int>daysNumber)
        {
            for (int i = 0; i < daysNumber.Count; i++)
            {
                int taskPerDay = 0;
                foreach (KeyValuePair<DataModel.Task,int> item in unFinishedTasks)
                {
                    
                    //day equals to the dayPanel ID( name )
                    if(item.Value == daysNumber[i])
                    {

                        taskPerDay++;
                        if (taskPerDay > 1)
                        {
                            
                            Panel flagPanel = dayPanels[i].Controls.OfType<Panel>().ToList().Where(x => x.Name.Contains("flagPanel")).First();
                            //dayPanels[i].Controls.Add(PushFlagToPanel(item.Key.Level,flagPanel));
                            PushFlagToPanel(item.Key.Level,flagPanel,taskPerDay);
                        }
                        else
                        {
                            dayPanels[i].Controls.AddRange(GenerateFlagPanel(daysNumber[i]));

                            Panel flagPanel = dayPanels[i].Controls.OfType<Panel>().ToList().Where(x => x.Name.Contains("flagPanel")).First();
                            PushFlagToPanel(item.Key.Level, flagPanel, taskPerDay);
                        }
                    }
                }
            }
        }

        private Control[] GenerateFlagPanel(int dayNumber)
        {

            //It is to get labeled the upper panel in the root panel
            Panel titlePanel = new Panel()
            {
                Name = "titlePanel" + dayNumber.ToString(),
                Dock = DockStyle.Top,
                BackColor=Color.Black
            };
            titlePanel.Size = new Size(titlePanel.Width, 33);

            //Place for task's flags
            Panel flagPanel = new Panel()
            {
                Name = "flagPanel" + dayNumber.ToString(),
                Dock = DockStyle.Top,
                BackColor=Color.White
            };
            flagPanel.Size = new Size(flagPanel.Width, 37);


            Control[] ctl =
            {
                flagPanel,titlePanel
            };

            return ctl;
        }
        private void PushFlagToPanel(int Level,Panel Head,int CountTask)
        {
            if (CountTask >= 3)
            {
                Label moreTaskLbl = new Label()
                {
                    Text = "+" + CountTask.ToString()
                };

                moreTaskLbl.Location = GetNeededFlag_Position(moreTaskLbl.Size.Width, CountTask);

                Head.Controls.Add(moreTaskLbl);
            }
            else
            {
                PictureBox flag = new PictureBox()
                {
                    Size = new Size(35, 25),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = GetNeededFlag_Image(Level),
                    Name = "flag" + "_" + InputModel.Int(Head.Name)
                };
                flag.Location = GetNeededFlag_Position(flag.Size.Width, CountTask);

                flag.Click += SelectedFlag_Click;

                Head.Controls.Add(flag);
            }
        }

        private Image GetNeededFlag_Image(int Level)
        {
            Image img = null;
            string path = @"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\";

            if (Level == 1)
            {
                img = Image.FromFile(path + "flag_1.png");
            }
            else if (Level == 2)
            {
                img = Image.FromFile(path + "flag_2.png");
            }
            else
            {
                img = Image.FromFile(path + "flag_3.png");
            }
            

            return img;
        }

        private Point GetNeededFlag_Position(int FlagSizeWidth,int CountTask)
        {
            Point loc = new Point();

            if (CountTask == 1)
            {
                loc = new Point(3, 6);
            }
            else if(CountTask==2)
            {
                loc = new Point(FlagSizeWidth, 6);
            }
            else
            {
                loc = new Point(FlagSizeWidth-10 , 6);
            }

            return loc;
        }

        private int CurrentMonthDayCount(int Month)
        {
            int days = 0;

            days= DateTime.DaysInMonth(DateTime.Now.Year, Month);

            return days;
        }

        private string CurrentMonthName()
        {
            string output = "";

            DateTime date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            output = date.ToString("MMMM");

            return output;
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

            TaskModel.Selected_Tasks = TaskModel.SelectTaskByDayNumber_List(selectDayNumber,CurrentMonthNumber, true);

            try
            {
                MessageBox.Show(TaskModel.Selected_Tasks[1].Content);
                EditForm form = new EditForm();
                form.Show();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }

        private void SelectedFlag_Click(object sender, EventArgs e)
        {
            PictureBox root = (PictureBox)sender;

            //IDE EGY EDIT-COMPLTE megoldás
            MessageBox.Show(InputModel.Int(root.Name).ToString());
        }

        #endregion

        #region Monts
        private void nextMonth_Click(object sender, EventArgs e)
        {
            
        }

        private void prevMonth_Click(object sender, EventArgs e)
        {
        }
        #endregion

        #endregion
    }
}
