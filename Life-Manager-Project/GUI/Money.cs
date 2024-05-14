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
    public partial class Money : Form
    {
        public Money()
        {
            InitializeComponent();
        }

        #region Function
        private void ShowData()
        {
            btnShowAll.Enabled = false;
            btnDay.Enabled = true;
            MoneyBUS mnyBUS = new MoneyBUS();
            List<MoneyDTO> ds = mnyBUS.HienThi();
            lvwMoney.Items.Clear();
            int Thu = 0, Chi = 0, Tong;
            foreach (MoneyDTO item in ds)
            {
                ListViewItem lvi = new ListViewItem(item.Ngay.ToShortDateString());
                lvi.SubItems.Add(item.ThoiGian.ToString());
                lvi.SubItems.Add(item.Ten);
                lvi.SubItems.Add(item.ThuChi);
                lvi.SubItems.Add(item.GiaTien.ToString());
                lvi.SubItems.Add(item.Nhom);
                lvi.SubItems.Add(item.Vi);
                lvi.SubItems.Add(item.Voi);
                lvi.SubItems.Add(item.GhiChu);
                lvwMoney.Items.Add(lvi);
                if (item.ThuChi == "Thu")
                    Thu += Int32.Parse(item.GiaTien);
                else
                    Chi += Int32.Parse(item.GiaTien);
            }
            lblIn.Text = Thu.ToString();
            lblOut.Text = Chi.ToString();
            Tong = Thu - Chi;
            lblInOut.Text = Tong.ToString();
        }

        private void ShowData(DateTime Ngay)
        {
            btnShowAll.Enabled = true;
            MoneyBUS mnyBUS = new MoneyBUS();
            List<MoneyDTO> ds = mnyBUS.HienThi(Ngay);
            lvwMoney.Items.Clear();
            int Thu = 0, Chi = 0, Tong;
            foreach (MoneyDTO item in ds)
            {
                ListViewItem lvi = new ListViewItem(item.Ngay.ToShortDateString());
                lvi.SubItems.Add(item.ThoiGian.ToString());
                lvi.SubItems.Add(item.Ten);
                lvi.SubItems.Add(item.ThuChi);
                lvi.SubItems.Add(item.GiaTien.ToString());
                lvi.SubItems.Add(item.Nhom);
                lvi.SubItems.Add(item.Vi);
                lvi.SubItems.Add(item.Voi);
                lvi.SubItems.Add(item.GhiChu);
                lvwMoney.Items.Add(lvi);
                if (item.ThuChi == "Thu")
                    Thu += Int32.Parse(item.GiaTien);
                else
                    Chi += Int32.Parse(item.GiaTien);
            }
            lblIn.Text = Thu.ToString();
            lblIn.Text = Chi.ToString();
            Tong = Thu - Chi;
            lblInOut.Text = Tong.ToString();
        }

        private void DeleteData(MoneyDTO mny)
        {
            try
            {
                MoneyBUS mnyBUS = new MoneyBUS();
                mnyBUS.Xoa(mny);
            }
            catch (Exception) { }
        }
        #endregion Function

        #region Event
        private void Money_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlActive.Visible = !pnlActive.Visible;
            btnDel.Enabled = !btnDel.Enabled;
            btnEdit.Enabled = !btnEdit.Enabled;
            btnClear.Enabled = !btnClear.Enabled;
            if (btnAdd.Text == "Thêm")
                btnAdd.Text = "Xong";
            else
            {
                btnAdd.Text = "Thêm";
                MoneyDTO mny = new MoneyDTO();
                mny.Ngay = DateTime.Parse(dtpkActiveDate.Value.ToShortDateString());
                mny.ThoiGian = TimeSpan.Parse(dtpkActiveTime.Value.ToString("HH:mm"));
                mny.Ten = tbxActiveName.Text.Trim();
                mny.ThuChi = cbxActiveInOut.Text.Trim();
                mny.GiaTien = nudwActivePrice.Value.ToString();
                mny.Nhom = tbxActiveGroup.Text.Trim();
                mny.Vi = tbxActiveWallet.Text.Trim();
                mny.Voi = tbxActiveWith.Text.Trim();
                mny.GhiChu = tbxActiveNote.Text.Trim();
                MoneyBUS mnyBUS = new MoneyBUS();
                try
                {
                    bool kt = mnyBUS.Them(mny);
                    if (kt)
                    {
                        MessageBox.Show("Thêm giao dịch mới thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày + Thời gian + Tên + Thu chi + Giá tiền không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                MoneyDTO mny = new MoneyDTO();
                mny.Ngay = DateTime.Parse(lvwMoney.SelectedItems[0].SubItems[0].Text);
                mny.ThoiGian = TimeSpan.Parse(lvwMoney.SelectedItems[0].SubItems[1].Text);
                mny.Ten = lvwMoney.SelectedItems[0].SubItems[2].Text;
                MoneyBUS mnyBUS = new MoneyBUS();
                DialogResult result = MessageBox.Show("Sự kiện này sẽ bị xóa! Bạn chắc chứ?", "Xóa sự kiện!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool kt = mnyBUS.Xoa(mny);
                    if (kt)
                    {
                        MessageBox.Show("Xóa sự kiện thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
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
                    dtpkActiveDate.Text = DateTime.Parse(lvwMoney.SelectedItems[0].SubItems[0].Text).ToString();
                    dtpkActiveTime.Text = TimeSpan.Parse(lvwMoney.SelectedItems[0].SubItems[1].Text).ToString();
                    tbxActiveName.Text = lvwMoney.SelectedItems[0].SubItems[2].Text;
                    cbxActiveInOut.Text = lvwMoney.SelectedItems[0].SubItems[3].Text;
                    nudwActivePrice.Text = lvwMoney.SelectedItems[0].SubItems[4].Text;
                    tbxActiveGroup.Text = lvwMoney.SelectedItems[0].SubItems[5].Text;
                    tbxActiveWallet.Text = lvwMoney.SelectedItems[0].SubItems[6].Text;
                    tbxActiveWith.Text = lvwMoney.SelectedItems[0].SubItems[7].Text;
                    tbxActiveNote.Text = lvwMoney.SelectedItems[0].SubItems[8].Text;
                    
                    pnlActive.Visible = true;
                    btnDel.Enabled = false;
                    btnAdd.Enabled = false;
                    btnEdit.Text = "Xong";
                }
                catch (Exception)
                {
                    MessageBox.Show("Chọn sự kiện để sửa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEdit.Text = "Sửa";
                }
            }
            else
            {
                MoneyDTO mny = new MoneyDTO();
                mny.Ngay = DateTime.Parse(dtpkActiveDate.Value.ToShortDateString());
                mny.ThoiGian = TimeSpan.Parse(dtpkActiveTime.Value.ToString("HH:mm"));
                mny.Ten = tbxActiveName.Text.Trim();
                mny.ThuChi = cbxActiveInOut.Text.Trim();
                mny.GiaTien = nudwActivePrice.Value.ToString();
                mny.Nhom = tbxActiveGroup.Text.Trim();
                mny.Vi = tbxActiveWallet.Text.Trim();
                mny.Voi = tbxActiveWith.Text.Trim();
                mny.GhiChu = tbxActiveNote.Text.Trim();
                MoneyBUS mnyBUS = new MoneyBUS();
                DateTime NgayTruyen = DateTime.Parse(lvwMoney.SelectedItems[0].SubItems[0].Text);
                TimeSpan ThoiGianTruyen = TimeSpan.Parse(lvwMoney.SelectedItems[0].SubItems[1].Text);
                string TenTruyen = lvwMoney.SelectedItems[0].SubItems[2].Text;
                try
                {
                    bool kt = mnyBUS.Sua(mny, NgayTruyen, ThoiGianTruyen, TenTruyen);
                    if (kt)
                    {
                        MessageBox.Show("Sửa sự kiện thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Ngày + Thời gian + Tên + Thu chi + Giá tiền không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pnlActive.Visible = false;
                btnDel.Enabled = true;
                btnAdd.Enabled = true;
                btnClear.Enabled = true;
                btnEdit.Text = "Sửa";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Toàn bộ giao dịch sẽ bị xóa! Bạn chắc chứ?", "Làm mới sự kiện!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MoneyBUS mnyBUS = new MoneyBUS();
                List<MoneyDTO> ds = mnyBUS.HienThi();
                foreach (MoneyDTO item in ds)
                    DeleteData(item);
                ShowData();
                MessageBox.Show("Làm mới giao dịch thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            dtpkMoney.Value = dtpkMoney.Value.AddDays(-1);
            ShowData(dtpkMoney.Value);
            btnShowAll.Enabled = true;
            btnDay.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkMoney.Value = dtpkMoney.Value.AddDays(+1);
            ShowData(dtpkMoney.Value);
            btnShowAll.Enabled = true;
            btnDay.Enabled = false;
        }

        private void dtpkMoney_ValueChanged(object sender, EventArgs e)
        {
            ShowData(dtpkMoney.Value);
            btnShowAll.Enabled = true;
            btnDay.Enabled = false;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            ShowData(dtpkMoney.Value);
            btnDay.Enabled = false;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MoneyReport f = new MoneyReport();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
        #endregion Event
    }
}
