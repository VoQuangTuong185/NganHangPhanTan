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

namespace NganHang
{
    public partial class frmLietKeKH : Form
    {
        public frmLietKeKH()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (cmbLoai.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa chọn loại báo cáo!!", "", MessageBoxButtons.OK);
                cmbLoai.Focus();
                return;
            }
            Xtrp_LietKeKH rpt = new Xtrp_LietKeKH(cmbLoai.Text.Substring(0, 1), cmbCN.SelectedValue.ToString());
            ReportPrintTool print = new ReportPrintTool(rpt);
            print.ShowPreviewDialog();
        }

        private void frmLietKeKH_Load(object sender, EventArgs e)
        {
            this.dS_CHINHANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dS_CHINHANHTableAdapter.Fill(this.dS.DS_CHINHANH);
            cmbCN.SelectedIndex = Program.mChiNhanh;
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

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCN.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbCN.SelectedValue.ToString();
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

        private void mACNComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCNFinal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}