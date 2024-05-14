
namespace GUI
{
    partial class Timer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timer));
            this.pnlDown = new System.Windows.Forms.Panel();
            this.nudDownSecond = new System.Windows.Forms.NumericUpDown();
            this.nudDownMinute = new System.Windows.Forms.NumericUpDown();
            this.nudDownHour = new System.Windows.Forms.NumericUpDown();
            this.lblDownTime = new System.Windows.Forms.Label();
            this.pgbTime = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDownEdit = new System.Windows.Forms.Button();
            this.btnDownStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDownPause = new System.Windows.Forms.Button();
            this.btnDownStart = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlUp = new System.Windows.Forms.Panel();
            this.lblUpTimeM = new System.Windows.Forms.Label();
            this.lblUpTime = new System.Windows.Forms.Label();
            this.lstFlag = new System.Windows.Forms.ListView();
            this.clnLap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTimeFlag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTimeTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpResert = new System.Windows.Forms.Button();
            this.btnUpFlag = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpPause = new System.Windows.Forms.Button();
            this.btnUpStart = new System.Windows.Forms.Button();
            this.tmrDown = new System.Windows.Forms.Timer(this.components);
            this.tmrUp = new System.Windows.Forms.Timer(this.components);
            this.pnlDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownHour)).BeginInit();
            this.pnlUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDown
            // 
            this.pnlDown.Controls.Add(this.nudDownSecond);
            this.pnlDown.Controls.Add(this.nudDownMinute);
            this.pnlDown.Controls.Add(this.nudDownHour);
            this.pnlDown.Controls.Add(this.lblDownTime);
            this.pnlDown.Controls.Add(this.pgbTime);
            this.pnlDown.Controls.Add(this.label2);
            this.pnlDown.Controls.Add(this.btnDownEdit);
            this.pnlDown.Controls.Add(this.btnDownStop);
            this.pnlDown.Controls.Add(this.label1);
            this.pnlDown.Controls.Add(this.btnDownPause);
            this.pnlDown.Controls.Add(this.btnDownStart);
            this.pnlDown.Location = new System.Drawing.Point(0, 0);
            this.pnlDown.Margin = new System.Windows.Forms.Padding(2);
            this.pnlDown.Name = "pnlDown";
            this.pnlDown.Size = new System.Drawing.Size(398, 510);
            this.pnlDown.TabIndex = 0;
            // 
            // nudDownSecond
            // 
            this.nudDownSecond.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudDownSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDownSecond.Location = new System.Drawing.Point(257, 63);
            this.nudDownSecond.Margin = new System.Windows.Forms.Padding(2);
            this.nudDownSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudDownSecond.Name = "nudDownSecond";
            this.nudDownSecond.Size = new System.Drawing.Size(102, 98);
            this.nudDownSecond.TabIndex = 108;
            this.nudDownSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDownSecond.Visible = false;
            // 
            // nudDownMinute
            // 
            this.nudDownMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudDownMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDownMinute.Location = new System.Drawing.Point(143, 63);
            this.nudDownMinute.Margin = new System.Windows.Forms.Padding(2);
            this.nudDownMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudDownMinute.Name = "nudDownMinute";
            this.nudDownMinute.Size = new System.Drawing.Size(102, 98);
            this.nudDownMinute.TabIndex = 107;
            this.nudDownMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDownMinute.Visible = false;
            // 
            // nudDownHour
            // 
            this.nudDownHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.nudDownHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDownHour.Location = new System.Drawing.Point(32, 63);
            this.nudDownHour.Margin = new System.Windows.Forms.Padding(2);
            this.nudDownHour.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudDownHour.Name = "nudDownHour";
            this.nudDownHour.Size = new System.Drawing.Size(102, 98);
            this.nudDownHour.TabIndex = 106;
            this.nudDownHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudDownHour.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudDownHour.Visible = false;
            // 
            // lblDownTime
            // 
            this.lblDownTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDownTime.Location = new System.Drawing.Point(10, 54);
            this.lblDownTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDownTime.Name = "lblDownTime";
            this.lblDownTime.Size = new System.Drawing.Size(376, 114);
            this.lblDownTime.TabIndex = 102;
            this.lblDownTime.Text = "10:00:00";
            this.lblDownTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pgbTime
            // 
            this.pgbTime.Location = new System.Drawing.Point(10, 217);
            this.pgbTime.Margin = new System.Windows.Forms.Padding(2);
            this.pgbTime.Maximum = 0;
            this.pgbTime.Name = "pgbTime";
            this.pgbTime.Size = new System.Drawing.Size(376, 99);
            this.pgbTime.Step = 1;
            this.pgbTime.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(394, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bộ đếm giảm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDownEdit
            // 
            this.btnDownEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownEdit.Location = new System.Drawing.Point(229, 421);
            this.btnDownEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownEdit.Name = "btnDownEdit";
            this.btnDownEdit.Size = new System.Drawing.Size(134, 65);
            this.btnDownEdit.TabIndex = 3;
            this.btnDownEdit.Text = "Chỉnh sửa";
            this.btnDownEdit.UseVisualStyleBackColor = true;
            this.btnDownEdit.Click += new System.EventHandler(this.btnDownEdit_Click);
            // 
            // btnDownStop
            // 
            this.btnDownStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownStop.Location = new System.Drawing.Point(34, 421);
            this.btnDownStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownStop.Name = "btnDownStop";
            this.btnDownStop.Size = new System.Drawing.Size(134, 65);
            this.btnDownStop.TabIndex = 2;
            this.btnDownStop.Text = "Dừng lại";
            this.btnDownStop.UseVisualStyleBackColor = true;
            this.btnDownStop.Click += new System.EventHandler(this.btnDownStop_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 180);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiến trình";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDownPause
            // 
            this.btnDownPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownPause.Location = new System.Drawing.Point(229, 330);
            this.btnDownPause.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownPause.Name = "btnDownPause";
            this.btnDownPause.Size = new System.Drawing.Size(134, 65);
            this.btnDownPause.TabIndex = 1;
            this.btnDownPause.Text = "Tạm ngừng";
            this.btnDownPause.UseVisualStyleBackColor = true;
            this.btnDownPause.Click += new System.EventHandler(this.btnDownPause_Click);
            // 
            // btnDownStart
            // 
            this.btnDownStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownStart.Location = new System.Drawing.Point(34, 330);
            this.btnDownStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownStart.Name = "btnDownStart";
            this.btnDownStart.Size = new System.Drawing.Size(134, 65);
            this.btnDownStart.TabIndex = 0;
            this.btnDownStart.Text = "Bắt đầu";
            this.btnDownStart.UseVisualStyleBackColor = true;
            this.btnDownStart.Click += new System.EventHandler(this.btnDownStart_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(806, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 510);
            this.panel2.TabIndex = 1;
            // 
            // pnlUp
            // 
            this.pnlUp.Controls.Add(this.lblUpTimeM);
            this.pnlUp.Controls.Add(this.lblUpTime);
            this.pnlUp.Controls.Add(this.lstFlag);
            this.pnlUp.Controls.Add(this.label3);
            this.pnlUp.Controls.Add(this.btnUpResert);
            this.pnlUp.Controls.Add(this.btnUpFlag);
            this.pnlUp.Controls.Add(this.label4);
            this.pnlUp.Controls.Add(this.btnUpPause);
            this.pnlUp.Controls.Add(this.btnUpStart);
            this.pnlUp.Location = new System.Drawing.Point(412, 0);
            this.pnlUp.Margin = new System.Windows.Forms.Padding(2);
            this.pnlUp.Name = "pnlUp";
            this.pnlUp.Size = new System.Drawing.Size(398, 510);
            this.pnlUp.TabIndex = 101;
            // 
            // lblUpTimeM
            // 
            this.lblUpTimeM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpTimeM.Location = new System.Drawing.Point(10, 155);
            this.lblUpTimeM.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpTimeM.Name = "lblUpTimeM";
            this.lblUpTimeM.Size = new System.Drawing.Size(376, 25);
            this.lblUpTimeM.TabIndex = 102;
            this.lblUpTimeM.Text = "00:00:00";
            this.lblUpTimeM.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpTime
            // 
            this.lblUpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpTime.Location = new System.Drawing.Point(10, 54);
            this.lblUpTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUpTime.Name = "lblUpTime";
            this.lblUpTime.Size = new System.Drawing.Size(376, 114);
            this.lblUpTime.TabIndex = 8;
            this.lblUpTime.Text = "00:00:00";
            this.lblUpTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstFlag
            // 
            this.lstFlag.AllowDrop = true;
            this.lstFlag.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstFlag.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnLap,
            this.clnTimeFlag,
            this.clnTimeTotal});
            this.lstFlag.GridLines = true;
            this.lstFlag.HideSelection = false;
            this.lstFlag.Location = new System.Drawing.Point(10, 217);
            this.lstFlag.Margin = new System.Windows.Forms.Padding(2);
            this.lstFlag.Name = "lstFlag";
            this.lstFlag.Size = new System.Drawing.Size(376, 99);
            this.lstFlag.TabIndex = 108;
            this.lstFlag.UseCompatibleStateImageBehavior = false;
            this.lstFlag.View = System.Windows.Forms.View.Details;
            // 
            // clnLap
            // 
            this.clnLap.Text = "Vòng";
            this.clnLap.Width = 54;
            // 
            // clnTimeFlag
            // 
            this.clnTimeFlag.Text = "Thời gian";
            this.clnTimeFlag.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnTimeFlag.Width = 157;
            // 
            // clnTimeTotal
            // 
            this.clnTimeTotal.Text = "Tổng thời gian";
            this.clnTimeTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clnTimeTotal.Width = 161;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(2, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(394, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bộ đếm tăng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpResert
            // 
            this.btnUpResert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpResert.Location = new System.Drawing.Point(229, 421);
            this.btnUpResert.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpResert.Name = "btnUpResert";
            this.btnUpResert.Size = new System.Drawing.Size(134, 65);
            this.btnUpResert.TabIndex = 8;
            this.btnUpResert.Text = "Đặt lại";
            this.btnUpResert.UseVisualStyleBackColor = true;
            this.btnUpResert.Click += new System.EventHandler(this.btnUpResert_Click);
            // 
            // btnUpFlag
            // 
            this.btnUpFlag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpFlag.Location = new System.Drawing.Point(34, 421);
            this.btnUpFlag.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpFlag.Name = "btnUpFlag";
            this.btnUpFlag.Size = new System.Drawing.Size(134, 65);
            this.btnUpFlag.TabIndex = 7;
            this.btnUpFlag.Text = "Đặt cờ";
            this.btnUpFlag.UseVisualStyleBackColor = true;
            this.btnUpFlag.Click += new System.EventHandler(this.btnUpFlag_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "Bộ đặt cờ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUpPause
            // 
            this.btnUpPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpPause.Location = new System.Drawing.Point(229, 330);
            this.btnUpPause.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpPause.Name = "btnUpPause";
            this.btnUpPause.Size = new System.Drawing.Size(134, 65);
            this.btnUpPause.TabIndex = 6;
            this.btnUpPause.Text = "Tạm ngừng";
            this.btnUpPause.UseVisualStyleBackColor = true;
            this.btnUpPause.Click += new System.EventHandler(this.btnUpPause_Click);
            // 
            // btnUpStart
            // 
            this.btnUpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpStart.Location = new System.Drawing.Point(34, 330);
            this.btnUpStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpStart.Name = "btnUpStart";
            this.btnUpStart.Size = new System.Drawing.Size(134, 65);
            this.btnUpStart.TabIndex = 5;
            this.btnUpStart.Text = "Bắt đầu";
            this.btnUpStart.UseVisualStyleBackColor = true;
            this.btnUpStart.Click += new System.EventHandler(this.btnUpStart_Click);
            // 
            // tmrDown
            // 
            this.tmrDown.Interval = 1000;
            this.tmrDown.Tick += new System.EventHandler(this.tmrDown_Tick);
            // 
            // tmrUp
            // 
            this.tmrUp.Interval = 10;
            this.tmrUp.Tick += new System.EventHandler(this.tmrUp_Tick);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 510);
            this.Controls.Add(this.pnlUp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bộ đếm thời gian";
            this.pnlDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudDownSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDownHour)).EndInit();
            this.pnlUp.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDown;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDownEdit;
        private System.Windows.Forms.Button btnDownStop;
        private System.Windows.Forms.Button btnDownPause;
        private System.Windows.Forms.Button btnDownStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pgbTime;
        private System.Windows.Forms.Panel pnlUp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpResert;
        private System.Windows.Forms.Button btnUpFlag;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpPause;
        private System.Windows.Forms.Button btnUpStart;
        private System.Windows.Forms.ListView lstFlag;
        private System.Windows.Forms.ColumnHeader clnLap;
        private System.Windows.Forms.ColumnHeader clnTimeFlag;
        private System.Windows.Forms.ColumnHeader clnTimeTotal;
        private System.Windows.Forms.Timer tmrDown;
        private System.Windows.Forms.Label lblUpTime;
        private System.Windows.Forms.Timer tmrUp;
        private System.Windows.Forms.Label lblDownTime;
        private System.Windows.Forms.NumericUpDown nudDownHour;
        private System.Windows.Forms.NumericUpDown nudDownSecond;
        private System.Windows.Forms.NumericUpDown nudDownMinute;
        private System.Windows.Forms.Label lblUpTimeM;
    }
}