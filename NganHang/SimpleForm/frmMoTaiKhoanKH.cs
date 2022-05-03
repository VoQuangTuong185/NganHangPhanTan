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
        bool btn_Add_clicked = false;
        public frmMoTaiKhoanKH()
        {
            InitializeComponent();
        }

        private void khachHangBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsKH_TT.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);
        }

        private void frmMoTaiKhoanKH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.KhachHang_TT' table. You can move, or remove it, as needed.
            DS.EnforceConstraints = false;
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            this.khachHang_TTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.khachHang_TTTableAdapter.Fill(this.DS.KhachHang_TT);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);

            cmbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            panelControl2.Enabled = cmsPHUCHOI.Enabled = cmsLUU.Enabled = false ;
            if (cmbChiNhanh.SelectedIndex == 0)
            {
                teMACN.EditValue = "BENTHANH";
            }
            else if(cmbChiNhanh.SelectedIndex == 1)
            {
                teMACN.EditValue = "TANDINH";
            }
           
            if (Program.mGroup == "NganHang")
            {
                cmbChiNhanh.Enabled = true;
                cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled  = false;
                teMACN.EditValue = "Không được sửa!!";
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
            btn_Add_clicked = true;
            gcTK.Enabled = gcKH.Enabled = false;
            cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTAILAI.Enabled = cmsTHOAT.Enabled = false;
            cmsLUU.Enabled = cmsPHUCHOI.Enabled = true;
            vitri = bdsTK.Position;
            bdsTK.AddNew();
            teCMND.Text = ((DataRowView)bdsTK[bdsTK.Position])["CMND"].ToString();
            //teMACN.Text = ((DataRowView)bdsTK[bdsTK.Position])["MACN"].ToString();
            numbSODU.Value = 0;
            MessageBox.Show(cmbChiNhanh.SelectedValue.ToString(), "", MessageBoxButtons.OK);
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
                this.khachHang_TTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHang_TTTableAdapter.Fill(this.DS.KhachHang_TT);
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            }
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
            if (btn_Add_clicked == true || SOTK == txtSOTK.Text)
            {
                MessageBox.Show("EXEC frmMoTaiKhoanKH_OpenAccount '" + txtSOTK.Text + "','" + teCMND.Text + "','" + numbSODU.Value + "','" + teMACN.Text + "','" + dateNgayMoTK.DateTime + "'", "", MessageBoxButtons.OK);
                Program.ExecSqlNonQuery("EXEC frmMoTaiKhoanKH_OpenAccount '" + txtSOTK.Text + "','" + teCMND.Text + "','" + numbSODU.Value + "','" + teMACN.Text + "','" + dateNgayMoTK.DateTime + "'");
                this.khachHang_TTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHang_TTTableAdapter.Fill(this.DS.KhachHang_TT);
                btn_Add_clicked = false;
            }
            else
            {
                Program.myReader.Close();
                string strlenh1 = "EXEC frmMoTaiKhoanKH_duplicateSoTK '" + txtSOTK.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    MessageBox.Show("Số tài khoản đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }
                Program.myReader.Close();
            }
            gcTK.Enabled = gcKH.Enabled = true;
            cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTAILAI.Enabled = cmsTHOAT.Enabled = true;
            cmsLUU.Enabled = cmsPHUCHOI.Enabled = false;
            panelControl2.Enabled = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            bdsTK.Position = vitri;
        }

        private void hiệuChỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitri = bdsTK.Position;
            panelControl2.Enabled = true;
            cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTAILAI.Enabled = cmsTHOAT.Enabled = false;
            cmsLUU.Enabled = cmsPHUCHOI.Enabled = true;
            gcTK.Enabled = gcKH.Enabled = false; 
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SOTK = int.Parse(((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString());
            if (bdsGR.Count > 0)
            {
                MessageBox.Show("Không thể xoá tài khoản này vì đã giao dịch phiếu gửi rút tiền", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCT.Count > 0)
            {
                MessageBox.Show("Không thể xoá tài khoản này vì đã giao dịch phiếu chuyển tiền", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá nhân viên " + SOTK + " ??", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsTK.RemoveCurrent();
                    this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.taiKhoanTableAdapter.Update(this.DS.TaiKhoan);
                    MessageBox.Show("Xoá thành công tài khoản " + SOTK, "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá tài khoản. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
                    bdsTK.Position = bdsTK.Find("MANV", SOTK);
                    return;
                }
            }
            if (bdsTK.Count == 0) cmsXOA.Enabled = false; //hết nhân viên rồi thì k xoá đc nữa
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
                this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
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
    }
}
