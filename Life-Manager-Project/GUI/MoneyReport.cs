using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace GUI
{
    public partial class MoneyReport : Form
    {
        string strCon = @"Data Source=DESKTOP-KT38O65\TNGUYEN;Initial Catalog=LifeManager;Integrated Security=True";
        SqlConnection sqlCon = null;

        public MoneyReport()
        {
            InitializeComponent();
        }

        private void MoneyReport_Load(object sender, EventArgs e)
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            sqlCon.Open();
            string sql = "SELECT * FROM tblMoney";
            SqlDataAdapter adapter = new SqlDataAdapter(sql, sqlCon);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "DataSetMoney");
            this.rpMoney.LocalReport.ReportEmbeddedResource = "GUI.ReportMoney.rdlc";

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSetMoney";
            rds.Value = ds.Tables["DataSetMoney"];
            this.rpMoney.LocalReport.DataSources.Add(rds);

            this.rpMoney.RefreshReport();
        }
    }
}
