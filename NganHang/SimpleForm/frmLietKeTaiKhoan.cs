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
        String macn = "";
        public frmLietKeTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmLietKeTaiKhoan_Load(object sender, EventArgs e)
        {
            this.nhanVien1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVien1TableAdapter.Fill(this.DS.NhanVien1);
            macn = ((DataRowView)bdsNV[0])["MACN"].ToString(); //**VẪN CÒN TIỀM ẨN LỖI CHƯA FIX**
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

        private void hOTENComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                manv = int.Parse(cmbHOTEN.SelectedValue.ToString());
            }
            catch (Exception ex)
            {

            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            manv = int.Parse(txtManv.Text);
            Xtrp_LietKeTaiKhoan rpt = new Xtrp_LietKeTaiKhoan(manv, cmbLoai.Text.Substring(0, 1), int.Parse(cmbNam.Text));
            rpt.lb_batdau.Text = batdau;

            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();

        }
    }
}
