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
    public partial class TimeTable : Form
    {
        public TimeTable()
        {
            InitializeComponent();
        }

        #region Function
        private void ShowData()
        {
            TimeTableBUS ttbeBUS = new TimeTableBUS();
            List<TimeTableDTO> ds = ttbeBUS.HienThi();
            lvwTimeTable.Items.Clear();
            foreach (TimeTableDTO item in ds)
            {
                ListViewItem lvi = new ListViewItem(item.ThoiGian.ToString());
                lvi.SubItems.Add(item.Thu2);
                lvi.SubItems.Add(item.Thu3);
                lvi.SubItems.Add(item.Thu4);
                lvi.SubItems.Add(item.Thu5);
                lvi.SubItems.Add(item.Thu6);
                lvi.SubItems.Add(item.Thu7);
                lvi.SubItems.Add(item.ChuNhat);
                lvwTimeTable.Items.Add(lvi);
            }
        }

        private void DeleteData(TimeTableDTO ttbe)
        {
            try
            {
                TimeTableBUS ttbeBUS = new TimeTableBUS();
                ttbeBUS.Xoa(ttbe);
            }
            catch (Exception) { }
        }
        #endregion

        #region Event
        private void TimeTable_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnDel.Enabled = !btnDel.Enabled;
            btnEdit.Enabled = !btnEdit.Enabled;
            btnClear.Enabled = !btnClear.Enabled;
            pnlActive.Visible = !pnlActive.Visible;
            if (btnAdd.Text == "Thêm")
                btnAdd.Text = "Xong";
            else
            {
                btnAdd.Text = "Thêm";
                TimeTableDTO ttbe = new TimeTableDTO();
                ttbe.ThoiGian = TimeSpan.Parse(dtpkActiveTime.Value.ToString("HH:mm"));
                ttbe.Thu2 = cbxActive2.Checked == true ? tbxActiveName.Text.Trim() : "";
                ttbe.Thu3 = cbxActive3.Checked == true ? tbxActiveName.Text.Trim() : "";
                ttbe.Thu4 = cbxActive4.Checked == true ? tbxActiveName.Text.Trim() : "";
                ttbe.Thu5 = cbxActive5.Checked == true ? tbxActiveName.Text.Trim() : "";
                ttbe.Thu6 = cbxActive6.Checked == true ? tbxActiveName.Text.Trim() : "";
                ttbe.Thu7 = cbxActive7.Checked == true ? tbxActiveName.Text.Trim() : "";
                ttbe.ChuNhat = cbxActive1.Checked == true ? tbxActiveName.Text.Trim() : "";
                TimeTableBUS ttbeBUS = new TimeTableBUS();
                try
                {
                    bool kt = ttbeBUS.Them(ttbe);
                if (kt)
                {
                    MessageBox.Show("Thêm khóa biểu mới thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData();
                }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thời gian khóa biểu không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                TimeTableDTO ttbe = new TimeTableDTO();
                ttbe.ThoiGian = TimeSpan.Parse(lvwTimeTable.SelectedItems[0].SubItems[0].Text);
                TimeTableBUS ttbeBUS = new TimeTableBUS();
                DialogResult result = MessageBox.Show("Khóa biểu này sẽ bị xóa! Bạn chắc chứ?", "Xóa khóa biểu!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    bool kt = ttbeBUS.Xoa(ttbe);
                    if (kt)
                    {
                        MessageBox.Show("Xóa khóa biểu thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Chọn khóa biểu để xóa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Text == "Sửa")
            {
                try
                {
                    dtpkActiveTime.Text = TimeSpan.Parse(lvwTimeTable.SelectedItems[0].SubItems[0].Text).ToString();
                    cbxActive2.Checked = lvwTimeTable.SelectedItems[0].SubItems[1].Text == "" ? false : true;
                    cbxActive3.Checked = lvwTimeTable.SelectedItems[0].SubItems[2].Text == "" ? false : true;
                    cbxActive4.Checked = lvwTimeTable.SelectedItems[0].SubItems[3].Text == "" ? false : true;
                    cbxActive5.Checked = lvwTimeTable.SelectedItems[0].SubItems[4].Text == "" ? false : true;
                    cbxActive6.Checked = lvwTimeTable.SelectedItems[0].SubItems[5].Text == "" ? false : true;
                    cbxActive7.Checked = lvwTimeTable.SelectedItems[0].SubItems[6].Text == "" ? false : true;
                    cbxActive1.Checked = lvwTimeTable.SelectedItems[0].SubItems[7].Text == "" ? false : true;
                    tbxActiveName.Text = "";
                    pnlActive.Visible = true;
                    btnDel.Enabled = false;
                    btnAdd.Enabled = false;
                    btnEdit.Text = "Xong";
                }
                catch (Exception)
                {
                    MessageBox.Show("Chọn khóa biểu để sửa!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnEdit.Text = "Sửa";
                }
            }
            else
            {
                TimeTableDTO ttbe = new TimeTableDTO();
                ttbe.ThoiGian = TimeSpan.Parse(dtpkActiveTime.Value.ToString("HH:mm"));
                ttbe.Thu2 = cbxActive2.Checked == true ? tbxActiveName.Text.Trim() : lvwTimeTable.SelectedItems[0].SubItems[1].Text;
                ttbe.Thu3 = cbxActive3.Checked == true ? tbxActiveName.Text.Trim() : lvwTimeTable.SelectedItems[0].SubItems[2].Text;
                ttbe.Thu4 = cbxActive4.Checked == true ? tbxActiveName.Text.Trim() : lvwTimeTable.SelectedItems[0].SubItems[3].Text;
                ttbe.Thu5 = cbxActive5.Checked == true ? tbxActiveName.Text.Trim() : lvwTimeTable.SelectedItems[0].SubItems[4].Text;
                ttbe.Thu6 = cbxActive6.Checked == true ? tbxActiveName.Text.Trim() : lvwTimeTable.SelectedItems[0].SubItems[5].Text;
                ttbe.Thu7 = cbxActive7.Checked == true ? tbxActiveName.Text.Trim() : lvwTimeTable.SelectedItems[0].SubItems[6].Text;
                ttbe.ChuNhat = cbxActive1.Checked == true ? tbxActiveName.Text.Trim() : lvwTimeTable.SelectedItems[0].SubItems[7].Text;
                TimeTableBUS ttbeBUS = new TimeTableBUS();
                try
                {
                    TimeSpan ThoiGianTruyen = TimeSpan.Parse(lvwTimeTable.SelectedItems[0].SubItems[0].Text);
                    bool kt = ttbeBUS.Sua(ttbe, ThoiGianTruyen);
                    if (kt)
                    {
                        MessageBox.Show("Cập nhập khóa biểu thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Thời gian khóa biểu không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                pnlActive.Visible = false;
                btnDel.Enabled = true;
                btnAdd.Enabled = true;
                btnEdit.Text = "Sửa";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Toàn bộ khóa biểu sẽ bị xóa! Bạn chắc chứ?", "Làm mới sự kiện!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                TimeTableBUS ttbeBUS = new TimeTableBUS();
                List<TimeTableDTO> ds = ttbeBUS.HienThi();
                foreach (TimeTableDTO item in ds)
                    DeleteData(item);
                ShowData();
                MessageBox.Show("Làm mới khóa biểu thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnShow1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhập!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion Event
    }
}
