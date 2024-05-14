
namespace GUI
{
    partial class Another
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Another));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxValue = new System.Windows.Forms.TextBox();
            this.btnDefault = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.cbxColumn = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwAnother = new System.Windows.Forms.ListView();
            this.clnGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnMain = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnExtra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlActive = new System.Windows.Forms.Panel();
            this.dtpkActiveStart = new System.Windows.Forms.DateTimePicker();
            this.dtpkActiveEnd = new System.Windows.Forms.DateTimePicker();
            this.cbxAcitveStatus = new System.Windows.Forms.CheckBox();
            this.tbxActiveTag = new System.Windows.Forms.TextBox();
            this.tbxActiveNote = new System.Windows.Forms.TextBox();
            this.tbxActiveExtra = new System.Windows.Forms.TextBox();
            this.tbxActiveMain = new System.Windows.Forms.TextBox();
            this.tbxActiveName = new System.Windows.Forms.TextBox();
            this.tbxActiveGroup = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbxValue);
            this.panel1.Controls.Add(this.btnDefault);
            this.panel1.Controls.Add(this.btnSort);
            this.panel1.Controls.Add(this.cbxColumn);
            this.panel1.Controls.Add(this.btnFilter);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(13, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1494, 84);
            this.panel1.TabIndex = 3;
            // 
            // tbxValue
            // 
            this.tbxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxValue.Location = new System.Drawing.Point(470, 10);
            this.tbxValue.Name = "tbxValue";
            this.tbxValue.Size = new System.Drawing.Size(200, 23);
            this.tbxValue.TabIndex = 9;
            // 
            // btnDefault
            // 
            this.btnDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDefault.Location = new System.Drawing.Point(20, 10);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(209, 66);
            this.btnDefault.TabIndex = 8;
            this.btnDefault.Text = "Mặc định";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // btnSort
            // 
            this.btnSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSort.Location = new System.Drawing.Point(250, 40);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(200, 35);
            this.btnSort.TabIndex = 7;
            this.btnSort.Text = "Sắp xếp";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_click);
            // 
            // cbxColumn
            // 
            this.cbxColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxColumn.FormattingEnabled = true;
            this.cbxColumn.Items.AddRange(new object[] {
            "Nhóm",
            "Tên",
            "Chính",
            "Thẻ",
            "Bắt đầu",
            "Trạng thái",
            "Kết thúc"});
            this.cbxColumn.Location = new System.Drawing.Point(250, 10);
            this.cbxColumn.Name = "cbxColumn";
            this.cbxColumn.Size = new System.Drawing.Size(200, 24);
            this.cbxColumn.TabIndex = 6;
            this.cbxColumn.Text = "Chọn cột để thao tác";
            // 
            // btnFilter
            // 
            this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.Location = new System.Drawing.Point(470, 40);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(200, 35);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "Lọc";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(1260, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(209, 66);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(1100, 10);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(150, 65);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(940, 10);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(150, 65);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(780, 10);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwAnother
            // 
            this.lvwAnother.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnGroup,
            this.clnName,
            this.clnMain,
            this.clnExtra,
            this.clnNote,
            this.clnTag,
            this.clnStart,
            this.clnCheck,
            this.clnEnd});
            this.lvwAnother.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAnother.GridLines = true;
            this.lvwAnother.HideSelection = false;
            this.lvwAnother.Location = new System.Drawing.Point(12, 21);
            this.lvwAnother.Name = "lvwAnother";
            this.lvwAnother.Size = new System.Drawing.Size(1494, 402);
            this.lvwAnother.TabIndex = 5;
            this.lvwAnother.UseCompatibleStateImageBehavior = false;
            this.lvwAnother.View = System.Windows.Forms.View.Details;
            // 
            // clnGroup
            // 
            this.clnGroup.Text = "Nhóm";
            this.clnGroup.Width = 150;
            // 
            // clnName
            // 
            this.clnName.Text = "Tên";
            this.clnName.Width = 202;
            // 
            // clnMain
            // 
            this.clnMain.Text = "Chính";
            this.clnMain.Width = 210;
            // 
            // clnExtra
            // 
            this.clnExtra.Text = "Phụ";
            this.clnExtra.Width = 185;
            // 
            // clnNote
            // 
            this.clnNote.Text = "Ghi chú";
            this.clnNote.Width = 280;
            // 
            // clnTag
            // 
            this.clnTag.Text = "Thẻ";
            this.clnTag.Width = 145;
            // 
            // clnStart
            // 
            this.clnStart.Text = "Bắt đầu";
            this.clnStart.Width = 125;
            // 
            // clnCheck
            // 
            this.clnCheck.Text = "TT";
            this.clnCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnCheck.Width = 50;
            // 
            // clnEnd
            // 
            this.clnEnd.Text = "Kết thúc";
            this.clnEnd.Width = 125;
            // 
            // pnlActive
            // 
            this.pnlActive.Controls.Add(this.dtpkActiveStart);
            this.pnlActive.Controls.Add(this.dtpkActiveEnd);
            this.pnlActive.Controls.Add(this.cbxAcitveStatus);
            this.pnlActive.Controls.Add(this.tbxActiveTag);
            this.pnlActive.Controls.Add(this.tbxActiveNote);
            this.pnlActive.Controls.Add(this.tbxActiveExtra);
            this.pnlActive.Controls.Add(this.tbxActiveMain);
            this.pnlActive.Controls.Add(this.tbxActiveName);
            this.pnlActive.Controls.Add(this.tbxActiveGroup);
            this.pnlActive.Location = new System.Drawing.Point(12, 372);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(1474, 50);
            this.pnlActive.TabIndex = 6;
            this.pnlActive.Visible = false;
            // 
            // dtpkActiveStart
            // 
            this.dtpkActiveStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkActiveStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkActiveStart.Location = new System.Drawing.Point(1175, 11);
            this.dtpkActiveStart.Name = "dtpkActiveStart";
            this.dtpkActiveStart.Size = new System.Drawing.Size(120, 30);
            this.dtpkActiveStart.TabIndex = 10;
            // 
            // dtpkActiveEnd
            // 
            this.dtpkActiveEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkActiveEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkActiveEnd.Location = new System.Drawing.Point(1353, 11);
            this.dtpkActiveEnd.Name = "dtpkActiveEnd";
            this.dtpkActiveEnd.Size = new System.Drawing.Size(120, 30);
            this.dtpkActiveEnd.TabIndex = 9;
            // 
            // cbxAcitveStatus
            // 
            this.cbxAcitveStatus.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxAcitveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxAcitveStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAcitveStatus.Location = new System.Drawing.Point(1301, 13);
            this.cbxAcitveStatus.Name = "cbxAcitveStatus";
            this.cbxAcitveStatus.Size = new System.Drawing.Size(46, 28);
            this.cbxAcitveStatus.TabIndex = 8;
            this.cbxAcitveStatus.UseVisualStyleBackColor = true;
            // 
            // tbxActiveTag
            // 
            this.tbxActiveTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveTag.Location = new System.Drawing.Point(1031, 13);
            this.tbxActiveTag.Name = "tbxActiveTag";
            this.tbxActiveTag.Size = new System.Drawing.Size(138, 30);
            this.tbxActiveTag.TabIndex = 5;
            // 
            // tbxActiveNote
            // 
            this.tbxActiveNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveNote.Location = new System.Drawing.Point(746, 13);
            this.tbxActiveNote.Name = "tbxActiveNote";
            this.tbxActiveNote.Size = new System.Drawing.Size(279, 30);
            this.tbxActiveNote.TabIndex = 4;
            // 
            // tbxActiveExtra
            // 
            this.tbxActiveExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveExtra.Location = new System.Drawing.Point(560, 13);
            this.tbxActiveExtra.Name = "tbxActiveExtra";
            this.tbxActiveExtra.Size = new System.Drawing.Size(180, 30);
            this.tbxActiveExtra.TabIndex = 3;
            // 
            // tbxActiveMain
            // 
            this.tbxActiveMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveMain.Location = new System.Drawing.Point(351, 13);
            this.tbxActiveMain.Name = "tbxActiveMain";
            this.tbxActiveMain.Size = new System.Drawing.Size(203, 30);
            this.tbxActiveMain.TabIndex = 2;
            // 
            // tbxActiveName
            // 
            this.tbxActiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveName.Location = new System.Drawing.Point(152, 13);
            this.tbxActiveName.Name = "tbxActiveName";
            this.tbxActiveName.Size = new System.Drawing.Size(193, 30);
            this.tbxActiveName.TabIndex = 1;
            // 
            // tbxActiveGroup
            // 
            this.tbxActiveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveGroup.Location = new System.Drawing.Point(3, 13);
            this.tbxActiveGroup.Name = "tbxActiveGroup";
            this.tbxActiveGroup.Size = new System.Drawing.Size(143, 30);
            this.tbxActiveGroup.TabIndex = 0;
            // 
            // Another
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1519, 516);
            this.Controls.Add(this.pnlActive);
            this.Controls.Add(this.lvwAnother);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Another";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khác";
            this.Load += new System.EventHandler(this.Another_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cbxColumn;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDefault;
        private System.Windows.Forms.TextBox tbxValue;
        private System.Windows.Forms.ListView lvwAnother;
        private System.Windows.Forms.ColumnHeader clnGroup;
        private System.Windows.Forms.ColumnHeader clnName;
        private System.Windows.Forms.ColumnHeader clnMain;
        private System.Windows.Forms.ColumnHeader clnExtra;
        private System.Windows.Forms.ColumnHeader clnNote;
        private System.Windows.Forms.ColumnHeader clnTag;
        private System.Windows.Forms.ColumnHeader clnStart;
        private System.Windows.Forms.ColumnHeader clnCheck;
        private System.Windows.Forms.ColumnHeader clnEnd;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.DateTimePicker dtpkActiveStart;
        private System.Windows.Forms.DateTimePicker dtpkActiveEnd;
        private System.Windows.Forms.CheckBox cbxAcitveStatus;
        private System.Windows.Forms.TextBox tbxActiveTag;
        private System.Windows.Forms.TextBox tbxActiveNote;
        private System.Windows.Forms.TextBox tbxActiveExtra;
        private System.Windows.Forms.TextBox tbxActiveMain;
        private System.Windows.Forms.TextBox tbxActiveName;
        private System.Windows.Forms.TextBox tbxActiveGroup;
    }
}