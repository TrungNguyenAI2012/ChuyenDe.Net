
namespace GUI
{
    partial class Pomodoro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomodoro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblTotalProject = new System.Windows.Forms.Label();
            this.tbnFix = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblFinishProject = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTotalProject = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pgbTotalProject = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pgbTime = new System.Windows.Forms.ProgressBar();
            this.lblTotalPomodoro = new System.Windows.Forms.Label();
            this.lblFinishPomodoro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pgbPomodoro = new System.Windows.Forms.ProgressBar();
            this.lblLevel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNextLevel = new System.Windows.Forms.Button();
            this.btnResert = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.tmrTime = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.lblTotalProject);
            this.panel1.Controls.Add(this.tbnFix);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.lblFinishProject);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cbxTotalProject);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pgbTotalProject);
            this.panel1.Location = new System.Drawing.Point(7, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 138);
            this.panel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(10, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(267, 46);
            this.label10.TabIndex = 17;
            this.label10.Text = "Quản lý dự án";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(635, 77);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(186, 51);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblTotalProject
            // 
            this.lblTotalProject.AutoSize = true;
            this.lblTotalProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalProject.Location = new System.Drawing.Point(550, 77);
            this.lblTotalProject.Name = "lblTotalProject";
            this.lblTotalProject.Size = new System.Drawing.Size(42, 46);
            this.lblTotalProject.TabIndex = 16;
            this.lblTotalProject.Text = "0";
            // 
            // tbnFix
            // 
            this.tbnFix.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbnFix.Location = new System.Drawing.Point(731, 22);
            this.tbnFix.Name = "tbnFix";
            this.tbnFix.Size = new System.Drawing.Size(90, 39);
            this.tbnFix.TabIndex = 15;
            this.tbnFix.Text = "Sửa";
            this.tbnFix.UseVisualStyleBackColor = true;
            this.tbnFix.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(635, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 39);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblFinishProject
            // 
            this.lblFinishProject.AutoSize = true;
            this.lblFinishProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishProject.Location = new System.Drawing.Point(462, 77);
            this.lblFinishProject.Name = "lblFinishProject";
            this.lblFinishProject.Size = new System.Drawing.Size(42, 46);
            this.lblFinishProject.TabIndex = 15;
            this.lblFinishProject.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(539, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 39);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(510, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 46);
            this.label9.TabIndex = 14;
            this.label9.Text = "/";
            // 
            // cbxTotalProject
            // 
            this.cbxTotalProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTotalProject.FormattingEnabled = true;
            this.cbxTotalProject.Location = new System.Drawing.Point(283, 22);
            this.cbxTotalProject.Name = "cbxTotalProject";
            this.cbxTotalProject.Size = new System.Drawing.Size(250, 39);
            this.cbxTotalProject.TabIndex = 5;
            this.cbxTotalProject.Text = "Các dự án";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tiến độ:";
            // 
            // pgbTotalProject
            // 
            this.pgbTotalProject.Location = new System.Drawing.Point(180, 77);
            this.pgbTotalProject.Maximum = 0;
            this.pgbTotalProject.Name = "pgbTotalProject";
            this.pgbTotalProject.Size = new System.Drawing.Size(275, 46);
            this.pgbTotalProject.Step = 1;
            this.pgbTotalProject.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pgbTime);
            this.panel2.Controls.Add(this.lblTotalPomodoro);
            this.panel2.Controls.Add(this.lblFinishPomodoro);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pgbPomodoro);
            this.panel2.Controls.Add(this.lblLevel);
            this.panel2.Location = new System.Drawing.Point(7, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 216);
            this.panel2.TabIndex = 5;
            // 
            // pgbTime
            // 
            this.pgbTime.Location = new System.Drawing.Point(225, 58);
            this.pgbTime.Maximum = 0;
            this.pgbTime.Name = "pgbTime";
            this.pgbTime.Size = new System.Drawing.Size(360, 76);
            this.pgbTime.Step = 1;
            this.pgbTime.TabIndex = 14;
            // 
            // lblTotalPomodoro
            // 
            this.lblTotalPomodoro.AutoSize = true;
            this.lblTotalPomodoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPomodoro.Location = new System.Drawing.Point(543, 160);
            this.lblTotalPomodoro.Name = "lblTotalPomodoro";
            this.lblTotalPomodoro.Size = new System.Drawing.Size(42, 46);
            this.lblTotalPomodoro.TabIndex = 13;
            this.lblTotalPomodoro.Text = "0";
            // 
            // lblFinishPomodoro
            // 
            this.lblFinishPomodoro.AutoSize = true;
            this.lblFinishPomodoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinishPomodoro.Location = new System.Drawing.Point(455, 160);
            this.lblFinishPomodoro.Name = "lblFinishPomodoro";
            this.lblFinishPomodoro.Size = new System.Drawing.Size(42, 46);
            this.lblFinishPomodoro.TabIndex = 12;
            this.lblFinishPomodoro.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(503, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 46);
            this.label4.TabIndex = 11;
            this.label4.Text = "/";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(19, 58);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(200, 76);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "25:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 46);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tiến độ:";
            // 
            // pgbPomodoro
            // 
            this.pgbPomodoro.Location = new System.Drawing.Point(173, 160);
            this.pgbPomodoro.Maximum = 0;
            this.pgbPomodoro.Name = "pgbPomodoro";
            this.pgbPomodoro.Size = new System.Drawing.Size(275, 46);
            this.pgbPomodoro.Step = 1;
            this.pgbPomodoro.TabIndex = 9;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(3, 3);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(372, 46);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Thời gian \'Làm việc\'";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNextLevel);
            this.panel3.Controls.Add(this.btnResert);
            this.panel3.Controls.Add(this.btnPause);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Location = new System.Drawing.Point(610, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 216);
            this.panel3.TabIndex = 6;
            // 
            // btnNextLevel
            // 
            this.btnNextLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextLevel.Location = new System.Drawing.Point(117, 114);
            this.btnNextLevel.Name = "btnNextLevel";
            this.btnNextLevel.Size = new System.Drawing.Size(90, 81);
            this.btnNextLevel.TabIndex = 12;
            this.btnNextLevel.Text = "Tiếp theo";
            this.btnNextLevel.UseVisualStyleBackColor = true;
            this.btnNextLevel.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnResert
            // 
            this.btnResert.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResert.Location = new System.Drawing.Point(12, 114);
            this.btnResert.Name = "btnResert";
            this.btnResert.Size = new System.Drawing.Size(90, 81);
            this.btnResert.TabIndex = 11;
            this.btnResert.Text = "Đặt lại";
            this.btnResert.UseVisualStyleBackColor = true;
            this.btnResert.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(117, 8);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(90, 81);
            this.btnPause.TabIndex = 10;
            this.btnPause.Text = "Tạm Ngừng";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 8);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(90, 81);
            this.btnStart.TabIndex = 9;
            this.btnStart.Text = "Bắt đầu";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btn_Click);
            // 
            // tmrTime
            // 
            this.tmrTime.Interval = 1000;
            // 
            // Pomodoro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 409);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Pomodoro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phương pháp Pomodoro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgbTotalProject;
        private System.Windows.Forms.ComboBox cbxTotalProject;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnNextLevel;
        private System.Windows.Forms.Button btnResert;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblTotalProject;
        private System.Windows.Forms.Button tbnFix;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblFinishProject;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTotalPomodoro;
        private System.Windows.Forms.Label lblFinishPomodoro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar pgbPomodoro;
        private System.Windows.Forms.ProgressBar pgbTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Timer tmrTime;
    }
}