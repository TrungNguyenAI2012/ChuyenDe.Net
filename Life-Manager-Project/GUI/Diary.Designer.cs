
namespace GUI
{
    partial class Diary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Diary));
            this.dtpkDairy = new System.Windows.Forms.DateTimePicker();
            this.btnPre = new System.Windows.Forms.Button();
            this.tbxDairy = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChoosePicture = new System.Windows.Forms.Button();
            this.pbxDairy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDairy)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpkDairy
            // 
            this.dtpkDairy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkDairy.Location = new System.Drawing.Point(113, 38);
            this.dtpkDairy.Name = "dtpkDairy";
            this.dtpkDairy.Size = new System.Drawing.Size(243, 23);
            this.dtpkDairy.TabIndex = 0;
            this.dtpkDairy.ValueChanged += new System.EventHandler(this.dtpkDairy_ValueChanged);
            // 
            // btnPre
            // 
            this.btnPre.BackColor = System.Drawing.Color.White;
            this.btnPre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPre.Location = new System.Drawing.Point(77, 38);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(30, 23);
            this.btnPre.TabIndex = 1;
            this.btnPre.Text = "<";
            this.btnPre.UseVisualStyleBackColor = false;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // tbxDairy
            // 
            this.tbxDairy.AllowDrop = true;
            this.tbxDairy.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDairy.Location = new System.Drawing.Point(90, 81);
            this.tbxDairy.Multiline = true;
            this.tbxDairy.Name = "tbxDairy";
            this.tbxDairy.ReadOnly = true;
            this.tbxDairy.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxDairy.Size = new System.Drawing.Size(289, 414);
            this.tbxDairy.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(362, 38);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(30, 23);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(432, 465);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 34);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Viết";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(510, 465);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(109, 34);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Làm mới";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChoosePicture.Location = new System.Drawing.Point(625, 465);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.Size = new System.Drawing.Size(127, 34);
            this.btnChoosePicture.TabIndex = 8;
            this.btnChoosePicture.Text = "Chọn hình";
            this.btnChoosePicture.UseVisualStyleBackColor = true;
            this.btnChoosePicture.Click += new System.EventHandler(this.btnChoosePicture_Click);
            // 
            // pbxDairy
            // 
            this.pbxDairy.ErrorImage = global::GUI.Properties.Resources.ErrorImage;
            this.pbxDairy.Image = global::GUI.Properties.Resources.DefaultDairy;
            this.pbxDairy.Location = new System.Drawing.Point(456, 45);
            this.pbxDairy.Name = "pbxDairy";
            this.pbxDairy.Size = new System.Drawing.Size(286, 414);
            this.pbxDairy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxDairy.TabIndex = 9;
            this.pbxDairy.TabStop = false;
            // 
            // Diary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(825, 531);
            this.Controls.Add(this.pbxDairy);
            this.Controls.Add(this.btnChoosePicture);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbxDairy);
            this.Controls.Add(this.btnPre);
            this.Controls.Add(this.dtpkDairy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Diary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhật ký";
            this.Load += new System.EventHandler(this.Diary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDairy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpkDairy;
        private System.Windows.Forms.Button btnPre;
        private System.Windows.Forms.TextBox tbxDairy;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChoosePicture;
        private System.Windows.Forms.PictureBox pbxDairy;
    }
}