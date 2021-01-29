
namespace Calendar.Main
{
    partial class AddSection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSection));
            this.mainBackBtn = new System.Windows.Forms.PictureBox();
            this.mainExitBtn = new System.Windows.Forms.PictureBox();
            this.mainAddBtn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listPanel = new System.Windows.Forms.Panel();
            this.formFadingTimer = new System.Windows.Forms.Timer(this.components);
            this.lblCurrentDate = new System.Windows.Forms.Label();
            this.addPanel = new System.Windows.Forms.Panel();
            this.insertPanel = new System.Windows.Forms.Panel();
            this.alarmLvl3 = new System.Windows.Forms.RadioButton();
            this.alarmLvl2 = new System.Windows.Forms.RadioButton();
            this.alarmLvl1 = new System.Windows.Forms.RadioButton();
            this.alarmLvl3Btn = new System.Windows.Forms.Button();
            this.alarmLvl2Btn = new System.Windows.Forms.Button();
            this.alarmLvl1Btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTxtBox = new System.Windows.Forms.TextBox();
            this.contentTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainBackBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainExitBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAddBtn)).BeginInit();
            this.addPanel.SuspendLayout();
            this.insertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainBackBtn
            // 
            this.mainBackBtn.BackColor = System.Drawing.Color.Transparent;
            this.mainBackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainBackBtn.Image = ((System.Drawing.Image)(resources.GetObject("mainBackBtn.Image")));
            this.mainBackBtn.Location = new System.Drawing.Point(73, 63);
            this.mainBackBtn.Margin = new System.Windows.Forms.Padding(5);
            this.mainBackBtn.Name = "mainBackBtn";
            this.mainBackBtn.Size = new System.Drawing.Size(100, 50);
            this.mainBackBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainBackBtn.TabIndex = 0;
            this.mainBackBtn.TabStop = false;
            this.mainBackBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // mainExitBtn
            // 
            this.mainExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.mainExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainExitBtn.Image = ((System.Drawing.Image)(resources.GetObject("mainExitBtn.Image")));
            this.mainExitBtn.Location = new System.Drawing.Point(377, 63);
            this.mainExitBtn.Margin = new System.Windows.Forms.Padding(5);
            this.mainExitBtn.Name = "mainExitBtn";
            this.mainExitBtn.Size = new System.Drawing.Size(100, 50);
            this.mainExitBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainExitBtn.TabIndex = 1;
            this.mainExitBtn.TabStop = false;
            this.mainExitBtn.Click += new System.EventHandler(this.mainBtn_Click);
            // 
            // mainAddBtn
            // 
            this.mainAddBtn.BackColor = System.Drawing.Color.Transparent;
            this.mainAddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mainAddBtn.Image = ((System.Drawing.Image)(resources.GetObject("mainAddBtn.Image")));
            this.mainAddBtn.Location = new System.Drawing.Point(16, 28);
            this.mainAddBtn.Name = "mainAddBtn";
            this.mainAddBtn.Size = new System.Drawing.Size(100, 50);
            this.mainAddBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainAddBtn.TabIndex = 2;
            this.mainAddBtn.TabStop = false;
            this.mainAddBtn.Click += new System.EventHandler(this.mainAddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(134, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Adj hozzá új feladatot";
            // 
            // listPanel
            // 
            this.listPanel.AutoScroll = true;
            this.listPanel.BackColor = System.Drawing.Color.Transparent;
            this.listPanel.Location = new System.Drawing.Point(73, 246);
            this.listPanel.Name = "listPanel";
            this.listPanel.Size = new System.Drawing.Size(408, 405);
            this.listPanel.TabIndex = 4;
            // 
            // formFadingTimer
            // 
            this.formFadingTimer.Interval = 10;
            this.formFadingTimer.Tick += new System.EventHandler(this.formFadingTimer_Tick);
            // 
            // lblCurrentDate
            // 
            this.lblCurrentDate.AutoSize = true;
            this.lblCurrentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentDate.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentDate.Location = new System.Drawing.Point(205, 63);
            this.lblCurrentDate.Name = "lblCurrentDate";
            this.lblCurrentDate.Size = new System.Drawing.Size(68, 24);
            this.lblCurrentDate.TabIndex = 5;
            this.lblCurrentDate.Text = "label2";
            // 
            // addPanel
            // 
            this.addPanel.BackColor = System.Drawing.Color.Transparent;
            this.addPanel.Controls.Add(this.mainAddBtn);
            this.addPanel.Controls.Add(this.label1);
            this.addPanel.Location = new System.Drawing.Point(99, 121);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(356, 100);
            this.addPanel.TabIndex = 6;
            // 
            // insertPanel
            // 
            this.insertPanel.Controls.Add(this.alarmLvl3);
            this.insertPanel.Controls.Add(this.alarmLvl2);
            this.insertPanel.Controls.Add(this.alarmLvl1);
            this.insertPanel.Controls.Add(this.alarmLvl3Btn);
            this.insertPanel.Controls.Add(this.alarmLvl2Btn);
            this.insertPanel.Controls.Add(this.alarmLvl1Btn);
            this.insertPanel.Controls.Add(this.label3);
            this.insertPanel.Controls.Add(this.dateTxtBox);
            this.insertPanel.Controls.Add(this.contentTxtBox);
            this.insertPanel.Controls.Add(this.label2);
            this.insertPanel.Controls.Add(this.btnInsert);
            this.insertPanel.Location = new System.Drawing.Point(115, 227);
            this.insertPanel.Name = "insertPanel";
            this.insertPanel.Size = new System.Drawing.Size(331, 198);
            this.insertPanel.TabIndex = 7;
            this.insertPanel.Visible = false;
            // 
            // alarmLvl3
            // 
            this.alarmLvl3.AutoSize = true;
            this.alarmLvl3.Location = new System.Drawing.Point(241, 47);
            this.alarmLvl3.Name = "alarmLvl3";
            this.alarmLvl3.Size = new System.Drawing.Size(94, 17);
            this.alarmLvl3.TabIndex = 12;
            this.alarmLvl3.TabStop = true;
            this.alarmLvl3.Text = "Nagyon fontos";
            this.alarmLvl3.UseVisualStyleBackColor = true;
            this.alarmLvl3.CheckedChanged += new System.EventHandler(this.alarmLevel_Checked);
            // 
            // alarmLvl2
            // 
            this.alarmLvl2.AutoSize = true;
            this.alarmLvl2.Location = new System.Drawing.Point(137, 47);
            this.alarmLvl2.Name = "alarmLvl2";
            this.alarmLvl2.Size = new System.Drawing.Size(57, 17);
            this.alarmLvl2.TabIndex = 11;
            this.alarmLvl2.TabStop = true;
            this.alarmLvl2.Text = "Fontos";
            this.alarmLvl2.UseVisualStyleBackColor = true;
            this.alarmLvl2.CheckedChanged += new System.EventHandler(this.alarmLevel_Checked);
            // 
            // alarmLvl1
            // 
            this.alarmLvl1.AutoSize = true;
            this.alarmLvl1.Location = new System.Drawing.Point(22, 51);
            this.alarmLvl1.Name = "alarmLvl1";
            this.alarmLvl1.Size = new System.Drawing.Size(48, 17);
            this.alarmLvl1.TabIndex = 10;
            this.alarmLvl1.TabStop = true;
            this.alarmLvl1.Text = "Ráér";
            this.alarmLvl1.UseVisualStyleBackColor = true;
            this.alarmLvl1.CheckedChanged += new System.EventHandler(this.alarmLevel_Checked);
            // 
            // alarmLvl3Btn
            // 
            this.alarmLvl3Btn.BackColor = System.Drawing.Color.Transparent;
            this.alarmLvl3Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alarmLvl3Btn.BackgroundImage")));
            this.alarmLvl3Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.alarmLvl3Btn.Location = new System.Drawing.Point(250, 3);
            this.alarmLvl3Btn.Name = "alarmLvl3Btn";
            this.alarmLvl3Btn.Size = new System.Drawing.Size(78, 38);
            this.alarmLvl3Btn.TabIndex = 9;
            this.alarmLvl3Btn.UseVisualStyleBackColor = false;
            this.alarmLvl3Btn.Click += new System.EventHandler(this.alarmBtn_Click);
            // 
            // alarmLvl2Btn
            // 
            this.alarmLvl2Btn.BackColor = System.Drawing.Color.Transparent;
            this.alarmLvl2Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alarmLvl2Btn.BackgroundImage")));
            this.alarmLvl2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.alarmLvl2Btn.Location = new System.Drawing.Point(123, 3);
            this.alarmLvl2Btn.Name = "alarmLvl2Btn";
            this.alarmLvl2Btn.Size = new System.Drawing.Size(78, 38);
            this.alarmLvl2Btn.TabIndex = 8;
            this.alarmLvl2Btn.UseVisualStyleBackColor = false;
            this.alarmLvl2Btn.Click += new System.EventHandler(this.alarmBtn_Click);
            // 
            // alarmLvl1Btn
            // 
            this.alarmLvl1Btn.BackColor = System.Drawing.Color.Transparent;
            this.alarmLvl1Btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("alarmLvl1Btn.BackgroundImage")));
            this.alarmLvl1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.alarmLvl1Btn.Location = new System.Drawing.Point(3, 3);
            this.alarmLvl1Btn.Name = "alarmLvl1Btn";
            this.alarmLvl1Btn.Size = new System.Drawing.Size(78, 38);
            this.alarmLvl1Btn.TabIndex = 7;
            this.alarmLvl1Btn.UseVisualStyleBackColor = false;
            this.alarmLvl1Btn.Click += new System.EventHandler(this.alarmBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dátum:";
            // 
            // dateTxtBox
            // 
            this.dateTxtBox.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTxtBox.Location = new System.Drawing.Point(94, 71);
            this.dateTxtBox.Name = "dateTxtBox";
            this.dateTxtBox.Size = new System.Drawing.Size(149, 25);
            this.dateTxtBox.TabIndex = 3;
            // 
            // contentTxtBox
            // 
            this.contentTxtBox.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.contentTxtBox.Location = new System.Drawing.Point(68, 120);
            this.contentTxtBox.Multiline = true;
            this.contentTxtBox.Name = "contentTxtBox";
            this.contentTxtBox.Size = new System.Drawing.Size(201, 37);
            this.contentTxtBox.TabIndex = 2;
            this.contentTxtBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(141, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Feladat:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(94, 163);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(149, 31);
            this.btnInsert.TabIndex = 0;
            this.btnInsert.Text = "Hozzáad";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(544, 741);
            this.Controls.Add(this.insertPanel);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.lblCurrentDate);
            this.Controls.Add(this.listPanel);
            this.Controls.Add(this.mainExitBtn);
            this.Controls.Add(this.mainBackBtn);
            this.Name = "AddSection";
            this.Text = "AddSection";
            this.Load += new System.EventHandler(this.AddSection_Load);
            this.MouseEnter += new System.EventHandler(this.AddSection_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.mainBackBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainExitBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainAddBtn)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            this.insertPanel.ResumeLayout(false);
            this.insertPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainBackBtn;
        private System.Windows.Forms.PictureBox mainExitBtn;
        private System.Windows.Forms.PictureBox mainAddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel listPanel;
        private System.Windows.Forms.Timer formFadingTimer;
        private System.Windows.Forms.Label lblCurrentDate;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.Panel insertPanel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox contentTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dateTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button alarmLvl3Btn;
        private System.Windows.Forms.Button alarmLvl2Btn;
        private System.Windows.Forms.Button alarmLvl1Btn;
        private System.Windows.Forms.RadioButton alarmLvl1;
        private System.Windows.Forms.RadioButton alarmLvl3;
        private System.Windows.Forms.RadioButton alarmLvl2;
    }
}