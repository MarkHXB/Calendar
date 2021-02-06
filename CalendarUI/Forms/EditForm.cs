using Calendar.Models;
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
        private int sMonthNumber = 0;
        private int sDayNumber = 0;

        private static DataModel.Task test = new DataModel.Task();
        private static DataModel.Task test2 = new DataModel.Task();

        private int lastTaskPanelPosY = 42;
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
            unsuccededLabel.Text = TaskModel.GetCurrentDayTaskNumber_Not_Completed(sMonthNumber, sDayNumber).ToString();
            succededLabel.Text = TaskModel.GetCurrentDayTaskNumber_Completed(sMonthNumber, sDayNumber).ToString();

            string finalTxt = Form1.MonthNumber < 10 ? "0" + Form1.MonthNumber.ToString() : Form1.MonthNumber.ToString();
            monthLabel.Text = finalTxt + "." + Form1.SelectedMonthNumber;
            dayLabel.Text = InputModel.GetMonthDayName(Form1.MonthNumber, Form1.SelectedMonthNumber);
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
                return Color.FromArgb(70,Color.Green);
            }
            else if (task.Level == 2)
            {
                return Color.FromArgb(70, Color.Blue);
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
            Label dayTitle = new Label()
            {
                Name = "taskPanelTitle" + index.ToString(),
                Text = task.Alarm_Date.ToString("MM-dd"),
                Font = new Font(new FontFamily(this.Font.Name), 16f),
                Location = new Point(166, 5),
                BackColor = Color.Transparent
            };
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
            Button completeBtn = new Button()
            {
                Name = "taskPanelCompleteBtn" + index.ToString(),
                Font = new Font(new FontFamily(this.Font.Name), 12f),
                Text="Kész",
                Location=new Point(174,71),
                Size=new Size(75,26)
            };

            Control[] panelContent =
            {
                dayTitle,taskContent,completeBtn
            };

            panel.Controls.AddRange(panelContent);

            lastTaskPanelPosY += 119;

            return panel;
        }

        private void GenerateTaskPanels()
        {
            List<DataModel.Task> tasks = TaskModel.SelectTaskByDayNumber_List(sDayNumber, sMonthNumber);

            int counter = 0;

            foreach (var item in tasks)
            {
                showPnTaskPn.Controls.Add(SetTaskPanelSettings(item, counter));

                counter++;
            }
        }


        #endregion


        private void InsertForm_Load(object sender, EventArgs e)
        {
            sMonthNumber = Form1.MonthNumber;
            sDayNumber = Form1.SelectedMonthNumber;

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
            Form1 form = new Form1();
            form.Show();

            this.Hide();
        }
    }
}
