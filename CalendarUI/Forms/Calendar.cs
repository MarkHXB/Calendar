using Calendar.Main;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Forms.CalendarForm
{
    public partial class Calendar : Form
    {
        public static string choosedDay_Name = "";
        public static int choosedDay = 0;
        private static bool restoreData = true;
        private static int posX=0;
        private static int posY = -100;
        private static List<string> napok_name;
        private static List<int> napok_szam;
        private static int reDate = 1;
        public static Form form = null;
        public static List<Task> selectedTask = new List<Task>();
        public Calendar()
        {
            InitializeComponent();
           
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
           
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (restoreData)
            {
                form = this;

                menuPanel_config();

                calendar_config();

                restoreData= false;

                Task.ReadOnLoad();
            }
            if (e.X <= menuPanel.Width)
            {
                menuPanel.Visible = true;
                menuPanel.Enabled = true;
                btnTaskForm.Enabled = true;
                btnTaskForm.Visible = true;
                lblMainForm.Visible = true;
                
            }
            else
            {
                menuPanel.Visible = false;
                menuPanel.Enabled = false;
                btnTaskForm.Enabled = false;
                btnTaskForm.Visible = false;
                lblMainForm.Visible = false;
            }

        }


        #region calendarConfig


        private void calendar_config()
        {
            napok_name = new List<string>
            {
                "Hétfő","Kedd","Szerda","Csütörtök","Péntek","Szombat","Vasárnap"
            };
            napok_szam = new List<int>();
            for (int i = 0; i < 40; i++)
            {
                napok_szam.Add(i + 1);
            }
            
            for (int i = 0; i < 40; i++)
            {
          
                Button dayButton = new Button()
                {
                    Name="dayB"+(i+1).ToString(),
                    Font=new System.Drawing.Font("Microsoft Tai Le",20f),
                    Text=getDayNumber(i+1).ToString(),
                    Location=new System.Drawing.Point(18,0),
                    Size=new System.Drawing.Size(81,58)
                };
                Label dayLabel = new Label()
                {
                    Name = "dayL" + (i + 1).ToString(),
                    Font = new System.Drawing.Font("Arial", 14f),
                    Text = getTheDayName(i + 1)
                };
                Panel dayPanel = new Panel()
                {
                    Name = "dayP" + (i + 1),
                    Size = new System.Drawing.Size(115, 96),
                    Location = new System.Drawing.Point(getPosX(i), getPosY(i)),
                    Visible = true,
                };

                dayButton.Click += dayBtn_Click;

                dayPanel.Controls.Add(dayButton);
                dayPanel.Controls.Add(dayLabel);

                dayLabel.Location = new Point(dayLabel.Parent.Width / 6, 61);

                this.Controls.Add(dayPanel);
                     
            }
            paintOutDays();
        }
        private int getDayNumber(int index)
        {
            int result = index;

            DateTime now = DateTime.Now;

            int ldoMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            if (index > ldoMonth)
            {
                result = reDate++;
            }

            return result;
        }
        private string getTheDayName(int index)
        {
            DateTime now = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime t = now.AddDays(+(index-1));
            string day=System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat.GetDayName(t.DayOfWeek);
            return day;
        }
        private int getPosX(int index)
        {
            if(index < 1)
            {
                posX = 206;
                return posX;
            }
            else if (index % 7 == 0)
            {
                posX = 206;
                return posX;
            }
            else
            {
                posX += 121;
                return posX;
            }
        }
        private int getPosY(int index)
        {
            if (index % 7 == 0)
            {
                posY += 111;
                return posY;
            }
            else
            {
                return posY;
            }
        }
        private void paintOutDays()
        {
            DateTime now = DateTime.Now;

            int ldoMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            List<Panel> dayPanels = this.Controls.OfType<Panel>().ToList().Where(x => x.Name.Contains("dayP")).ToList();

            dayPanels.Select(x => x.Name).ToList().Sort();

            for (int i = 0; i < dayPanels.Count; i++)
            {
                Button dayBtn = dayPanels[i].Controls.OfType<Button>().First();
                int currentDate = Convert.ToInt32(dayBtn.Text);

                if (currentDate < now.Day || i >= ldoMonth)
                {   
                    dayPanels[i].BackColor = Color.FromArgb(0,0,0,6);
                }
            }
        }


        #endregion




        #region menuPanelConfig

        private void menuPanel_config()
        {
            setDayTitle();

            show_currentday_tasks();
        }
        private void setDayTitle()
        {
            lblMainForm.Text = System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat.GetDayName(DateTime.Now.DayOfWeek);
        }
        private void show_currentday_tasks()
        {
            /*currentTasks.BeginUpdate();
            currentTasks.Nodes.Add("Parent");
            currentTasks.Nodes[0].Nodes.Add("Child 1");
            currentTasks.Nodes[0].Nodes.Add("Child 2");
            currentTasks.Nodes[0].Nodes[1].Nodes.Add("Grandchild");
            currentTasks.Nodes[0].Nodes[1].Nodes[0].Nodes.Add("Great Grandchild");
            currentTasks.EndUpdate();*/


            currentTasks.BeginUpdate();

            try
            {
                //read DATABASE

                //Task.testData();
                
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }

            currentTasks.EndUpdate();
        }

        #endregion




        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnTaskForm_Click(object sender, EventArgs e)
        {
            if (choosedDay != 0)
            {
                MainForm main = new MainForm();
                main.Show();

                this.Hide();
            }
        }
        private void dayBtn_Click(object sender, EventArgs e)
        {
            List<Panel> panels = this.Controls.OfType<Panel>().ToList().Where(x => x.Name.Contains("dayP")).ToList();
            List<Label> dayName = new List<Label>();


            for (int i = 0; i < panels.Count; i++)
            {
                dayName.Add(panels[i].Controls.OfType<Label>().FirstOrDefault());
            }

            Button button = (Button)sender;
            
            for (int i = 0; i < 40; i++)
            {
                if (button.Text == (i + 1).ToString())
                {
                    choosedDay = i + 1;
                    choosedDay_Name = dayName[i].Text;
                }
            }

            show_currentday_tasks();
        }
    }
}
