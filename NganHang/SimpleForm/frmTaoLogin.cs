using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NganHang.SimpleForm
{
    public partial class frmTaoLogin : Form
    {
        String macn = "";
        int vitri = 0;
        public frmTaoLogin()
        {
            InitializeComponent();
        }
        private void Reload()
        {
            if (bdsNV_X_LOGIN.Count > 0)
            {
                txtTrangThai.EditValue = "Chọn nhân viên để tạo tài khoản đăng nhập hệ thống!!";
                panInput.Enabled = gcNV_X_LOGIN.Enabled = true;
            }
            else
            {
                txtTrangThai.EditValue = "Hiện tất cả nhân viên trong chi nhánh đã có tài khoản đăng nhập!!";
                panInput.Enabled = gcNV_X_LOGIN.Enabled = false;
            }
            txtLoginName.Clear();
            txtPass.Clear();
        }
        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            {
                this.lay_NV_Chua_Co_LoginTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lay_NV_Chua_Co_LoginTableAdapter.Fill(this.DS.Lay_NV_Chua_Co_Login);
                this.thong_Tin_LoginName1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.thong_Tin_LoginName1TableAdapter.Fill(this.DS.Thong_Tin_LoginName1, Program.mGroup);
                macn = ((DataRowView)bdsNV_X_LOGIN[0])["MACN"].ToString(); //**VẪN CÒN TIỀM ẨN LỖI CHƯA FIX**
                cmbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
                cmbChiNhanh.DisplayMember = "TENCN";
                cmbChiNhanh.ValueMember = "TENSERVER";
                cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
                gcNV_X_LOGIN.Enabled = true;
                groupBox1.Enabled = false;
                if (Program.mGroup == "NganHang")
                {
                    cmbChiNhanh.Enabled = true;
                    memoLuuY.EditValue += "Tài khoản có thể: \r\n";
                    memoLuuY.EditValue += "- Xem các báo cáo trên tất cả chi nhánh\r\n";
                    memoLuuY.EditValue += "- Tra cứu dữ liệu trên tất cả chi nhánh\r\n";
                    memoLuuY.EditValue += "- Tạo tài khoản đăng nhập hệ thống thuộc cùng nhóm (NGANHANG)";
                }
                else
                {
                    memoLuuY.EditValue += "Tài khoản có thể: \r\n";
                    memoLuuY.EditValue += "- Toàn quyền cập nhật dữ liệu trên chi nhánh thuộc về\r\n";
                    memoLuuY.EditValue += "- Tra cứu dữ liệu trên chi nhánh thuộc về\r\n";
                    memoLuuY.EditValue += "- Tạo tài khoản đăng nhập hệ thống thuộc cùng nhóm (CHINHANH)";
                    cmbChiNhanh.Enabled = false;
                }
                Reload();
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
                this.lay_NV_Chua_Co_LoginTableAdapter.Connection.ConnectionString = Program.connstr;
                this.lay_NV_Chua_Co_LoginTableAdapter.Fill(this.DS.Lay_NV_Chua_Co_Login);
                this.thong_Tin_LoginName1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.thong_Tin_LoginName1TableAdapter.Fill(this.DS.Thong_Tin_LoginName1, Program.mGroup);
            }
        }
        private bool CHECK_LOGIN_TRUNG(string txtLoginName)
        {
            Program.myReader.Close();
            string strlenh1 = "EXEC Kiem_Tra_LOGIN_Trung   '" + txtLoginName + "','" + Program.mGroup + "'";
            MessageBox.Show(strlenh1, "", MessageBoxButtons.OK);
            Program.myReader = Program.ExecSqlDataReader(strlenh1);
            Program.myReader.Read();
            if (Program.myReader.HasRows)
            {              
                return true;
            }
            return false;
        }
        private void btnCreateLogin_Click(object sender, EventArgs e)
        {
            string MANV = ((DataRowView)bdsNV_X_LOGIN[bdsNV_X_LOGIN.Position])["MANV"].ToString();
            if (txtLoginName.Text.Trim() == "" || txtPass.Text.Trim() == "")
            {
                MessageBox.Show("Login name và mật khẩu không được trống", "", MessageBoxButtons.OK);
                return;
            }
            if (CHECK_LOGIN_TRUNG(txtLoginName.Text))
            {
                MessageBox.Show("TÊN LOGIN đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                return;
            }          
            try
            {
                Program.myReader.Close();
                string cmd = "EXEC SP_TAOLOGIN '" + txtLoginName.Text + "','" + txtPass.Text + "','" + MANV + "','" + Program.mGroup + "'";
                MessageBox.Show(cmd, "", MessageBoxButtons.OK);
                if (Program.ExecSqlNonQuery(cmd) == 1)
                    MessageBox.Show("Tạo Login '" + txtLoginName.Text + "' Thành Công", "", MessageBoxButtons.OK);
                else
                    return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo login. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNV_X_LOGIN.Enabled =gc_LGINFO1.Enabled = true;
            this.lay_NV_Chua_Co_LoginTableAdapter.Fill(this.DS.Lay_NV_Chua_Co_Login);
            this.thong_Tin_LoginName1TableAdapter.Fill(this.DS.Thong_Tin_LoginName1, Program.mGroup);
            groupBox1.Enabled = false;
        }
        private void cmsXOA_Click(object sender, EventArgs e)
        {
            string LG_NAME= ((DataRowView)bds_LGINFO[bds_LGINFO.Position])["TENLOGIN"].ToString();
            string MANV = ((DataRowView)bds_LGINFO[bds_LGINFO.Position])["MANV"].ToString();
            if (MANV == Program.username)
            {
                MessageBox.Show("Không thể xoá tài khoản '"+ LG_NAME + "' vì bạn đang đăng nhập bằng chính tài khoản này!!", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá TÊN LOGIN '" + LG_NAME + "' ??", "Xác nhận",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                string command = "EXEC Xoa_Login '" + LG_NAME + "','" + MANV + "'";
                if (Program.ExecSqlNonQuery(command) == 1)
                    try
                    {
                        MessageBox.Show("Xoá Login '" + LG_NAME + "' Thành Công", "", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi tạo login. \n" + ex.Message, "", MessageBoxButtons.OK);
                        return;
                    }
            }
            gcNV_X_LOGIN.Enabled = true;
            gcNV_X_LOGIN.Enabled = groupBox1.Enabled = gc_LGINFO1.Enabled = true;
            this.lay_NV_Chua_Co_LoginTableAdapter.Fill(this.DS.Lay_NV_Chua_Co_Login);
            this.thong_Tin_LoginName1TableAdapter.Fill(this.DS.Thong_Tin_LoginName1, Program.mGroup);
        }

        private void cmsTAILAI_Click(object sender, EventArgs e)
        {
            try
            {
                this.thong_Tin_LoginName1TableAdapter.Fill(this.DS.Thong_Tin_LoginName1, Program.mGroup);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.lay_NV_Chua_Co_LoginTableAdapter.Fill(this.DS.Lay_NV_Chua_Co_Login);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

        private void btnCreateAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string MANV = ((DataRowView)bdsNV_X_LOGIN[bdsNV_X_LOGIN.Position])["MANV"].ToString();
            vitri = bdsNV_X_LOGIN.Position;
            txtTrangThai.EditValue = "Mã nhân viên được chọn để tạo login: '" + MANV+" '";
            groupBox1.Enabled = true;
            gcNV_X_LOGIN.Enabled = gc_LGINFO1.Enabled = false;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV_X_LOGIN.CancelEdit();
            bds_LGINFO.CancelEdit();
            gcNV_X_LOGIN.Enabled = gc_LGINFO1.Enabled = true;
            bdsNV_X_LOGIN.Position = vitri;
            txtTrangThai.EditValue = "Chọn nhân viên để tạo tài khoản đăng nhập hệ thống!!";
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.thong_Tin_LoginName1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.thong_Tin_LoginName1TableAdapter.Fill(this.DS.Thong_Tin_LoginName1, Program.mGroup);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void rOLEToolStripLabel_Click(object sender, EventArgs e)
        {

        }

        private void rOLEToolStripTextBox_Click(object sender, EventArgs e)
        {

        }
    }
}
