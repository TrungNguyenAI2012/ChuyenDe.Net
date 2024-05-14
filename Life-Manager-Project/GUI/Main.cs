using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            tmrMain.Start();
        }

        int x = 0;

        #region Event
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            if (x++ >= 3)
            {
                tmrMain.Stop();
                pbxTime.Hide();
            }
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No)
                e.Cancel = true;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnAlarm.Visible = false;
            btnNote.Visible = false;
            btnGanttChart.Visible = false;
            btnHealth.Visible = false;
            btnEvent.Visible = false;
            btnTimeTable.Visible = false;
            btnPomodoro.Visible = false;
            btnAnother.Visible = false;
            btnTimer.Visible = false;
            btnDiary.Visible = false;
            btnMindMap.Visible = false;
            btnMoney.Visible = false;
            btnTime.Visible = !btnTime.Visible;
            btnLife.Visible = !btnLife.Visible;
            btnJob.Visible = !btnJob.Visible;
            btnManager.Visible = !btnManager.Visible;
        }
        // Main
        private void btnTime_Click(object sender, EventArgs e)
        {
            btnAlarm.Visible = !btnAlarm.Visible;
            btnTimeTable.Visible = !btnTimeTable.Visible;
            btnTimer.Visible = !btnTimer.Visible;
        }
        private void btnLife_Click(object sender, EventArgs e)
        {
            btnNote.Visible = !btnNote.Visible;
            btnEvent.Visible = !btnEvent.Visible;
            btnDiary.Visible = !btnDiary.Visible;
        }
        private void btnJob_Click(object sender, EventArgs e)
        {
            btnGanttChart.Visible = !btnGanttChart.Visible;
            btnPomodoro.Visible = !btnPomodoro.Visible;
            btnMindMap.Visible = !btnMindMap.Visible;
        }
        private void btnManager_Click(object sender, EventArgs e)
        {
            btnHealth.Visible = !btnHealth.Visible;
            btnAnother.Visible = !btnAnother.Visible;
            btnMoney.Visible = !btnMoney.Visible;
        }
        // Time
        private void btnTimer_Click(object sender, EventArgs e)
        {
            Timer f = new Timer();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnTimeTable_Click(object sender, EventArgs e)
        {
            TimeTable f = new TimeTable();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnAlarm_Click(object sender, EventArgs e)
        {
            Alarm f = new Alarm();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        // Life
        private void btnNote_Click(object sender, EventArgs e)
        {
            Note f = new Note();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnDiary_Click(object sender, EventArgs e)
        {
            Diary f = new Diary();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnEvent_Click(object sender, EventArgs e)
        {
            Event f = new Event();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        // Manager
        private void btnAnother_Click(object sender, EventArgs e)
        {
            Another f = new Another();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnMoney_Click(object sender, EventArgs e)
        {
            Money f = new Money();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnHealth_Click(object sender, EventArgs e)
        {
            Health f = new Health();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        // Job
        private void btnGanttChart_Click(object sender, EventArgs e)
        {
            GanttChart f = new GanttChart();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnMindMap_Click(object sender, EventArgs e)
        {
            MindMap f = new MindMap();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        private void btnPomodoro_Click(object sender, EventArgs e)
        {
            Pomodoro f = new Pomodoro();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion Event
    }
}