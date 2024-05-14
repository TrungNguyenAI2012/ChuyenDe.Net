
namespace GUI
{
    partial class MoneyReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoneyReport));
            this.rpMoney = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataTableMoneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetMoney = new GUI.DataSetMoney();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableMoneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMoney)).BeginInit();
            this.SuspendLayout();
            // 
            // rpMoney
            // 
            this.rpMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetMoney";
            reportDataSource1.Value = this.DataTableMoneyBindingSource;
            this.rpMoney.LocalReport.DataSources.Add(reportDataSource1);
            this.rpMoney.LocalReport.ReportEmbeddedResource = "GUI.ReportMoney.rdlc";
            this.rpMoney.Location = new System.Drawing.Point(0, 0);
            this.rpMoney.Name = "rpMoney";
            this.rpMoney.ServerReport.BearerToken = null;
            this.rpMoney.Size = new System.Drawing.Size(800, 450);
            this.rpMoney.TabIndex = 0;
            this.rpMoney.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // DataTableMoneyBindingSource
            // 
            this.DataTableMoneyBindingSource.DataMember = "DataTableMoney";
            this.DataTableMoneyBindingSource.DataSource = this.DataSetMoney;
            // 
            // DataSetMoney
            // 
            this.DataSetMoney.DataSetName = "DataSetMoney";
            this.DataSetMoney.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MoneyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rpMoney);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoneyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoneyReport";
            this.Load += new System.EventHandler(this.MoneyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableMoneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetMoney)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpMoney;
        private System.Windows.Forms.BindingSource DataTableMoneyBindingSource;
        private DataSetMoney DataSetMoney;
    }
}