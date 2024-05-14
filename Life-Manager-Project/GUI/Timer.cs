using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GUI
{
    public partial class Timer : Form
    {
        public Timer()
        {
            InitializeComponent();
        }

        int hDown = 10, mDown = 00, sDown = 00;

        #region FunctionDown
        private void setTimeDownLabel(int h, int m, int s)
        {
            TimeSpan timeDown = new TimeSpan(h, m, s);
            lblDownTime.Text = timeDown.ToString(@"hh\:mm\:ss");
        }

        private void setTime()
        {
            this.hDown = Convert.ToInt32(nudDownHour.Value);
            this.mDown = Convert.ToInt32(nudDownMinute.Value);
            this.sDown = Convert.ToInt32(nudDownSecond.Value);
            setTimeDownLabel(this.hDown, this.mDown, this.sDown);
            pgbTime.Maximum = ((hDown * 60 + mDown) * 60) + sDown;
        }
        #endregion FunctionDown

        #region EventDown
        private void btnDownStart_Click(object sender, EventArgs e)
        {
            pgbTime.Maximum = ((hDown * 60 + mDown) * 60) + sDown;
            tmrDown.Start();
        }

        private void btnDownPause_Click(object sender, EventArgs e)
        {
            tmrDown.Stop();
        }

        private void btnDownStop_Click(object sender, EventArgs e)
        {
            tmrDown.Stop();
            pgbTime.Value = 0;
            setTime();
        }

        private void btnDownEdit_Click(object sender, EventArgs e)
        {
            btnDownStop.PerformClick();
            nudDownHour.Visible = !nudDownHour.Visible;
            nudDownMinute.Visible = !nudDownMinute.Visible;
            nudDownSecond.Visible = !nudDownSecond.Visible;
            btnDownStart.Enabled = !btnDownStart.Enabled;
            btnDownPause.Enabled = !btnDownPause.Enabled;
            btnDownStop.Enabled = !btnDownStop.Enabled;
            if (nudDownHour.Visible == true)
                btnDownEdit.Text = "Xong";
            else
            {
                setTime();
                btnDownEdit.Text = "Chỉnh sửa";
            }
        }

        private void tmrDown_Tick(object sender, EventArgs e)
        {
            sDown--;
            if (sDown == 0)
            {
                sDown = 60;
                if (mDown == 0)
                {
                    mDown = 60;
                    if (hDown == 0)
                    {
                        hDown--;
                        tmrDown.Stop();
                        MessageBox.Show("Thời gian bạn cài đã hết!", "Hết thời gian!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        setTime();
                    }
                    else
                        hDown--;
                }
                mDown--;
            }
            pgbTime.PerformStep();
            setTimeDownLabel(this.hDown, this.mDown, this.sDown);
        }
        #endregion EventDown

        int mUp = 00, sUp = 00, msUp = 000, mUpM = 00, sUpM = 00, msUpM = 000, lap = 0;

        #region FunctionUp
        private string setTimeUpLabel(int m, int s, int ms)
        {
            TimeSpan timeDown = new TimeSpan(m, s, ms);
            return timeDown.ToString(@"hh\:mm\:ss");
        }

        private string setTimeUpMLabel(int m, int s, int ms)
        {
            TimeSpan timeDown = new TimeSpan(m, s, ms);
            return timeDown.ToString(@"hh\:mm\:ss");
        }

        void LoadListView()
        {
            ListViewItem item = new ListViewItem();
            item.Text = this.lap.ToString();
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = setTimeUpMLabel(this.mUpM, this.sUpM, this.msUpM) });
            item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = setTimeUpLabel(this.mUp, this.sUp, this.msUp) });
            lstFlag.Items.Add(item);
        }
        #endregion FunctionUp

        #region EventUp
        private void btnUpStart_Click(object sender, EventArgs e)
        {
            tmrUp.Start();
        }

        private void btnUpPause_Click(object sender, EventArgs e)
        {
            tmrUp.Stop();
        }

        private void btnUpFlag_Click(object sender, EventArgs e)
        {
            this.lap++;
            LoadListView();
            this.mUpM = 00;
            this.sUpM = 00;
            this.msUpM = 000;
            lblUpTimeM.Text = setTimeUpMLabel(this.mUpM, this.sUpM, this.msUpM);
        }

        private void btnUpResert_Click(object sender, EventArgs e)
        {
            tmrUp.Stop();
            this.lap = 0;
            this.mUp = 00;
            this.sUp = 00;
            this.msUp = 000;
            lblUpTime.Text = setTimeUpLabel(this.mUp, this.sUp, this.msUp);
            this.mUpM = 00;
            this.sUpM = 00;
            this.msUpM = 000;
            lblUpTimeM.Text = setTimeUpMLabel(this.mUpM, this.sUpM, this.msUpM);
            lstFlag.Items.Clear();
        }

        private void tmrUp_Tick(object sender, EventArgs e)
        {
            msUp++;
            if (msUp == 65)
            {
                msUp = 0;
                sUp++;
                if (sUp == 60)
                {
                    sUp = 0;
                    mUp++;
                }
            }
            lblUpTime.Text = setTimeUpLabel(this.mUp, this.sUp, this.msUp);
            msUpM++;
            if (msUpM == 65)
            {
                msUpM = 0;
                sUpM++;
                if (sUpM == 60)
                {
                    sUpM = 0;
                    mUpM++;
                }
            }
            lblUpTimeM.Text = setTimeUpMLabel(this.mUpM, this.sUpM, this.msUpM);
        }
        #endregion EventUp
    }
}