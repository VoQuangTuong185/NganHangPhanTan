using DevExpress.XtraReports.UI;
using System;
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
            this.dS_CHINHANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dS_CHINHANHTableAdapter.Fill(this.DS.DS_CHINHANH);
            cmbCN.Enabled = false;
            if (Program.mGroup == "NganHang")
            {
                cmbCN.Enabled = true;
                cmbLoai.Enabled = true;
            }
            else
            {
                cmbLoai.Enabled = false;
                cmbLoai.Text = "Chi nhánh hiện tại";
            }
        }


        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (batdau.DateTime > DateTime.Now || batdau.Text.Trim() == "")
            {
                MessageBox.Show("Ngày bắt đầu trống hoặc mốc thời gian là trước hiện tại", "", MessageBoxButtons.OK);
                batdau.Focus();
                return;
            }
            if (ketthuc.DateTime > DateTime.Now || ketthuc.Text.Trim() == "")
            {
                MessageBox.Show("Ngày kết thúc trống hoặc mốc thời gian là trước hiện tại", "", MessageBoxButtons.OK);
                ketthuc.Focus();
                return;
            }
            Xtrp_LietKeTaiKhoan rpt = new Xtrp_LietKeTaiKhoan(batdau.DateTime, ketthuc.DateTime, cmbLoai.Text.Substring(0,1), cmbCN.SelectedValue.ToString());
            rpt.lb_batdau.Text = batdau.DateTime.ToString("dd/M/yyyy");
            rpt.lb_ketthuc.Text = ketthuc.DateTime.ToString("dd/M/yyyy");

            if (cmbCN.SelectedIndex == 0)
            {
                rpt.tlLoai.Text = "Chi nhánh Bến Thành";
            }
            else if (cmbCN.SelectedIndex == 1)
            {
                rpt.tlLoai.Text = "Chi nhánh Tân Định";
            }
            if (cmbLoai.Text == "Tất cả các chi nhánh")
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
            if (cmbCN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            if (cmbCN.SelectedIndex != Program.mChiNhanh)
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

        private void batdau_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ketthuc_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
