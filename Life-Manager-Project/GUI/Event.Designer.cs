
namespace GUI
{
    partial class Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.dtpkActiveEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpkActiveStart = new System.Windows.Forms.DateTimePicker();
            this.tbxActiveNote = new System.Windows.Forms.TextBox();
            this.dtpkActiveDate = new System.Windows.Forms.DateTimePicker();
            this.tbxActiveName = new System.Windows.Forms.TextBox();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.lvwEvent = new System.Windows.Forms.ListView();
            this.clnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTimeStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTimeEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowToday = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlActive);
            this.panel1.Controls.Add(this.dtpkDate);
            this.panel1.Controls.Add(this.lvwEvent);
            this.panel1.Controls.Add(this.btnNext);
            this.panel1.Controls.Add(this.btnPre);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(739, 531);
            this.panel1.TabIndex = 8;
            // 
            // pnlActive
            // 
            this.pnlActive.Controls.Add(this.dtpkActiveEnd);
            this.pnlActive.Controls.Add(this.dtpkActiveStart);
            this.pnlActive.Controls.Add(this.tbxActiveNote);
            this.pnlActive.Controls.Add(this.dtpkActiveDate);
            this.pnlActive.Controls.Add(this.tbxActiveName);
            this.pnlActive.Location = new System.Drawing.Point(5, 447);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(713, 76);
            this.pnlActive.TabIndex = 8;
            this.pnlActive.Visible = false;
            // 
            // dtpkActiveEnd
            // 
            this.dtpkActiveEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkActiveEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkActiveEnd.Location = new System.Drawing.Point(582, 22);
            this.dtpkActiveEnd.Name = "dtpkActiveEnd";
            this.dtpkActiveEnd.ShowUpDown = true;
            this.dtpkActiveEnd.Size = new System.Drawing.Size(130, 29);
            this.dtpkActiveEnd.TabIndex = 4;
            this.dtpkActiveEnd.Value = new System.DateTime(2021, 8, 31, 23, 59, 0, 0);
            // 
            // dtpkActiveStart
            // 
            this.dtpkActiveStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkActiveStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkActiveStart.Location = new System.Drawing.Point(454, 22);
            this.dtpkActiveStart.Name = "dtpkActiveStart";
            this.dtpkActiveStart.ShowUpDown = true;
            this.dtpkActiveStart.Size = new System.Drawing.Size(130, 29);
            this.dtpkActiveStart.TabIndex = 3;
            this.dtpkActiveStart.Value = new System.DateTime(2021, 8, 31, 0, 0, 0, 0);
            // 
            // tbxActiveNote
            // 
            this.tbxActiveNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveNote.Location = new System.Drawing.Point(258, 22);
            this.tbxActiveNote.Multiline = true;
            this.tbxActiveNote.Name = "tbxActiveNote";
            this.tbxActiveNote.Size = new System.Drawing.Size(200, 29);
            this.tbxActiveNote.TabIndex = 2;
            this.tbxActiveNote.Text = "Ghi chú";
            // 
            // dtpkActiveDate
            // 
            this.dtpkActiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkActiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkActiveDate.Location = new System.Drawing.Point(0, 22);
            this.dtpkActiveDate.Name = "dtpkActiveDate";
            this.dtpkActiveDate.Size = new System.Drawing.Size(134, 29);
            this.dtpkActiveDate.TabIndex = 1;
            // 
            // tbxActiveName
            // 
            this.tbxActiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveName.Location = new System.Drawing.Point(133, 22);
            this.tbxActiveName.Name = "tbxActiveName";
            this.tbxActiveName.Size = new System.Drawing.Size(126, 29);
            this.tbxActiveName.TabIndex = 0;
            this.tbxActiveName.Text = "Tên";
            // 
            // dtpkDate
            // 
            this.dtpkDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.CalendarMonthBackground = System.Drawing.SystemColors.ActiveBorder;
            this.dtpkDate.CustomFormat = "dd mm yyyy";
            this.dtpkDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Location = new System.Drawing.Point(69, 12);
            this.dtpkDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(603, 38);
            this.dtpkDate.TabIndex = 7;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // lvwEvent
            // 
            this.lvwEvent.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnDate,
            this.clnName,
            this.clnNote,
            this.clnTimeStart,
            this.clnTimeEnd});
            this.lvwEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwEvent.GridLines = true;
            this.lvwEvent.HideSelection = false;
            this.lvwEvent.Location = new System.Drawing.Point(5, 56);
            this.lvwEvent.Name = "lvwEvent";
            this.lvwEvent.Size = new System.Drawing.Size(731, 467);
            this.lvwEvent.TabIndex = 6;
            this.lvwEvent.UseCompatibleStateImageBehavior = false;
            this.lvwEvent.View = System.Windows.Forms.View.Details;
            // 
            // clnDate
            // 
            this.clnDate.Text = "Ngày";
            this.clnDate.Width = 130;
            // 
            // clnName
            // 
            this.clnName.Text = "Tên";
            this.clnName.Width = 125;
            // 
            // clnNote
            // 
            this.clnNote.Text = "Ghi chú";
            this.clnNote.Width = 195;
            // 
            // clnTimeStart
            // 
            this.clnTimeStart.Text = "Bắt đầu";
            this.clnTimeStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnTimeStart.Width = 130;
            // 
            // clnTimeEnd
            // 
            this.clnTimeEnd.Text = "Kết thúc";
            this.clnTimeEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnTimeEnd.Width = 130;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(678, 12);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(58, 38);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.Location = new System.Drawing.Point(5, 12);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(58, 38);
            this.btnPre.TabIndex = 7;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnShowToday);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnShowAll);
            this.panel2.Location = new System.Drawing.Point(758, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 531);
            this.panel2.TabIndex = 9;
            // 
            // btnShowToday
            // 
            this.btnShowToday.Enabled = false;
            this.btnShowToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowToday.Location = new System.Drawing.Point(24, 114);
            this.btnShowToday.Name = "btnShowToday";
            this.btnShowToday.Size = new System.Drawing.Size(158, 82);
            this.btnShowToday.TabIndex = 12;
            this.btnShowToday.Text = "Hiển thị hôm nay";
            this.btnShowToday.UseVisualStyleBackColor = true;
            this.btnShowToday.Click += new System.EventHandler(this.btnShowToday_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(24, 430);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(158, 69);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(24, 330);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(158, 69);
            this.btnDel.TabIndex = 10;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(24, 230);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(158, 69);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(24, 15);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(158, 82);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Hiển thị theo ngày";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 547);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Event";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sự kiện";
            this.Load += new System.EventHandler(this.Event_Load);
            this.panel1.ResumeLayout(false);
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvwEvent;
        private System.Windows.Forms.ColumnHeader clnDate;
        private System.Windows.Forms.ColumnHeader clnName;
        private System.Windows.Forms.ColumnHeader clnNote;
        private System.Windows.Forms.ColumnHeader clnTimeStart;
        private System.Windows.Forms.ColumnHeader clnTimeEnd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.TextBox tbxActiveName;
        private System.Windows.Forms.TextBox tbxActiveNote;
        private System.Windows.Forms.DateTimePicker dtpkActiveDate;
        private System.Windows.Forms.DateTimePicker dtpkActiveEnd;
        private System.Windows.Forms.DateTimePicker dtpkActiveStart;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.Button btnShowToday;
    }
}