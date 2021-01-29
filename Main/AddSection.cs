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
using System.Threading;

namespace Calendar.Main
{
    public partial class AddSection : Form
    {
        static bool[] alarmPressed;
        static bool insertPanelPressed = false;
        static bool refreshDbContent = true;
        static bool restoreDb = true;
        public static bool thereIsTask = false;
        private static int alarm_level=0;
        static MainForm main;
        public static AddSection form;
        public AddSection()
        {
            restoreDb = true;
            refreshDbContent = true;
            InitializeComponent();
            
        }

        private void AddSection_Load(object sender, EventArgs e)
        {
            alarmPressed = new bool[4];

            main = new MainForm();

            if (restoreDb)
            {
                restoreDb = false;
            }
        }

        private void mainBtn_Click(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;

            if (button.Name.Contains("Back"))
            {  
                formFadingTimer.Start();
            }
        }

        private void formFading()
        {
           
            if (this.Opacity > 0)
            {
                this.Opacity -= .10;
                main.Opacity += .10;
            }
            else
            {
                main.Show();
                this.Hide();
                formFadingTimer.Stop();
                refreshDbContent = true;
            }
        }

        private void formFadingTimer_Tick(object sender, EventArgs e)
        {
            formFading();
        }

        [Obsolete]
        private void mainAddBtn_Click(object sender, EventArgs e)
        {
            if (!insertPanelPressed)
            {
                insertPanelPressed = true;
                insertPanel.Enabled = true;
                insertPanel.Visible = true;
            }
            else
            {
                insertPanel.Enabled = false;
                insertPanel.Visible = false;
                insertPanelPressed = false;
            }
        }

        private void AddSection_MouseEnter(object sender, EventArgs e)
        {
            if (refreshDbContent)
            {
                AddSection.form = this;
                if (this.Opacity == 1)
                {
                    refreshDbContent = false;
                    lblCurrentDate.Text = System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat.GetMonthName(System.DateTime.Now.Month)+
                        " "+Calendar.choosedDay + "." + " "+"\n"+
                        System.Threading.Thread.CurrentThread.CurrentUICulture.DateTimeFormat.GetDayName(new DateTime(DateTime.Now.Year,DateTime.Now.Month,Calendar.choosedDay).DayOfWeek);

                    int neededPanelcC = 0;
                    int locY = 40;
                    Panel center = this.Controls.OfType<Panel>().Where(x => x.Name == "listPanel").First();


                    foreach (var item in Task.DbContent)
                    {
                        if (item.Date_Id == Calendar.choosedDay)
                        {

                            Panel released_Task = newTaskSection(item.TaskContent, neededPanelcC, locY);

                            center.Controls.Add(released_Task);
                            locY += 200;
                            neededPanelcC++;
                        }
                    }
                }
            }
        }


        #region restoreDBContent
        private Panel newTaskSection(string textContent,int index,int locY)
        {
            Panel panel = new Panel()
            {
                Name = $"panel{index}",
                Size = new Size(275, 180),
                Location = new Point(68, locY),
                BorderStyle = BorderStyle.None,
                Margin = new Padding(3)
            };

            //az adott panelbe kéne még majd beledobálnom a dolgokat

            PictureBox pcBox = new PictureBox()
            {
                Location = new Point(21,68),
                Image = Image.FromFile(@"C:\Users\bakon\OneDrive\Asztali gép\Infó\C#\Calendar\Assets\level3_circle_edited.png"),
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(35,28),
                Margin = new Padding(3)
            };
            Label pcLabelT = new Label()
            {
                Text = "Feladat:",
                Location = new Point(66,11),
                Margin = new Padding(3),
                Font=new Font(new FontFamily("Arial"),16f)
            };
            Label pcLabelC = new Label()
            {
                Text = textContent,
                Location = new Point(80, 56),
                Margin = new Padding(3)
            };
            Label pcLabelDate = new Label()
            {
                Text=Task.DbContent[index].Alarm.ToString(),
                Margin=new Padding(3),
                Font=new Font(new FontFamily("Microsoft YaHei"),10f),
                Location=new Point(172,11),
            };
            Button pcSucBtn = new Button()
            {
                Text = "Teljesítem",
                BackColor = Color.Gray,
                ForeColor = Color.White,
                Size = new Size(95, 27),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(21, 137),
                Margin = new Padding(3),
                Font=new Font(new FontFamily("Microsoft YaHei"),11f)
            };
            Button pcDelBtn = new Button()
            {
                Text = "Törlöm",
                BackColor = Color.Gray,
                ForeColor = Color.White,
                Size = new Size(95, 27),
                FlatStyle = FlatStyle.Flat,           
                Location = new Point(176, 137),
                Margin = new Padding(3),
                Font = new Font(new FontFamily("Microsoft YaHei"), 9f)
            };
            panel.Controls.Add(pcBox);
            panel.Controls.Add(pcLabelT);
            panel.Controls.Add(pcLabelC);
            panel.Controls.Add(pcLabelDate);
            panel.Controls.Add(pcSucBtn);
            panel.Controls.Add(pcDelBtn);

            return panel;
        }


        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void alarmBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void alarmLvl1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task task = new Task();

            //task.Insert();

           
        }

        private void alarmLevel_Checked(object sender, EventArgs e)
        {
            if (alarmLvl1.Checked) { alarm_level = 1; }
            else if (alarmLvl2.Checked) { alarm_level = 2; }
            else if (alarmLvl3.Checked) { alarm_level = 3; }
        }
    }
}
