using System;
using System.Data;
using System.Windows.Forms;

namespace NganHang.SimpleForm
{
    public partial class frmCreateLogin : Form
    {
        String macn = "";
        int vitri = 0;
        public frmCreateLogin()
        {
            InitializeComponent();
        }
        private void Reload()
        {
            if (bdsNV_X_LOGIN.Count > 0)
            {
                txtTrangThai.EditValue = "Chọn nhân viên để tạo tài khoản đăng nhập hệ thống!!";
                panInput.Enabled = gc_LGINFO1.Enabled = true;
            }
            else
            {
                txtTrangThai.EditValue = "Hiện tất cả nhân viên trong chi nhánh đã có tài khoản đăng nhập!!";
                panInput.Enabled = gc_LGINFO1.Enabled = false;
            }
            txtLoginName.Clear();
            txtPass.Clear();
        }
        private void frmTaoLogin_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            {
                this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.DS.frmCreateLogin_GetEmployeeNotHaveLogin);
                this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Connection.ConnectionString = Program.connstr;
                this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.DS.frmCreateLogin_GetLoginsOfBranch, Program.mGroup);
                macn = ((DataRowView)bdsNV_X_LOGIN[0])["MACN"].ToString(); 
                cmbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
                cmbChiNhanh.DisplayMember = "TENCN";
                cmbChiNhanh.ValueMember = "TENSERVER";
                cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
                gc_LGINFO1.Enabled = true;
                grFormTaoLogin.Enabled = false;
                cmbChiNhanh.Enabled = false;
                if (Program.mGroup == "NganHang")
                {
                    memoLuuY.EditValue += "Tài khoản có thể: \r\n";
                    memoLuuY.EditValue += "- Xem các báo cáo trên tất cả chi nhánh\r\n";
                    memoLuuY.EditValue += "- Tra cứu dữ liệu trên tất cả chi nhánh\r\n";
                    memoLuuY.EditValue += "- Tạo tài khoản đăng nhập hệ thống thuộc cùng nhóm (NGANHANG)";
                }
                else
                {
                    btnCreateAccount.Enabled = cmsXOA.Enabled = true;
                    memoLuuY.EditValue += "Tài khoản có thể: \r\n";
                    memoLuuY.EditValue += "- Toàn quyền cập nhật dữ liệu trên chi nhánh thuộc về\r\n";
                    memoLuuY.EditValue += "- Tra cứu dữ liệu trên chi nhánh thuộc về\r\n";
                    memoLuuY.EditValue += "- Tạo tài khoản đăng nhập hệ thống thuộc cùng nhóm (CHINHANH)";
                }
                Reload();
            }
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private bool CHECK_LOGIN_TRUNG(string txtLoginName)
        {
            Program.myReader.Close();
            string strlenh1 = "EXEC frmCreateLogin_DuplicateLOGIN '" + txtLoginName + "','" + Program.mGroup + "'";
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
            Program.myReader.Close();
            string cmd = "EXEC frmCreateLogin_CreateLoginForEmployee '" + txtLoginName.Text + "','" + txtPass.Text + "','" + MANV + "','" + Program.mGroup + "'";
            Program.ExecSqlNonQuery(cmd);

            gcNV_X_LOGIN.Enabled = gc_LGINFO1.Enabled = true;
            this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.DS.frmCreateLogin_GetEmployeeNotHaveLogin);
            this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.DS.frmCreateLogin_GetLoginsOfBranch, Program.mGroup);
            grFormTaoLogin.Enabled = false;
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
                string command = "EXEC frmCreateLogin_DeleteLoginForEmployee '" + LG_NAME + "','" + MANV + "'";
                Program.ExecSqlNonQuery(command);
            }
            gc_LGINFO1.Enabled = true;
            gc_LGINFO1.Enabled = grFormTaoLogin.Enabled = gc_LGINFO1.Enabled = true;
            this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.DS.frmCreateLogin_GetEmployeeNotHaveLogin);
            this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.DS.frmCreateLogin_GetLoginsOfBranch, Program.mGroup);
        }

        private void cmsTAILAI_Click(object sender, EventArgs e)
        {
            try
            {
                this.frmCreateLogin_GetLoginsOfBranchTableAdapter.Fill(this.DS.frmCreateLogin_GetLoginsOfBranch, Program.mGroup);
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
                this.frmCreateLogin_GetEmployeeNotHaveLoginTableAdapter.Fill(this.DS.frmCreateLogin_GetEmployeeNotHaveLogin);
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
            grFormTaoLogin.Enabled = true;
            gcNV_X_LOGIN.Enabled = gc_LGINFO1.Enabled = false;
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV_X_LOGIN.CancelEdit();
            bds_LGINFO.CancelEdit();
            gcNV_X_LOGIN.Enabled = gc_LGINFO1.Enabled = true;
            grFormTaoLogin.Enabled = false;
            bdsNV_X_LOGIN.Position = vitri;
            txtTrangThai.EditValue = "Chọn nhân viên để tạo tài khoản đăng nhập hệ thống!!";
        }
    }
}
