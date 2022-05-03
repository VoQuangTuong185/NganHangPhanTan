using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class Xtrp_LietKeTaiKhoan : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_LietKeTaiKhoan()
        {
            InitializeComponent();
        }
        public Xtrp_LietKeTaiKhoan(string batdau, string ketthuc, string loai)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = batdau;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = ketthuc;
            this.sqlDataSource1.Queries[0].Parameters[2].Value = loai;
            this.sqlDataSource1.Fill();
        }

    }
}
