using Calendar.Models;
using CalendarLibrary.Models;
using Forms.Form1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarUI.Forms
{
    public partial class EditForm : Form
    {
        private static DataModel.Task test = new DataModel.Task();
        private static DataModel.Task test2 = new DataModel.Task();

        private static DataModel.Date SelectedRow_Date= null;
        private static DataModel.Task SelectedRow_Task = null;

        private static List<DataModel.Task> Loaded_Data_Tasks = new List<DataModel.Task>();

        private int lastTaskPanelPosY = 42;
        private int lastFollowLinePosY = 42;

        private Label lastStatusBtnClicked = null;

        private Panel updatePanel = null;

        private List<bool> Clicked_TaskPanel;

        public EditForm()
        {
            InitializeComponent();
        }




        #region Form_Functions


        #endregion


        #region Set OnLoad Data


        private void Testing_Data()
        {
            test.Id = 1;
            test.Level = 1;
            test.Content = "valami";
            test.IsComplete = 0;

            test2.Id = 1;
            test2.Level = 3;
            test2.Content = "valami2";
            test2.IsComplete = 0;
        }

        private void SetLabelContents()
        {
            unsuccededLabel.Text = TaskModel.GetCurrentDayTaskNumber_Not_Completed(MainFormModel.Month, MainFormModel.Day).ToString();
            succededLabel.Text = TaskModel.GetCurrentDayTaskNumber_Completed(MainFormModel.Month, MainFormModel.Day).ToString();

            string finalTxt = MainFormModel.Month < 10 ? "0" + MainFormModel.Month.ToString() : MainFormModel.Month.ToString();
            string finalDTxt = MainFormModel.Day < 10 ? "0" + MainFormModel.Day.ToString() : MainFormModel.Day.ToString();
            monthLabel.Text = finalTxt + "." + finalDTxt;
            monthLabel.Location = new Point(showPnTitlePn.Width / 2 - monthLabel.Width / 2, monthLabel.Location.Y);
            dayLabel.Text = InputModel.GetMonthDayName(MainFormModel.Month, MainFormModel.Day);
            dayLabel.Location = new Point(showPnTitlePn.Width / 2 - dayLabel.Width / 2, dayLabel.Location.Y);
        }

        private void SetBasiclblContents()
        {
            editPnTitlePn.BackColor = Color.FromArgb(81, 196, 163);
            editPnTitlePn.ForeColor = Color.White;

            //testPanel.BackColor = Color.FromArgb(70, Color.Red);
        }

        private Color DecideCurrentTaskColor(DataModel.Task task)
        {
            if(task.Level == 1)
            {
                return Color.FromArgb(70,Color.Blue);
            }
            else if (task.Level == 2)
            {
                return Color.FromArgb(70, Color.Green);
            }
            else
            {
                return Color.FromArgb(70, Color.Red);
            }
        }
        
        private Panel SetTaskPanelSettings(DataModel.Task task,int index)
        {
            Panel panel = new Panel()
            {
                Size=new Size(430,97),
                Name="taskPanel"+index.ToString(),
                BackColor=DecideCurrentTaskColor(task),
                Location=new Point(64,lastTaskPanelPosY)
            };
            Button completeBtn = new Button()
            {
                Name = "completeBtn" + index.ToString(),
                Location = new Point(0, 0),
                BackgroundImage=Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\complete.png"),
                BackgroundImageLayout=ImageLayout.Zoom,
                Size=new Size(25,25),
                FlatStyle=FlatStyle.Flat,
                BackColor=Color.FromArgb(70,Color.White)
                
            };
            completeBtn.FlatAppearance.BorderSize = 0;
            completeBtn.Click += taskCompleteBtn_Click;

            Label dayTitle = new Label()
            {
                Name = "taskPanelTitle" + index.ToString(),
                Text = task.Alarm_Date.ToString("MMM-dd"),
                Font = new Font(new FontFamily(this.Font.Name), 14f),
                Location = new Point(166, 1),
                BackColor = Color.Transparent
            };

            Button deleteBtn = new Button()
            {
                Name="deleteBtn"+index.ToString(),
                BackgroundImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\delete.png"),
                BackgroundImageLayout = ImageLayout.Zoom,
                Size = new Size(25, 25),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(70, Color.White)
            };
            deleteBtn.Location = new Point(panel.Width - deleteBtn.Width, 0);
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.Click += taskDeleteBtn_Click;

            deleteBtn.FlatAppearance.BorderSize = 0;
            TextBox taskContent = new TextBox()
            {
                Name = "taskPanelContent" + index.ToString(),
                Text = task.Content,
                Font = new Font(new FontFamily(this.Font.Name), 12f),
                Location = new Point(14, 37),
                Size = new Size(398, 31),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical
            };
            Label taskTime = new Label()
            {
                Name = "taskPanelTimeWarn" + index.ToString(),
                Text = task.Alarm_Date.ToString("HH:mm"),
                Font = new Font(new FontFamily(this.Font.Name), 11f),
                Location=new Point(5,panel.Height-25),
                BackColor=Color.Transparent
            };

            Control[] panelContent =
            {
                dayTitle,taskContent,completeBtn,deleteBtn,taskTime
            };

            panel.Click += taskPanel_Click;

            panel.Controls.AddRange(panelContent);

            lastTaskPanelPosY += 119;

            return panel;
        }
        /// <summary>
        /// for others
        /// </summary>
        private void RefreshForm_New()
        {

        }
        /// <summary>
        /// For delete and complet
        /// </summary>
        private void RefreshForm_Old()
        {

            this.Hide();

            TaskModel.RefreshLocalDB_EditForm();

            EditForm form = new EditForm();

            form.Show();
        }
        private void taskDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;

                Panel currentTask = (Panel)button.Parent;

                string Date = currentTask.Controls.OfType<Label>().ToList().Where(x => x.Name.Contains("taskPanelTitle")).First().Text;
                string Content = currentTask.Controls.OfType<TextBox>().ToList().Where(x => x.Name.Contains("taskPanelContent")).First().Text;

                foreach (var item in Loaded_Data_Tasks)
                {
                    if (item.Alarm_Date == Convert.ToDateTime(Date) && item.Content == Content)
                    {
                        foreach (var value in TaskModel.Date_Table)
                        {
                            if (item.Id == value.Task_ID)
                            {
                                TaskModel.Delete(value);
                            }
                        }
                    }
                }

                RefreshForm_Old();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }

        private void taskCompleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;

                Panel currentTask = (Panel)button.Parent;

                string Date = currentTask.Controls.OfType<Label>().ToList().Where(x => x.Name.Contains("taskPanelTitle")).First().Text;
                string Content = currentTask.Controls.OfType<TextBox>().ToList().Where(x => x.Name.Contains("taskPanelContent")).First().Text;

                foreach (var item in Loaded_Data_Tasks)
                {
                    if (item.Alarm_Date == Convert.ToDateTime(Date) && item.Content == Content)
                    {
                        foreach (var value in TaskModel.Date_Table)
                        {
                            if(item.Id == value.Task_ID)
                            {
                                TaskModel.Complete(value);
                            }
                        }         
                    }    
                }

                RefreshForm_Old();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }

        private void taskPanel_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;

            if (Clicked_TaskPanel[InputModel.Int(panel.Name)])
            {
                panel.Invalidate();

                Clicked_TaskPanel[InputModel.Int(panel.Name)] = false;
            }
            else
            {
                panel.CreateGraphics().DrawRectangle(new Pen(new SolidBrush(Color.Blue), 5), panel.ClientRectangle);

                Clicked_TaskPanel[InputModel.Int(panel.Name)] = true;
            }

            Label Date = panel.Controls.OfType<Label>().ToList().Where(x => x.Name.Contains("taskPanelTitle")).First();
            TextBox Content = panel.Controls.OfType<TextBox>().ToList().Where(x => x.Name.Contains("taskPanelContent")).First();
         
            foreach (var item in Loaded_Data_Tasks)
            {
                if (item.Content == Content.Text)
                {
                    SelectedRow_Task = item;
                    
                }
            }

            foreach (var item in TaskModel.Date_Table)
            {
                foreach (var date in Loaded_Data_Tasks)
                {
                    if(date.Id == item.Task_ID)
                    {
                        SelectedRow_Date = item;
                    }
                }
            }
    
            try
            {
                Panel root = this.Controls.OfType<Panel>().ToList().Where(x => x.Name.Contains("statusPanel")).First();

                Panel modifyPanel= root.Controls.OfType<Panel>().ToList().Where(x => x.Name.Contains("modifyPanel")).First();

                TextBox alarmBox = modifyPanel.Controls.OfType<TextBox>().ToList().Where(x => x.Name.Contains("modifyAlarmDate")).First();
                TextBox contentBox = modifyPanel.Controls.OfType<TextBox>().ToList().Where(x => x.Name.Contains("modifyContentBox")).First();


                alarmBox.Text = MainFormModel.Year + "." + SelectedRow_Date.Month_ID.ToString() + "." + SelectedRow_Date.Date_ID.ToString();
                contentBox.Text = Content.Text;

                updatePanel = modifyPanel;
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
        }

        private PictureBox FollowLine(string type)
        {
            PictureBox pct = null;

            switch (type)
            {
                case "waiting":
                    pct = new PictureBox()
                    {
                        Image=Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\follow_line_waiting.png"),
                        SizeMode=PictureBoxSizeMode.Zoom,
                        Location=new Point(12,lastFollowLinePosY),
                        Size=new Size(29,116)
                    };
                    break;
                case "unfinished":
                    pct = new PictureBox()
                    {
                        Image = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\follow_line_unfinished.png"),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(12, lastFollowLinePosY),
                        Size = new Size(29, 116)
                    };
                    break;
                case "complete":
                    pct = new PictureBox()
                    {
                        Image = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\follow_line_complet.png"),
                        SizeMode = PictureBoxSizeMode.Zoom,
                        Location = new Point(12, lastFollowLinePosY),
                        Size = new Size(29, 116)
                    };
                    break;
            }

            return pct;
        }

        private void GenerateFollowLine(DataModel.Task task)
        {
            DateTime now = DateTime.Now;
            PictureBox line = null;

            //Still waiting
            if(task.IsComplete == 0 && now.Day < MainFormModel.Day)
            {
                line=FollowLine("waiting");
            }
            //Unfinished
            else if (task.IsComplete == 0 && now.Day > MainFormModel.Day)
            {
                line=FollowLine("unfinished");
            }
            else if(task.IsComplete == 0 && now.Day == MainFormModel.Day)
            {
                line = FollowLine("waiting");
            }
            //Still waiting
            else if (task.IsComplete == 1)
            {
                line=FollowLine("complete");
            } 

            showPnTaskPn.Controls.Add(line);

            lastFollowLinePosY += 109;
        }

        private void GenerateTaskPanels()
        {
            Loaded_Data_Tasks = TaskModel.Selected_Tasks;

            Clicked_TaskPanel = new List<bool>();
            for (int i = 0; i < Loaded_Data_Tasks.Count; i++)
            {
                Clicked_TaskPanel.Add(false);
            }

            int counter = 0;

            foreach (var item in Loaded_Data_Tasks)
            {
                showPnTaskPn.Controls.Add(SetTaskPanelSettings(item, counter));

                GenerateFollowLine(item);

                counter++;
            }

            GenerateAddPanel();
        }

        private void GenerateAddPanel()
        {
            addCurrentDayPanel.Location = new Point(showPnTaskPn.Width/2-addCurrentDayPanel.Width/2, lastTaskPanelPosY + addCurrentDayPanel.Height/3);
            addCurrentDayPanel.Enabled = true;
            addCurrentDayPanel.Visible = true;
        }

        private void RefreshForm()
        {
            TaskModel.RefreshLocalDB_EditForm();

            this.Hide();

            EditForm form = new EditForm();   

            form.Show();
        }


        #endregion


        #region  INPUTmodel
        private string GetTheTextAboutObject(object Item)
        {
            string output = "";

            if(Item is Label)
            {
                Label _value = Item as Label;
                output = _value.Text;
            }
            else if (Item is TextBox)
            {
                TextBox _value = Item as TextBox;
                output = _value.Text;
            }

            return output;
        }
        #endregion

        
        private void InsertForm_Load(object sender, EventArgs e)
        {
            Testing_Data();

            SetBasiclblContents();

            SetLabelContents();

            GenerateTaskPanels();
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {


            //e.Graphics.DrawRectangle(new Pen(Color.Blue,5), 0, 0, label1.Width - 1, label1.Height - 1);


        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            TaskModel.RefreshLocalDB_CalendarForm();

            Form1 form = new Form1();
            form.Show();

            this.Hide();
        }


        #region  statusPanel

        private void statusBtn_Click(object sender, EventArgs e)
        {
            Label button = (Label)sender;

            #region SelectedLabel

            if (lastStatusBtnClicked == null)
            {
                lastStatusBtnClicked = button;
            }

            if(button.Name != lastStatusBtnClicked.Name)
            {
                lastStatusBtnClicked.ForeColor = Color.White;
                lastStatusBtnClicked = button;
            }

            lastStatusBtnClicked.ForeColor = Color.Yellow;

            #endregion

            switch (lastStatusBtnClicked.Name)
            {
                case "editLbl":
                    statusPanel.Controls.Add(GenerateModifyPanel());
                    
                    break;
                case "insertLbl":
                    statusPanel.Controls.Add(GenerateInsertPanel());

                    break;
                case "deleteLbl":
                    statusPanel.Controls.Add(GenerateDeletePanel());
                    break;

            };         
        }


        private Panel GenerateModifyPanel()
        {
            Panel panel = null;
       
            bool needed = true;

            for (int i = 0; i < statusPanel.Controls.Count; i++)
            {
                if (statusPanel.Controls[i].Name == "modifyPanel")
                {
                    needed = false;
                }
                if (statusPanel.Controls[i].Name.Contains("insertPanel") || statusPanel.Controls[i].Name.Contains("deletePanel"))
                {
                    statusPanel.Controls.Remove(statusPanel.Controls[i]);
                    needed = true;
                }
            }

            if (needed)
            {
                panel = new Panel()
                {
                    Name = "modifyPanel",
                    Size = new Size(363, 227),
                    BackColor = Color.White,
                    Location=new Point(13,206)
                };

                Label wTitle = new Label()
                {
                    Text = "Határidő:",
                    Font = new Font(new FontFamily(this.Font.Name), 16f),
                    Name = "modifyAlarmDateTitle",
                    Location = new Point(141, 30)
                };

                TextBox wBox = new TextBox()
                {
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Name = "modifyAlarmDateBox",
                    Location = new Point(102, 57),
                    Size = new Size(156, 31)
                };
                Label cTitle = new Label()
                {
                    Text = "Feladat:",
                    Font = new Font(new FontFamily(this.Font.Name), 16f),
                    Name = "modifyContentTitle",
                    Location = new Point(149, 94)
                };

                TextBox cBox = new TextBox()
                {
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Name = "modifyContentBox",
                    Location = new Point(31, 121),
                    Size = new Size(315, 29)
                };
                Button confirmBtn = new Button()
                {
                    Text = "Módosítás",
                    Location = new Point(138, 173),
                    Font = new Font(new FontFamily(this.Font.Name), 11f),
                    Size = new Size(85, 27)
                };

                confirmBtn.Click += SubmitChanges_Click;

                Control[] ctl =
                {
                wTitle,wBox,cTitle,cBox,confirmBtn
                };

                panel.Controls.AddRange(ctl);
            }
            return panel;
        }
        private Panel GenerateInsertPanel()
        {
            Panel panel = null;

            bool needed = true;

            for (int i = 0; i < statusPanel.Controls.Count; i++)
            {
                if (statusPanel.Controls[i].Name == "insertPanel")
                {
                    needed = false;
                }
                if (statusPanel.Controls[i].Name.Contains("modifyPanel") || statusPanel.Controls[i].Name.Contains("deletePanel"))
                {
                    statusPanel.Controls.Remove(statusPanel.Controls[i]);
                    needed = true;
                }
            }

            if (needed)
            {
                panel = new Panel()
                {
                    Name = "insertPanel",
                    Size = new Size(340, 367),
                    BackColor = Color.White,
                    Location = new Point(22, 176)
                };

                Label wTitle = new Label()
                {
                    Text = "Fontosság",
                    Font = new Font(new FontFamily(this.Font.Name), 11f),
                    Name = "insertAlarmDateTitle",
                    Location = new Point(77, 23)
                };

                RadioButton lvl1 = new RadioButton()
                {
                    Name="insertAlarmLvl1",
                    Text="Ráér",
                    Location=new Point(68,66),
                    Font = new Font(new FontFamily(this.Font.Name), 8f),
                };
                RadioButton lvl2 = new RadioButton()
                {
                    Name = "insertAlarmLvl2",
                    Text = "Fontos",
                    Location = new Point(68, 104),
                    Font = new Font(new FontFamily(this.Font.Name), 8f),
                };
                RadioButton lvl3 = new RadioButton()
                {
                    Name = "insertAlarmLvl3",
                    Text = "Sürgős",
                    Location = new Point(68, 138),
                    Font = new Font(new FontFamily(this.Font.Name), 8f),
                };
                Label cTitle = new Label()
                {
                    Text = "Határidő",
                    Font = new Font(new FontFamily(this.Font.Name), 11f),
                    Name = "insertContentTitle",
                    Location = new Point(190, 23)
                };
                Label hourTitle = new Label()
                {
                    Text = "Óra",
                    Font = new Font(new FontFamily(this.Font.Name), 11f),
                    Name = "insertHourTitle",
                    Location = new Point(77, 197)
                };
                Label minuteTitle = new Label()
                {
                    Text = "Perc",
                    Font = new Font(new FontFamily(this.Font.Name), 11f),
                    Name = "insertHourTitle",
                    Location = new Point(208, 197)
                };

                #region ComboBox_Year

                ComboBox cbYear = new ComboBox()
                {
                    Name="insertDateYear",
                    Text=DateTime.Now.Year.ToString(),
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Size=new Size(63,32),
                    Location=new Point(194,57)
                };
                IEnumerable<int> enumerableYear = Enumerable.Range(DateTime.Now.Year, 2050);
                int[] yearNumbers = enumerableYear.ToArray();
                for (int i = 0; i < yearNumbers.Length; i++)
                {
                    cbYear.Items.Add(yearNumbers[i]);
                }

                #endregion

                #region ComboBox_Month

                ComboBox cbMonth = new ComboBox()
                {
                    Name = "insertDateMonth",
                    Text = DateTime.Now.Month.ToString(),
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Size = new Size(63,32),
                    Location=new Point(194,95)
                };
                IEnumerable<int> enumerableMonth = Enumerable.Range(1, 12);
                int[] monthNumbers = enumerableMonth.ToArray();
                for (int i = 0; i < monthNumbers.Length; i++)
                {
                    cbMonth.Items.Add(monthNumbers[i]);
                }

                #endregion

                #region ComboBox_Day

                ComboBox cbDay = new ComboBox()
                {
                    Name = "insertDateDay",
                    Text = DateTime.Now.Day.ToString(),
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Size = new Size(63, 32),
                    Location = new Point(194, 133)
                };
                int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                IEnumerable<int> enumerableDay = Enumerable.Range(1, days);
                int[] dayNumbers = enumerableDay.ToArray();
                for (int i = 0; i < dayNumbers.Length; i++)
                {
                    cbDay.Items.Add(dayNumbers[i]);
                }

                #endregion

                #region ComboBox_Hour

                ComboBox cbHour = new ComboBox()
                {
                    Name = "insertDateHour",
                    Text = "12",
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Size = new Size(63, 32),
                    Location = new Point(68, 228)
                };
                int[] hours = Enumerable.Range(1, 24).ToArray();

                for (int i = 0; i < hours.Length; i++)
                {
                    cbHour.Items.Add(hours[i]);
                }

                #endregion

                #region ComboBox_Minute

                ComboBox cbMinute = new ComboBox()
                {
                    Name = "insertDateMinute",
                    Text = "30",
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Size = new Size(63, 32),
                    Location = new Point(195, 228)
                };
                int[] minutes = Enumerable.Range(0, 60).ToArray();

                for (int i = 0; i < minutes.Length; i++)
                {
                    cbMinute.Items.Add(minutes[i]);
                }

                #endregion

                TextBox content = new TextBox()
                {
                    Name="insertContent",
                    Size=new Size(309,51),
                    Location=new Point(14,278),
                    Multiline=true,
                    Font = new Font(new FontFamily(this.Font.Name), 12f),
                    ScrollBars=ScrollBars.Vertical
                };

                Button confirmBtn = new Button()
                {
                    Name="insertBtn",
                    Text = "Hozzáad",
                    Location = new Point(118, 335),
                    Font = new Font(new FontFamily(this.Font.Name), 12f),
                    Size = new Size(93,26)
                };

                confirmBtn.Click += InsertTaskBtn_Click;

                Control[] ctl =
                {
                wTitle,lvl1,lvl2,lvl3,cTitle,cbYear,cbMonth,cbDay,
                content, confirmBtn,cbHour,cbMinute,
                hourTitle,minuteTitle
                };
                cbYear.KeyPress += ComboBox_Key;
                cbMonth.KeyPress += ComboBox_Key;
                cbDay.KeyPress += ComboBox_Key;
                cbHour.KeyPress += ComboBox_Key;
                cbMinute.KeyPress += ComboBox_Key;
                panel.Controls.AddRange(ctl);
            }
            return panel;
        }
        private Panel GenerateInsertPanel(bool addCurrent)
        {
            Panel panel = null;

            bool needed = true;

            for (int i = 0; i < statusPanel.Controls.Count; i++)
            {
                if (statusPanel.Controls[i].Name == "insertPanel")
                {
                    needed = false;
                }
                if (statusPanel.Controls[i].Name.Contains("modifyPanel") || statusPanel.Controls[i].Name.Contains("deletePanel"))
                {
                    statusPanel.Controls.Remove(statusPanel.Controls[i]);
                    needed = true;
                }
            }

            if (needed)
            {
                panel = new Panel()
                {
                    Name = "insertPanel",
                    Size = new Size(340, 367),
                    BackColor = Color.White,
                    Location = new Point(22, 176)
                };

                Label wTitle = new Label()
                {
                    Text = "Fontosság",
                    Font = new Font(new FontFamily(this.Font.Name), 11f),
                    Name = "insertAlarmDateTitle",
                    Location = new Point(77, 23)
                };

                RadioButton lvl1 = new RadioButton()
                {
                    Name = "insertAlarmLvl1",
                    Text = "Ráér",
                    Location = new Point(68, 66),
                    Font = new Font(new FontFamily(this.Font.Name), 8f),
                };
                RadioButton lvl2 = new RadioButton()
                {
                    Name = "insertAlarmLvl2",
                    Text = "Fontos",
                    Location = new Point(68, 104),
                    Font = new Font(new FontFamily(this.Font.Name), 8f),
                };
                RadioButton lvl3 = new RadioButton()
                {
                    Name = "insertAlarmLvl3",
                    Text = "Sürgős",
                    Location = new Point(68, 138),
                    Font = new Font(new FontFamily(this.Font.Name), 8f),
                };
                Label cTitle = new Label()
                {
                    Text = "Határidő",
                    Font = new Font(new FontFamily(this.Font.Name), 11f),
                    Name = "insertContentTitle",
                    Location = new Point(190, 23)
                };
                Label hourTitle = new Label()
                {
                    Text = "Óra",
                    Font = new Font(new FontFamily(this.Font.Name), 11f),
                    Name = "insertHourTitle",
                    Location = new Point(77,197)
                };
                Label minuteTitle = new Label()
                {
                    Text = "Perc",
                    Font = new Font(new FontFamily(this.Font.Name), 11f),
                    Name = "insertHourTitle",
                    Location = new Point(208, 197)
                };

                #region ComboBox_Year

                ComboBox cbYear = new ComboBox()
                {
                    Name = "insertDateYear",
                    Text = DateTime.Now.Year.ToString(),
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Size = new Size(63, 32),
                    Location = new Point(194, 57)
                };
                IEnumerable<int> enumerableYear = Enumerable.Range(DateTime.Now.Year, 2050);
                int[] yearNumbers = enumerableYear.ToArray();
                for (int i = 0; i < yearNumbers.Length; i++)
                {
                    cbYear.Items.Add(yearNumbers[i]);
                }

                #endregion

                #region ComboBox_Month

                ComboBox cbMonth = new ComboBox()
                {
                    Name = "insertDateMonth",
                    Text = MainFormModel.Month.ToString(),
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Size = new Size(63, 32),
                    Location = new Point(194, 95)
                };
                IEnumerable<int> enumerableMonth = Enumerable.Range(1, 12);
                int[] monthNumbers = enumerableMonth.ToArray();
                for (int i = 0; i < monthNumbers.Length; i++)
                {
                    cbMonth.Items.Add(monthNumbers[i]);
                }

                #endregion

                #region ComboBox_Day

                ComboBox cbDay = new ComboBox()
                {
                    Name = "insertDateDay",
                    Text = MainFormModel.Day.ToString(),
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Size = new Size(63, 32),
                    Location = new Point(194, 133)
                };
                int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                IEnumerable<int> enumerableDay = Enumerable.Range(1, days);
                int[] dayNumbers = enumerableDay.ToArray();
                for (int i = 0; i < dayNumbers.Length; i++)
                {
                    cbDay.Items.Add(dayNumbers[i]);
                }

                #endregion

                #region ComboBox_Hour

                ComboBox cbHour = new ComboBox()
                {
                    Name = "insertDateHour",
                    Text = "12",
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Size = new Size(63, 32),
                    Location = new Point(68, 228)
                };
                int[]hours = Enumerable.Range(1, 24).ToArray();
                
                for (int i = 0; i < hours.Length; i++)
                {
                    cbHour.Items.Add(hours[i]);
                }

                #endregion

                #region ComboBox_Minute

                ComboBox cbMinute = new ComboBox()
                {
                    Name = "insertDateMinute",
                    Text = "30",
                    Font = new Font(new FontFamily(this.Font.Name), 14f),
                    Size = new Size(63, 32),
                    Location = new Point(195,228)
                };
                int[] minutes = Enumerable.Range(0, 60).ToArray();

                for (int i = 0; i < minutes.Length; i++)
                {
                    cbMinute.Items.Add(minutes[i]);
                }

                #endregion

                TextBox content = new TextBox()
                {
                    Name = "insertContent",
                    Size = new Size(309, 51),
                    Location = new Point(14, 278),
                    Multiline = true,
                    Font = new Font(new FontFamily(this.Font.Name), 12f),
                    ScrollBars = ScrollBars.Vertical
                };

                Button confirmBtn = new Button()
                {
                    Name = "insertBtn",
                    Text = "Hozzáad",
                    Location = new Point(118, 335),
                    Font = new Font(new FontFamily(this.Font.Name), 12f),
                    Size = new Size(93, 26)
                };

                confirmBtn.Click += InsertTaskBtn_Click;

                Control[] ctl =
                {
                wTitle,lvl1,lvl2,lvl3,cTitle,cbYear,cbMonth,cbDay,
                content, confirmBtn,
                hourTitle,minuteTitle,cbMinute,cbHour
                };

                cbYear.KeyPress += ComboBox_Key;
                cbMonth.KeyPress += ComboBox_Key;
                cbDay.KeyPress += ComboBox_Key;
                cbHour.KeyPress += ComboBox_Key;
                cbMinute.KeyPress += ComboBox_Key;

                panel.Controls.AddRange(ctl);
            }
            return panel;
        }

        private void ComboBox_Key(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private Panel GenerateDeletePanel()
        {
            Panel panel = null;

            bool needed = true;

            for (int i = 0; i < statusPanel.Controls.Count; i++)
            {
                if (statusPanel.Controls[i].Name == "deletePanel")
                {
                    needed = false;
                }
                if (statusPanel.Controls[i].Name.Contains("modifyPanel") || statusPanel.Controls[i].Name.Contains("insertPanel"))
                {
                    statusPanel.Controls.Remove(statusPanel.Controls[i]);
                    needed = true;
                }
            }

            if (needed)
            {
                panel = new Panel()
                {
                    Name = "deletePanel",
                    Size = new Size(366,156),
                    BackColor = Color.White,
                    Location = new Point(9,254)
                };

                Label wTitle = new Label()
                {
                    Text = "Biztosan törölni szeretnéd?",
                    Font = new Font(new FontFamily(this.Font.Name), 16f),
                    Name = "deleteTitle",
                    Location = new Point(43,37),
                    Size=new Size(273,25)
                };

                Button btnYes = new Button()
                {
                    Name="deleteBtnYes",
                    Text="Igen",
                    Font = new Font(new FontFamily(this.Font.Name), 16f),
                    Size=new Size(100,35),
                    Location=new Point(57,93)
                };
                btnYes.Click += deleteBtn_Yes_Click;

                Button btnNo = new Button()
                {
                    Name = "deleteBtnNo",
                    Text = "Nem",
                    Font = new Font(new FontFamily(this.Font.Name), 16f),
                    Size = new Size(100, 35),
                    Location = new Point(203,93)
                };
                btnNo.Click += deleteBtn_No_Click;

               
                Control[] ctl =
                {
                    wTitle,btnYes,btnNo
                };

                panel.Controls.AddRange(ctl);
            }
            return panel;
        }

        private void SubmitChanges_Click(object sender, EventArgs e)
        {
            try
            {
                TextBox alarmBox = updatePanel.Controls.OfType<TextBox>().ToList().Where(x => x.Name.Contains("modifyAlarmDate")).First();
                TextBox contentBox = updatePanel.Controls.OfType<TextBox>().ToList().Where(x => x.Name.Contains("modifyContentBox")).First();

                SelectedRow_Task.Alarm_Date = Convert.ToDateTime(alarmBox.Text);
                SelectedRow_Task.Content = contentBox.Text;

                TaskModel.Edit(SelectedRow_Date, SelectedRow_Task);

                RefreshForm_Old();
            }
            catch (Exception x)
            {
                MessageBox.Show("Valamilyen probléma adódott.");
                MessageBox.Show(x.Message);             
            }            
        }


        private int GetherLevelInfo(Panel head)
        {
            int output = 0;

            List<RadioButton> levels = new List<RadioButton>();

            for (int i = 0; i < head.Controls.Count; i++)
            {
                if (head.Controls[i].Name.Contains("insertAlarmLvl"))
                {
                    levels.Add((RadioButton)head.Controls[i]);
                }
            }

            levels = levels.OrderBy(x => x.Name).ToList();

            if (levels[0].Checked) { output = 1; }
            else if (levels[1].Checked) { output = 2; }
            else if (levels[2].Checked){ output = 3; }

            return output;
        }
        private DateTime GetherAlarmInfo(Panel head)
        {
            DateTime output=new DateTime();

            List<ComboBox> alarms = new List<ComboBox>();

            for (int i = 0; i < head.Controls.Count; i++)
            {
                if (head.Controls[i].Name.Contains("insertDate"))
                {
                    Console.WriteLine(head.Controls[i].Text);
                    alarms.Add((ComboBox)head.Controls[i]);
                }
            }

            int year = 0;
            int month = 0;
            int day = 0;
            int hour = 0;
            int minute = 0;

            foreach (var item in alarms)
            {
                if (item.Name.Contains("Year"))
                {
                    year = Convert.ToInt32(item.Text);
                }
                if (item.Name.Contains("Month"))
                {
                    month = Convert.ToInt32(item.Text);
                }
                if (item.Name.Contains("Day"))
                {
                    day = Convert.ToInt32(item.Text);
                }
                if (item.Name.Contains("Hour"))
                {
                    hour = Convert.ToInt32(item.Text);
                }
                if (item.Name.Contains("Minute"))
                {
                    minute = Convert.ToInt32(item.Text);
                }
            }

            output = new DateTime(year,
                month, day, hour, minute,0);

            return output;
        }
        private string GetherContentInfo(Panel head)
        {
            string output = "";

            output = head.Controls.OfType<TextBox>().ToList().Where(x => x.Name.Contains("insertContent")).FirstOrDefault().Text;
            if (output.Length > 60)
            {
                output = "Túl hosszú az üzenet.";
            }

            return output;
        }

        private void InsertTaskBtn_Click(object sender, EventArgs e)
        {
            Panel insertPanel = statusPanel.Controls.OfType<Panel>().ToList().Where(x => x.Name.Contains("insertPanel")).FirstOrDefault();

            //Define insertPanel content
            int Level = 0;
            DateTime Alarm;
            string Content = "";

            int _level = GetherLevelInfo(insertPanel);
            if (_level != 0) { Level = _level; }

            Alarm = GetherAlarmInfo(insertPanel);

            bool _content = InputModel.checkSqlInjection(GetherContentInfo(insertPanel));
            if (_content) { MessageBox.Show("Jelentve lett az adminisztrátórnak"); return; }
            else { Content = GetherContentInfo(insertPanel); }

            DataModel.Task insertModel = new DataModel.Task();
            insertModel.Alarm_Date = Alarm;
            insertModel.Level = Level;
            insertModel.Content = Content;

            TaskModel.Insert(null, insertModel);

            RefreshForm_Old();
        }
        private void deleteBtn_Yes_Click(object sender, EventArgs e)
        {
            try
            {
                if (SelectedRow_Task != null)
                {
                    TaskModel.Delete(SelectedRow_Task);
                    RefreshForm_Old();
                } 
            }
            catch (Exception x)
            {
                MessageBox.Show("Először válassz ki egy feladatot!");
                RefreshForm();
            }        
        }
        private void deleteBtn_No_Click(object sender, EventArgs e)
        {
            
        }

        #endregion

        private void addCDButton_Click(object sender, EventArgs e)
        {
            statusPanel.Controls.Add(GenerateInsertPanel(true));
        }

        private void unsuccededLabel_Click(object sender, EventArgs e)
        {

        }

        private void EditForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            #region Application Icon

            Form1.App_Icon.Icon = null;
            Form1.App_Icon.Dispose();
            Application.DoEvents();

            #endregion

            Application.Exit();
        }
    }
}
