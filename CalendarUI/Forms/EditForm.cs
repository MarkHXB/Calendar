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
        private static DataModel.Task test = new DataModel.Task();
        private static DataModel.Task test2 = new DataModel.Task();
        public EditForm()
        {
            InitializeComponent();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
            test.Id = 1;
            test.Level = 1;
            test.Content = "valami";
            test.IsComplete = 0;

            test2.Id = 1;
            test2.Level = 3;
            test2.Content = "valami2";
            test2.IsComplete = 0;


            editPnTitlePn.BackColor = Color.FromArgb(81, 196, 163);
            editPnTitlePn.ForeColor = Color.White;

            testPanel.BackColor = Color.FromArgb(70, Color.Red);

            monthLabel.Text = (Form1.MonthNumber <10?"0"+Form1.MonthNumber:Form1.MonthNumber) + "." + Form1.SelectedMonthNumber;
            dayLabel.Text = InputModel.GetMonthDayName(Form1.MonthNumber,Form1.SelectedMonthNumber);
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {


            //e.Graphics.DrawRectangle(new Pen(Color.Blue,5), 0, 0, label1.Width - 1, label1.Height - 1);


        }
    }
}
