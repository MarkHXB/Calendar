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

namespace Forms.Form1
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SizeTableToFit();
        }
        private void SizeTableToFit()
        {
            int rows=tableLayoutPanel1.RowCount;
            int columns = tableLayoutPanel1.ColumnCount;

            for (int j = 0; j < columns; j++)
            {
                tableLayoutPanel1.ColumnStyles[j].SizeType = SizeType.AutoSize;
                
                for (int i = 0; i < rows; i++)
                {
                    tableLayoutPanel1.RowStyles[i].SizeType = SizeType.AutoSize;
                    Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    tableLayoutPanel1.Controls.Add(new Panel() { BackColor = randomColor,Dock=DockStyle.Fill }, j, i);
                }
            }
            
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            SizeTableToFit();
        }
    }
}
