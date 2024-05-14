
namespace GUI
{
    partial class Health
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Health));
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.btnTomorrow = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxFeeling = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxWeight = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPre = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvwHealth = new System.Windows.Forms.ListView();
            this.clnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnSymptom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDrug = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTimes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDrinked = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pnlActive = new System.Windows.Forms.Panel();
            this.cbxActiveDrug = new System.Windows.Forms.CheckBox();
            this.nudnUsed = new System.Windows.Forms.NumericUpDown();
            this.nudwTimes = new System.Windows.Forms.NumericUpDown();
            this.tbxActiveSymptom = new System.Windows.Forms.TextBox();
            this.tbxActiveName = new System.Windows.Forms.TextBox();
            this.dtpkActiveDate = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudnUsed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudwTimes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpkDate);
            this.panel2.Controls.Add(this.btnTomorrow);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.tbxFeeling);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.tbxHeight);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbxWeight);
            this.panel2.Controls.Add(this.btnNext);
            this.panel2.Controls.Add(this.btnPre);
            this.panel2.Location = new System.Drawing.Point(855, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(337, 218);
            this.panel2.TabIndex = 4;
            // 
            // dtpkDate
            // 
            this.dtpkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDate.Location = new System.Drawing.Point(46, 3);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtpkDate.Size = new System.Drawing.Size(246, 24);
            this.dtpkDate.TabIndex = 19;
            this.dtpkDate.ValueChanged += new System.EventHandler(this.dtpkDate_ValueChanged);
            // 
            // btnTomorrow
            // 
            this.btnTomorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTomorrow.Location = new System.Drawing.Point(190, 150);
            this.btnTomorrow.Name = "btnTomorrow";
            this.btnTomorrow.Size = new System.Drawing.Size(130, 51);
            this.btnTomorrow.TabIndex = 18;
            this.btnTomorrow.Text = "Như hôm qua";
            this.btnTomorrow.UseVisualStyleBackColor = true;
            this.btnTomorrow.Click += new System.EventHandler(this.btnTomorrow_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(16, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 51);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Cập nhập";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxFeeling
            // 
            this.tbxFeeling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxFeeling.Location = new System.Drawing.Point(9, 91);
            this.tbxFeeling.Multiline = true;
            this.tbxFeeling.Name = "tbxFeeling";
            this.tbxFeeling.ReadOnly = true;
            this.tbxFeeling.Size = new System.Drawing.Size(311, 53);
            this.tbxFeeling.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Ngày hôm nay của bạn thế nào?:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "cm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Chiều cao:";
            // 
            // tbxHeight
            // 
            this.tbxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHeight.Location = new System.Drawing.Point(255, 39);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.ReadOnly = true;
            this.tbxHeight.Size = new System.Drawing.Size(50, 26);
            this.tbxHeight.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(137, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Kg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Cân nặng:";
            // 
            // tbxWeight
            // 
            this.tbxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxWeight.Location = new System.Drawing.Point(87, 39);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.ReadOnly = true;
            this.tbxWeight.Size = new System.Drawing.Size(50, 26);
            this.tbxWeight.TabIndex = 7;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(298, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 24);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.Location = new System.Drawing.Point(4, 2);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(36, 25);
            this.btnPre.TabIndex = 5;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDel);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(855, 237);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 210);
            this.panel1.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(190, 125);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 75);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(16, 125);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 75);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(190, 16);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(130, 75);
            this.btnDel.TabIndex = 2;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(16, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(130, 75);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvwHealth
            // 
            this.lvwHealth.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clnDate,
            this.clnName,
            this.clnSymptom,
            this.clnDrug,
            this.clnTimes,
            this.clnDrinked});
            this.lvwHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwHealth.GridLines = true;
            this.lvwHealth.HideSelection = false;
            this.lvwHealth.Location = new System.Drawing.Point(8, 13);
            this.lvwHealth.Name = "lvwHealth";
            this.lvwHealth.Size = new System.Drawing.Size(835, 434);
            this.lvwHealth.TabIndex = 8;
            this.lvwHealth.UseCompatibleStateImageBehavior = false;
            this.lvwHealth.View = System.Windows.Forms.View.Details;
            // 
            // clnDate
            // 
            this.clnDate.Text = "Ngày";
            this.clnDate.Width = 100;
            // 
            // clnName
            // 
            this.clnName.Text = "Tên";
            this.clnName.Width = 163;
            // 
            // clnSymptom
            // 
            this.clnSymptom.Text = "Triệu chứng";
            this.clnSymptom.Width = 300;
            // 
            // clnDrug
            // 
            this.clnDrug.Text = "Thuốc";
            this.clnDrug.Width = 70;
            // 
            // clnTimes
            // 
            this.clnTimes.Text = "Số liều";
            this.clnTimes.Width = 90;
            // 
            // clnDrinked
            // 
            this.clnDrinked.Text = "Đã uống";
            this.clnDrinked.Width = 90;
            // 
            // pnlActive
            // 
            this.pnlActive.Controls.Add(this.cbxActiveDrug);
            this.pnlActive.Controls.Add(this.nudnUsed);
            this.pnlActive.Controls.Add(this.nudwTimes);
            this.pnlActive.Controls.Add(this.tbxActiveSymptom);
            this.pnlActive.Controls.Add(this.tbxActiveName);
            this.pnlActive.Controls.Add(this.dtpkActiveDate);
            this.pnlActive.Location = new System.Drawing.Point(8, 402);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(816, 45);
            this.pnlActive.TabIndex = 9;
            this.pnlActive.Visible = false;
            // 
            // cbxActiveDrug
            // 
            this.cbxActiveDrug.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbxActiveDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxActiveDrug.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActiveDrug.Location = new System.Drawing.Point(571, 12);
            this.cbxActiveDrug.Name = "cbxActiveDrug";
            this.cbxActiveDrug.Size = new System.Drawing.Size(56, 21);
            this.cbxActiveDrug.TabIndex = 6;
            this.cbxActiveDrug.UseVisualStyleBackColor = true;
            // 
            // nudnUsed
            // 
            this.nudnUsed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudnUsed.Location = new System.Drawing.Point(727, 11);
            this.nudnUsed.Name = "nudnUsed";
            this.nudnUsed.Size = new System.Drawing.Size(90, 23);
            this.nudnUsed.TabIndex = 5;
            this.nudnUsed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nudwTimes
            // 
            this.nudwTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudwTimes.Location = new System.Drawing.Point(633, 11);
            this.nudwTimes.Name = "nudwTimes";
            this.nudwTimes.Size = new System.Drawing.Size(90, 23);
            this.nudwTimes.TabIndex = 4;
            this.nudwTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxActiveSymptom
            // 
            this.tbxActiveSymptom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveSymptom.Location = new System.Drawing.Point(263, 9);
            this.tbxActiveSymptom.Multiline = true;
            this.tbxActiveSymptom.Name = "tbxActiveSymptom";
            this.tbxActiveSymptom.Size = new System.Drawing.Size(302, 26);
            this.tbxActiveSymptom.TabIndex = 3;
            // 
            // tbxActiveName
            // 
            this.tbxActiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveName.Location = new System.Drawing.Point(105, 9);
            this.tbxActiveName.Name = "tbxActiveName";
            this.tbxActiveName.Size = new System.Drawing.Size(159, 26);
            this.tbxActiveName.TabIndex = 2;
            // 
            // dtpkActiveDate
            // 
            this.dtpkActiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkActiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkActiveDate.Location = new System.Drawing.Point(4, 8);
            this.dtpkActiveDate.Name = "dtpkActiveDate";
            this.dtpkActiveDate.Size = new System.Drawing.Size(101, 27);
            this.dtpkActiveDate.TabIndex = 1;
            // 
            // Health
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 453);
            this.Controls.Add(this.pnlActive);
            this.Controls.Add(this.lvwHealth);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Health";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chăm sóc sức khỏe";
            this.Load += new System.EventHandler(this.Health_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudnUsed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudwTimes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox tbxWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxHeight;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxFeeling;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTomorrow;
        private System.Windows.Forms.ListView lvwHealth;
        private System.Windows.Forms.ColumnHeader clnName;
        private System.Windows.Forms.ColumnHeader clnSymptom;
        private System.Windows.Forms.ColumnHeader clnDrug;
        private System.Windows.Forms.ColumnHeader clnTimes;
        private System.Windows.Forms.ColumnHeader clnDrinked;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        public System.Windows.Forms.ColumnHeader clnDate;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.CheckBox cbxActiveDrug;
        private System.Windows.Forms.NumericUpDown nudnUsed;
        private System.Windows.Forms.NumericUpDown nudwTimes;
        private System.Windows.Forms.TextBox tbxActiveSymptom;
        private System.Windows.Forms.TextBox tbxActiveName;
        private System.Windows.Forms.DateTimePicker dtpkActiveDate;
    }
}