
namespace CalendarUI.Forms
{
    partial class AddTaskManually
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddTaskManually));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.insertAlarmLvl3 = new System.Windows.Forms.RadioButton();
            this.insertAlarmLvl2 = new System.Windows.Forms.RadioButton();
            this.insertAlarmLvl1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.cbDay = new System.Windows.Forms.ComboBox();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.insertAlarmLvl3);
            this.panel1.Controls.Add(this.insertAlarmLvl2);
            this.panel1.Controls.Add(this.insertAlarmLvl1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox);
            this.panel1.Controls.Add(this.cbDay);
            this.panel1.Controls.Add(this.cbMonth);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbYear);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 554);
            this.panel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(438, 77);
            this.panel3.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Új feladat hozzáadása";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 77);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(131, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fontosság";
            // 
            // insertAlarmLvl3
            // 
            this.insertAlarmLvl3.AutoSize = true;
            this.insertAlarmLvl3.Location = new System.Drawing.Point(122, 242);
            this.insertAlarmLvl3.Name = "insertAlarmLvl3";
            this.insertAlarmLvl3.Size = new System.Drawing.Size(58, 17);
            this.insertAlarmLvl3.TabIndex = 8;
            this.insertAlarmLvl3.TabStop = true;
            this.insertAlarmLvl3.Text = "Sürgős";
            this.insertAlarmLvl3.UseVisualStyleBackColor = true;
            // 
            // insertAlarmLvl2
            // 
            this.insertAlarmLvl2.AutoSize = true;
            this.insertAlarmLvl2.Location = new System.Drawing.Point(122, 204);
            this.insertAlarmLvl2.Name = "insertAlarmLvl2";
            this.insertAlarmLvl2.Size = new System.Drawing.Size(57, 17);
            this.insertAlarmLvl2.TabIndex = 7;
            this.insertAlarmLvl2.TabStop = true;
            this.insertAlarmLvl2.Text = "Fontos";
            this.insertAlarmLvl2.UseVisualStyleBackColor = true;
            // 
            // insertAlarmLvl1
            // 
            this.insertAlarmLvl1.AutoSize = true;
            this.insertAlarmLvl1.Location = new System.Drawing.Point(122, 166);
            this.insertAlarmLvl1.Name = "insertAlarmLvl1";
            this.insertAlarmLvl1.Size = new System.Drawing.Size(48, 17);
            this.insertAlarmLvl1.TabIndex = 6;
            this.insertAlarmLvl1.TabStop = true;
            this.insertAlarmLvl1.Text = "Ráér";
            this.insertAlarmLvl1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(169, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hozzáad";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox.Location = new System.Drawing.Point(12, 306);
            this.textBox.Multiline = true;
            this.textBox.Name = "textBox";
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox.Size = new System.Drawing.Size(414, 57);
            this.textBox.TabIndex = 4;
            // 
            // cbDay
            // 
            this.cbDay.AutoCompleteCustomSource.AddRange(new string[] {
            "2021",
            "2022"});
            this.cbDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDay.FormattingEnabled = true;
            this.cbDay.Location = new System.Drawing.Point(248, 233);
            this.cbDay.Name = "cbDay";
            this.cbDay.Size = new System.Drawing.Size(63, 32);
            this.cbDay.TabIndex = 3;
            // 
            // cbMonth
            // 
            this.cbMonth.AutoCompleteCustomSource.AddRange(new string[] {
            "2021",
            "2022"});
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(248, 195);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(63, 32);
            this.cbMonth.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(244, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Határidő";
            // 
            // cbYear
            // 
            this.cbYear.AutoCompleteCustomSource.AddRange(new string[] {
            "2021",
            "2022"});
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(248, 157);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(63, 32);
            this.cbYear.TabIndex = 0;
            // 
            // AddTaskManually
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 554);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddTaskManually";
            this.Text = "Calendar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddTaskManually_FormClosing);
            this.Load += new System.EventHandler(this.AddTaskManually_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton insertAlarmLvl3;
        private System.Windows.Forms.RadioButton insertAlarmLvl2;
        private System.Windows.Forms.RadioButton insertAlarmLvl1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.ComboBox cbDay;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbYear;
    }
}