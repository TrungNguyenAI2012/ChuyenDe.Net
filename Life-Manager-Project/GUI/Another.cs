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
    public partial class Another : Form
    {
        public Another()
        {
            InitializeComponent();
        }

        #region Function
        private void ShowData()
        {
            AnotherBUS antrBUS = new AnotherBUS();
            List<AnotherDTO> ds = antrBUS.HienThi();
            lvwAnother.Items.Clear();
            foreach (AnotherDTO item in ds)
            {
                ListViewItem lvi = new ListViewItem(item.Nhom.ToString());
                lvi.SubItems.Add(item.Ten);
                lvi.SubItems.Add(item.Chinh);
                lvi.SubItems.Add(item.Phu);
                lvi.SubItems.Add(item.GhiChu);
                lvi.SubItems.Add(item.The);
                lvi.SubItems.Add(item.BatDau.ToShortDateString());
                lvi.SubItems.Add(item.TrangThai.ToString());
                lvi.SubItems.Add(item.KetThuc.ToShortDateString());
                lvwAnother.Items.Add(lvi);
            }
        }

        //private void ShowData(string Truyen)
        //{
        //    try
        //    {
        //        AnotherBUS antrBUS = new AnotherBUS();
        //        List<AnotherDTO> ds = antrBUS.SapXep(Truyen);
        //        lvwAnother.Items.Clear();
        //        foreach (AnotherDTO item in ds)
        //        {
        //            ListViewItem lvi = new ListViewItem(item.Nhom.ToString());
        //            lvi.SubItems.Add(item.Ten);
        //            lvi.SubItems.Add(item.Chinh);
        //            lvi.SubItems.Add(item.Phu);
        //            lvi.SubItems.Add(item.GhiChu);
        //            lvi.SubItems.Add(item.The);
        //            lvi.SubItems.Add(item.BatDau.ToShortDateString());
        //            lvi.SubItems.Add(item.TrangThai.ToString());
        //            lvi.SubItems.Add(item.KetThuc.ToShortDateString());
        //            lvwAnother.Items.Add(lvi);
        //        }
        //    } catch (Exception) { }
        //}

        private void DeleteData(AnotherDTO antr)
        {
            try
            {
                AnotherBUS antrBUS = new AnotherBUS();
                antrBUS.Xoa(antr);
            }
            catch (Exception) { }
        }
        #endregion Function

        #region Event
        private void Another_Load(object sender, EventArgs e)
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
                AnotherDTO antr = new AnotherDTO();
                antr.Nhom = tbxActiveGroup.Text.Trim();
                antr.Ten = tbxActiveName.Text.Trim();
                antr.Chinh = tbxActiveMain.Text.Trim();
                antr.Phu = tbxActiveExtra.Text.Trim();
                antr.GhiChu = tbxActiveNote.Text.Trim();
                antr.The = tbxActiveTag.Text.Trim();
                antr.BatDau = DateTime.Parse(dtpkActiveStart.Value.ToShortDateString());
                antr.TrangThai = cbxAcitveStatus.Checked;
                antr.KetThuc = DateTime.Parse(dtpkActiveEnd.Value.ToShortDateString());
                AnotherBUS antrBUS = new AnotherBUS();
                try
                {
                    bool kt = antrBUS.Them(antr);
                    if (kt)
                    {
                        MessageBox.Show("Thêm quản lý mới thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                    }
                }
                    catch (Exception)
                {
                    MessageBox.Show("Nhóm + Tên + Chính không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                AnotherDTO antr = new AnotherDTO();
                antr.Nhom = lvwAnother.SelectedItems[0].SubItems[0].Text;
                antr.Ten = lvwAnother.SelectedItems[0].SubItems[1].Text;
                antr.Chinh = lvwAnother.SelectedItems[0].SubItems[2].Text;
                AnotherBUS antrBUS = new AnotherBUS();
                DialogResult result = MessageBox.Show("Quản lý này sẽ bị xóa! Bạn chắc chứ?", "Xóa quản lý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool kt = antrBUS.Xoa(antr);
                    if (kt)
                    {
                        MessageBox.Show("Xóa quản lý thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn quản lý để xóa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Sửa")
            {
                try
                {
                    tbxActiveGroup.Text = lvwAnother.SelectedItems[0].SubItems[0].Text;
                    tbxActiveName.Text = lvwAnother.SelectedItems[0].SubItems[1].Text;
                    tbxActiveMain.Text = lvwAnother.SelectedItems[0].SubItems[2].Text;
                    tbxActiveExtra.Text = lvwAnother.SelectedItems[0].SubItems[3].Text;
                    tbxActiveNote.Text = lvwAnother.SelectedItems[0].SubItems[4].Text;
                    tbxActiveTag.Text = lvwAnother.SelectedItems[0].SubItems[5].Text;
                    dtpkActiveStart.Text = DateTime.Parse(lvwAnother.SelectedItems[0].SubItems[6].Text).ToShortDateString();
                    cbxAcitveStatus.Checked = Boolean.Parse(lvwAnother.SelectedItems[0].SubItems[7].Text);
                    dtpkActiveEnd.Text = DateTime.Parse(lvwAnother.SelectedItems[0].SubItems[8].Text).ToShortDateString();

                    pnlActive.Visible = true;
                    btnDel.Enabled = false;
                    btnAdd.Enabled = false;
                    btnClear.Enabled = false;
                    btnEdit.Text = "Xong";
                }
                catch (Exception)
                {
                    MessageBox.Show("Chọn quản lý để sửa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEdit.Text = "Sửa";
                }
            }
            else
            {
                AnotherDTO antr = new AnotherDTO();
                antr.Nhom = tbxActiveGroup.Text.Trim();
                antr.Ten = tbxActiveName.Text.Trim();
                antr.Chinh = tbxActiveMain.Text.Trim();
                antr.Phu = tbxActiveExtra.Text.Trim();
                antr.GhiChu = tbxActiveNote.Text.Trim();
                antr.The = tbxActiveTag.Text.Trim();
                antr.BatDau = DateTime.Parse(dtpkActiveStart.Value.ToShortDateString());
                antr.TrangThai = cbxAcitveStatus.Checked;
                antr.KetThuc = DateTime.Parse(dtpkActiveEnd.Value.ToShortDateString());
                AnotherBUS antrBUS = new AnotherBUS();
                string NhomTruyen = lvwAnother.SelectedItems[0].SubItems[0].Text;
                string TenTruyen = lvwAnother.SelectedItems[0].SubItems[1].Text;
                string ChinhTruyen = lvwAnother.SelectedItems[0].SubItems[2].Text;
                try
                {
                    bool kt = antrBUS.Sua(antr, NhomTruyen, TenTruyen, ChinhTruyen);
                    if (kt)
                    {
                        MessageBox.Show("Sửa quản lý thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhóm + Tên + Chính không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            DialogResult result = MessageBox.Show("Toàn bộ quản lý sẽ bị xóa sạch! Bạn chắc chứ?", "Làm mới quản lý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AnotherBUS antrBUS = new AnotherBUS();
                List<AnotherDTO> ds = antrBUS.HienThi();
                foreach (AnotherDTO item in ds)
                    DeleteData(item);
                ShowData();
                MessageBox.Show("Làm mới quản lý thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void btnDefault_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnSort_click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //private void btnSort_click(object sender, EventArgs e)
        //{
        //    string Truyen = "Nhom";
        //    switch (cbxColumn.Text)
        //    {
        //        case "Nhóm":
        //            Truyen = "Nhom";
        //            break;
        //        case "Tên":
        //            Truyen = "Ten";
        //            break;
        //        case "Chính":
        //            Truyen = "Chinh";
        //            break;
        //        case "Thẻ":
        //            Truyen = "The";
        //            break;
        //        case "Bắt đầu":
        //            Truyen = "BatDau";
        //            break;
        //        case "Trạng thái":
        //            Truyen = "TrangThai";
        //            break;
        //        case "Kết thúc":
        //            Truyen = "KetThuc";
        //            break;
        //    }
        //    ShowData(Truyen);
        //}

        //private void btnFilter_Click(object sender, EventArgs e)
        //{
        //    if (cbxColumn.Text == "Nhóm")
        //        tbxValue.Text = "Lọc theo Nhóm";
        //    if (cbxColumn.Text == "Tên")
        //        tbxValue.Text = "Lọc theo Tên";
        //    if (cbxColumn.Text == "Chính")
        //        tbxValue.Text = "Lọc theo Chính";
        //    if (cbxColumn.Text == "Thẻ")
        //        tbxValue.Text = "Lọc theo Thẻ";
        //    if (cbxColumn.Text == "Bắt đầu")
        //        tbxValue.Text = "Lọc theo Bắt đầu";
        //    if (cbxColumn.Text == "Trạng thái")
        //        tbxValue.Text = "Lọc theo Trạng thái";
        //    if (cbxColumn.Text == "Kết thúc")
        //        tbxValue.Text = "Lọc theo Kết thúc";
        //}
        #endregion Event
    }
}
