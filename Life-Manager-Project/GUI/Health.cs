using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS;
using DTO;

namespace GUI
{
    public partial class Health : Form
    {
        public Health()
        {
            InitializeComponent();
        }

        #region Function
        private void ShowData()
        {
            HealthBUS hthBUS = new HealthBUS();
            List<HealthDTO> ds = hthBUS.HienThi();
            lvwHealth.Items.Clear();
            foreach (HealthDTO item in ds)
            {
                ListViewItem lvi = new ListViewItem(item.Ngay.ToShortDateString());
                lvi.SubItems.Add(item.Ten);
                lvi.SubItems.Add(item.TrieuChung);
                lvi.SubItems.Add(item.UongThuoc.ToString());
                lvi.SubItems.Add(item.SoLieu.ToString());
                lvi.SubItems.Add(item.DaUong.ToString());
                lvwHealth.Items.Add(lvi);
            }
        }

        private void ShowData(DateTime Ngay)
        {
            try
            {
                HealthBUS hthBUS = new HealthBUS();
                HealthDTO ds = hthBUS.HienThi(Ngay);
                tbxWeight.Text = ds.CanNang.ToString();
                tbxHeight.Text = ds.ChieuCao.ToString();
                tbxFeeling.Text = ds.CamGiac;
            }
            catch (Exception)
            {
                tbxWeight.Text = "";
                tbxHeight.Text = "";
                tbxFeeling.Text = "";
            }
        }
        
        private void DeleteData(HealthDTO hth)
        {
            try
            {
                HealthBUS hthBUS = new HealthBUS();
                hthBUS.Xoa(hth);
            } catch (Exception) { }
        }
        #endregion

        #region Event
        private void Health_Load(object sender, EventArgs e)
        {
            ShowData();
            ShowData(dtpkDate.Value);
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
                HealthDTO hth = new HealthDTO();
                hth.Ngay = DateTime.Parse(dtpkActiveDate.Value.ToShortDateString());
                hth.Ten = tbxActiveName.Text.Trim();
                hth.TrieuChung = tbxActiveSymptom.Text.Trim();
                hth.UongThuoc = cbxActiveDrug.Checked;
                hth.SoLieu = Int32.Parse(nudwTimes.Value.ToString());
                hth.DaUong = Int32.Parse(nudnUsed.Value.ToString());
                HealthBUS hthBUS = new HealthBUS();
                bool kt = hthBUS.Them(hth);
                if (kt)
                {
                    MessageBox.Show("Thêm bệnh án mới thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                HealthDTO hth = new HealthDTO();
                hth.Ngay = DateTime.Parse(lvwHealth.SelectedItems[0].SubItems[0].Text);
                hth.Ten = lvwHealth.SelectedItems[0].SubItems[1].Text;
                hth.TrieuChung = lvwHealth.SelectedItems[0].SubItems[2].Text;
                hth.UongThuoc = Boolean.Parse(lvwHealth.SelectedItems[0].SubItems[3].Text);
                hth.SoLieu = Int32.Parse(lvwHealth.SelectedItems[0].SubItems[4].Text);
                hth.DaUong = Int32.Parse(lvwHealth.SelectedItems[0].SubItems[5].Text);
                HealthBUS hthBUS = new HealthBUS();
                DialogResult result = MessageBox.Show("Bệnh án này sẽ bị xóa! Bạn chắc chứ?", "Xóa bệnh án!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool kt = hthBUS.Xoa(hth);
                    if (kt)
                    {
                        MessageBox.Show("Xóa bệnh án thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn bệnh án để xóa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Sửa")
            {
                try
                {
                    dtpkActiveDate.Text = DateTime.Parse(lvwHealth.SelectedItems[0].SubItems[0].Text).ToString();
                    tbxActiveName.Text = lvwHealth.SelectedItems[0].SubItems[1].Text;
                    tbxActiveSymptom.Text = lvwHealth.SelectedItems[0].SubItems[2].Text;
                    cbxActiveDrug.Checked = Boolean.Parse(lvwHealth.SelectedItems[0].SubItems[3].Text);
                    nudwTimes.Text = Int32.Parse(lvwHealth.SelectedItems[0].SubItems[4].Text).ToString();
                    nudnUsed.Text = Int32.Parse(lvwHealth.SelectedItems[0].SubItems[5].Text).ToString();
                    pnlActive.Visible = true;
                    btnDel.Enabled = false;
                    btnAdd.Enabled = false;
                    btnEdit.Text = "Xong";
                }
                catch (Exception)
                {
                    MessageBox.Show("Chọn bệnh án để sửa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEdit.Text = "Sửa";
                }
            }
            else
            {
                HealthDTO hth = new HealthDTO();
                hth.Ngay = DateTime.Parse(dtpkActiveDate.Value.ToString("MM-dd-yyyy"));
                hth.Ten = tbxActiveName.Text.Trim();
                hth.TrieuChung = tbxActiveSymptom.Text.Trim();
                hth.UongThuoc = Boolean.Parse(cbxActiveDrug.Checked.ToString());
                hth.SoLieu = Int32.Parse(nudwTimes.Value.ToString());
                hth.DaUong = Int32.Parse(nudnUsed.Value.ToString());
                HealthBUS hthBUS = new HealthBUS();
                DateTime NgayTruyen = DateTime.Parse(lvwHealth.SelectedItems[0].SubItems[0].Text);
                string TenTruyen = lvwHealth.SelectedItems[0].SubItems[1].Text;
                string TrieuChungTruyen = lvwHealth.SelectedItems[0].SubItems[2].Text;
                bool UongThuocTruyen = Boolean.Parse(lvwHealth.SelectedItems[0].SubItems[3].Text);
                int SoLieuTruyen = Int32.Parse(lvwHealth.SelectedItems[0].SubItems[4].Text);
                int DaUongTruyen = Int32.Parse(lvwHealth.SelectedItems[0].SubItems[5].Text);
                bool kt = hthBUS.Sua(hth, NgayTruyen, TenTruyen, TrieuChungTruyen, UongThuocTruyen, SoLieuTruyen, DaUongTruyen);
                    if (kt)
                    {
                        MessageBox.Show("Cập nhập bệnh án thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
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
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(-1);
            ShowData(dtpkDate.Value);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDate.Value = dtpkDate.Value.AddDays(+1);
            ShowData(dtpkDate.Value);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            tbxHeight.ReadOnly = !tbxHeight.ReadOnly;
            tbxWeight.ReadOnly = !tbxWeight.ReadOnly;
            tbxFeeling.ReadOnly = !tbxFeeling.ReadOnly;
            dtpkDate.Enabled = !dtpkDate.Enabled;
            btnPre.Enabled = !btnPre.Enabled;
            btnNext.Enabled = !btnNext.Enabled;
            if (btnUpdate.Text == "Cập nhập")
                btnUpdate.Text = "Xong";
            else
            {
                HealthDTO hth = new HealthDTO();
                hth.Ngay = dtpkDate.Value;
                hth.CanNang = Int32.Parse(tbxWeight.Text);
                hth.ChieuCao = Int32.Parse(tbxHeight.Text);
                hth.CamGiac = tbxFeeling.Text;
                HealthBUS hthBUS = new HealthBUS();
                try
                {
                    bool kt1 = hthBUS.Them(hth, dtpkDate.Value);
                } catch { }
                try
                {
                    bool kt2 = hthBUS.Sua(hth, dtpkDate.Value);
                    if (kt2)
                    {
                        MessageBox.Show("Cập nhập cải thiện thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData(dtpkDate.Value);
                    }
                } catch { }
                btnUpdate.Text = "Cập nhập";
            }
        }

        private void btnTomorrow_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Cải thiện sẽ giống hôm qua! Bạn chắc chứ?", "Cập nhập cải thiện!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                HealthDTO hthCu = new HealthDTO();
                HealthBUS hthBUS = new HealthBUS();
                hthCu = hthBUS.HienThi(dtpkDate.Value.AddDays(-1));
                HealthDTO hth = new HealthDTO();
                hth.Ngay = dtpkDate.Value;
                hth.CanNang = hthCu.CanNang;
                hth.ChieuCao = hthCu.ChieuCao;
                hth.CamGiac = hthCu.CamGiac;
                try
                {
                    bool kt1 = hthBUS.Them(hth, dtpkDate.Value);
                }
                catch { }
                try
                {
                    bool kt2 = hthBUS.Sua(hth, dtpkDate.Value);
                    if (kt2)
                    {
                        MessageBox.Show("Cập nhập cải thiện thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData(dtpkDate.Value);
                    }
                }
                catch { MessageBox.Show("Bạn chưa cập nhập hôm qua!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Toàn bộ bệnh án sẽ bị xóa! Bạn chắc chứ?", "Làm mới sự kiện!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                HealthBUS hthBUS = new HealthBUS();
                List<HealthDTO> ds = hthBUS.HienThi();
                foreach (HealthDTO item in ds)
                    DeleteData(item);
                ShowData();
                MessageBox.Show("Làm mới bệnh án thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion Event
    }
}