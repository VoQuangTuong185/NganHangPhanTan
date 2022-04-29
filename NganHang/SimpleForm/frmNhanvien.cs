﻿using System;
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
    public partial class frmNhanvien : Form
    {
        int vitri = 0;
        String macn = "";
        bool btn_Add_clicked = false;
        public frmNhanvien()
        {
            InitializeComponent();
        }

        private void nhanVienBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

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
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

                this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN);

                this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
                this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
                //macn = ((DataRowView)bdsNV[0])["MACN"].ToString();
            }
        }
        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            DS.EnforceConstraints = false;
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);

            this.gD_CHUYENTIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_CHUYENTIENTableAdapter.Fill(this.DS.GD_CHUYENTIEN); 
                     
            this.gD_GOIRUTTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gD_GOIRUTTableAdapter.Fill(this.DS.GD_GOIRUT);
            /*VẪN CÒN TIỀM ẨN LỖI CHƯA FIX*/
            macn = ((DataRowView)bdsNV[0])["MACN"].ToString(); //**VẪN CÒN TIỀM ẨN LỖI CHƯA FIX**
            cmbChiNhanh.DataSource = Program.bds_dspm; // sao chép bds_ds đã load ở form đăng nhập
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            panelControl2.Enabled = btnUndo.Enabled = btnSave.Enabled = false;
            if (Program.mGroup == "NganHang")
            {
                cmbChiNhanh.Enabled = true;
                btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnChuyenNV.Enabled = false;
            }
            else
            {
                btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnChuyenNV.Enabled = true;
                cmbChiNhanh.Enabled = false;
            }
        }

        private void nhanVienBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bdsNV.EndEdit();
            this.tableAdapterManager.UpdateAll(this.DS);

        }
        private void btnThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            txtMANV.Focus();
            panelControl2.Enabled = true;
            bdsNV.AddNew();
            txtMACN.Text = macn;//tự gán mã chi nhánh = chi nhánh đang đăng nhập của tài khoản thuộc chi nhánh
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcNV.Enabled = false; txtMACN.Enabled = false;
            btn_Add_clicked = true;
        }
        private void btnSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            String manv = ((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString();
            if (txtMANV.Text.Trim() == "")
            {
                MessageBox.Show("Mã nhân viên không được trống", "", MessageBoxButtons.OK);
                txtMANV.Focus();
                return;
            }
            if (txtHO.Text.Trim() == "")
            {
                MessageBox.Show("Họ nhân viên không được trống", "", MessageBoxButtons.OK);
                txtHO.Focus();
                return;
            }
            if (txtTEN.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được trống", "", MessageBoxButtons.OK);
                txtTEN.Focus();
                return;
            }
            if (txtDIACHI.Text.Trim() == "")
            {
                MessageBox.Show("Địa chỉ không được trống", "", MessageBoxButtons.OK);
                txtDIACHI.Focus();
                return;
            }
            if (!txtSODT.Text.All(Char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ", "", MessageBoxButtons.OK);
                txtSODT.Focus();
                return;
            }
            if (txtSODT.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại nhân viên không đúng 10 chữ số", "", MessageBoxButtons.OK);
                txtSODT.Focus();
                return;
            }
            // Kiểm tra mã nhân viên tồn tại trên site chủ
            //viết 1 SP kiểm tra mã trùng. gọi SP đó thông qua hàm ExecSqlDataReader dưới dạng có hay không!! 
            if (btn_Add_clicked == true || manv != txtMANV.Text)
            {
                Program.myReader.Close();
                string strlenh1 = "EXEC Kiem_Tra_MANV_Trung '" + txtMANV.Text + "'";
                Program.myReader = Program.ExecSqlDataReader(strlenh1);
                Program.myReader.Read();
                if (Program.myReader.HasRows)
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại \nVui lòng nhập lại", "", MessageBoxButtons.OK);
                    return;
                }
            }
            try
            {
                bdsNV.EndEdit(); //kết thúc quá trình hiệu chỉnh (ghi vào datasource)
                bdsNV.ResetCurrentItem();//đưa thông tin lên lưới
                this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                MessageBox.Show("Lưu thành công!!", "", MessageBoxButtons.OK);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhân viên. \n" + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
            gcNV.Enabled = true;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
            panelControl2.Enabled = false;
        }

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpdate_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            vitri = bdsNV.Position;
            panelControl2.Enabled = true;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = false;
            btnSave.Enabled = btnUndo.Enabled = true;
            gcNV.Enabled = false; txtMACN.Enabled = false;
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Int32 manv = 0;
            manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
            if (bdsGR.Count > 0)
            {
                MessageBox.Show("Không thể xoá nhân viên này vì đã giao dịch phiếu gửi rút tiền", "", MessageBoxButtons.OK);
                return;
            }
            if (bdsCT.Count > 0)
            {
                MessageBox.Show("Không thể xoá nhân viên này vì đã giao dịch phiếu chuyển tiền", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn có thật sự muốn xoá nhân viên "+ manv +" ??", "Xác nhận",
                MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    bdsNV.RemoveCurrent();
                    this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
                    this.nhanVienTableAdapter.Update(this.DS.NhanVien);
                    MessageBox.Show("Xoá thành công nhân viên " + manv, "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xoá nhân viên. Bạn hãy xoá lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }
            if (bdsNV.Count == 0) btnDelete.Enabled = false; //hết nhân viên rồi thì k xoá đc nữa
        }
        private void btnReload_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi reload: " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsNV.CancelEdit();//hai trường hợp: đang thêm bỏ thêm, đang sửa bỏ sửa
            if (btnAdd.Enabled == false) bdsNV.Position = vitri;
            gcNV.Enabled = true;
            panelControl2.Enabled = false;
            btnAdd.Enabled = btnUpdate.Enabled = btnDelete.Enabled = btnReload.Enabled = btnExit.Enabled = true;
            btnSave.Enabled = btnUndo.Enabled = false;
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
    }
}
