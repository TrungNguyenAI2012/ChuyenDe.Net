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
    public partial class Pomodoro : Form
    {

        public Pomodoro()
        {
            InitializeComponent();
            //setTimePomodoro();
        }

        //int h, m, s, times = 5;

        //#region Function
        //private void setTimeLabel(int h, int m, int s)
        //{
        //    TimeSpan timeLabel = new TimeSpan(h, m, s);
        //    lblTime.Text = timeLabel.ToString(@"mm\:ss");
        //}

        //private void setTimePomodoro()
        //{
        //    lblLevel.Text = "Thời gian 'Làm việc'";
        //    this.m = 25;
        //    this.s = 00;
        //    setTimeLabel(this.h, this.m, this.s);
        //    pgbTime.Maximum = 1500;
        //    pgbPomodoro.PerformStep();
        //}

        //private void setTimeShortBreak()
        //{
        //    lblLevel.Text = "Thời gian 'Nghỉ ngắn'";
        //    this.m = 05;
        //    this.s = 00;
        //    setTimeLabel(this.h, this.m, this.s);
        //    pgbTime.Maximum = 300;
        //}

        //private void setTimeLongBreak()
        //{
        //    lblLevel.Text = "Thời gian 'Nghỉ dài'";
        //    this.m = 15;
        //    this.s = 00;
        //    setTimeLabel(this.h, this.m, this.s);
        //    pgbTime.Maximum = 900;
        //}
        //#endregion Function

        //#region Event
        //private void btnStart_Click(object sender, EventArgs e)
        //{
        //    tmrTime.Start();
        //}

        //private void btnPause_Click(object sender, EventArgs e)
        //{
        //    tmrTime.Stop();
        //}

        //private void btnNextLevel_Click(object sender, EventArgs e)
        //{

        //}

        //private void btnResert_Click(object sender, EventArgs e)
        //{
        //    setTimePomodoro();
        //    tmrTime.Stop();
        //}

        //private void tmrTime_Tick(object sender, EventArgs e)
        //{
        //    pgbPomodoro.Maximum = times;
        //    lblTotalPomodoro.Text = this.times.ToString();
        //    this.s--;
        //    if (this.s == 0)
        //    {
        //        this.s = 60;
        //        if (this.m == 0)
        //        {
        //            this.times--;
        //            if (this.times % 2 == 0)
        //                setTimePomodoro();
        //            else
        //                setTimeShortBreak();
        //        }
        //        this.m--;
        //    }
        //    pgbTime.PerformStep();
        //    setTimeLabel(this.h, this.m, this.s);
        //}
        //#endregion Event

        #region Event
        private void btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion Event
    }
}
