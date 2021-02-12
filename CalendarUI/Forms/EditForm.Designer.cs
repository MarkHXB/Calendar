
namespace CalendarUI.Forms
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.showPnTaskPn = new System.Windows.Forms.Panel();
            this.addCurrentDayPanel = new System.Windows.Forms.Panel();
            this.addCDTitle = new System.Windows.Forms.Label();
            this.addCDButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.showPnSuccededPn = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.succededLabel = new System.Windows.Forms.Label();
            this.unsuccededLabel = new System.Windows.Forms.Label();
            this.succededTitle = new System.Windows.Forms.Label();
            this.unsuccededTasksTitle = new System.Windows.Forms.Label();
            this.showPnTitlePn = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.Button();
            this.dayLabel = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.editPnTitlePn = new System.Windows.Forms.Panel();
            this.insertLbl = new System.Windows.Forms.Label();
            this.deleteLbl = new System.Windows.Forms.Label();
            this.editLbl = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.showPnTaskPn.SuspendLayout();
            this.addCurrentDayPanel.SuspendLayout();
            this.showPnSuccededPn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.showPnTitlePn.SuspendLayout();
            this.statusPanel.SuspendLayout();
            this.editPnTitlePn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.showPnTaskPn);
            this.panel2.Controls.Add(this.showPnSuccededPn);
            this.panel2.Controls.Add(this.showPnTitlePn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(547, 665);
            this.panel2.TabIndex = 1;
            // 
            // showPnTaskPn
            // 
            this.showPnTaskPn.AutoScroll = true;
            this.showPnTaskPn.BackColor = System.Drawing.Color.White;
            this.showPnTaskPn.Controls.Add(this.addCurrentDayPanel);
            this.showPnTaskPn.Controls.Add(this.label5);
            this.showPnTaskPn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showPnTaskPn.Location = new System.Drawing.Point(0, 86);
            this.showPnTaskPn.Name = "showPnTaskPn";
            this.showPnTaskPn.Size = new System.Drawing.Size(547, 579);
            this.showPnTaskPn.TabIndex = 5;
            // 
            // addCurrentDayPanel
            // 
            this.addCurrentDayPanel.Controls.Add(this.addCDTitle);
            this.addCurrentDayPanel.Controls.Add(this.addCDButton);
            this.addCurrentDayPanel.Enabled = false;
            this.addCurrentDayPanel.Location = new System.Drawing.Point(102, 293);
            this.addCurrentDayPanel.Name = "addCurrentDayPanel";
            this.addCurrentDayPanel.Size = new System.Drawing.Size(265, 104);
            this.addCurrentDayPanel.TabIndex = 7;
            this.addCurrentDayPanel.Visible = false;
            // 
            // addCDTitle
            // 
            this.addCDTitle.AutoSize = true;
            this.addCDTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addCDTitle.Location = new System.Drawing.Point(72, 12);
            this.addCDTitle.Name = "addCDTitle";
            this.addCDTitle.Size = new System.Drawing.Size(105, 30);
            this.addCDTitle.TabIndex = 1;
            this.addCDTitle.Text = "Új feladat";
            // 
            // addCDButton
            // 
            this.addCDButton.BackColor = System.Drawing.Color.Transparent;
            this.addCDButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addCDButton.BackgroundImage")));
            this.addCDButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addCDButton.FlatAppearance.BorderSize = 0;
            this.addCDButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCDButton.Location = new System.Drawing.Point(77, 54);
            this.addCDButton.Name = "addCDButton";
            this.addCDButton.Size = new System.Drawing.Size(98, 44);
            this.addCDButton.TabIndex = 0;
            this.addCDButton.UseVisualStyleBackColor = false;
            this.addCDButton.Click += new System.EventHandler(this.addCDButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(226, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Feladatok:";
            // 
            // showPnSuccededPn
            // 
            this.showPnSuccededPn.Controls.Add(this.pictureBox2);
            this.showPnSuccededPn.Controls.Add(this.pictureBox1);
            this.showPnSuccededPn.Controls.Add(this.succededLabel);
            this.showPnSuccededPn.Controls.Add(this.unsuccededLabel);
            this.showPnSuccededPn.Controls.Add(this.succededTitle);
            this.showPnSuccededPn.Controls.Add(this.unsuccededTasksTitle);
            this.showPnSuccededPn.Dock = System.Windows.Forms.DockStyle.Top;
            this.showPnSuccededPn.Location = new System.Drawing.Point(0, 65);
            this.showPnSuccededPn.Name = "showPnSuccededPn";
            this.showPnSuccededPn.Size = new System.Drawing.Size(547, 21);
            this.showPnSuccededPn.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(298, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 13);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 13);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // succededLabel
            // 
            this.succededLabel.AutoSize = true;
            this.succededLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.succededLabel.Location = new System.Drawing.Point(464, 3);
            this.succededLabel.Name = "succededLabel";
            this.succededLabel.Size = new System.Drawing.Size(34, 15);
            this.succededLabel.TabIndex = 6;
            this.succededLabel.Text = "point";
            // 
            // unsuccededLabel
            // 
            this.unsuccededLabel.AutoSize = true;
            this.unsuccededLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unsuccededLabel.Location = new System.Drawing.Point(196, 3);
            this.unsuccededLabel.Name = "unsuccededLabel";
            this.unsuccededLabel.Size = new System.Drawing.Size(34, 15);
            this.unsuccededLabel.TabIndex = 5;
            this.unsuccededLabel.Text = "point";
            // 
            // succededTitle
            // 
            this.succededTitle.AutoSize = true;
            this.succededTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.succededTitle.Location = new System.Drawing.Point(330, 3);
            this.succededTitle.Name = "succededTitle";
            this.succededTitle.Size = new System.Drawing.Size(128, 16);
            this.succededTitle.TabIndex = 4;
            this.succededTitle.Text = "Teljesített feladatok:";
            // 
            // unsuccededTasksTitle
            // 
            this.unsuccededTasksTitle.AutoSize = true;
            this.unsuccededTasksTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.unsuccededTasksTitle.Location = new System.Drawing.Point(44, 3);
            this.unsuccededTasksTitle.Name = "unsuccededTasksTitle";
            this.unsuccededTasksTitle.Size = new System.Drawing.Size(146, 16);
            this.unsuccededTasksTitle.TabIndex = 3;
            this.unsuccededTasksTitle.Text = "Teljesítettlen feladatok:";
            // 
            // showPnTitlePn
            // 
            this.showPnTitlePn.BackColor = System.Drawing.Color.White;
            this.showPnTitlePn.Controls.Add(this.backBtn);
            this.showPnTitlePn.Controls.Add(this.dayLabel);
            this.showPnTitlePn.Controls.Add(this.monthLabel);
            this.showPnTitlePn.Dock = System.Windows.Forms.DockStyle.Top;
            this.showPnTitlePn.Location = new System.Drawing.Point(0, 0);
            this.showPnTitlePn.Name = "showPnTitlePn";
            this.showPnTitlePn.Size = new System.Drawing.Size(547, 65);
            this.showPnTitlePn.TabIndex = 0;
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.Transparent;
            this.backBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("backBtn.BackgroundImage")));
            this.backBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backBtn.Location = new System.Drawing.Point(12, 15);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(61, 36);
            this.backBtn.TabIndex = 2;
            this.backBtn.UseVisualStyleBackColor = false;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dayLabel.Location = new System.Drawing.Point(212, 38);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(40, 24);
            this.dayLabel.TabIndex = 1;
            this.dayLabel.Text = "day";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.monthLabel.Location = new System.Drawing.Point(212, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(63, 24);
            this.monthLabel.TabIndex = 0;
            this.monthLabel.Text = "month";
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.editPnTitlePn);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.statusPanel.Location = new System.Drawing.Point(547, 0);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(373, 665);
            this.statusPanel.TabIndex = 2;
            // 
            // editPnTitlePn
            // 
            this.editPnTitlePn.BackColor = System.Drawing.Color.White;
            this.editPnTitlePn.Controls.Add(this.insertLbl);
            this.editPnTitlePn.Controls.Add(this.deleteLbl);
            this.editPnTitlePn.Controls.Add(this.editLbl);
            this.editPnTitlePn.Dock = System.Windows.Forms.DockStyle.Top;
            this.editPnTitlePn.Location = new System.Drawing.Point(0, 0);
            this.editPnTitlePn.Name = "editPnTitlePn";
            this.editPnTitlePn.Size = new System.Drawing.Size(373, 66);
            this.editPnTitlePn.TabIndex = 3;
            // 
            // insertLbl
            // 
            this.insertLbl.AutoSize = true;
            this.insertLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.insertLbl.Location = new System.Drawing.Point(146, 23);
            this.insertLbl.Name = "insertLbl";
            this.insertLbl.Size = new System.Drawing.Size(120, 25);
            this.insertLbl.TabIndex = 1;
            this.insertLbl.Text = "Hozzáadás";
            this.insertLbl.Click += new System.EventHandler(this.statusBtn_Click);
            // 
            // deleteLbl
            // 
            this.deleteLbl.AutoSize = true;
            this.deleteLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.deleteLbl.Location = new System.Drawing.Point(297, 23);
            this.deleteLbl.Name = "deleteLbl";
            this.deleteLbl.Size = new System.Drawing.Size(72, 25);
            this.deleteLbl.TabIndex = 2;
            this.deleteLbl.Text = "Törlés";
            this.deleteLbl.Click += new System.EventHandler(this.statusBtn_Click);
            // 
            // editLbl
            // 
            this.editLbl.AutoSize = true;
            this.editLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.editLbl.Location = new System.Drawing.Point(8, 23);
            this.editLbl.Name = "editLbl";
            this.editLbl.Size = new System.Drawing.Size(111, 25);
            this.editLbl.TabIndex = 0;
            this.editLbl.Text = "Módosítás";
            this.editLbl.Click += new System.EventHandler(this.statusBtn_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 665);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditForm";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.InsertForm_Load);
            this.panel2.ResumeLayout(false);
            this.showPnTaskPn.ResumeLayout(false);
            this.showPnTaskPn.PerformLayout();
            this.addCurrentDayPanel.ResumeLayout(false);
            this.addCurrentDayPanel.PerformLayout();
            this.showPnSuccededPn.ResumeLayout(false);
            this.showPnSuccededPn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.showPnTitlePn.ResumeLayout(false);
            this.showPnTitlePn.PerformLayout();
            this.statusPanel.ResumeLayout(false);
            this.editPnTitlePn.ResumeLayout(false);
            this.editPnTitlePn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Panel editPnTitlePn;
        private System.Windows.Forms.Label insertLbl;
        private System.Windows.Forms.Label deleteLbl;
        private System.Windows.Forms.Label editLbl;
        private System.Windows.Forms.Panel showPnSuccededPn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label succededLabel;
        private System.Windows.Forms.Label unsuccededLabel;
        private System.Windows.Forms.Label succededTitle;
        private System.Windows.Forms.Label unsuccededTasksTitle;
        private System.Windows.Forms.Panel showPnTitlePn;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel showPnTaskPn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Panel addCurrentDayPanel;
        private System.Windows.Forms.Label addCDTitle;
        private System.Windows.Forms.Button addCDButton;
    }
}