
namespace GUI
{
    partial class TimeTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTable));
            this.lvwTimeTable = new System.Windows.Forms.ListView();
            this.clnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnMon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTues = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnWed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnThur = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnFri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSun = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.tbxActiveName = new System.Windows.Forms.TextBox();
            this.cbxActive1 = new System.Windows.Forms.CheckBox();
            this.cbxActive7 = new System.Windows.Forms.CheckBox();
            this.cbxActive6 = new System.Windows.Forms.CheckBox();
            this.cbxActive3 = new System.Windows.Forms.CheckBox();
            this.cbxActive4 = new System.Windows.Forms.CheckBox();
            this.cbxActive5 = new System.Windows.Forms.CheckBox();
            this.cbxActive2 = new System.Windows.Forms.CheckBox();
            this.dtpkActiveTime = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShow2 = new System.Windows.Forms.Button();
            this.btnShow1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwTimeTable
            // 
            this.lvwTimeTable.BackColor = System.Drawing.SystemColors.Window;
            this.lvwTimeTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnTime,
            this.clnMon,
            this.clnTues,
            this.clnWed,
            this.clnThur,
            this.clnFri,
            this.clnSat,
            this.clnSun});
            this.lvwTimeTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTimeTable.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lvwTimeTable.GridLines = true;
            this.lvwTimeTable.HideSelection = false;
            this.lvwTimeTable.Location = new System.Drawing.Point(8, 10);
            this.lvwTimeTable.Name = "lvwTimeTable";
            this.lvwTimeTable.Size = new System.Drawing.Size(1495, 425);
            this.lvwTimeTable.TabIndex = 0;
            this.lvwTimeTable.UseCompatibleStateImageBehavior = false;
            this.lvwTimeTable.View = System.Windows.Forms.View.Details;
            // 
            // clnTime
            // 
            this.clnTime.Text = "Thời gian";
            this.clnTime.Width = 144;
            // 
            // clnMon
            // 
            this.clnMon.Text = "Thứ hai";
            this.clnMon.Width = 190;
            // 
            // clnTues
            // 
            this.clnTues.Text = "Thứ ba";
            this.clnTues.Width = 190;
            // 
            // clnWed
            // 
            this.clnWed.Text = "Thứ tư";
            this.clnWed.Width = 190;
            // 
            // clnThur
            // 
            this.clnThur.Text = "Thứ năm";
            this.clnThur.Width = 190;
            // 
            // clnFri
            // 
            this.clnFri.Text = "Thứ sáu";
            this.clnFri.Width = 190;
            // 
            // clnSat
            // 
            this.clnSat.Text = "Thứ bảy";
            this.clnSat.Width = 190;
            // 
            // clnSun
            // 
            this.clnSun.Text = "Chủ Nhật";
            this.clnSun.Width = 190;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(630, 445);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 82);
            this.panel1.TabIndex = 1;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(660, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 75);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(431, 7);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(156, 75);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(207, 7);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(156, 75);
            this.btnDel.TabIndex = 1;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(3, 7);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(156, 75);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pnlActive
            // 
            this.pnlActive.Controls.Add(this.tbxActiveName);
            this.pnlActive.Controls.Add(this.cbxActive1);
            this.pnlActive.Controls.Add(this.cbxActive7);
            this.pnlActive.Controls.Add(this.cbxActive6);
            this.pnlActive.Controls.Add(this.cbxActive3);
            this.pnlActive.Controls.Add(this.cbxActive4);
            this.pnlActive.Controls.Add(this.cbxActive5);
            this.pnlActive.Controls.Add(this.cbxActive2);
            this.pnlActive.Controls.Add(this.dtpkActiveTime);
            this.pnlActive.Location = new System.Drawing.Point(8, 343);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(1477, 91);
            this.pnlActive.TabIndex = 2;
            this.pnlActive.Visible = false;
            // 
            // tbxActiveName
            // 
            this.tbxActiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveName.Location = new System.Drawing.Point(235, 23);
            this.tbxActiveName.Name = "tbxActiveName";
            this.tbxActiveName.Size = new System.Drawing.Size(668, 45);
            this.tbxActiveName.TabIndex = 8;
            // 
            // cbxActive1
            // 
            this.cbxActive1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxActive1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive1.Location = new System.Drawing.Point(1357, 8);
            this.cbxActive1.Name = "cbxActive1";
            this.cbxActive1.Size = new System.Drawing.Size(112, 75);
            this.cbxActive1.TabIndex = 7;
            this.cbxActive1.Text = "Chủ nhật";
            this.cbxActive1.UseVisualStyleBackColor = true;
            // 
            // cbxActive7
            // 
            this.cbxActive7.AutoSize = true;
            this.cbxActive7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxActive7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive7.Location = new System.Drawing.Point(1215, 49);
            this.cbxActive7.Name = "cbxActive7";
            this.cbxActive7.Size = new System.Drawing.Size(128, 35);
            this.cbxActive7.TabIndex = 6;
            this.cbxActive7.Text = "Thứ bảy";
            this.cbxActive7.UseVisualStyleBackColor = true;
            // 
            // cbxActive6
            // 
            this.cbxActive6.AutoSize = true;
            this.cbxActive6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxActive6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive6.Location = new System.Drawing.Point(1215, 8);
            this.cbxActive6.Name = "cbxActive6";
            this.cbxActive6.Size = new System.Drawing.Size(128, 35);
            this.cbxActive6.TabIndex = 5;
            this.cbxActive6.Text = "Thứ sáu";
            this.cbxActive6.UseVisualStyleBackColor = true;
            // 
            // cbxActive3
            // 
            this.cbxActive3.AutoSize = true;
            this.cbxActive3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxActive3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive3.Location = new System.Drawing.Point(922, 49);
            this.cbxActive3.Name = "cbxActive3";
            this.cbxActive3.Size = new System.Drawing.Size(114, 35);
            this.cbxActive3.TabIndex = 4;
            this.cbxActive3.Text = "Thứ ba";
            this.cbxActive3.UseVisualStyleBackColor = true;
            // 
            // cbxActive4
            // 
            this.cbxActive4.AutoSize = true;
            this.cbxActive4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxActive4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive4.Location = new System.Drawing.Point(1062, 10);
            this.cbxActive4.Name = "cbxActive4";
            this.cbxActive4.Size = new System.Drawing.Size(107, 35);
            this.cbxActive4.TabIndex = 3;
            this.cbxActive4.Text = "Thứ tư";
            this.cbxActive4.UseVisualStyleBackColor = true;
            // 
            // cbxActive5
            // 
            this.cbxActive5.AutoSize = true;
            this.cbxActive5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxActive5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive5.Location = new System.Drawing.Point(1062, 49);
            this.cbxActive5.Name = "cbxActive5";
            this.cbxActive5.Size = new System.Drawing.Size(136, 35);
            this.cbxActive5.TabIndex = 2;
            this.cbxActive5.Text = "Thứ năm";
            this.cbxActive5.UseVisualStyleBackColor = true;
            // 
            // cbxActive2
            // 
            this.cbxActive2.AutoSize = true;
            this.cbxActive2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxActive2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive2.Location = new System.Drawing.Point(922, 10);
            this.cbxActive2.Name = "cbxActive2";
            this.cbxActive2.Size = new System.Drawing.Size(120, 35);
            this.cbxActive2.TabIndex = 1;
            this.cbxActive2.Text = "Thứ hai";
            this.cbxActive2.UseVisualStyleBackColor = true;
            // 
            // dtpkActiveTime
            // 
            this.dtpkActiveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkActiveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkActiveTime.Location = new System.Drawing.Point(5, 23);
            this.dtpkActiveTime.Name = "dtpkActiveTime";
            this.dtpkActiveTime.ShowUpDown = true;
            this.dtpkActiveTime.Size = new System.Drawing.Size(224, 45);
            this.dtpkActiveTime.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShow2);
            this.panel2.Controls.Add(this.btnShow1);
            this.panel2.Location = new System.Drawing.Point(13, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 82);
            this.panel2.TabIndex = 4;
            // 
            // btnShow2
            // 
            this.btnShow2.Enabled = false;
            this.btnShow2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow2.Location = new System.Drawing.Point(315, 7);
            this.btnShow2.Name = "btnShow2";
            this.btnShow2.Size = new System.Drawing.Size(198, 75);
            this.btnShow2.TabIndex = 4;
            this.btnShow2.Text = "Dọc";
            this.btnShow2.UseVisualStyleBackColor = true;
            // 
            // btnShow1
            // 
            this.btnShow1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow1.Location = new System.Drawing.Point(3, 4);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(198, 75);
            this.btnShow1.TabIndex = 3;
            this.btnShow1.Text = "Ngang";
            this.btnShow1.UseVisualStyleBackColor = true;
            this.btnShow1.Click += new System.EventHandler(this.btnShow1_Click);
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 539);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlActive);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwTimeTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TimeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thời khóa biểu";
            this.Load += new System.EventHandler(this.TimeTable_Load);
            this.panel1.ResumeLayout(false);
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwTimeTable;
        private System.Windows.Forms.ColumnHeader clnTime;
        private System.Windows.Forms.ColumnHeader clnMon;
        private System.Windows.Forms.ColumnHeader clnTues;
        private System.Windows.Forms.ColumnHeader clnWed;
        private System.Windows.Forms.ColumnHeader clnThur;
        private System.Windows.Forms.ColumnHeader clnFri;
        private System.Windows.Forms.ColumnHeader clnSat;
        private System.Windows.Forms.ColumnHeader clnSun;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.DateTimePicker dtpkActiveTime;
        private System.Windows.Forms.CheckBox cbxActive1;
        private System.Windows.Forms.CheckBox cbxActive7;
        private System.Windows.Forms.CheckBox cbxActive6;
        private System.Windows.Forms.CheckBox cbxActive3;
        private System.Windows.Forms.CheckBox cbxActive4;
        private System.Windows.Forms.CheckBox cbxActive5;
        private System.Windows.Forms.CheckBox cbxActive2;
        private System.Windows.Forms.TextBox tbxActiveName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnShow1;
        private System.Windows.Forms.Button btnShow2;
    }
}