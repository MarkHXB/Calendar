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
        public EditForm()
        {
            InitializeComponent();
        }

        private void InsertForm_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Paint(object sender, PaintEventArgs e)
        {


            e.Graphics.DrawRectangle(new Pen(Color.Blue,5), 0, 0, label1.Width - 1, label1.Height - 1);


        }
    }
}
