using Calendar.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Forms.CalendarForm;

namespace Forms.Main
{
    public partial class MainForm : Form
    {
        private static int currentDBindex=0;
         private static bool restoreData=true;
         public static Form form = null;
         private static int lastItemPosi_Y = 0;
         private static bool[] SelectLevelButtonsClicked;
        
         public MainForm()
         {
             SelectLevelButtonsClicked = new bool[4];
             restoreData = true;

             InitializeComponent();     
         }
        
         private void Main_Load(object sender, EventArgs e)
         {
             CollectCurrentDayTasks_OnLoad();
         }

         private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
         {
             Application.Exit();
         }

         private void mainP_Move(object sender, MouseEventArgs e)
         {

         }
         private void mainForm_Activated(object sender, EventArgs e)
         {
             if (restoreData)
             {
                 form = this;

                 MainPanelConfig();

                 menuPanel_2_config_activated();

                 restoreData = false;
             }
         }

         #region Main

         private void MainPanelConfig()
         {
             currentDBindex = 0;

             if (!OccursWhenHaveNoTask())
             {
                 GenerateMainElements();
             }
         }

         //HAVE TASKS PANEL
         private void GenerateMainElements()
         {
             int posY_label = 17;

             int task_number = CountTasks();

             for (int i = 0; i < task_number; i++)
             {
                 Panel panel = new Panel()
                 {
                     //Style
                     Size = new Size(950, 73),
                     Location = new Point(17, posY_label),

                     //Data
                     Name = $"taskPanel{i + 1}",
                     BackColor = Color.FromArgb(10, Color.Black)

                 };

                 Button button = new Button()
                 {
                     //Style
                     Location = new Point(3, 17),
                     Size = new Size(40, 39),
                     BackColor = Color.Transparent,
                     FlatStyle = FlatStyle.Flat,
                     BackgroundImageLayout = ImageLayout.Zoom,

                     //Data
                     BackgroundImage = SelectAlarmImage(),
                     Name=$"taskButton{i+1}"
                 };
                 Label titleLabel = new Label()
                 {
                     //Style
                     Location=new Point(49,13),
                     Font=new Font(new FontFamily("Microsoft Sans Serif"),14f),

                     //Data
                     Name=$"taskTitleLabel{i+1}",
                     Text= SelectTitleText(),
                     BackColor = Color.FromArgb(20, Color.Blue)
                 };
                 Label dateLabel = new Label()
                 {
                     //Style
                     Location = new Point(54,45),
                     Font = new Font(new FontFamily("Microsoft Sans Serif"), 12f),

                     //Data
                     Name = $"taskDateLabel{i + 1}",
                     Text = SelectAlarmDate(),
                     BackColor = Color.FromArgb(20, Color.Red)
                 };
                 Button completeBtn = new Button()
                 {
                     Location=new Point(682,25),
                     Size=new Size(30,24),
                     BackgroundImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\complete.png"),
                     BackgroundImageLayout=ImageLayout.Zoom,
                     FlatStyle=FlatStyle.Flat,
                     BackColor=Color.Transparent,
                     Text="",
                     Name="completeBtn"
                 };
                 Button editBtn = new Button()
                 {
                     Location = new Point(773, 25),
                     Size = new Size(30, 24),
                     BackgroundImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\edit.png"),
                     BackgroundImageLayout = ImageLayout.Zoom,
                     FlatStyle = FlatStyle.Flat,
                     BackColor = Color.Transparent,
                     Text = "",
                     Name = "editBtn"
                 };
                 Button deleteBtn = new Button()
                 {
                     Location = new Point(860, 25),
                     Size = new Size(30, 24),
                     BackgroundImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\delete.png"),
                     BackgroundImageLayout = ImageLayout.Zoom,
                     FlatStyle = FlatStyle.Flat,
                     BackColor = Color.Transparent,
                     Text = "",
                     Name = "deleteBtn"
                 };

                 //EVENTS
                 completeBtn.Click+=CompleteTaskBtn_Click;
                 editBtn.Click += EditTaskBtn_Click;
                 deleteBtn.Click += DeleteTaskBtn_Click;




                 //Style
                 button.FlatAppearance.BorderSize = 0;
                 completeBtn.FlatAppearance.BorderSize = 0;
                 editBtn.FlatAppearance.BorderSize = 0;
                 deleteBtn.FlatAppearance.BorderSize = 0;



                 //Data
                 Control[] panel_content =
                 {
                     button,titleLabel,dateLabel,
                     completeBtn,editBtn,deleteBtn
                 };

                 panel.Controls.AddRange(panel_content);

                 mainPanel.Controls.Add(panel);

                 posY_label += 88;
                 lastItemPosi_Y = posY_label;
             }

             InsertNewTask();
         }

         private void DeleteTaskBtn_Click(object sender, EventArgs e)
         {
             Button button = (Button)sender;

             Control control = sender as Control;
             Control parent = control.Parent;
             Panel insertPanelPosChange = null;

             int selectedTaskIndex = InputModel.Int(parent.Name);
             int selectedDB_row = SelectRowByID(selectedTaskIndex);

             //Delete DB
             for (int i = 0; i < mainPanel.Controls.Count; i++)
             {
                 if (mainPanel.Controls[i].Name.Contains("Insert"))
                 {
                     insertPanelPosChange = (Panel)mainPanel.Controls[i];
                 }
             }

             lastItemPosi_Y -= 200;

             mainPanel.Controls.Remove(parent);
             mainPanel.Controls.Remove(insertPanelPosChange);

             foreach (var item in TaskModel.Date_Table)
             {
                 if (item.Task_ID == CalendarForm.Calendar.selectedTask[selectedTaskIndex - 1].Id)
                 {
                     //set DB row value
                    // Task editableTask = new Task();

                     //editableTask.Delete(item.Task_Id_Dates);
                 }
             }

             //Calendar.selectedTask.RemoveAt(selectedTaskIndex - 1);


             restoreData = true;
         }

         private void EditTaskBtn_Click(object sender, EventArgs e)
         {
             Button button = (Button)sender;

             Control control = sender as Control;
             Control parent = control.Parent;

             int selectedTaskIndex = InputModel.Int(parent.Name);
             int selectedDB_row=SelectRowByID(selectedTaskIndex);

             int Level = 0;
             DateTime Alarm;
             string Content = "";

             //Level = Task.DbContent[selectedDB_row].TaskLevel;
             //Alarm = Task.DbContent[selectedDB_row].Alarm;
            // Content = Task.DbContent[selectedDB_row].TaskContent+" "+"változtattak rajtam";

             //EDIT DB
            // Task editableTask = new Task();

            // editableTask.Edit(selectedDB_row, Level, Alarm, Content);
         }
         private int SelectRowByID(int selectedTask)
         {
             int output = 0;
             int counter = 0;

             foreach (var item in TaskModel.Date_Table)
             {
                 if (item.Task_ID ==CalendarForm.Calendar.selectedTask[selectedTask - 1].Id)
                 {
                     output = counter;
                 }
                 counter++;
             }

             return output;
         }
         /// <summary>
         /// 
         /// REMOVE CURRENT PANEL    [Complete]
         /// CHANGE TASK STATUS TO COMPLETED ~ TRUE  [Non]
         /// MOVE ADDTASK PANEL UPPER    [Non]
         /// 
         /// </summary>
         private void CompleteTaskBtn_Click(object sender, EventArgs e)
         {
             Button button = (Button)sender;
             Control control = sender as Control;
             Control parent = control.Parent;
             Panel insertPanelPosChange = null;

             for (int i = 0; i < mainPanel.Controls.Count; i++)
             {
                 if (mainPanel.Controls[i].Name.Contains("Insert"))
                 {
                     insertPanelPosChange =(Panel)mainPanel.Controls[i];
                 }
             }

             lastItemPosi_Y -= parent.Location.Y;

             mainPanel.Controls.Remove(parent);
             mainPanel.Controls.Remove(insertPanelPosChange);

             int selectedTaskIndex = InputModel.Int(parent.Name);

             foreach (var item in TaskModel.Date_Table)
             {
                 if(item.Date_ID == CalendarForm.Calendar.selectedTask[selectedTaskIndex-1].Id)
                 {
                     //item.Is = true;

                    // //set DB row value
                     //Task editableTask = new Task();

                    // editableTask.Edit(item.Task_Id_Dates);
                 }
             }

            // Calendar.selectedTask.RemoveAt(selectedTaskIndex - 1);


             restoreData = true;
         }

         //SORRY PANEL
         private void InsertNewTask()
         {
             Panel panel = new Panel()
             {
                 Size=new Size(612,81),
                 Location=new Point(170,lastItemPosi_Y),
                 Name="Insert_Panel_O"
             };

             Console.WriteLine(panel.Location.Y);

             Button button = new Button()
             {
                 Location=new Point(108,24),
                 Size=new Size(85,54),
                 BackgroundImage=Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\add_icon.png"),
                 BackgroundImageLayout=ImageLayout.Zoom,
                 BackColor=Color.Transparent,
                 FlatStyle=FlatStyle.Flat,
                 Name="Insert_Panel_Label_O"
             };
             Label label = new Label()
             {
                 Location=new Point(211,34),
                 Font=new Font(new FontFamily("Microsoft Tai Le"),18f),
                 Name="Insert_Panel_Label_O",
                 Text="Adj hozzá új feladatot.",
                 Size=new Size(265,31)
             };

             button.FlatAppearance.BorderSize = 0;
             button.Click += insertButton_Click;

             Control[] control_content =
             {
                 button,label
             };
             panel.Controls.AddRange(control_content);
             mainPanel.Controls.Add(panel);

             lastItemPosi_Y = panel.Location.Y + panel.Size.Height;
         }

         private void insertButton_Click(object sender, EventArgs e)
         {
             ShowInsertPanel();
         }

         private void ShowInsertPanel()
         {
             Panel panel = new Panel()
             {
                 Name = "Insert_Panel_Show",
                 Location = new Point(257, lastItemPosi_Y+20),
                 Size = new Size(436, 269)

             };
             Label title = new Label()
             {
                 Text="Fontosság:",
                 Location=new Point(156,10),
                 Font=new Font(new FontFamily("Microsoft YaHei"),14f),
                 Size=new Size(114,26)
             };
             Button bt1 = new Button()
             {
                 BackgroundImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\level1_flag.png"),
                 Location=new Point(53,48),
                 BackgroundImageLayout=ImageLayout.Zoom,
                 Size=new Size(78,38),
                 Name="btnLevel1"
             };
             Button bt2 = new Button()
             {
                 BackgroundImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\level2_flag.png"),
                 Location = new Point(173, 48),
                 BackgroundImageLayout = ImageLayout.Zoom,
                 Size = new Size(78, 38),
                 Name = "btnLevel2"
             };
             Button bt3 = new Button()
             {
                 BackgroundImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\level3_flag.png"),
                 Location = new Point(300, 48),
                 BackgroundImageLayout = ImageLayout.Zoom,
                 Size = new Size(78, 38),
                 Name = "btnLevel3"
             };
             RadioButton rd1 = new RadioButton()
             {
                 Text="Ráér",
                 Name="rdButton1",
                 Location=new Point(72,91)
             };
             RadioButton rd2 = new RadioButton()
             {
                 Text = "Fontos",
                 Name = "rdButton2",
                 Location = new Point(187, 91)
             };
             RadioButton rd3 = new RadioButton()
             {
                 Text = "Nagyon fontos",
                 Name = "rdButton3",
                 Location = new Point(291, 91)
             };
             Label date_Title = new Label()
             {
                 Font=new Font(new FontFamily("Microsoft Tai Le"),12f),
                 Text="Dátum",
                 Location=new Point(131,112)
             };
             TextBox txtBox_Date = new TextBox()
             {
                 Size=new Size(152,29),
                 Name="txtBoxDate",
                 Location=new Point(126,136),
                 Font = new Font(new FontFamily("Microsoft Tai Le"), 14f),

             };
             Label content_Title = new Label()
             {
                 Font = new Font(new FontFamily("Microsoft Tai Le"), 12f),
                 Text = "Tartalom",
                 Location=new Point(61,170),

             };
             TextBox txtBox_Content = new TextBox()
             {
                 Size = new Size(308, 36),
                 Name = "txtBoxContent",
                 Location = new Point(57, 194),
                 Font = new Font(new FontFamily("Microsoft Tai Le"), 10f),
                 Multiline=true
             };
             Button insert_Btn = new Button()
             {
                 Location=new Point(173,237),
                 Text="Hozzáad",
                 Font = new Font(new FontFamily("Microsoft Tai Le"), 12f),
                 Size=new Size(97,30)
             };

             insert_Btn.Click += insertNewTask_Click;

             bt1.Click += selectedLevel_Click;
             bt2.Click += selectedLevel_Click;
             bt3.Click += selectedLevel_Click;

             Control[]control =
             {
                 title,bt1,bt2,bt3,rd1,rd2,rd3,date_Title,txtBox_Date,content_Title,
                 txtBox_Content,insert_Btn
             };

             panel.Controls.AddRange(control);

             mainPanel.Controls.Add(panel);    

         }

         #region TASK_LEVEL_BUTTON

         private void selectedLevel_Click(object sender, EventArgs e)
         {
             Button button = (Button)sender;

             WhichLevelButtonWasClicked(button);

             //Ide egy olyan stílus metódus majd a stílus osztályból ami megváltoztatja
             //a kiválasztott button stílusát
         }
         private void WhichLevelButtonWasClicked(Button button)
         {
             string val = "";

             int allowedButtonCount = 0;

            //NonSqlTask.SelectedButtonIndex = ConvertTo.Int(button.Name);

            //int buttonIndex = NonSqlTask.SelectedButtonIndex;

           /* for (int i = 0; i < SelectLevelButtonsClicked.Length; i++)
             {
                 if (buttonIndex == i)
                 {
                     if (!SelectLevelButtonsClicked[i])
                     {
                         SelectLevelButtonsClicked[i] = true;
                         button.BackColor = Color.FromArgb(20, Color.Black); 
                     }
                     else
                     {
                         SelectLevelButtonsClicked[i] = false;
                         button.BackColor = Color.White;
                     }
                 }
             }*/
         }

         //Ide egy olyan stílus metódus majd a stílus osztályból ami megváltoztatja
         //a kiválasztott button stílusát

         #endregion

         private void insertNewTask_Click(object sender, EventArgs e)
         {
             /*Task task = new Task();

             Control ctl = sender as Control;
             Control pctl = ctl.Parent;

             TextBox alarm=null;
             TextBox content=null;

             int _level = 1;
             DateTime _alarm;
             string _content;

             RadioButton checkedButton = pctl.Controls.OfType<RadioButton>()
                                       .FirstOrDefault(r => r.Checked);

             for (int x = 0; x < pctl.Controls.Count; x++)
             {
                 if (pctl.Controls[x].Name == "txtBoxDate")
                 {
                     alarm = pctl.Controls[x] as TextBox;
                 }
                 if (pctl.Controls[x].Name == "txtBoxContent")
                 {
                     content =pctl.Controls[x] as TextBox;
                 }

             }

             _level = NonSqlTask.MakeTaskLevel(checkedButton);
             _alarm = NonSqlTask.MakeTaskAlarm(alarm);
             _content= NonSqlTask.MakeTaskContent(content);

             //OCCURS when some field is not right
             NonSqlTask.Warning();

             NonSqlTask task_managment = new NonSqlTask()
             {
                 Level = _level,
                 Alarm = _alarm,
                 Content = _content
             };

             if(NonSqlTask.Part1 && NonSqlTask.Part2 && NonSqlTask.Part3)
             {
                 task.Insert(task_managment.Level,
                    task_managment.Alarm, task_managment.Content);

                 mainPanel.Controls.Remove(pctl.Controls[0].Parent);

                 restoreData = true;
             }
             else
             {
                 Console.WriteLine(NonSqlTask.Part1 +" "+ NonSqlTask.Part2 +" "+NonSqlTask.Part3);
                 return;
             }
             */
         }



         #region CheckInputForDataBase


         private DateTime CheckInputDate(string input)
         {
             DateTime output = new DateTime();

             try
             {
                 output = Convert.ToDateTime(output);

             }
             catch (Exception x)
             {
                 MessageBox.Show(x.Message);
                MessageBox.Show($"Dátum: {input}\nNormális dátum legyen. pl.:( 2021.07.24. )");

             }

             return output;
         }



         #endregion



         private bool OccursWhenHaveNoTask()
         {
             bool result = false;

             if (CountTasks() == 0)
             {
                 result = true;

                 PictureBox image = new PictureBox()
                 {
                     Location = new Point(mainPanel.Size.Width/4, -25),
                     Size = new Size(476,455),
                     Image = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\sorry_image_jak_edited.png"),
                     SizeMode=PictureBoxSizeMode.Zoom,
                     Name="sorryImage"
                 };

                 lastItemPosi_Y = image.Location.Y+image.Size.Height;

                 mainPanel.Controls.Add(image);

                 InsertNewTask();

             }

             return result;
         }

         #endregion

         #region menuPanel_1



         #endregion

         #region menuPanel_2

         private void menuPanel_2_config_activated()
         {
             menuP2_Content_Activated();

         }
         private void menuP2_Content_Activated()
         {
             //currentDayName.Text = Calendar.choosedDay_Name;

             int task_number = CountTasks();

             currentTasksLbl.Text = task_number.ToString();
         }

         #endregion

         #region Functions
         private void CollectCurrentDayTasks_OnLoad()
         {
             /*foreach (var item in Task.DbContent)
             {
                 if (item.Date_Id == Calendar.choosedDay)
                 {
                     Calendar.selectedTask.Add(new Task
                     {
                         Date_Id = item.Date_Id,
                         Task_Id_Dates=item.Task_Id_Dates,
                         TaskLevel = item.TaskLevel,
                         Alarm = item.Alarm,
                         TaskContent = item.TaskContent,
                         TaskComplete = item.TaskComplete
                     });

                 }
             }*/
         }
         private int CountTasks()
         {
             int tasks = 0;
            /*
             foreach (var item in Task.DbContent)
             {
                 Console.WriteLine(item.Date_Id +" "+ Calendar.choosedDay +" "+ item.TaskComplete);
                 if (item.Date_Id == Calendar.choosedDay&& !item.TaskComplete)
                 {
                     ;
                     tasks++;
                 }
             }
            */
             return tasks;
         }

         private Image SelectAlarmImage()
         {
             Image alarmImage = null;

             /*Console.WriteLine(Calendar.selectedTask.Count+" "+ currentDBindex);

             if (Calendar.selectedTask[currentDBindex].TaskLevel == 1)
             {
                 alarmImage= Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\level1_circle_edited.png");
             }
             else if (Calendar.selectedTask[currentDBindex].TaskLevel == 2)
             {
                 alarmImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\level2_circle_edited.png");
             }
             else
             {
                 alarmImage = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\level3_circle_edited.png");
             }

            */
             return alarmImage;
         }

         private string SelectTitleText()
         {
             string content = "";

             //content = Calendar.selectedTask[currentDBindex].TaskContent;

             return content;
         }

         private string SelectAlarmDate()
         {
             DateTime date;
             string content = "";

             //date = Calendar.selectedTask[currentDBindex].Alarm;
             //content = date.ToString();

             //currentDBindex++;

             return content;
         }

         #endregion

         private void btnBackForm_Click(object sender, EventArgs e)
         { 
             //Calendar.form.Show();

             this.Hide();

         }

         private void MainForm_MouseLeave(object sender, EventArgs e)
         {

         }
         private void RefreshLocalDB()
         {
             //Calendar.selectedTask = new List<Task>();

             CollectCurrentDayTasks_OnLoad();
         }
         private void mainPanel_MouseMove(object sender, MouseEventArgs e)
         {
             if (restoreData)
             {
                 form = this;

                 RefreshLocalDB();

                 InsertNewTask();

                 menuPanel_2_config_activated();

                 restoreData = false;
             }
         }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }


}
