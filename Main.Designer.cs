
namespace Calendar
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
            this.menuPanel_1.SuspendLayout();
            this.menuPanel_2.SuspendLayout();
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
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(214, 91);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(979, 510);
            this.mainPanel.TabIndex = 16;
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
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
    }
}