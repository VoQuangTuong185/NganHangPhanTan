namespace NganHang.SimpleForm
{
    partial class frmChuyenTien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label mACNLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DS = new NganHang.DS();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new NganHang.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.taiKhoanTableAdapter = new NganHang.DSTableAdapters.TaiKhoanTableAdapter();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.txtSoTkNhanTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.frmChuyenTien_InfoReceiverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frmChuyenTien_InfoReceiverTableAdapter = new NganHang.DSTableAdapters.frmChuyenTien_InfoReceiverTableAdapter();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.hOTENTextBox = new System.Windows.Forms.TextBox();
            this.sOTKTextBox = new System.Windows.Forms.TextBox();
            this.cMNDTextBox = new System.Windows.Forms.TextBox();
            this.mACNTextBox = new System.Windows.Forms.TextBox();
            hOTENLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmChuyenTien_InfoReceiverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1718, 41);
            this.panelControl1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(134, 9);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(325, 24);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1718, 30);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "Chọn khách hàng chuyển tiền";
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KhachHang";
            this.bdsKH.DataSource = this.DS;
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.bdsKH;
            this.khachHangGridControl.Location = new System.Drawing.Point(0, 71);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(787, 198);
            this.khachHangGridControl.TabIndex = 14;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colNGAYCAP});
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFind.AlwaysVisible = true;
            this.gridView1.OptionsFind.FindFilterColumns = "CMND";
            this.gridView1.OptionsFind.FindNullPrompt = "Nhập CMND Khách hàng....";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 3;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "FK_KhachHang_TaiKhoan";
            this.bdsTK.DataSource = this.bdsKH;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.bdsTK;
            this.taiKhoanGridControl.Location = new System.Drawing.Point(0, 316);
            this.taiKhoanGridControl.MainView = this.gridView2;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(787, 198);
            this.taiKhoanGridControl.TabIndex = 14;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.taiKhoanGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnTimKiem);
            this.groupControl2.Controls.Add(mACNLabel);
            this.groupControl2.Controls.Add(this.label2);
            this.groupControl2.Controls.Add(this.txtSoTkNhanTien);
            this.groupControl2.Controls.Add(sOTKLabel);
            this.groupControl2.Controls.Add(this.mACNTextBox);
            this.groupControl2.Controls.Add(this.hOTENTextBox);
            this.groupControl2.Controls.Add(cMNDLabel);
            this.groupControl2.Controls.Add(hOTENLabel);
            this.groupControl2.Controls.Add(this.cMNDTextBox);
            this.groupControl2.Controls.Add(this.sOTKTextBox);
            this.groupControl2.Location = new System.Drawing.Point(873, 77);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.ShowCaption = false;
            this.groupControl2.Size = new System.Drawing.Size(818, 437);
            this.groupControl2.TabIndex = 15;
            this.groupControl2.Text = "groupControl2";
            // 
            // txtSoTkNhanTien
            // 
            this.txtSoTkNhanTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTkNhanTien.ForeColor = System.Drawing.Color.Black;
            this.txtSoTkNhanTien.Location = new System.Drawing.Point(282, 15);
            this.txtSoTkNhanTien.Name = "txtSoTkNhanTien";
            this.txtSoTkNhanTien.Size = new System.Drawing.Size(134, 30);
            this.txtSoTkNhanTien.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập số tài khoản người nhận";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frmChuyenTien_InfoReceiverBindingSource
            // 
            this.frmChuyenTien_InfoReceiverBindingSource.DataMember = "frmChuyenTien_InfoReceiver";
            this.frmChuyenTien_InfoReceiverBindingSource.DataSource = this.DS;
            // 
            // frmChuyenTien_InfoReceiverTableAdapter
            // 
            this.frmChuyenTien_InfoReceiverTableAdapter.ClearBeforeFill = true;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(458, 15);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(138, 33);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.ForeColor = System.Drawing.Color.Black;
            hOTENLabel.Location = new System.Drawing.Point(25, 105);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(114, 25);
            hOTENLabel.TabIndex = 20;
            hOTENLabel.Text = "Họ và Tên: ";
            // 
            // hOTENTextBox
            // 
            this.hOTENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmChuyenTien_InfoReceiverBindingSource, "HOTEN", true));
            this.hOTENTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTENTextBox.ForeColor = System.Drawing.Color.Black;
            this.hOTENTextBox.Location = new System.Drawing.Point(159, 105);
            this.hOTENTextBox.Name = "hOTENTextBox";
            this.hOTENTextBox.Size = new System.Drawing.Size(199, 30);
            this.hOTENTextBox.TabIndex = 21;
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.ForeColor = System.Drawing.Color.Black;
            sOTKLabel.Location = new System.Drawing.Point(25, 165);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(121, 25);
            sOTKLabel.TabIndex = 21;
            sOTKLabel.Text = "Số tài khoản";
            // 
            // sOTKTextBox
            // 
            this.sOTKTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmChuyenTien_InfoReceiverBindingSource, "SOTK", true));
            this.sOTKTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sOTKTextBox.ForeColor = System.Drawing.Color.Black;
            this.sOTKTextBox.Location = new System.Drawing.Point(159, 162);
            this.sOTKTextBox.Name = "sOTKTextBox";
            this.sOTKTextBox.Size = new System.Drawing.Size(199, 30);
            this.sOTKTextBox.TabIndex = 22;
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.ForeColor = System.Drawing.Color.Black;
            cMNDLabel.Location = new System.Drawing.Point(414, 108);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(78, 25);
            cMNDLabel.TabIndex = 22;
            cMNDLabel.Text = "CMND:";
            // 
            // cMNDTextBox
            // 
            this.cMNDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmChuyenTien_InfoReceiverBindingSource, "CMND", true));
            this.cMNDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMNDTextBox.ForeColor = System.Drawing.Color.Black;
            this.cMNDTextBox.Location = new System.Drawing.Point(512, 108);
            this.cMNDTextBox.Name = "cMNDTextBox";
            this.cMNDTextBox.Size = new System.Drawing.Size(199, 30);
            this.cMNDTextBox.TabIndex = 23;
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.ForeColor = System.Drawing.Color.Black;
            mACNLabel.Location = new System.Drawing.Point(423, 167);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(78, 25);
            mACNLabel.TabIndex = 23;
            mACNLabel.Text = "MACN:";
            // 
            // mACNTextBox
            // 
            this.mACNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmChuyenTien_InfoReceiverBindingSource, "MACN", true));
            this.mACNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mACNTextBox.ForeColor = System.Drawing.Color.Black;
            this.mACNTextBox.Location = new System.Drawing.Point(512, 167);
            this.mACNTextBox.Name = "mACNTextBox";
            this.mACNTextBox.Size = new System.Drawing.Size(199, 30);
            this.mACNTextBox.TabIndex = 24;
            // 
            // frmChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1718, 717);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.khachHangGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmChuyenTien";
            this.Text = "frmChuyenTien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmChuyenTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frmChuyenTien_InfoReceiverBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsKH;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl khachHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource bdsTK;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.TextBox txtSoTkNhanTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource frmChuyenTien_InfoReceiverBindingSource;
        private DSTableAdapters.frmChuyenTien_InfoReceiverTableAdapter frmChuyenTien_InfoReceiverTableAdapter;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox hOTENTextBox;
        private System.Windows.Forms.TextBox sOTKTextBox;
        private System.Windows.Forms.TextBox cMNDTextBox;
        private System.Windows.Forms.TextBox mACNTextBox;
    }
}