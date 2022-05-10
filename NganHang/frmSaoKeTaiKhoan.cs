using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang
{
    public partial class frmSaoKeTaiKhoan : Form
    {
        public frmSaoKeTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmSaoKeTaiKhoan_Load(object sender, EventArgs e)
        {
            this.thongTinKH_TKSaoKeTableAdapter.Connection.ConnectionString = Program.connstr;
            this.thongTinKH_TKSaoKeTableAdapter.Fill(this.DS.ThongTinKH_TKSaoKe);
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

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();
            if (cmbChiNhanh.SelectedIndex != Program.mChiNhanh)
            {
                Program.mlogin = Program.remotelogin;
                Program.password = Program.remotepassword;
            }
            else
            {
                Program.mlogin = Program.mloginDN;
                Program.password = Program.passwordDN;
            }
            if (Program.KetNoi() == 0) MessageBox.Show("Lỗi kết nối về chi nhánh mới", "", MessageBoxButtons.OK);
            else
            {
                this.thongTinKH_TKSaoKeTableAdapter.Connection.ConnectionString = Program.connstr;
                this.thongTinKH_TKSaoKeTableAdapter.Fill(this.DS.ThongTinKH_TKSaoKe);
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            XtrpSaoKeTaiKhoan rpt = new XtrpSaoKeTaiKhoan(batdau.DateTime, ketthuc.DateTime, cmbHoTenKhSk.Text);
        }
    }
}
