
namespace Forms.Main
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuPanel_1 = new System.Windows.Forms.Panel();
            this.btnBackForm = new System.Windows.Forms.Button();
            this.menuPanel_2 = new System.Windows.Forms.Panel();
            this.currentTasksLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.currentDayName = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuPanel_1.SuspendLayout();
            this.menuPanel_2.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel_1
            // 
            this.menuPanel_1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuPanel_1.Controls.Add(this.btnBackForm);
            this.menuPanel_1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel_1.Location = new System.Drawing.Point(0, 0);
            this.menuPanel_1.Name = "menuPanel_1";
            this.menuPanel_1.Size = new System.Drawing.Size(214, 601);
            this.menuPanel_1.TabIndex = 14;
            // 
            // btnBackForm
            // 
            this.btnBackForm.BackColor = System.Drawing.Color.Transparent;
            this.btnBackForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackForm.BackgroundImage")));
            this.btnBackForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBackForm.Location = new System.Drawing.Point(12, 12);
            this.btnBackForm.Name = "btnBackForm";
            this.btnBackForm.Size = new System.Drawing.Size(76, 54);
            this.btnBackForm.TabIndex = 0;
            this.btnBackForm.UseVisualStyleBackColor = false;
            this.btnBackForm.Click += new System.EventHandler(this.btnBackForm_Click);
            // 
            // menuPanel_2
            // 
            this.menuPanel_2.Controls.Add(this.currentTasksLbl);
            this.menuPanel_2.Controls.Add(this.label2);
            this.menuPanel_2.Controls.Add(this.currentDayName);
            this.menuPanel_2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuPanel_2.Location = new System.Drawing.Point(214, 0);
            this.menuPanel_2.Name = "menuPanel_2";
            this.menuPanel_2.Size = new System.Drawing.Size(979, 91);
            this.menuPanel_2.TabIndex = 15;
            // 
            // currentTasksLbl
            // 
            this.currentTasksLbl.AutoSize = true;
            this.currentTasksLbl.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentTasksLbl.Location = new System.Drawing.Point(501, 56);
            this.currentTasksLbl.Name = "currentTasksLbl";
            this.currentTasksLbl.Size = new System.Drawing.Size(61, 23);
            this.currentTasksLbl.TabIndex = 2;
            this.currentTasksLbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mára ennyi feladat van:";
            // 
            // currentDayName
            // 
            this.currentDayName.AutoSize = true;
            this.currentDayName.Font = new System.Drawing.Font("Microsoft Tai Le", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentDayName.ForeColor = System.Drawing.Color.Firebrick;
            this.currentDayName.Location = new System.Drawing.Point(395, 9);
            this.currentDayName.Name = "currentDayName";
            this.currentDayName.Size = new System.Drawing.Size(100, 37);
            this.currentDayName.TabIndex = 0;
            this.currentDayName.Text = "label1";
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.Controls.Add(this.panel3);
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.panel2);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(214, 91);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(979, 510);
            this.mainPanel.TabIndex = 16;
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(30, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 312);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(77, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fontosság";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(68, 142);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(68, 104);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(68, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(122, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hozzáad";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(15, 192);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(309, 51);
            this.textBox1.TabIndex = 4;
            // 
            // comboBox3
            // 
            this.comboBox3.AutoCompleteCustomSource.AddRange(new string[] {
            "2021",
            "2022"});
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboBox3.Location = new System.Drawing.Point(194, 133);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(63, 32);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.Text = "2021";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteCustomSource.AddRange(new string[] {
            "2021",
            "2022"});
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox2.Location = new System.Drawing.Point(194, 95);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(63, 32);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.Text = "2021";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(190, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Határidő";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "2021",
            "2022"});
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.comboBox1.Location = new System.Drawing.Point(194, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(63, 32);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "2021";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(30, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(366, 156);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(203, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 33);
            this.button3.TabIndex = 2;
            this.button3.Text = "Nem";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(57, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Igen";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(43, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(273, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Biztosan törölni szeretnéd?";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Location = new System.Drawing.Point(482, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(265, 104);
            this.panel3.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(77, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 44);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(72, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 30);
            this.label5.TabIndex = 1;
            this.label5.Text = "Új feladat";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1193, 601);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel_2);
            this.Controls.Add(this.menuPanel_1);
            this.MinimumSize = new System.Drawing.Size(1209, 640);
            this.Name = "MainForm";
            this.Text = "Main";
            this.Activated += new System.EventHandler(this.mainForm_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseLeave += new System.EventHandler(this.MainForm_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainP_Move);
            this.menuPanel_1.ResumeLayout(false);
            this.menuPanel_2.ResumeLayout(false);
            this.menuPanel_2.PerformLayout();
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel_1;
        private System.Windows.Forms.Panel menuPanel_2;
        private System.Windows.Forms.Label currentTasksLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label currentDayName;
        private System.Windows.Forms.Button btnBackForm;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
    }
}