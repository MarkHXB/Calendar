
namespace Calendar
{
    partial class ListTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dayIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayOfTheMonthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.datesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.addButton1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.addButton2 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addButton3 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datesBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayIDDataGridViewTextBoxColumn,
            this.dayNameDataGridViewTextBoxColumn,
            this.dayOfTheMonthDataGridViewTextBoxColumn,
            this.Add});
            this.dataGridView1.DataSource = this.datesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(188, 484);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 151);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dayIDDataGridViewTextBoxColumn
            // 
            this.dayIDDataGridViewTextBoxColumn.DataPropertyName = "DayID";
            this.dayIDDataGridViewTextBoxColumn.HeaderText = "DayID";
            this.dayIDDataGridViewTextBoxColumn.Name = "dayIDDataGridViewTextBoxColumn";
            this.dayIDDataGridViewTextBoxColumn.Width = 50;
            // 
            // dayNameDataGridViewTextBoxColumn
            // 
            this.dayNameDataGridViewTextBoxColumn.DataPropertyName = "DayName";
            this.dayNameDataGridViewTextBoxColumn.HeaderText = "DayName";
            this.dayNameDataGridViewTextBoxColumn.Name = "dayNameDataGridViewTextBoxColumn";
            this.dayNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dayOfTheMonthDataGridViewTextBoxColumn
            // 
            this.dayOfTheMonthDataGridViewTextBoxColumn.DataPropertyName = "DayOfTheMonth";
            this.dayOfTheMonthDataGridViewTextBoxColumn.HeaderText = "DayOfTheMonth";
            this.dayOfTheMonthDataGridViewTextBoxColumn.Name = "dayOfTheMonthDataGridViewTextBoxColumn";
            this.dayOfTheMonthDataGridViewTextBoxColumn.Width = 200;
            // 
            // Add
            // 
            this.Add.HeaderText = "Add";
            this.Add.Name = "Add";
            this.Add.Text = "Add";
            this.Add.ToolTipText = "Add";
            // 
            // datesBindingSource
            // 
            this.datesBindingSource.DataSource = typeof(global::Calendar.Dates);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.addButton1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 206);
            this.panel1.TabIndex = 2;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.BlueViolet;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 72);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(133, 68);
            this.panel10.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Blue;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 140);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(133, 66);
            this.panel9.TabIndex = 4;
            // 
            // addButton1
            // 
            this.addButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton1.Location = new System.Drawing.Point(0, 23);
            this.addButton1.Name = "addButton1";
            this.addButton1.Size = new System.Drawing.Size(133, 43);
            this.addButton1.TabIndex = 3;
            this.addButton1.Text = "Add";
            this.addButton1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.addButton2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(188, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(137, 100);
            this.panel2.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.BlueViolet;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 72);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(137, 28);
            this.panel11.TabIndex = 6;
            // 
            // addButton2
            // 
            this.addButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton2.Location = new System.Drawing.Point(0, 23);
            this.addButton2.Name = "addButton2";
            this.addButton2.Size = new System.Drawing.Size(137, 43);
            this.addButton2.TabIndex = 4;
            this.addButton2.Text = "Add";
            this.addButton2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.addButton3);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Location = new System.Drawing.Point(353, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(137, 100);
            this.panel3.TabIndex = 3;
            // 
            // addButton3
            // 
            this.addButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.addButton3.Location = new System.Drawing.Point(0, 23);
            this.addButton3.Name = "addButton3";
            this.addButton3.Size = new System.Drawing.Size(137, 43);
            this.addButton3.TabIndex = 5;
            this.addButton3.Text = "Add";
            this.addButton3.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.button4);
            this.panel4.Location = new System.Drawing.Point(524, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(137, 100);
            this.panel4.TabIndex = 3;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.button5);
            this.panel5.Location = new System.Drawing.Point(224, 278);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(137, 100);
            this.panel5.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 23);
            this.button5.TabIndex = 1;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Transparent;
            this.panel6.Controls.Add(this.button6);
            this.panel6.Location = new System.Drawing.Point(224, 152);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(137, 100);
            this.panel6.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(137, 23);
            this.button6.TabIndex = 1;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Transparent;
            this.panel7.Controls.Add(this.button7);
            this.panel7.Location = new System.Drawing.Point(395, 152);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(137, 100);
            this.panel7.TabIndex = 7;
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.Location = new System.Drawing.Point(0, 0);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(137, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Transparent;
            this.panel8.Controls.Add(this.button8);
            this.panel8.Location = new System.Drawing.Point(572, 152);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(137, 100);
            this.panel8.TabIndex = 4;
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.Location = new System.Drawing.Point(0, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(137, 23);
            this.button8.TabIndex = 1;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 768);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ListTest";
            this.Text = "ListTest";
            this.Load += new System.EventHandler(this.ListTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datesBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource datesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayOfTheMonthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button addButton1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button addButton2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button addButton3;
    }
}