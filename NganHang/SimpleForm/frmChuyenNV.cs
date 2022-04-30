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
    public partial class frmChuyenNV : Form
    {
        public frmChuyenNV()
        {
            InitializeComponent();
        }
        private void frmChuyenNV_Load(object sender, EventArgs e)
        {
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            cmbChiNhanh.DataSource = new BindingSource(Program.bds_dspm, string.Empty);
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            cmbChiNhanh.Enabled = false;

            cmbCNFinal.DataSource = new BindingSource(Program.bds_dspm, string.Empty);
            cmbCNFinal.DisplayMember = "TENCN";
            cmbCNFinal.ValueMember = "TENSERVER";
            cmbCNFinal.SelectedIndex = Program.mChiNhanh;
        }

        private void btnChuyenNV_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
            string MACN = ((DataRowView)bdsNV[0])["MACN"].ToString();
            if (cmbCNFinal.SelectedIndex == Program.mChiNhanh)
            {
                MessageBox.Show("Chi nhánh chuyển đi phải khác chi nhánh ban đầu", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn muốn chuyển nhân viên " + manv + " sang chi nhánh " + MACN + "??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                try
                {
                    if (Program.ExecSqlNonQuery("EXEC SP_Chuyen_NV '" + manv + "','" + MACN + "'") == 1)
                        MessageBox.Show("Chuyển Nhân Viên Thành Công!!", "", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("Chuyển Nhân Viên Thất Bại!!", "", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi chuyển nhân viên. Bạn hãy chuyển lại\n" + ex.Message, "", MessageBoxButtons.OK);
                    this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
                    bdsNV.Position = bdsNV.Find("MANV", manv);
                    return;
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
