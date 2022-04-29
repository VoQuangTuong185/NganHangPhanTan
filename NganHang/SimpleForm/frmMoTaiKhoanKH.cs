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
    public partial class frmMoTaiKhoanKH : Form
    {
        int vitri = 0;
        String macn = "";
        bool btn_Add_clicked = false;
        public frmMoTaiKhoanKH()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void frmMoTaiKhoanKH_Load(object sender, EventArgs e)
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
            panelControl2.Enabled = cmsPHUCHOI.Enabled = cmsLUU.Enabled = false ;
            if (Program.mGroup == "NganHang")
            {
                cmbChiNhanh.Enabled = true;
                cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled  = false;
            }
            else
            {
                cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled  = true;
                cmbChiNhanh.Enabled = false;
            }
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelControl2.Enabled = true;
            gcTK.Enabled = gcKH.Enabled = false;
            cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTAILAI.Enabled = cmsTHOAT.Enabled = false;
            btn_Add_clicked = cmsLUU.Enabled = cmsPHUCHOI.Enabled = true;
            vitri = bdsTK.Position;
            txtMACN.Text = macn;
            bdsTK.AddNew();
            ((DataRowView)bdsTK[bdsTK.Position])["CMND"] = teCMND.Text;
            ((DataRowView)bdsTK[bdsTK.Position])["MACN"] = macn;
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
                //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
        }

        private void teCMND_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String SOTK = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString();
            if (txtSOTK.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được trống", "", MessageBoxButtons.OK);
                txtSOTK.Focus();
                return;
            }
            if (teCMND.Text.Trim() == "")
            {
                MessageBox.Show("CMND không được trống", "", MessageBoxButtons.OK);
                teCMND.Focus();
                return;
            }
            if (numbSODU.Value <=0 )
            {
                MessageBox.Show("Số dư không được trống hoặc bằng 0", "", MessageBoxButtons.OK);
                numbSODU.Focus();
                return;
            }
            if (dateNgayMoTK.DateTime > DateTime.Now || dateNgayMoTK.Text.Trim() == "")
            {
                MessageBox.Show("Ngày cấp CMND khách hàng trống hoặc mốc thời gian là trước hiện tại", "", MessageBoxButtons.OK);
                dateNgayMoTK.Focus();
                return;
            }
            if (btn_Add_clicked == true || SOTK != txtSOTK.Text)
            {
                Program.myReader.Close();
                string strlenh1 = "EXEC Kiem_Tra_SOTK_Trung '" + txtSOTK.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    MessageBox.Show("Số tài khoản đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }
                Program.myReader.Close();
            }
            try
            {
                bdsTK.EndEdit(); //kết thúc quá trình hiệu chỉnh (ghi vào datasource)
                bdsTK.ResetCurrentItem();//đưa thông tin lên lưới
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Update(this.DS.TaiKhoan);
                MessageBox.Show("Lưu thành công!!", "", MessageBoxButtons.OK);               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcTK.Enabled = gcKH.Enabled = true;
            cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTAILAI.Enabled = cmsTHOAT.Enabled = true;
            cmsLUU.Enabled = cmsPHUCHOI.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void hiệuChỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitri = bdsTK.Position;
            panelControl2.Enabled = true;
            cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTAILAI.Enabled = cmsTHOAT.Enabled = false;
            cmsLUU.Enabled = cmsPHUCHOI.Enabled = true;
            gcTK.Enabled = gcKH.Enabled = txtMACN.Enabled = false; 
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsTK.CancelEdit();//hai trường hợp: đang thêm bỏ thêm, đang sửa bỏ sửa
            if (cmsTHEM.Enabled == false) bdsTK.Position = vitri;
            gcTK.Enabled = true;

            panelControl2.Enabled = false;
            cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTAILAI.Enabled = cmsTHOAT.Enabled = true;
            cmsLUU.Enabled = cmsPHUCHOI.Enabled = false;
            gcTK.Enabled = gcKH.Enabled = true;
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

        private void cmsTHOAT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
