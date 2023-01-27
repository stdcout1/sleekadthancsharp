using System.Windows.Forms;


namespace sleekadthancsharp
{
    public partial class landing : Form
    {
        //DateTime today = DateTime.Now;
        DateTime today = new DateTime(2023, 01, 24, 6, 19, 00);
        PrayerTimes PrayerTime;
        AdthanPlayer player = new AdthanPlayer();
        bool play = true;
        public landing()
        {
            InitializeComponent();
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "Tooltip message here";
            this.ShowInTaskbar = false;
            this.Hide();
            PrayerTime = new PrayerTimes("Toronto", "Canada", today.Day, today.Month, today.Year); //make a new prayer time object which will hold the request
            timer1.Enabled = true;
        }

        private void landing_Load(object sender, EventArgs e)
        {
            
        }

        private void minimize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            //notifyIcon1.Visible = false;
            //label1.Text = PrayerTime.jingle.data[today.Day].timings.Fajr;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (PrayerTime.CheckTime(today.TimeOfDay, player, play))
            {
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipTitle = $"Time for {PrayerTime.curr_prayer}!";
                notifyIcon1.BalloonTipText = string.Join(string.Empty, player.SelectPhrases(PrayerTime.curr_prayer));
                notifyIcon1.ShowBalloonTip(1000);
            }
            today = today.AddSeconds(1);

        }

        private void dismiss(object sender, EventArgs e)
        {
            player.StopAdthan();
        }
        private void clicked (object sender, EventArgs e)
        {
            player.StopAdthan();
        }

        private void adthanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdthanToggle.Checked = !AdthanToggle.Checked;
            play = !play;
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.Hide();
                e.Cancel = true;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}