using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang.SimpleForm
{
    public partial class frmLietKeTaiKhoan : Form
    {
        int manv;
        public frmLietKeTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmLietKeTaiKhoan_Load(object sender, EventArgs e)
        {
            this.khachHang1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHang1TableAdapter.Fill(this.DS.KhachHang1);
            cmbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "NganHang")
            {
                cmbChiNhanh.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
            }

        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Xtrp_LietKeTaiKhoan rpt = new Xtrp_LietKeTaiKhoan(batdau.DateTime.ToString(), ketthuc.DateTime.ToString(), cmbLoai.Text.Substring(0,1));
            rpt.lb_batdau.Text = batdau.DateTime.ToString();
            rpt.lb_ketthuc.Text = ketthuc.DateTime.ToString();
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }
    }
}
