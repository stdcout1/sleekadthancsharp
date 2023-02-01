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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GUI.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Controls.Add(this.flowLayoutPanel2);
            this.groupBox1.Controls.Add(this.flowLayoutPanel6);
            this.groupBox1.Controls.Add(this.flowLayoutPanel5);
            this.groupBox1.Controls.Add(this.flowLayoutPanel4);
            this.groupBox1.Controls.Add(this.flowLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(395, 450);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prayer Notfications";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.comboBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 63);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(377, 54);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fajr";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(212, 46);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.SettingsChange);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.comboBox2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 123);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(377, 54);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sunrise";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(123, 3);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(212, 46);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.SettingsChange);
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.label6);
            this.flowLayoutPanel6.Controls.Add(this.comboBox6);
            this.flowLayoutPanel6.Location = new System.Drawing.Point(12, 363);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(377, 54);
            this.flowLayoutPanel6.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 6);
            this.label6.Margin = new System.Windows.Forms.Padding(6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Isha";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(123, 3);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(212, 46);
            this.comboBox6.TabIndex = 1;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.SettingsChange);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.comboBox5);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(12, 303);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(377, 54);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 6);
            this.label5.Margin = new System.Windows.Forms.Padding(6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Magrib";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(123, 3);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(212, 46);
            this.comboBox5.TabIndex = 1;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.SettingsChange);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.label4);
            this.flowLayoutPanel4.Controls.Add(this.comboBox4);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(12, 243);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(377, 54);
            this.flowLayoutPanel4.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 6);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Asr";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(123, 3);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(212, 46);
            this.comboBox4.TabIndex = 1;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.SettingsChange);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.comboBox3);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 183);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(377, 54);
            this.flowLayoutPanel3.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Duhur";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(123, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(212, 46);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.SettingsChange);
            // 
            // landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "landing";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.landing_Load);
            this.Resize += new System.EventHandler(this.minimize);
            this.GUI.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private ContextMenuStrip GUI;
        private ToolStripMenuItem AdthanToggle;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label1;
        private ComboBox comboBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label label2;
        private ComboBox comboBox2;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label label6;
        private ComboBox comboBox6;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label label5;
        private ComboBox comboBox5;
        private FlowLayoutPanel flowLayoutPanel4;
        private Label label4;
        private ComboBox comboBox4;
        private FlowLayoutPanel flowLayoutPanel3;
        private Label label3;
        private ComboBox comboBox3;
    }
}