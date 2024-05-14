using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
        }

        #region Function
        private void ShowData()
        {
            EventBUS evtBUS = new EventBUS();
            List<EventDTO> ds = evtBUS.HienThi();
            lvwEvent.Items.Clear();
            foreach (EventDTO item in ds)
            {
                ListViewItem lvi = new ListViewItem(item.Ngay.ToShortDateString());
                lvi.SubItems.Add(item.Ten);
                lvi.SubItems.Add(item.GhiChu);
                lvi.SubItems.Add(item.BatDau.ToString());
                lvi.SubItems.Add(item.KetThuc.ToString());
                lvwEvent.Items.Add(lvi);
            }
        }

        private void ShowData(DateTime DateInput)
        {
            EventBUS evtBUS = new EventBUS();
            List<EventDTO> ds = evtBUS.HienThi(DateInput);
            lvwEvent.Items.Clear();
            foreach (EventDTO item in ds)
            {
                ListViewItem lvi = new ListViewItem(item.Ngay.ToShortDateString());
                lvi.SubItems.Add(item.Ten);
                lvi.SubItems.Add(item.GhiChu);
                lvi.SubItems.Add(item.BatDau.ToString());
                lvi.SubItems.Add(item.KetThuc.ToString());
                lvwEvent.Items.Add(lvi);
            }
        }
        
        private void CheckToday(DateTime dtpkDate)
        {
            if (dtpkDate.Date == DateTime.Today)
                btnShowToday.Enabled = false;
            else
                btnShowToday.Enabled = true;
        }
        #endregion Function

        #region Event
        private void Event_Load(object sender, EventArgs e)
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
                EventDTO evt = new EventDTO();
                evt.Ngay = DateTime.Parse(dtpkActiveDate.Value.ToShortDateString());
                evt.Ten = tbxActiveName.Text.Trim();
                evt.GhiChu = tbxActiveNote.Text.Trim();
                evt.BatDau = TimeSpan.Parse(dtpkActiveStart.Value.ToString("HH:mm"));
                evt.KetThuc = TimeSpan.Parse(dtpkActiveEnd.Value.ToString("HH:mm"));
                EventBUS evtBUS = new EventBUS();
                try
                {
                    bool kt = evtBUS.Them(evt);
                    if (kt)
                    {
                        MessageBox.Show("Thêm sự kiện mới thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                        btnShowAll.Text = "Hiển thị theo ngày";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày + Tên sự kiện không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                EventDTO evt = new EventDTO();
                evt.Ngay = DateTime.Parse(lvwEvent.SelectedItems[0].SubItems[0].Text);
                evt.Ten = lvwEvent.SelectedItems[0].SubItems[1].Text;
                EventBUS evtBUS = new EventBUS();
                DialogResult result = MessageBox.Show("Sự kiện này sẽ bị xóa! Bạn chắc chứ?", "Xóa sự kiện!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool kt = evtBUS.Xoa(evt);
                    if (kt)
                    {
                        MessageBox.Show("Xóa sự kiện thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                        btnShowAll.Text = "Hiển thị theo ngày";
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn sự kiện để xóa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Sửa")
            {
                try
                {
                    dtpkActiveDate.Text = DateTime.Parse(lvwEvent.SelectedItems[0].SubItems[0].Text).ToString();
                    tbxActiveName.Text = lvwEvent.SelectedItems[0].SubItems[1].Text;
                    tbxActiveNote.Text = lvwEvent.SelectedItems[0].SubItems[2].Text;
                    dtpkActiveStart.Text = TimeSpan.Parse(lvwEvent.SelectedItems[0].SubItems[3].Text).ToString();
                    dtpkActiveEnd.Text = TimeSpan.Parse(lvwEvent.SelectedItems[0].SubItems[4].Text).ToString();
                    pnlActive.Visible = true;
                    btnDel.Enabled = false;
                    btnAdd.Enabled = false;
                    btnEdit.Text = "Xong";
                }
                catch (Exception)
                {
                    MessageBox.Show("Chọn sự kiện để sửa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEdit.Text = "Sửa";
                    btnShowAll.Text = "Hiển thị theo ngày";
                }
            }
            else
            {
                EventDTO evt = new EventDTO();
                evt.Ngay = DateTime.Parse(dtpkActiveDate.Value.ToString("MM-dd-yyyy"));
                evt.Ten = tbxActiveName.Text.Trim();
                evt.GhiChu = tbxActiveNote.Text.Trim();
                evt.BatDau = TimeSpan.Parse(dtpkActiveStart.Value.ToString("HH:mm"));
                evt.KetThuc = TimeSpan.Parse(dtpkActiveEnd.Value.ToString("HH:mm"));
                EventBUS evtBUS = new EventBUS();
                DateTime NgayTruyen = DateTime.Parse(lvwEvent.SelectedItems[0].SubItems[0].Text);
                string TenTruyen = lvwEvent.SelectedItems[0].SubItems[1].Text;
                try
                {
                    bool kt = evtBUS.Sua(evt, NgayTruyen, TenTruyen);
                    if (kt)
                    {
                        MessageBox.Show("Sửa sự kiện thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                        btnShowAll.Text = "Hiển thị theo ngày";
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày + Tên sự kiện không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pnlActive.Visible = false;
                btnDel.Enabled = true;
                btnAdd.Enabled = true;
                btnEdit.Text = "Sửa";
            }
        }

        private void dtpkDate_ValueChanged(object sender, EventArgs e)
        {
            ShowData(dtpkDate.Value);
            btnShowAll.Text = "Hiển thị tất cả";
            CheckToday(dtpkDate.Value);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
            ShowData(dtpkDate.Value);
            btnShowAll.Text = "Hiển thị tất cả";
            CheckToday(dtpkDate.Value);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(+1);
            ShowData(dtpkDate.Value);
            btnShowAll.Text = "Hiển thị tất cả";
            CheckToday(dtpkDate.Value);
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            if (btnShowAll.Text == "Hiển thị tất cả")
            {
                ShowData();
                btnShowAll.Text = "Hiển thị theo ngày";
            }
            else
            {
                ShowData(dtpkDate.Value);
                btnShowAll.Text = "Hiển thị tất cả";
            }
            CheckToday(dtpkDate.Value);
        }

        private void btnShowToday_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = DateTime.Today;
            CheckToday(dtpkDate.Value);
        }
        #endregion Event
    }
}
