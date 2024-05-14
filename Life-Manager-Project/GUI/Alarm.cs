using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class Alarm : Form
    {
        public Alarm()
        {
            InitializeComponent();
            tmrTime.Start();
            //Control.CheckForIllegalCrossThreadCalls = false;
        }

        #region Function
        private void ShowData()
        {
            AlarmBUS almBUS = new AlarmBUS();
            List<AlarmDTO> ds = almBUS.HienThi();
            lvwAlarm.Items.Clear();
            foreach (AlarmDTO item in ds)
            {
                ListViewItem lvi = new ListViewItem(item.ThoiGian.ToString());
                lvi.SubItems.Add(item.Ten);
                lvi.SubItems.Add(item.GhiChu);
                lvwAlarm.Items.Add(lvi);
            }
        }

        //void CheckAlarm()
        //{
        //    lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
        //AlarmBUS almBUS = new AlarmBUS();
        //List<AlarmDTO> ds = almBUS.HienThi();
        //foreach (AlarmDTO item in ds)
        //{
        //    if (item.ThoiGian == DateTime.Now.TimeOfDay)
        //    {
        //        MessageBox.Show("Tới báo thức " + item.Ten + "\n" + item.GhiChu, "Báo thức!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}
        //}
        #endregion Function

        #region Event
        private void Alarm_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlActive.Visible = !pnlActive.Visible;
            btnDel.Enabled = !btnDel.Enabled;
            btnEdit.Enabled = !btnEdit.Enabled;
            if (btnAdd.Text == "Thêm")
                btnAdd.Text = "Xong";
            else
            {
                btnAdd.Text = "Thêm";
                AlarmDTO alm = new AlarmDTO();
                alm.ThoiGian = TimeSpan.Parse(dtpkActiveTime.Value.ToString("HH:mm"));
                alm.Ten = tbxActiveName.Text.Trim();
                alm.GhiChu = tbxActiveNote.Text.Trim();
                AlarmBUS almBUS = new AlarmBUS();
                try
                {
                    bool kt = almBUS.Them(alm);
                    if (kt)
                    {
                        MessageBox.Show("Thêm báo thức mới thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thời gian không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                AlarmDTO alm = new AlarmDTO();
                alm.ThoiGian = TimeSpan.Parse(lvwAlarm.SelectedItems[0].SubItems[0].Text);
                AlarmBUS almBUS = new AlarmBUS();
                DialogResult result = MessageBox.Show("Báo thức này sẽ bị xóa! Bạn chắc chứ?", "Xóa báo thức!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool kt = almBUS.Xoa(alm);
                    if (kt)
                    {
                        MessageBox.Show("Xóa báo thức thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn báo thức để xóa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            pnlActive.Visible = !pnlActive.Visible;
            btnDel.Enabled = !btnDel.Enabled;
            btnAdd.Enabled = !btnAdd.Enabled;
            if (btnEdit.Text == "Sửa")
            {
                try
                {
                    dtpkActiveTime.Text = TimeSpan.Parse(lvwAlarm.SelectedItems[0].SubItems[0].Text).ToString();
                    tbxActiveName.Text = lvwAlarm.SelectedItems[0].SubItems[1].Text;
                    tbxActiveNote.Text = lvwAlarm.SelectedItems[0].SubItems[2].Text;
                    
                    pnlActive.Visible = true;
                    btnDel.Enabled = false;
                    btnAdd.Enabled = false;
                    btnEdit.Text = "Xong";
                }
                catch (Exception)
                {
                    MessageBox.Show("Chọn báo thức để sửa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEdit.Text = "Sửa";
                }
            }
            else
            {
                AlarmDTO alm = new AlarmDTO();
                alm.ThoiGian = TimeSpan.Parse(dtpkActiveTime.Value.ToString("HH:mm"));
                alm.Ten = tbxActiveName.Text.Trim();
                alm.GhiChu = tbxActiveNote.Text.Trim();
                AlarmBUS almBUS = new AlarmBUS();
                TimeSpan ThoiGianTruyen = TimeSpan.Parse(lvwAlarm.SelectedItems[0].SubItems[0].Text);
                try
                {
                    bool kt = almBUS.Sua(alm, ThoiGianTruyen);
                    if (kt)
                    {
                        MessageBox.Show("Sửa báo thức thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thời gian không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pnlActive.Visible = false;
                btnDel.Enabled = true;
                btnAdd.Enabled = true;
                btnEdit.Text = "Sửa";
            }
        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("HH:mm:ss");
            //ThreadStart ts = new ThreadStart(CheckAlarm);
            //Thread thrd = new Thread(ts);
            //thrd.Start();
        }
        #endregion Event
    }
}
