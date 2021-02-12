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
    public partial class AddTaskManually : Form
    {
        public AddTaskManually()
        {
            InitializeComponent();

            
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
            else if (levels[2].Checked) { output = 3; }

            return output;
        }
        private DateTime GetherAlarmInfo(Panel head)
        {
            DateTime output = new DateTime(DateTime.Now.Year,DateTime.Now.Month,DateTime.Now.Day);

            try
            {
                output = new DateTime(Convert.ToInt32(cbYear.Text),
                Convert.ToInt32(cbMonth.Text), Convert.ToInt32(cbDay.Text));

                
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }

            return output;
        }
        private string GetherContentInfo(Panel head)
        {
            string output = "";

            output = textBox.Text;

            return output;
        }

        private void setComboBoxSetting()
        {
            #region ComboBox_Year

            cbYear.Name = "insertDateYear";
            cbYear.Text = DateTime.Now.Year.ToString();
                   
            IEnumerable<int> enumerableYear = Enumerable.Range(DateTime.Now.Year, 2050);
            int[] yearNumbers = enumerableYear.ToArray();
            for (int i = 0; i < yearNumbers.Length; i++)
            {
                cbYear.Items.Add(yearNumbers[i]);
            }

            #endregion

            #region ComboBox_Month

            cbMonth.Name = "insertDateMonth";
            cbMonth.Name = MainFormModel.Month.ToString();              
            
            IEnumerable<int> enumerableMonth = Enumerable.Range(1, 12);
            int[] monthNumbers = enumerableMonth.ToArray();
            for (int i = 0; i < monthNumbers.Length; i++)
            {
                cbMonth.Items.Add(monthNumbers[i]);
            }

            #endregion

            #region ComboBox_Day

            cbDay.Name = "insertDateMonth";
            cbDay.Name = MainFormModel.Day.ToString();

            int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            IEnumerable<int> enumerableDay = Enumerable.Range(1, days);
            int[] dayNumbers = enumerableDay.ToArray();
            for (int i = 0; i < dayNumbers.Length; i++)
            {
                cbDay.Items.Add(dayNumbers[i]);
            }

            #endregion
        }

        private void AddTaskManually_Load(object sender, EventArgs e)
        {
            setComboBoxSetting();




        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            Panel insertPanel = (Panel)btn.Parent;

            //Define insertPanel content
            int Level = 0;
            DateTime Alarm;
            string Content = "";

            int _level = GetherLevelInfo(insertPanel);
            if (_level != 0)
            {
                Level = _level;


                Alarm = GetherAlarmInfo(insertPanel);

                bool _content = InputModel.checkSqlInjection(GetherContentInfo(insertPanel));
                if (_content) { MessageBox.Show("Jelentve lett az adminisztrátórnak"); return; }
                else { Content = GetherContentInfo(insertPanel); }

                DataModel.Task insertModel = new DataModel.Task();
                insertModel.Alarm_Date = Alarm;
                insertModel.Level = Level;
                insertModel.Content = Content;

                TaskModel.Insert(null, insertModel);

                this.Close();         
            }
            else
            {
                MessageBox.Show("Jelölj be legalább egy szintet!");
            }
        }

        private void AddTaskManually_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.RefreshForm();
        }
    }
}
