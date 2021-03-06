using System;
using System.Data;
using System.Windows.Forms;

namespace NganHang.SimpleForm
{
    public partial class frmMoTaiKhoanKH : Form
    {
        int vitri = 0;
        bool btn_Edit_clicked = false;
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
            DS.EnforceConstraints = false;
            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            cmbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            cmbChiNhanh.Enabled = false;     
            if (Program.mGroup == "NganHang")
            {              
                cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled  = false;
            }
            else
            {
                cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled  = true;
            }
            grbThongTinKH.Enabled = gcTK.Enabled = pnlThongTinTaiKhoan.Enabled = false;
        }
        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnlThongTinTaiKhoan.Enabled = true;
            gcTK.Enabled = false;
            bdsTK.AddNew();
            cmsTHEM.Enabled =cmsHIEUCHINH.Enabled = cmsXOA.Enabled= cmsTAILAI.Enabled= false;
            cmsLUU.Enabled = cmsPHUCHOI.Enabled = cmsTHOAT.Enabled = true;
            if (cmbChiNhanh.SelectedIndex == 0)
            {
                txtMACNSet.Text = "BENTHANH";
            }
            else if (cmbChiNhanh.SelectedIndex == 1)
            {
                txtMACNSet.Text = "TANDINH";
            }
            teCMND.Text = txtCMNDKhachHang.Text;
            numbSODU.Value = 0;              
            Program.myReader.Close();
            Program.conn.Close();
        }

        private void cmbChiNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbChiNhanh.SelectedValue.ToString() == "System.Data.DataRowView")
                return;
            Program.servername = cmbChiNhanh.SelectedValue.ToString();

        }

        private void lưuToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            String SOTK = ((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString().TrimEnd();                      
            if (txtSOTK.Text.Trim() == "")
            {
                MessageBox.Show("Số tài khoản không được trống", "", MessageBoxButtons.OK);
                txtSOTK.Focus();
                return;
            }
            if (teCMND.Text.Trim() == "" || teCMND.Text.Length!=10)
            {
                MessageBox.Show("CMND không được trống hoặc không đủ 10 số", "", MessageBoxButtons.OK);
                teCMND.Focus();
                return;
            }
            if (numbSODU.Value <=0 )
            {
                MessageBox.Show("Số dư không được trống hoặc bằng 0", "", MessageBoxButtons.OK);
                numbSODU.Focus();
                return;
            }
            String dt = String.Format("{0:yyyy-MM-dd HH:mm:ss.fff}", DateTime.Now);
            if (btn_Edit_clicked == true && SOTK.TrimEnd() == txtSOTK.Text.TrimEnd())
            {
                Program.ExecSqlNonQuery("EXEC frmMoTaiKhoanKH_OpenAccount '" + txtSOTK.Text.TrimEnd() + "','" + teCMND.Text + "','" + numbSODU.Value + "','" + txtMACNSet.Text + "','" + dt + "'");
                this.khachHang_TTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHang_TTTableAdapter.Fill(this.DS.frmMoTaiKhoanKH_InfoCustomer, txtCMNDKhachHang.Text);
                btn_Edit_clicked = false;
            }
            else
            {
                Program.myReader.Close();
                string strlenh1 = "EXEC frmMoTaiKhoanKH_duplicateSoTK '" + txtSOTK.Text.TrimEnd() + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    MessageBox.Show("Số tài khoản đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }
                Program.myReader.Close();
                Program.ExecSqlNonQuery("EXEC frmMoTaiKhoanKH_OpenAccount '" + txtSOTK.Text.TrimEnd() + "','" + teCMND.Text + "','" + numbSODU.Value + "','" + txtMACNSet.Text + "','" + dt + "'");
                this.khachHang_TTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHang_TTTableAdapter.Fill(this.DS.frmMoTaiKhoanKH_InfoCustomer, txtCMNDKhachHang.Text);
            }
            gcTK.Enabled = true;
            cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTAILAI.Enabled = cmsTHOAT.Enabled = true;
            cmsLUU.Enabled = cmsPHUCHOI.Enabled = false;
            panelControl2.Enabled = pnlThongTinTaiKhoan.Enabled = false;
            this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
            this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
            bdsKH_TT.Position = vitri;
        }

        private void hiệuChỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vitri = bdsKH_TT.Position;
            cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTAILAI.Enabled = cmsTHOAT.Enabled = false;
            cmsLUU.Enabled = cmsPHUCHOI.Enabled = pnlThongTinTaiKhoan.Enabled = true;
            btn_Edit_clicked = true;
            gcTK.Enabled = false; 
        }

        private void xoáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int SOTK = int.Parse(((DataRowView)bdsTK[bdsTK.Position])["SOTK"].ToString().TrimEnd());
            if (bds_GR.Count > 0)
            {
                MessageBox.Show("Không thể xoá tài khoản ngân hàng, vì đã thực hiện giao dịch gửi rút tiền ", "", MessageBoxButtons.OK);
                return;
            }
            if (bds_CTC.Count > 0)
            {
                MessageBox.Show("Không thể xoá tài khoản ngân hàng, vì đã thực hiện giao dịch chuyển tiền", "", MessageBoxButtons.OK);
                return;
            }
            if (bds_CTN.Count > 0)
            {
                MessageBox.Show("Không thể xoá tài khoản ngân hàng, vì đã thực hiện giao dịch nhận tiền", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá tài khoản " + SOTK + " ??", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    Program.myReader.Close();
                    Program.ExecSqlNonQuery("EXEC frmMoTaiKhoanKH_DeleteTaiKhoanKH '" + SOTK + "'");
                    this.khachHang_TTTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.khachHang_TTTableAdapter.Fill(this.DS.frmMoTaiKhoanKH_InfoCustomer, txtCMNDKhachHang.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá tài khoản. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.taiKhoanTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.taiKhoanTableAdapter.Fill(this.DS.TaiKhoan);
                    return;
                }
            }
            if (bdsTK.Count == 0) cmsXOA.Enabled = false; //hết tài khoản rồi thì k xoá đc nữa
        }

        private void phụcHồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bdsTK.CancelEdit();//hai trường hợp: đang thêm bỏ thêm, đang sửa bỏ sửa
            if (cmsTHEM.Enabled == false) bdsTK.Position = vitri;
            gcTK.Enabled = true;

            panelControl2.Enabled = pnlThongTinTaiKhoan.Enabled = false;
            if (bdsTK.Count > 0)
            {
                cmsPHUCHOI.Enabled = cmsTHEM.Enabled =cmsLUU.Enabled = false;
                cmsTHEM.Enabled = cmsTAILAI.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTHOAT.Enabled = true;
            }
            else
            {
                cmsTHEM.Enabled = cmsTAILAI.Enabled = true;
                cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTHOAT.Enabled = cmsPHUCHOI.Enabled =cmsLUU.Enabled= false;
            }
            gcTK.Enabled = true;
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
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtCMNDKhachHang.Text.Trim() == "" || txtCMNDKhachHang.Text.Length != 10)
            {
                MessageBox.Show("CMND không được trống hoặc không đủ 10 số", "", MessageBoxButtons.OK);
                txtCMNDKhachHang.Focus();
                grbThongTinKH.Enabled = gcTK.Enabled = pnlThongTinTaiKhoan.Enabled = false;
                return;
            }
            try
            {
                pnlThongTinTaiKhoan.Enabled = false;
                grbThongTinKH.Enabled = gcTK.Enabled = true;
                this.khachHang_TTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.khachHang_TTTableAdapter.Fill(this.DS.frmMoTaiKhoanKH_InfoCustomer, txtCMNDKhachHang.Text);
                if (bdsTK.Count > 0)
                {
                    cmsLUU.Enabled = cmsPHUCHOI.Enabled = false;
                     cmsTHEM.Enabled = cmsTAILAI.Enabled= cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTHOAT.Enabled = true;
                }
                else
                {
                    cmsTHEM.Enabled = cmsTAILAI.Enabled = true;
                    cmsHIEUCHINH.Enabled = cmsXOA.Enabled = cmsTHOAT.Enabled = cmsPHUCHOI.Enabled= cmsLUU.Enabled = false;
                }
                if (Program.mGroup == "NganHang")
                {
                    cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = false;
                }
                else
                {
                    cmsTHEM.Enabled = cmsHIEUCHINH.Enabled = cmsXOA.Enabled = true;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
