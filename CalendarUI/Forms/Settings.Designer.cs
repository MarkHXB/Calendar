
namespace CalendarUI.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.backBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.alarmPerDayBox = new System.Windows.Forms.ComboBox();
            this.colorBox = new System.Windows.Forms.ComboBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.backBtn.FlatAppearance.BorderSize = 4;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 45);
            this.backBtn.TabIndex = 0;
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 424);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(387, 77);
            this.panel2.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 77);
            this.panel1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(157, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Beállítások";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Felhasználónév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 30);
            this.label3.TabIndex = 15;
            this.label3.Text = "Alap szín:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(17, 191);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(347, 75);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Hányszor értesítsen egy nap az alkalmazás?";
            // 
            // alarmPerDayBox
            // 
            this.alarmPerDayBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.alarmPerDayBox.FormattingEnabled = true;
            this.alarmPerDayBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.alarmPerDayBox.Location = new System.Drawing.Point(176, 228);
            this.alarmPerDayBox.Name = "alarmPerDayBox";
            this.alarmPerDayBox.Size = new System.Drawing.Size(121, 38);
            this.alarmPerDayBox.TabIndex = 17;
            this.alarmPerDayBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // colorBox
            // 
            this.colorBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.colorBox.FormattingEnabled = true;
            this.colorBox.Items.AddRange(new object[] {
            "White",
            "Black",
            "Blue",
            "Green",
            "Red"});
            this.colorBox.Location = new System.Drawing.Point(146, 305);
            this.colorBox.Name = "colorBox";
            this.colorBox.Size = new System.Drawing.Size(121, 33);
            this.colorBox.TabIndex = 18;
            this.colorBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox2_KeyPress);
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usernameTxtBox.Location = new System.Drawing.Point(191, 119);
            this.usernameTxtBox.Multiline = true;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usernameTxtBox.Size = new System.Drawing.Size(184, 25);
            this.usernameTxtBox.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(146, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 43);
            this.button1.TabIndex = 20;
            this.button1.Text = "Mentés";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usernameTxtBox);
            this.Controls.Add(this.colorBox);
            this.Controls.Add(this.alarmPerDayBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(403, 540);
            this.MinimumSize = new System.Drawing.Size(403, 540);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox alarmPerDayBox;
        private System.Windows.Forms.ComboBox colorBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}