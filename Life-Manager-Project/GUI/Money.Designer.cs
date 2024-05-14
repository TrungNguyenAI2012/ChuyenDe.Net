
namespace GUI
{
    partial class Money
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Money));
            this.btnPre = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDay = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblIn = new System.Windows.Forms.Label();
            this.lblOut = new System.Windows.Forms.Label();
            this.lblInOut = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpkMoney = new System.Windows.Forms.DateTimePicker();
            this.lvwMoney = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtpkActiveDate = new System.Windows.Forms.DateTimePicker();
            this.pnlActive = new System.Windows.Forms.Panel();
            this.nudwActivePrice = new System.Windows.Forms.NumericUpDown();
            this.tbxActiveNote = new System.Windows.Forms.TextBox();
            this.tbxActiveWith = new System.Windows.Forms.TextBox();
            this.tbxActiveWallet = new System.Windows.Forms.TextBox();
            this.tbxActiveGroup = new System.Windows.Forms.TextBox();
            this.cbxActiveInOut = new System.Windows.Forms.ComboBox();
            this.tbxActiveName = new System.Windows.Forms.TextBox();
            this.dtpkActiveTime = new System.Windows.Forms.DateTimePicker();
            this.clnNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnWith = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnWallet = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnGroup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnIs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clnTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlActive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudwActivePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPre
            // 
            this.btnPre.Location = new System.Drawing.Point(920, 12);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(24, 30);
            this.btnPre.TabIndex = 4;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(1272, 13);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 30);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(6, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(145, 83);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(160, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(145, 83);
            this.btnDel.TabIndex = 7;
            this.btnDel.Text = "Xóa";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(314, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(145, 83);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(468, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(163, 83);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDay
            // 
            this.btnDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDay.Location = new System.Drawing.Point(907, 5);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(156, 83);
            this.btnDay.TabIndex = 12;
            this.btnDay.Text = "Ngày";
            this.btnDay.UseVisualStyleBackColor = true;
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Enabled = false;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(1069, 1);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(211, 83);
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "Tất cả";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.Location = new System.Drawing.Point(684, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(163, 83);
            this.btnReport.TabIndex = 16;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnReport);
            this.panel2.Controls.Add(this.btnShowAll);
            this.panel2.Controls.Add(this.btnDay);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnDel);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(13, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1283, 90);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 46);
            this.label3.TabIndex = 2;
            this.label3.Text = "Còn lại";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 71);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng cộng";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIn
            // 
            this.lblIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIn.Location = new System.Drawing.Point(35, 128);
            this.lblIn.Name = "lblIn";
            this.lblIn.Size = new System.Drawing.Size(245, 45);
            this.lblIn.TabIndex = 4;
            this.lblIn.Text = "0";
            this.lblIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOut
            // 
            this.lblOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOut.Location = new System.Drawing.Point(35, 228);
            this.lblOut.Name = "lblOut";
            this.lblOut.Size = new System.Drawing.Size(245, 45);
            this.lblOut.TabIndex = 2;
            this.lblOut.Text = "0";
            this.lblOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblInOut
            // 
            this.lblInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInOut.Location = new System.Drawing.Point(35, 328);
            this.lblInOut.Name = "lblInOut";
            this.lblInOut.Size = new System.Drawing.Size(245, 45);
            this.lblInOut.TabIndex = 5;
            this.lblInOut.Text = "0";
            this.lblInOut.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(268, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 46);
            this.label8.TabIndex = 6;
            this.label8.Text = "VNĐ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(268, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 46);
            this.label9.TabIndex = 7;
            this.label9.Text = "VNĐ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(268, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 46);
            this.label10.TabIndex = 7;
            this.label10.Text = "VNĐ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblInOut);
            this.panel1.Controls.Add(this.lblOut);
            this.panel1.Controls.Add(this.lblIn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(920, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 389);
            this.panel1.TabIndex = 1;
            // 
            // dtpkMoney
            // 
            this.dtpkMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkMoney.Location = new System.Drawing.Point(950, 13);
            this.dtpkMoney.Name = "dtpkMoney";
            this.dtpkMoney.Size = new System.Drawing.Size(316, 30);
            this.dtpkMoney.TabIndex = 3;
            this.dtpkMoney.ValueChanged += new System.EventHandler(this.dtpkMoney_ValueChanged);
            // 
            // lvwMoney
            // 
            this.lvwMoney.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvwMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMoney.GridLines = true;
            this.lvwMoney.HideSelection = false;
            this.lvwMoney.Location = new System.Drawing.Point(13, 18);
            this.lvwMoney.Name = "lvwMoney";
            this.lvwMoney.Size = new System.Drawing.Size(901, 425);
            this.lvwMoney.TabIndex = 7;
            this.lvwMoney.UseCompatibleStateImageBehavior = false;
            this.lvwMoney.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ngày";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Thời gian";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tên giao dịch";
            this.columnHeader3.Width = 160;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thu/Chi";
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Giá tiền";
            this.columnHeader5.Width = 115;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Nhóm";
            this.columnHeader6.Width = 95;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Ví";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Với";
            this.columnHeader8.Width = 80;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ghi chú";
            this.columnHeader9.Width = 140;
            // 
            // dtpkActiveDate
            // 
            this.dtpkActiveDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkActiveDate.Location = new System.Drawing.Point(3, 10);
            this.dtpkActiveDate.Name = "dtpkActiveDate";
            this.dtpkActiveDate.Size = new System.Drawing.Size(82, 20);
            this.dtpkActiveDate.TabIndex = 0;
            // 
            // pnlActive
            // 
            this.pnlActive.Controls.Add(this.nudwActivePrice);
            this.pnlActive.Controls.Add(this.tbxActiveNote);
            this.pnlActive.Controls.Add(this.tbxActiveWith);
            this.pnlActive.Controls.Add(this.tbxActiveWallet);
            this.pnlActive.Controls.Add(this.tbxActiveGroup);
            this.pnlActive.Controls.Add(this.cbxActiveInOut);
            this.pnlActive.Controls.Add(this.tbxActiveName);
            this.pnlActive.Controls.Add(this.dtpkActiveTime);
            this.pnlActive.Controls.Add(this.dtpkActiveDate);
            this.pnlActive.Location = new System.Drawing.Point(13, 401);
            this.pnlActive.Name = "pnlActive";
            this.pnlActive.Size = new System.Drawing.Size(883, 42);
            this.pnlActive.TabIndex = 8;
            this.pnlActive.Visible = false;
            // 
            // nudwActivePrice
            // 
            this.nudwActivePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudwActivePrice.Location = new System.Drawing.Point(393, 10);
            this.nudwActivePrice.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.nudwActivePrice.Name = "nudwActivePrice";
            this.nudwActivePrice.Size = new System.Drawing.Size(115, 23);
            this.nudwActivePrice.TabIndex = 10;
            this.nudwActivePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbxActiveNote
            // 
            this.tbxActiveNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveNote.Location = new System.Drawing.Point(746, 9);
            this.tbxActiveNote.Name = "tbxActiveNote";
            this.tbxActiveNote.Size = new System.Drawing.Size(136, 23);
            this.tbxActiveNote.TabIndex = 9;
            // 
            // tbxActiveWith
            // 
            this.tbxActiveWith.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveWith.Location = new System.Drawing.Point(665, 9);
            this.tbxActiveWith.Name = "tbxActiveWith";
            this.tbxActiveWith.Size = new System.Drawing.Size(80, 23);
            this.tbxActiveWith.TabIndex = 8;
            // 
            // tbxActiveWallet
            // 
            this.tbxActiveWallet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveWallet.Location = new System.Drawing.Point(603, 9);
            this.tbxActiveWallet.Name = "tbxActiveWallet";
            this.tbxActiveWallet.Size = new System.Drawing.Size(61, 23);
            this.tbxActiveWallet.TabIndex = 7;
            // 
            // tbxActiveGroup
            // 
            this.tbxActiveGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveGroup.Location = new System.Drawing.Point(508, 9);
            this.tbxActiveGroup.Name = "tbxActiveGroup";
            this.tbxActiveGroup.Size = new System.Drawing.Size(95, 23);
            this.tbxActiveGroup.TabIndex = 6;
            // 
            // cbxActiveInOut
            // 
            this.cbxActiveInOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActiveInOut.FormattingEnabled = true;
            this.cbxActiveInOut.Items.AddRange(new object[] {
            "Chi",
            "Thu"});
            this.cbxActiveInOut.Location = new System.Drawing.Point(325, 10);
            this.cbxActiveInOut.Name = "cbxActiveInOut";
            this.cbxActiveInOut.Size = new System.Drawing.Size(68, 24);
            this.cbxActiveInOut.TabIndex = 4;
            this.cbxActiveInOut.Text = "Chi";
            // 
            // tbxActiveName
            // 
            this.tbxActiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxActiveName.Location = new System.Drawing.Point(163, 11);
            this.tbxActiveName.Name = "tbxActiveName";
            this.tbxActiveName.Size = new System.Drawing.Size(161, 23);
            this.tbxActiveName.TabIndex = 3;
            // 
            // dtpkActiveTime
            // 
            this.dtpkActiveTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpkActiveTime.Location = new System.Drawing.Point(84, 10);
            this.dtpkActiveTime.Name = "dtpkActiveTime";
            this.dtpkActiveTime.ShowUpDown = true;
            this.dtpkActiveTime.Size = new System.Drawing.Size(79, 20);
            this.dtpkActiveTime.TabIndex = 1;
            // 
            // clnNote
            // 
            this.clnNote.Text = "Ghi chú";
            this.clnNote.Width = 110;
            // 
            // clnDate
            // 
            this.clnDate.Text = "Ngày";
            this.clnDate.Width = 103;
            // 
            // clnWith
            // 
            this.clnWith.Text = "Cùng với";
            this.clnWith.Width = 86;
            // 
            // clnWallet
            // 
            this.clnWallet.Text = "Ví";
            // 
            // clnGroup
            // 
            this.clnGroup.Text = "Nhóm";
            this.clnGroup.Width = 93;
            // 
            // clnPrice
            // 
            this.clnPrice.Text = "Giá tiền";
            this.clnPrice.Width = 113;
            // 
            // clnIs
            // 
            this.clnIs.Text = "Thu/Chi";
            this.clnIs.Width = 71;
            // 
            // clnName
            // 
            this.clnName.Text = "Tên giao dịch";
            this.clnName.Width = 160;
            // 
            // clnTime
            // 
            this.clnTime.Text = "Thời gian";
            this.clnTime.Width = 100;
            // 
            // Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1306, 545);
            this.Controls.Add(this.pnlActive);
            this.Controls.Add(this.lvwMoney);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.dtpkMoney);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Money";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý giao dịch";
            this.Load += new System.EventHandler(this.Money_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlActive.ResumeLayout(false);
            this.pnlActive.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudwActivePrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDay;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblIn;
        private System.Windows.Forms.Label lblOut;
        private System.Windows.Forms.Label lblInOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpkMoney;
        private System.Windows.Forms.ListView lvwMoney;
        private System.Windows.Forms.DateTimePicker dtpkActiveDate;
        private System.Windows.Forms.Panel pnlActive;
        private System.Windows.Forms.NumericUpDown nudwActivePrice;
        private System.Windows.Forms.TextBox tbxActiveNote;
        private System.Windows.Forms.TextBox tbxActiveWith;
        private System.Windows.Forms.TextBox tbxActiveWallet;
        private System.Windows.Forms.TextBox tbxActiveGroup;
        private System.Windows.Forms.ComboBox cbxActiveInOut;
        private System.Windows.Forms.TextBox tbxActiveName;
        private System.Windows.Forms.DateTimePicker dtpkActiveTime;
        private System.Windows.Forms.ColumnHeader clnNote;
        private System.Windows.Forms.ColumnHeader clnDate;
        private System.Windows.Forms.ColumnHeader clnWith;
        private System.Windows.Forms.ColumnHeader clnWallet;
        private System.Windows.Forms.ColumnHeader clnGroup;
        private System.Windows.Forms.ColumnHeader clnPrice;
        private System.Windows.Forms.ColumnHeader clnIs;
        private System.Windows.Forms.ColumnHeader clnName;
        private System.Windows.Forms.ColumnHeader clnTime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}