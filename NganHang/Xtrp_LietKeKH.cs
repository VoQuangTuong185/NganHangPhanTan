using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NganHang
{
    public partial class Xtrp_LietKeKH : DevExpress.XtraReports.UI.XtraReport
    {
        public Xtrp_LietKeKH()
        {
        }
        public Xtrp_LietKeKH(string loai, string CN)
        {
            InitializeComponent();
            this.sqlDataSource1.Connection.ConnectionString = Program.connstr;
            this.sqlDataSource1.Queries[0].Parameters[0].Value = loai;
            this.sqlDataSource1.Queries[0].Parameters[1].Value = CN;
            this.sqlDataSource1.Fill();
        }
    }
}
