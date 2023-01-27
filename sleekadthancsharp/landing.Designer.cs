namespace sleekadthancsharp
{
    partial class landing
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(landing));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.GUI = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AdthanToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.GUI.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "test";
            this.notifyIcon1.BalloonTipTitle = "title";
            this.notifyIcon1.ContextMenuStrip = this.GUI;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.BalloonTipClicked += new System.EventHandler(this.clicked);
            this.notifyIcon1.BalloonTipClosed += new System.EventHandler(this.dismiss);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // GUI
            // 
            this.GUI.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.GUI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdthanToggle,
            this.optionsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.GUI.Name = "GUI";
            this.GUI.Size = new System.Drawing.Size(160, 112);
            // 
            // AdthanToggle
            // 
            this.AdthanToggle.Checked = true;
            this.AdthanToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AdthanToggle.Name = "AdthanToggle";
            this.AdthanToggle.Size = new System.Drawing.Size(159, 36);
            this.AdthanToggle.Text = "Adthan";
            this.AdthanToggle.Click += new System.EventHandler(this.adthanToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(159, 36);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(159, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Name = "landing";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.landing_Load);
            this.Resize += new System.EventHandler(this.minimize);
            this.GUI.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private ContextMenuStrip GUI;
        private ToolStripMenuItem AdthanToggle;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}