using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace NganHang
{
    public partial class frmSaoKeTaiKhoan : Form
    {
        string SoTKSaoKe = "";
        public frmSaoKeTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmSaoKeTaiKhoan_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
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
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtSoTaiKhoanKhachHang.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được trống", "", MessageBoxButtons.OK);
                txtSoTaiKhoanKhachHang.Focus();
                textHoTenKhSk.Text = "";
                return;
            }
            if (Program.KetNoi() == 0) return;
            string strlenh = "EXEC frmSaoKeTaiKhoan_ThongTinTKSaoKe '" + txtSoTaiKhoanKhachHang.Text + "'";
            Program.myReader = Program.ExecSqlDataReader(strlenh);
            if (Program.myReader == null) return;
            Program.myReader.Read();
            if (!Program.myReader.HasRows)
            {
                MessageBox.Show("Số tài khoản không tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                return;
            }
            textHoTenKhSk.Text = Program.myReader.GetString(0);
            teCMND.Text = Program.myReader.GetString(1);
            SoTKSaoKe = Program.myReader.GetString(2);
            Program.myReader.Close();
            Program.conn.Close();
        }
        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            XtrpSaoKeTaiKhoan rpt = new XtrpSaoKeTaiKhoan(SoTKSaoKe,batdau.DateTime, ketthuc.DateTime);
            rpt.lbBatDau.Text = batdau.DateTime.ToString();
            rpt.lbKetThuc.Text = ketthuc.DateTime.ToString();
            rpt.lbSoTkSaoKe.Text = SoTKSaoKe;
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            textHoTenKhSk.Text = teCMND.Text = txtSoTaiKhoanKhachHang.Text = batdau.Text = ketthuc.Text = ""; 
        }
    }
}
