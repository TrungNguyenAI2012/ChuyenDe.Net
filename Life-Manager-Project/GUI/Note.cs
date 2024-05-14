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
    public partial class Note : Form
    {
        public Note()
        {
            InitializeComponent();
        }

        #region Function
        private void ShowData()
        {
            NoteBUS nteBUS = new NoteBUS();
            List<NoteDTO> ds = nteBUS.HienThi();
            cbxName.Items.Clear();
            foreach (NoteDTO item in ds)
            {
                cbxName.Items.Add(item.Ten);
            }
        }

        private void ShowData(string tenTruyen)
        {
            NoteBUS nteBUS = new NoteBUS();
            NoteDTO ds = nteBUS.HienThi(tenTruyen);
            tbxNote.Text = ds.GhiChu;
        }

        private void ShowAll()
        {
            ShowData();
            try
            {
                cbxName.SelectedIndex = 0;
            }
            catch (Exception)
            {
                cbxName.Text = "";
                tbxNote.Text = "";
            }
            ShowData(cbxName.Text);
        }
        #endregion Function

        #region Event
        private void Note_Load(object sender, EventArgs e)
        {
            ShowAll();
        }

        private void cbxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowData(cbxName.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            tbxNote.ReadOnly = !tbxNote.ReadOnly;
            btnDel.Enabled = !btnDel.Enabled;
            btnEdit.Enabled = !btnEdit.Enabled;
            tbxName.Visible = !tbxName.Visible;
            
            if (btnAdd.Text == "Thêm")
            {
                btnAdd.Text = "Xong";
                tbxNote.Text = "";
            }
            else
            {
                NoteDTO nte = new NoteDTO();
                nte.Ten = tbxName.Text;
                nte.GhiChu = tbxNote.Text;
                NoteBUS nteBUS = new NoteBUS();
                try
                {
                    bool kt = nteBUS.Them(nte);
                    if (kt)
                        MessageBox.Show("Thêm ghi chú mới thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tên ghi chú không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ShowAll();
                btnAdd.Text = "Thêm";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            NoteDTO nte = new NoteDTO();
            nte.Ten = cbxName.Text;
            NoteBUS nteBUS = new NoteBUS();
            DialogResult result = MessageBox.Show("Ghi chú này sẽ bị xóa vĩnh viễn! Bạn chắc chứ?", "Xóa ghi chú!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                nteBUS.Xoa(nte);
                cbxName.Items.Remove(cbxName.SelectedItem);
                MessageBox.Show("Xóa ghi chú thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowData();
                try
                {
                    cbxName.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    cbxName.Text = "";
                    tbxNote.Text = "";
                }
                ShowAll();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            tbxNote.ReadOnly = !tbxNote.ReadOnly;
            btnDel.Enabled = !btnDel.Enabled;
            btnAdd.Enabled = !btnAdd.Enabled;
            cbxName.Enabled = !cbxName.Enabled;
            if (btnEdit.Text == "Sửa")
                btnEdit.Text = "Xong";
            else
            {
                NoteDTO nte = new NoteDTO();
                nte.Ten = tbxName.Text;
                nte.GhiChu = tbxNote.Text;
                NoteBUS nteBUS = new NoteBUS();
                try
                {
                    bool kt = nteBUS.Sua(nte, cbxName.Text);
                    if (kt)
                        MessageBox.Show("Sửa ghi chú thành công!", "Thành công!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tên ghi chú không được để trùng!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ShowAll();
                btnEdit.Text = "Sửa";
            }
        }
        #endregion Event
    }
}
