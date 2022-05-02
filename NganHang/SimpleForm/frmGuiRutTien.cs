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
            // TODO: This line of code loads data into the 'dS.KhachHang' table. You can move, or remove it, as needed.
            this.khachHangTableAdapter.Fill(this.DS.KhachHang);

        }
    }
}
