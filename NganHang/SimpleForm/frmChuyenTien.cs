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
    public partial class frmChuyenTien : Form
    {
        String macn = "";
        int vitri = 0;
        public frmChuyenTien()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmChuyenTien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.DS.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            macn = ((DataRowView)bdsKH[0])["MACN"].ToString(); //**VẪN CÒN TIỀM ẨN LỖI CHƯA FIX**
            cmbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            pnlGD.Enabled = false;
            //panelControl2.Enabled = cmsPHUCHOI.Enabled = cmsLUU.Enabled = false;
            if (Program.mGroup == "NganHang")
            {
                cmbChiNhanh.Enabled = true;
                cmsTHEM.Enabled = cmsXoa.Enabled = cmsPHUCHOI.Enabled = false;
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
                DS.EnforceConstraints = false;
                this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHangTableAdapter.Fill(this.DS.KhachHang);
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                this.frmChuyenTien_InfoReceiverTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmChuyenTien_InfoReceiverTableAdapter.Fill(this.DS.frmChuyenTien_InfoReceiver, txtSoTkNhanTien.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void btnChuyenTien_Click(object sender, EventArgs e)
        {
            String dt = String.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", DateTime.Now);
            Program.ExecSqlNonQuery("EXEC frmChuyenTien_ChuyenTien '" + txtSoTKChuyen.Text + "','" + txtSoTKNhan.Text + "','" + nuSoTien.Value + "','" + dt + "','" + Program.username + "'");
            DS.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.DS.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = true;
            pnlGD.Enabled = false;
            bdsTK.Position = vitri;
        }

        private void cmsTHEM_Click(object sender, EventArgs e)
        {
            taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = false;
            pnlGD.Enabled = true;
            txtMANV.Text = Program.username;
            txtSoTKChuyen.Text = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
            vitri = bdsTK.Position;
        }
    }
}


