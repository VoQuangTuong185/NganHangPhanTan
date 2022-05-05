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
        public frmLietKeTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmLietKeTaiKhoan_Load(object sender, EventArgs e)
        {
            cmbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            if (Program.mGroup == "NganHang")
            {
                cmbChiNhanh.Enabled = true;
                cmbLoai.Enabled = true;
            }
            else
            {
                cmbChiNhanh.Enabled = false;
                cmbLoai.Enabled = false;
                cmbLoai.Text = "Chi nhánh hiện tại";
            }
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            Xtrp_LietKeTaiKhoan rpt = new Xtrp_LietKeTaiKhoan(batdau.DateTime, ketthuc.DateTime, cmbLoai.Text.Substring(0,1));
            rpt.lb_batdau.Text = batdau.DateTime.ToString();
            rpt.lb_ketthuc.Text = ketthuc.DateTime.ToString();

            if (cmbChiNhanh.SelectedIndex == 0)
            {
                rpt.tlLoai.Text = "Chi nhánh Bến Thành";
            }
            else if (cmbChiNhanh.SelectedIndex == 1)
            {
                rpt.tlLoai.Text = "Chi nhánh Tân Định";
            }
            else if (cmbLoai.Text == "Tất cả các chi nhánh")
            {
                rpt.tlLoai.Text = cmbLoai.Text;
            }

            if (cmbLoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn loại báo cáo!!", "", MessageBoxButtons.OK);
                cmbLoai.Focus();
                return;
            }
            if (batdau.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn thời gian bắt đầu!!", "", MessageBoxButtons.OK);
                batdau.Focus();
                return;
            }
            if (ketthuc.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn thời gian kết thúc!!", "", MessageBoxButtons.OK);
                ketthuc.Focus();
                return;
            }
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
                cmbLoai.Enabled = true;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0) MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
        }
    }
}
