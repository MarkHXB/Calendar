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
using CalendarLibrary.Models;

namespace Forms.Form1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public List<Panel> dayPanels = new List<Panel>();
        public int MenuOptions = 2;
        public int MenuOptionsRow = 1;

        #region ForEditForm

        public static int CurrentYear = MainFormModel.Year;
        public static int MonthNumber = MainFormModel.Month;
        public static int SelectedMonthNumber = 1;

        public static Form form = null;

        public TableLayoutPanel Table = null;

        private int FlowedDays = 0;

        #endregion


        public Form1()
        {
            InitializeComponent();
            form = this;
            Table = new TableLayoutPanel();
        }
        public static void RefreshForm()
        {
            TaskModel.RefreshLocalDB();

            form.Refresh();
        }
        
        private void LoadCalendar_OnLoad()
        {

            SetTableConfig();

            //1.: Set month days
            CalcutaMonthDays(MonthNumber);

            //2.: Generate Calendar
            GenerateCalendarTemplate();

            //3.: Position that
            SizeModified();

            //4.: Load the data
            LoadUserData_OnLoad();
        }

        #region LoadUserData_OnLoad MAIN functions

        private void CalcutaMonthDays(int Month)
        {
            LogModel.MakeAlart(new DataModel.Task() { Alarm_Date = DateTime.Now });
 
            //SET CURRENT Month nUmber
            int monthDaysCount = CurrentMonthDayCount(Month);

            //FEBRUARY
            if (monthDaysCount < 28)
            {
                //2 row is for menu
                //others are for days
                Table.RowCount = 2 + 3;
            }
            else if (monthDaysCount == 28)
            {
                //2 row is for menu
                //others are for days
                Table.RowCount = 2 + 4;
            }
            else if(monthDaysCount == 29)
            {
                //2 row is for menu
                //others are for days
                Table.RowCount = 2 + 5;
            }
            //OTHERS
            else if (monthDaysCount == 30)
            {
                //2 row is for menu
                //others are for days
                Table.RowCount = 2 + 5;
            }
            else if (monthDaysCount == 31)
            {
                //2 row is for menu
                //others are for days
                Table.RowCount = 2 + 5;
            }
        }

        private void GenerateCalendarTemplate()
        {
            #region PANELS
            


            int rows = Table.RowCount;
            int columns = Table.ColumnCount;
            int day = 1;

            string[] days =
            {
                "Hétfő","Kedd","Szerda","Csütörtök","Péntek","Szombat","Vasárnap"
            };

            //TABLE
            for (int j = 0; j < rows; j++)
            {
                for (int i = 0; i < columns; i++)
                {
                    //THIS ROW IS THE TITLE ROW ~ DAYS TITLE ~
                    if (j == 0)
                    {
                        Label title = new Label()
                        {
                            Anchor = AnchorStyles.None,
                            TextAlign = ContentAlignment.MiddleCenter,
                            Text = days[i],
                            Name = "daysTitle" + i.ToString()
                        };
                        Table.Controls.Add(title, i, j);
                    }

                    //STRIP MENU
                    else if (j == MenuOptionsRow && i == 0)
                    {
                        Panel head = new Panel()
                        {
                            Dock = DockStyle.Fill,
                            BackColor = Color.White
                        };
                        head.Paint += monthChooserPanel_Paint;

                        Button prevMonthBtn = new Button()
                        {
                            BackgroundImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\prevBtn.png"),
                            BackgroundImageLayout = ImageLayout.Zoom,
                            Name = "prevMonthBtn",
                            Text = "",
                            BackColor = Color.Transparent,
                            FlatStyle = FlatStyle.Flat,
                            Anchor = AnchorStyles.Left,
                            Width = 30
                        };
                        prevMonthBtn.FlatAppearance.BorderSize = 0;
                        prevMonthBtn.Location = new Point(0, head.Height / 2);
                        prevMonthBtn.Click += prevMonthBtn_Click_1;

                        Button nextMonthBtn = new Button()
                        {
                            BackgroundImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\nextBtn.png"),
                            BackgroundImageLayout = ImageLayout.Zoom,
                            Name = "nextMonthBtn",
                            Text = "",
                            BackColor = Color.Transparent,
                            FlatStyle = FlatStyle.Flat,
                            Anchor = AnchorStyles.Right,
                            Width = 30
                        };
                        nextMonthBtn.FlatAppearance.BorderSize = 0;
                        nextMonthBtn.Location = new Point(head.Width - nextMonthBtn.Width, head.Height / 2);
                        nextMonthBtn.Click += nextMonthBtn_Click_1;

                        head.Controls.Add(prevMonthBtn);
                        head.Controls.Add(nextMonthBtn);

                        Label currentMonthTitle = new Label()
                        {
                            Name = "currentMonthTitle",
                            Text = CurrentMonthName(MonthNumber),
                            Anchor = AnchorStyles.None,
                            TextAlign = ContentAlignment.MiddleCenter,
                        };
                        currentMonthTitle.Location = new Point(head.Width / 2 - currentMonthTitle.Width / 2, head.Height / 2);

                        head.Controls.Add(currentMonthTitle);

                        Table.Controls.Add(head, i, j);
                    }
                    else if (j == MenuOptionsRow && i == 1)
                    {
                        Panel head = new Panel()
                        {
                            Dock = DockStyle.Fill,
                            BackColor = Color.LightBlue,
                            Name = "addNewTaskManually"
                        };
                        Panel insertPanel = new Panel()
                        {
                            Name="insertPanel",
                            Dock=DockStyle.Top,
                            Size=new Size(head.Width,36),
                            BackColor=Color.White,
                            BorderStyle=BorderStyle.FixedSingle
                        };
                        head.Controls.Add(insertPanel);

                        Label insertTitle = new Label()
                        {
                            Name = "insertPanelTitle",
                            Text = "Új feladat hozzáadása",
                            Font = new Font(new FontFamily(this.Font.Name), 11f, FontStyle.Bold),
                            Anchor = AnchorStyles.Top, 
                            Cursor=Cursors.Hand
                        };
                        insertPanel.Controls.Add(insertTitle);
                        insertTitle.Location = new Point(head.Width / 2 - insertTitle.Width / 2, 7);
                        insertTitle.Click += AddNewTaskManuallyPanel_Click;


                        Table.Controls.Add(head, i, j);
                    }

                    //Task panels
                    else if (j > 1)
                    {
                        //Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

                        Panel panel = new Panel()
                        {
                            Name = "dayPanel" + day.ToString(),
                            BackColor = Color.White,
                            Dock = DockStyle.Fill,
                        };

                        Label dayNumber = new Label()
                        {
                            Text = GetDay(day, panel),
                            Anchor = (AnchorStyles.Left | AnchorStyles.Top),
                            Name = "dayNumber" + day.ToString()
                        };
                        dayNumber.Location = new Point(3, 3);

                        panel.Controls.Add(dayNumber);

                        panel.Click += dayPanel_Click;
                        panel.Paint += dayPanel_Paint;

                        Table.Controls.Add(panel, i, j);

                        day++;

                        dayPanels.Add(panel);
                    }
                }
            }

            //STRIP MENU ~ 1 ~ Year,Month chooser
            SetMonthChooserConfig();

            #endregion
        }

        private void AddNewTaskManuallyPanel_Click(object sender, EventArgs e)
        {
            AddTaskManually form = new AddTaskManually();
            form.Show();
        }

        private string GetDay(int index,Panel head)
        {
            string output = "";

            if (index > CurrentMonthDayCount(MainFormModel.Month))
            {
                FlowedDays++;
                output = FlowedDays.ToString();
                if(head!=null)
                    head.BackColor = Color.LightGray;
                return output;
            }
            else
            {
                output = index.ToString();
                return output;
            }
        }
        private void Table_Paint(object sender, TableLayoutCellPaintEventArgs e)
        {
            int rows= Table.RowCount;
            int columns = Table.ColumnCount;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (i > 1)
                    {
                        if (e.Column == j && e.Row == i)
                        {
                            e.Graphics.DrawRectangle(new Pen(Color.FromArgb(50, 175, 176, 179)), e.CellBounds);
                        }
                    }
                }
            }
            
        }

        private void monthChooserPanel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;

            /*
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
               Color.FromArgb(50, 162, 171, 165), 1, ButtonBorderStyle.Solid, // left
               Color.FromArgb(50, 162, 171, 165), 1, ButtonBorderStyle.Solid, // top
               Color.FromArgb(50, 162, 171, 165), 1, ButtonBorderStyle.Solid, // right
               Color.FromArgb(50, 162, 171, 165), 1, ButtonBorderStyle.Solid);// bottom   
            
            */
        }

        private void dayPanel_Paint(object sender,PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            
            ControlPaint.DrawBorder(e.Graphics, panel.ClientRectangle,
              Color.FromArgb(90, 162, 171, 165), 1, ButtonBorderStyle.Solid, // left
              Color.FromArgb(90, 162, 171, 165), 1, ButtonBorderStyle.Solid, // top
              Color.FromArgb(90, 162, 171, 165), 1, ButtonBorderStyle.Solid, // right
              Color.FromArgb(90, 162, 171, 165), 1, ButtonBorderStyle.Solid);// bottom
        }

        private void SizeModified()
        {
            int rows = Table.RowCount;
            int columns = Table.ColumnCount;

            //TABLELAYOUTPANEL
            for (int i = 0; i < columns; i++)
            {
                Table.ColumnStyles.Add(new ColumnStyle() { Width = 1, SizeType = SizeType.Percent });
                Table.ColumnStyles[i].Width = (float)Table.Width / columns;
                Table.Controls[i].Invalidate();

                for (int j = 0; j < rows; j++)
                {
                    Table.RowStyles.Add(new RowStyle() { Height = 1, SizeType = SizeType.Percent });
                    Table.RowStyles[j].Height = (float)Table.Height / rows - 1;
                    Table.Controls[j].Invalidate();
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

            //3.: Seeking unfinished Tasks in DB
            Dictionary<DataModel.Task, int> unFinishedTasks = CollectUnfinishedTasks(daysNumber,MainFormModel.Month);

            //4.: Fill the root panels( day panels ) with subpanels ( flags )
            DrawTasksPanel(unFinishedTasks, daysNumber);
            
        }

        #endregion


        #region LoadUserData_OnLoad SUB functions
        private void SetMonthChooserConfig()
        {
            //currentYearTitle.Text = CurrentYear.ToString();
            //currentMonthTitle.Text = CurrentMonthName(MonthNumber);
        }

        private List<int> CollectDaysNumber()
        {
            List<int> days = new List<int>();

            for (int i = 0; i < dayPanels.Count; i++)
            {
                days.Add(InputModel.Int(dayPanels[i].Name));
            }

            return days;
        }

        private Dictionary<DataModel.Task, int> CollectUnfinishedTasks(List<int>daysNumber,int monthNumber)
        {
            Dictionary<DataModel.Task,int> unFinishedTasks =new Dictionary<DataModel.Task, int>();

            for (int i = 0; i < daysNumber.Count; i++)
            {
                int taskNumber = 0;
                for (int j = 0; j < TaskModel.Date_Table.Count; j++)
                {
                    if (daysNumber[i] == TaskModel.Date_Table[j].Date_ID 
                        && TaskModel.Task_Table[j].IsComplete == 0
                        && TaskModel.Date_Table[j].Month_ID == monthNumber)
                    {
                        taskNumber++;
                        unFinishedTasks.Add(TaskModel.SelectTaskByDayNumber_Row(taskNumber,
                            daysNumber[i], MainFormModel.Month,true),daysNumber[i]);
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
                BackColor=Color.Transparent
            };
            titlePanel.Size = new Size(titlePanel.Width, 33);

            //Place for task's flags
            Panel flagPanel = new Panel()
            {
                Name = "flagPanel" + dayNumber.ToString(),
                Dock = DockStyle.Top,
                BackColor=Color.Transparent
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
                    Size = new Size(45, 35),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = GetNeededFlag_Image(Level),
                    Name = "flag" + "_" + InputModel.Int(Head.Name),
                    Anchor=AnchorStyles.Left,
                };
                flag.Location = GetNeededFlag_Position(flag.Size.Width, CountTask);

                flag.Click += flagTask_Click;
                
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
                loc = new Point(4, 6);
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
        private string CurrentMonthName(int Month)
        {
            string output = "";

            DateTime date = new DateTime(DateTime.Now.Year, Month, DateTime.Now.Day);

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
            form.Update();

            if(this.WindowState == FormWindowState.Minimized)
            {
                int currentDayTasks = TaskModel.GetCurrentDayTaskNumber_Not_Completed(DateTime.Now.Month, DateTime.Now.Day);
                if (currentDayTasks > 0)
                {
                    notifyIcon1.BalloonTipText = $"Mára még {currentDayTasks} feladatod van!";
                    notifyIcon1.ShowBalloonTip(1000);
                }
                else
                {
                    notifyIcon1.BalloonTipText = $"Esetleg gyere vissza később!";
                    notifyIcon1.ShowBalloonTip(1000);
                }
            }
        }

        #endregion


        #region Click_Events

        #region MENU

        private void prevMonthBtn_Click_1(object sender, EventArgs e)
        {
            MonthNumber -= 1;
            MainFormModel.Month -= 1;
            if (MonthNumber == 0)
            {
                CurrentYear--;
                MonthNumber = 12;
                MainFormModel.Month = 12;
            }
            RefreshTable();
        }

        private void nextMonthBtn_Click_1(object sender, EventArgs e)
        {
            MonthNumber += 1;
            MainFormModel.Month += 1;
            if (MonthNumber == 13)
            {
                CurrentYear++;
                MonthNumber = 1;
                MainFormModel.Month = 1;
            }
            RefreshTable();
        }

        #endregion

        #region DayPanel

        private void dayPanel_Click(object sender, EventArgs e)
        {
            
            Panel rootPanel = (Panel)sender;

            MainFormModel.Day = int.Parse(rootPanel.Controls[0].Text);

            TaskModel.Selected_Tasks = TaskModel.SelectTaskByDayNumber_List(MainFormModel.Day, MainFormModel.Month);

            try
            {
                EditForm form = new EditForm();
                form.Show();

                this.Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            
        }
        private void SelectedFlag_Click(object sender, EventArgs e)
        {
            PictureBox root = (PictureBox)sender;

            Panel head = (Panel)root.Parent;

            Panel body = (Panel)head.Parent;

            body.Click += flagTask_Click;
        }
        private void flagTask_Click(object sender, EventArgs e)
        {

            PictureBox root = (PictureBox)sender;

            Panel head = (Panel)root.Parent;

            Panel rootPanel = (Panel)head.Parent;

            MessageBox.Show(rootPanel.Name);
            MainFormModel.Day = int.Parse(rootPanel.Controls[0].Text);

            TaskModel.Selected_Tasks = TaskModel.SelectTaskByDayNumber_List(MainFormModel.Day, MainFormModel.Month);

            try
            {
                EditForm form = new EditForm();
                form.Show();

                this.Hide();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

        }

        #endregion

        #region Monts
        private void nextMonth_Click(object sender, EventArgs e)
        {
            
        }


        #endregion

        #endregion


        #region Refresh the Table

        private void SetTableConfig()
        {
            if(this.Controls.Contains(Table))
                this.Controls.Remove(Table);

            Table = new TableLayoutPanel();
            Table.Name = "tableLayoutPanel1";
            Table.ColumnCount = 7;
            Table.Dock = DockStyle.Fill;

            this.Controls.Add(Table);

            FlowedDays = 0;
        }
        private void RefreshTable()
        {
            SetTableConfig();

            CalcutaMonthDays(MonthNumber);

            //2.: Generate Calendar
            GenerateCalendarTemplate();

            //3.: Position that
            SizeModified();

            //4.: Load the data
            LoadUserData_OnLoad();
        }


        #endregion

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
