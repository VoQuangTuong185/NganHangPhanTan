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
            DS.EnforceConstraints = false;
            this.dS_CHINHANHTableAdapter.Connection.ConnectionString = Program.connstr;
            this.dS_CHINHANHTableAdapter.Fill(this.DS.DS_CHINHANH);
            this.nhanVienTableAdapter.Connection.ConnectionString = Program.connstr;
            this.nhanVienTableAdapter.Fill(this.DS.NhanVien);
            cmbChiNhanh.DataSource = new BindingSource(Program.bds_dspm, string.Empty);
            cmbChiNhanh.DisplayMember = "TENCN";
            cmbChiNhanh.ValueMember = "TENSERVER";
            cmbChiNhanh.SelectedIndex = Program.mChiNhanh;
            cmbChiNhanh.Enabled = false;
        }

        private void btnChuyenNV_Click(object sender, EventArgs e)
        {
            int manv = int.Parse(((DataRowView)bdsNV[bdsNV.Position])["MANV"].ToString());
            string MACN = cmbCNFinal.SelectedValue.ToString();
            MessageBox.Show(MACN, "", MessageBoxButtons.OK);
            if (cmbCNFinal.SelectedIndex == Program.mChiNhanh)
            {
                MessageBox.Show("Chi nhánh chuyển đi phải khác chi nhánh ban đầu", "", MessageBoxButtons.OK);
                return;
            }
            if (MessageBox.Show("Bạn muốn chuyển nhân viên " + manv + " sang chi nhánh " + MACN + "??", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                 Program.ExecSqlNonQuery("EXEC SP_Chuyen_NV '" + manv + "','" + MACN + "'");                 
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
