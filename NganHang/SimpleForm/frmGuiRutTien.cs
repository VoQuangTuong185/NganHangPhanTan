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
    public partial class frmGuiRutTien : Form
    {
        String macn = "";
        int vitri = 0;
        public frmGuiRutTien()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }

        private void frmGuiRutTien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.khachHangTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHangTableAdapter.Fill(this.DS.KhachHang);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
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
                cmsTHEM.Enabled = cmsXoa.Enabled = false;
            }
            else
            {
                cmsTHEM.Enabled = true;
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
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            }
        }

        private void cmsTHEM_Click(object sender, EventArgs e)
        {
            taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = false;
            pnlGD.Enabled = true;
            txtMANV.EditValue = Program.username;
            txtSOTK.EditValue = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
            vitri = bdsTK.Position;
        }

        private void cmsTHOAT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           
            String dt = String.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", DateTime.Now);
            String loaiGD = (cmbLoaiGD.SelectedIndex == 0) ? "GT" : "RT";
            if (txtSoTien.Value < 100000)
            {
                MessageBox.Show("Số tiền giao dịch thấp nhất là 100.000đ\nBạn hãy nhập lại...", "", MessageBoxButtons.OK);
                txtSoTien.Focus();
                return;
            }
            try
            {
                MessageBox.Show("EXEC frmGuiRutTien '" + txtSOTK.EditValue + "','" + loaiGD + "','" + dt + "','" + txtSoTien.Value + "','" + txtMANV.EditValue + "'", "", MessageBoxButtons.OK);
                Program.ExecSqlNonQuery("EXEC frmGuiRutTien '" + txtSOTK.EditValue + "','" + loaiGD + "','" + dt + "','" + txtSoTien.Value + "','" + txtMANV.EditValue + "'");
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
                taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = true;
                pnlGD.Enabled = false;
                bdsTK.Position = vitri;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cmsLUU_Click(object sender, EventArgs e)
        {

        }

        private void cmbLoaiGD_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiGD.Text == "Gửi tiền")
            {
                btnXacNhan.Text = "Gửi tiền";
            }
            else if (cmbLoaiGD.Text == "Rút tiền")
            {
                btnXacNhan.Text = "Rút tiền";
            }
        }

        private void cmsTAILAI_Click(object sender, EventArgs e)
        {
            try
            {
                this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void cmsPHUCHOI_Click(object sender, EventArgs e)
        {
            bdsTK.CancelEdit();//hai trường hợp: đang thêm bỏ thêm, đang sửa bỏ sửa
            if (cmsTHEM.Enabled == false) bdsTK.Position = vitri;
            taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = true;
            pnlGD.Enabled = false;
        }

        private void cmsXoa_Click(object sender, EventArgs e)
        {
            taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = false;
            pnlGD.Enabled = true;
            string MAGD = ((DataRowView)bdsGuiRut[bdsGuiRut.Position])["MAGD"].ToString();
            vitri = bdsGuiRut.Position;

            MessageBox.Show("EXEC frmGuiRutTien_DeleteGD '" + MAGD + "'", "", MessageBoxButtons.OK);
            Program.ExecSqlNonQuery("EXEC frmGuiRutTien_DeleteGD '" + MAGD + "'");
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            taiKhoanGridControl.Enabled = khachHangGridControl.Enabled = true;
            pnlGD.Enabled = false;
            bdsTK.Position = vitri;
        }
    }
}
