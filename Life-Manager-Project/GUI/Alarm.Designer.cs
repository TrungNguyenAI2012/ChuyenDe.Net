
namespace GUI
{
    partial class Alarm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Alarm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvwAlarm = new System.Windows.Forms.ListView();
            this.clnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.cbxActive5 = new System.Windows.Forms.CheckBox();
            this.cbxActive7 = new System.Windows.Forms.CheckBox();
            this.cbxActive1 = new System.Windows.Forms.CheckBox();
            this.cbxActive6 = new System.Windows.Forms.CheckBox();
            this.cbxActive4 = new System.Windows.Forms.CheckBox();
            this.cbxActive3 = new System.Windows.Forms.CheckBox();
            this.cbxActive2 = new System.Windows.Forms.CheckBox();
            this.tbxActiveNote = new System.Windows.Forms.TextBox();
            this.tbxActiveName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpkActiveTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTimeAlarm = new System.Windows.Forms.Label();
            this.lblNoteAlarm = new System.Windows.Forms.Label();
            this.lblNameAlarm = new System.Windows.Forms.Label();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tblNotification = new System.Windows.Forms.Label();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlActive.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lvwAlarm);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 524);
            this.panel1.TabIndex = 0;
            // 
            // lvwAlarm
            // 
            this.lvwAlarm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnTime,
            this.clnName,
            this.clnNote});
            this.lvwAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAlarm.GridLines = true;
            this.lvwAlarm.HideSelection = false;
            this.lvwAlarm.Location = new System.Drawing.Point(2, 3);
            this.lvwAlarm.Name = "lvwAlarm";
            this.lvwAlarm.Size = new System.Drawing.Size(873, 519);
            this.lvwAlarm.TabIndex = 7;
            this.lvwAlarm.UseCompatibleStateImageBehavior = false;
            this.lvwAlarm.View = System.Windows.Forms.View.Details;
            // 
            // clnTime
            // 
            this.clnTime.Text = "Thời gian";
            this.clnTime.Width = 200;
            // 
            // clnName
            // 
            this.clnName.Text = "Tên";
            this.clnName.Width = 250;
            // 
            // clnNote
            // 
            this.clnNote.Text = "Ghi chú";
            this.clnNote.Width = 402;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(327, 273);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(324, 175);
            this.lblName.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.pnlActive);
            this.panel2.Controls.Add(this.lblTimeAlarm);
            this.panel2.Controls.Add(this.lblNoteAlarm);
            this.panel2.Controls.Add(this.lblNameAlarm);
            this.panel2.Controls.Add(this.lblTimeLeft);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.tblNotification);
            this.panel2.Location = new System.Drawing.Point(895, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 524);
            this.panel2.TabIndex = 1;
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Black;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(5, 2);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(329, 82);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "00:00:00";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlActive
            // 
            this.pnlActive.Controls.Add(this.cbxActive5);
            this.pnlActive.Controls.Add(this.cbxActive7);
            this.pnlActive.Controls.Add(this.cbxActive1);
            this.pnlActive.Controls.Add(this.cbxActive6);
            this.pnlActive.Controls.Add(this.cbxActive4);
            this.pnlActive.Controls.Add(this.cbxActive3);
            this.pnlActive.Controls.Add(this.cbxActive2);
            this.pnlActive.Controls.Add(this.tbxActiveNote);
            this.pnlActive.Controls.Add(this.tbxActiveName);
            this.pnlActive.Controls.Add(this.label3);
            this.pnlActive.Controls.Add(this.label2);
            this.pnlActive.Controls.Add(this.dtpkActiveTime);
            this.pnlActive.Controls.Add(this.label1);
            this.pnlActive.Location = new System.Drawing.Point(5, 87);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(335, 337);
            this.pnlActive.TabIndex = 10;
            this.pnlActive.Visible = false;
            // 
            // cbxActive5
            // 
            this.cbxActive5.AutoSize = true;
            this.cbxActive5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive5.Location = new System.Drawing.Point(91, 155);
            this.cbxActive5.Name = "cbxActive5";
            this.cbxActive5.Size = new System.Drawing.Size(82, 29);
            this.cbxActive5.TabIndex = 12;
            this.cbxActive5.Text = "Thứ 5";
            this.cbxActive5.UseVisualStyleBackColor = true;
            // 
            // cbxActive7
            // 
            this.cbxActive7.AutoSize = true;
            this.cbxActive7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive7.Location = new System.Drawing.Point(179, 155);
            this.cbxActive7.Name = "cbxActive7";
            this.cbxActive7.Size = new System.Drawing.Size(82, 29);
            this.cbxActive7.TabIndex = 11;
            this.cbxActive7.Text = "Thứ 7";
            this.cbxActive7.UseVisualStyleBackColor = true;
            // 
            // cbxActive1
            // 
            this.cbxActive1.AllowDrop = true;
            this.cbxActive1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive1.Location = new System.Drawing.Point(263, 128);
            this.cbxActive1.Name = "cbxActive1";
            this.cbxActive1.Size = new System.Drawing.Size(74, 56);
            this.cbxActive1.TabIndex = 10;
            this.cbxActive1.Text = "Chủ Nhật";
            this.cbxActive1.UseVisualStyleBackColor = true;
            // 
            // cbxActive6
            // 
            this.cbxActive6.AutoSize = true;
            this.cbxActive6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive6.Location = new System.Drawing.Point(179, 128);
            this.cbxActive6.Name = "cbxActive6";
            this.cbxActive6.Size = new System.Drawing.Size(82, 29);
            this.cbxActive6.TabIndex = 9;
            this.cbxActive6.Text = "Thứ 6";
            this.cbxActive6.UseVisualStyleBackColor = true;
            // 
            // cbxActive4
            // 
            this.cbxActive4.AutoSize = true;
            this.cbxActive4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive4.Location = new System.Drawing.Point(91, 128);
            this.cbxActive4.Name = "cbxActive4";
            this.cbxActive4.Size = new System.Drawing.Size(82, 29);
            this.cbxActive4.TabIndex = 8;
            this.cbxActive4.Text = "Thứ 4";
            this.cbxActive4.UseVisualStyleBackColor = true;
            // 
            // cbxActive3
            // 
            this.cbxActive3.AutoSize = true;
            this.cbxActive3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive3.Location = new System.Drawing.Point(3, 155);
            this.cbxActive3.Name = "cbxActive3";
            this.cbxActive3.Size = new System.Drawing.Size(82, 29);
            this.cbxActive3.TabIndex = 7;
            this.cbxActive3.Text = "Thứ 3";
            this.cbxActive3.UseVisualStyleBackColor = true;
            // 
            // cbxActive2
            // 
            this.cbxActive2.AutoSize = true;
            this.cbxActive2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive2.Location = new System.Drawing.Point(3, 128);
            this.cbxActive2.Name = "cbxActive2";
            this.cbxActive2.Size = new System.Drawing.Size(82, 29);
            this.cbxActive2.TabIndex = 6;
            this.cbxActive2.Text = "Thứ 2";
            this.cbxActive2.UseVisualStyleBackColor = true;
            // 
            // tbxActiveNote
            // 
            this.tbxActiveNote.AllowDrop = true;
            this.tbxActiveNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveNote.Location = new System.Drawing.Point(3, 217);
            this.tbxActiveNote.Multiline = true;
            this.tbxActiveNote.Name = "tbxActiveNote";
            this.tbxActiveNote.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbxActiveNote.Size = new System.Drawing.Size(327, 117);
            this.tbxActiveNote.TabIndex = 5;
            this.tbxActiveNote.Text = "Ghi chú về báo thức";
            // 
            // tbxActiveName
            // 
            this.tbxActiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveName.Location = new System.Drawing.Point(3, 78);
            this.tbxActiveName.Name = "tbxActiveName";
            this.tbxActiveName.Size = new System.Drawing.Size(326, 38);
            this.tbxActiveName.TabIndex = 4;
            this.tbxActiveName.Text = "Báo thức";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ghi chú:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên:";
            // 
            // dtpkActiveTime
            // 
            this.dtpkActiveTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkActiveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkActiveTime.Location = new System.Drawing.Point(144, 7);
            this.dtpkActiveTime.Name = "dtpkActiveTime";
            this.dtpkActiveTime.ShowUpDown = true;
            this.dtpkActiveTime.Size = new System.Drawing.Size(185, 38);
            this.dtpkActiveTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thời gian:";
            // 
            // lblTimeAlarm
            // 
            this.lblTimeAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeAlarm.Location = new System.Drawing.Point(120, 80);
            this.lblTimeAlarm.Name = "lblTimeAlarm";
            this.lblTimeAlarm.Size = new System.Drawing.Size(215, 64);
            this.lblTimeAlarm.TabIndex = 12;
            this.lblTimeAlarm.Text = "00 : 00";
            // 
            // lblNoteAlarm
            // 
            this.lblNoteAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteAlarm.Location = new System.Drawing.Point(3, 281);
            this.lblNoteAlarm.Name = "lblNoteAlarm";
            this.lblNoteAlarm.Size = new System.Drawing.Size(326, 140);
            this.lblNoteAlarm.TabIndex = 11;
            this.lblNoteAlarm.Text = "Ghi chú về báo thức";
            // 
            // lblNameAlarm
            // 
            this.lblNameAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameAlarm.Location = new System.Drawing.Point(3, 215);
            this.lblNameAlarm.Name = "lblNameAlarm";
            this.lblNameAlarm.Size = new System.Drawing.Size(326, 64);
            this.lblNameAlarm.TabIndex = 10;
            this.lblNameAlarm.Text = "Báo thức";
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeLeft.Location = new System.Drawing.Point(99, 219);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(202, 62);
            this.lblTimeLeft.TabIndex = 9;
            this.lblTimeLeft.Text = "00:00";
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(120, 430);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 91);
            this.btnDel.TabIndex = 4;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(235, 430);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 91);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(5, 430);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 91);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tblNotification
            // 
            this.tblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 37F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblNotification.Location = new System.Drawing.Point(5, 80);
            this.tblNotification.Name = "tblNotification";
            this.tblNotification.Size = new System.Drawing.Size(325, 120);
            this.tblNotification.TabIndex = 1;
            this.tblNotification.Text = "Còn          phút nữa đến";
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1;
            this.tmrTime.Tick += new System.EventHandler(this.tmrTime_Tick);
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Alarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo thức";
            this.Load += new System.EventHandler(this.Alarm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label tblNotification;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Label lblNoteAlarm;
        private System.Windows.Forms.Label lblNameAlarm;
        private System.Windows.Forms.Label lblTimeAlarm;
        private System.Windows.Forms.Timer tmrTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.ListView lvwAlarm;
        private System.Windows.Forms.ColumnHeader clnTime;
        private System.Windows.Forms.ColumnHeader clnName;
        private System.Windows.Forms.ColumnHeader clnNote;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.CheckBox cbxActive5;
        private System.Windows.Forms.CheckBox cbxActive7;
        private System.Windows.Forms.CheckBox cbxActive1;
        private System.Windows.Forms.CheckBox cbxActive6;
        private System.Windows.Forms.CheckBox cbxActive4;
        private System.Windows.Forms.CheckBox cbxActive3;
        private System.Windows.Forms.CheckBox cbxActive2;
        private System.Windows.Forms.TextBox tbxActiveNote;
        private System.Windows.Forms.TextBox tbxActiveName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpkActiveTime;
        private System.Windows.Forms.Label label1;
    }
}