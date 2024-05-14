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
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }

        #region Function
        private void ShowData(DateTime Ngay)
        {
            try
            {
                DiaryBUS dayBUS = new DiaryBUS();
                DiaryDTO ds = dayBUS.HienThi(Ngay);
                tbxDairy.Text = ds.NhatKy;
                pbxDairy.ImageLocation = ds.Hinh;
            }
            catch (Exception)
            {
                tbxDairy.Text = "";
                pbxDairy.Image = Properties.Resources.DefaultDairy;
            }
        }
        #endregion

        #region Event
        private void Diary_Load(object sender, EventArgs e)
        {
            ShowData(DateTime.Now);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbxDairy.ReadOnly = !tbxDairy.ReadOnly;
            btnPre.Enabled = !btnPre.Enabled;
            btnNext.Enabled = !btnNext.Enabled;
            dtpkDairy.Enabled = !dtpkDairy.Enabled;
            if (btnEdit.Text == "Viết")
                btnEdit.Text = "Xong";
            else
            {
                DiaryDTO day = new DiaryDTO();
                day.Ngay = dtpkDairy.Value;
                day.NhatKy = tbxDairy.Text;
                day.Hinh = "Chưa có";
                DiaryBUS dayBUS = new DiaryBUS();
                try
                {
                    bool kt1 = dayBUS.Them(day, dtpkDairy.Value);
                } catch { }
                //try
                //{
                    bool kt2 = dayBUS.Sua(day, dtpkDairy.Value);
                    if (kt2)
                    {
                        MessageBox.Show("Lưu nhật ký thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData(dtpkDairy.Value);
                    }
                //} catch { }
                btnEdit.Text = "Viết";
            } 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Toàn bộ nhật ký hôm nay sẽ bị xóa sạch! Bạn chắc chứ?", "Làm mới nhật ký!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DiaryDTO day = new DiaryDTO();
                DiaryBUS dayBUS = new DiaryBUS();
                bool kt = dayBUS.Xoa(day, dtpkDairy.Value);
                if (kt)
                {
                    MessageBox.Show("Nhật ký đã được làm mới!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ShowData(dtpkDairy.Value);
                }
                pbxDairy.Image = Properties.Resources.DefaultDairy;
            } 
        }

        private void btnChoosePicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "All File|*.*";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                DiaryDTO day = new DiaryDTO();
                day.Ngay = dtpkDairy.Value;
                day.NhatKy = tbxDairy.Text;
                day.Hinh = "Chưa có";
                DiaryBUS dayBUS = new DiaryBUS();
                try
                {
                    bool kt1 = dayBUS.Them(day, dtpkDairy.Value);
                }
                catch { }
                try
                {
                    day.Hinh = dlg.FileName;
                    bool kt = dayBUS.SuaHinh(day, dtpkDairy.Value);
                    if (kt)
                    {
                        MessageBox.Show("Hình ảnh đã được lưu!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ShowData(dtpkDairy.Value);
                    }
                }
                catch { }
            }
        }

        private void dtpkDairy_ValueChanged(object sender, EventArgs e)
        {
            pbxDairy.Image = Properties.Resources.DefaultDairy;
            ShowData(dtpkDairy.Value);
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            dtpkDairy.Value = dtpkDairy.Value.AddDays(-1);
            pbxDairy.Image = Properties.Resources.DefaultDairy;
            ShowData(dtpkDairy.Value);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            dtpkDairy.Value = dtpkDairy.Value.AddDays(+1);
            pbxDairy.Image = Properties.Resources.DefaultDairy;
            ShowData(dtpkDairy.Value);
        }

        #endregion Event
    }
}
