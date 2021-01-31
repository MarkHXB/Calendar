
namespace Forms.CalendarForm
{
    partial class Calendar
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Node0", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.menuPanel = new System.Windows.Forms.Panel();
            this.lblMainForm = new System.Windows.Forms.Label();
            this.btnTaskForm = new System.Windows.Forms.Button();
            this.currentTasks = new System.Windows.Forms.TreeView();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuPanel.Controls.Add(this.currentTasks);
            this.menuPanel.Controls.Add(this.lblMainForm);
            this.menuPanel.Controls.Add(this.btnTaskForm);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(200, 619);
            this.menuPanel.TabIndex = 1;
            this.menuPanel.Visible = false;
            // 
            // lblMainForm
            // 
            this.lblMainForm.AutoSize = true;
            this.lblMainForm.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMainForm.Location = new System.Drawing.Point(59, 30);
            this.lblMainForm.Name = "lblMainForm";
            this.lblMainForm.Size = new System.Drawing.Size(40, 21);
            this.lblMainForm.TabIndex = 1;
            this.lblMainForm.Text = "Day";
            // 
            // btnTaskForm
            // 
            this.btnTaskForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTaskForm.Location = new System.Drawing.Point(36, 54);
            this.btnTaskForm.Name = "btnTaskForm";
            this.btnTaskForm.Size = new System.Drawing.Size(121, 34);
            this.btnTaskForm.TabIndex = 0;
            this.btnTaskForm.Text = "Feladatok:";
            this.btnTaskForm.UseVisualStyleBackColor = true;
            this.btnTaskForm.Click += new System.EventHandler(this.btnTaskForm_Click);
            // 
            // currentTasks
            // 
            this.currentTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.currentTasks.Location = new System.Drawing.Point(12, 108);
            this.currentTasks.Name = "currentTasks";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Node1";
            treeNode2.Name = "Node0";
            treeNode2.Text = "Node0";
            this.currentTasks.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.currentTasks.Size = new System.Drawing.Size(174, 499);
            this.currentTasks.TabIndex = 2;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1083, 619);
            this.Controls.Add(this.menuPanel);
            this.Name = "Calendar";
            this.Text = "Form2";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button btnTaskForm;
        private System.Windows.Forms.Label lblMainForm;
        private System.Windows.Forms.TreeView currentTasks;
    }
}