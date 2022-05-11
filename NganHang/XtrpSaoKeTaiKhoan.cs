using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class XtrpSaoKeTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public XtrpSaoKeTaiKhoan()
        {
            InitializeComponent();
        }
        public XtrpSaoKeTaiKhoan(string SOTK,DateTime batdau, DateTime ketthuc)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = SOTK;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = batdau;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = ketthuc;       
            this.sqlDataSource1.Fill();
        }
    }
}
