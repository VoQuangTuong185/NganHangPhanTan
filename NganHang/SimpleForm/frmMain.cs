using DevExpress.Xpo;
using NganHang.SimpleForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NganHang
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            rib_BaoCao.Visible = rib_DanhMuc.Visible = rib_NghiepVu.Visible = false;

            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            btnCreateLogin.Enabled = btnLogout.Enabled = false;
        }

        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void frmLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }
        }
        public void HienThiMenu()
        {
            MANV.Text = "MÃ NV: " + Program.username;
            HOTEN.Text = "Họ tên nhân viên: " + Program.mHoten;
            NHOM.Text = "Nhóm: " + Program.mGroup;
            //phân quyền
            rib_BaoCao.Visible = rib_DanhMuc.Visible = rib_NghiepVu.Visible = btnCreateLogin.Enabled = btnLogout.Enabled = true;
            frmLogin.Enabled = false;
            //tiếp tục "if" trên Program.mGroup để bật/tắt các nút lệnh trên menu chính
        }

        private void btnEmployeeManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
        private void btnLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Xác nhận đăng xuất khỏi tài khoản \n- Mã NV: " + Program.username + "\n- Tên: " + Program.mHoten + "\n- Nhóm: " + Program.mGroup, "Xác nhận",MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                foreach (Form form in MdiChildren)
                {
                    form.Close();
                }
                // Clear user info in status bar
                Program.frmChinh.MANV.Text = "Mã nhân viên: trống";
                Program.frmChinh.HOTEN.Text = "Họ tên: trống";
                Program.frmChinh.NHOM.Text = "Nhóm: trống";             
                rib_DanhMuc.Visible = rib_NghiepVu.Visible = rib_BaoCao.Visible = btnCreateLogin.Enabled = btnLogout.Enabled = false;
                frmLogin.Enabled = true;
            }
            Form frm = this.CheckExists(typeof(frmLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmLogin f = new frmLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnEmployeeManage_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmNhanVien));
            if (frm != null) frm.Activate();
            else
            {
                frmNhanVien f = new frmNhanVien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCustomerManage_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmKhachHang));
            if (frm != null) frm.Activate();
            else
            {
                frmKhachHang f = new frmKhachHang();
                f.MdiParent = this;
                f.Show();
            }
        }
        private void btnOpenCustomerAccount_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmMoTaiKhoanKH));
            if (frm != null) frm.Activate();
            else
            {
                frmMoTaiKhoanKH f = new frmMoTaiKhoanKH();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnCreateLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmCreateLogin));
            if (frm != null) frm.Activate();
            else
            {
                frmCreateLogin f = new frmCreateLogin();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnSaveCashService_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGuiRutTien));
            if (frm != null) frm.Activate();
            else
            {
                frmGuiRutTien f = new frmGuiRutTien();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnOpenedAccountReport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmLietKeTaiKhoan));
            if (frm != null) frm.Activate();
            else
            {
                frmLietKeTaiKhoan f = new frmLietKeTaiKhoan();
                f.MdiParent = this;
                f.Show();
            }
        }
    }
}
