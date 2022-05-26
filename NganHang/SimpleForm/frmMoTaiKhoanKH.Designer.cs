namespace NganHang.SimpleForm
{
    partial class frmMoTaiKhoanKH
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label cMNDLabel1;
            System.Windows.Forms.Label hOTENLabel;
            System.Windows.Forms.Label mACNLabel1;
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCMNDKhachHang = new System.Windows.Forms.TextBox();
            this.DS = new NganHang.DS();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.grbThongTinKH = new System.Windows.Forms.GroupBox();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.bdsKH_TT = new System.Windows.Forms.BindingSource(this.components);
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.gcTK = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsTHEM = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHIEUCHINH = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLUU = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXOA = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTAILAI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPHUCHOI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTHOAT = new System.Windows.Forms.ToolStripMenuItem();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlThongTinTaiKhoan = new System.Windows.Forms.GroupBox();
            this.teMACN = new DevExpress.XtraEditors.TextEdit();
            this.txtSOTK = new System.Windows.Forms.TextBox();
            this.teCMND = new System.Windows.Forms.TextBox();
            this.numbSODU = new System.Windows.Forms.NumericUpDown();
            this.taiKhoanTableAdapter = new NganHang.DSTableAdapters.TaiKhoanTableAdapter();
            this.gD_GOIRUTTableAdapter = new NganHang.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.khachHang_TTTableAdapter = new NganHang.DSTableAdapters.frmMoTaiKhoanKH_InfoCustomerTableAdapter();
            this.bds_CTC = new System.Windows.Forms.BindingSource(this.components);
            this.gD_CHUYENTIENTableAdapter = new NganHang.DSTableAdapters.GD_CHUYENTIENTableAdapter();
            this.bds_CTN = new System.Windows.Forms.BindingSource(this.components);
            this.bds_GR = new System.Windows.Forms.BindingSource(this.components);
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            cMNDLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            cMNDLabel1 = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            mACNLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.grbThongTinKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH_TT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.pnlThongTinTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMACN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbSODU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(479, 82);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(65, 20);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(477, 47);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(114, 20);
            mACNLabel.TabIndex = 2;
            mACNLabel.Text = "Mã chi nhánh:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(20, 43);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(106, 20);
            sOTKLabel.TabIndex = 4;
            sOTKLabel.Text = "Số tài khoản:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODULabel.Location = new System.Drawing.Point(20, 79);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(57, 20);
            sODULabel.TabIndex = 6;
            sODULabel.Text = "Số dư:";
            // 
            // cMNDLabel1
            // 
            cMNDLabel1.AutoSize = true;
            cMNDLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel1.Location = new System.Drawing.Point(53, 38);
            cMNDLabel1.Name = "cMNDLabel1";
            cMNDLabel1.Size = new System.Drawing.Size(56, 21);
            cMNDLabel1.TabIndex = 16;
            cMNDLabel1.Text = "CMND";
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.Location = new System.Drawing.Point(53, 76);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(64, 21);
            hOTENLabel.TabIndex = 17;
            hOTENLabel.Text = "Họ tên ";
            // 
            // mACNLabel1
            // 
            mACNLabel1.AutoSize = true;
            mACNLabel1.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel1.Location = new System.Drawing.Point(55, 114);
            mACNLabel1.Name = "mACNLabel1";
            mACNLabel1.Size = new System.Drawing.Size(146, 21);
            mACNLabel1.TabIndex = 18;
            mACNLabel1.Text = "Chi nhánh đăng ký";
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.btnTimKiem);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtCMNDKhachHang);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 43);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1573, 46);
            this.groupControl1.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 17;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(618, 8);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(125, 33);
            this.btnTimKiem.TabIndex = 32;
            this.btnTimKiem.Text = "Tìm kiếm...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(246, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nhập số CMND khách hàng";
            // 
            // txtCMNDKhachHang
            // 
            this.txtCMNDKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMNDKhachHang.ForeColor = System.Drawing.Color.Black;
            this.txtCMNDKhachHang.Location = new System.Drawing.Point(280, 8);
            this.txtCMNDKhachHang.Name = "txtCMNDKhachHang";
            this.txtCMNDKhachHang.Size = new System.Drawing.Size(312, 28);
            this.txtCMNDKhachHang.TabIndex = 30;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KhachHangTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Controls.Add(this.gcTK);
            this.panelControl3.Controls.Add(this.label3);
            this.panelControl3.Controls.Add(this.pnlThongTinTaiKhoan);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 89);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1573, 612);
            this.panelControl3.TabIndex = 20;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.grbThongTinKH);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(2, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1569, 202);
            this.panelControl2.TabIndex = 22;
            // 
            // grbThongTinKH
            // 
            this.grbThongTinKH.Controls.Add(mACNLabel1);
            this.grbThongTinKH.Controls.Add(this.txtHOTEN);
            this.grbThongTinKH.Controls.Add(this.txtMACN);
            this.grbThongTinKH.Controls.Add(this.txtCMND);
            this.grbThongTinKH.Controls.Add(hOTENLabel);
            this.grbThongTinKH.Controls.Add(cMNDLabel1);
            this.grbThongTinKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinKH.Location = new System.Drawing.Point(471, 18);
            this.grbThongTinKH.Name = "grbThongTinKH";
            this.grbThongTinKH.Size = new System.Drawing.Size(501, 164);
            this.grbThongTinKH.TabIndex = 20;
            this.grbThongTinKH.TabStop = false;
            this.grbThongTinKH.Text = "Thông tin của khách hàng";
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH_TT, "HOTEN", true));
            this.txtHOTEN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOTEN.Location = new System.Drawing.Point(209, 73);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.ReadOnly = true;
            this.txtHOTEN.Size = new System.Drawing.Size(240, 28);
            this.txtHOTEN.TabIndex = 18;
            // 
            // bdsKH_TT
            // 
            this.bdsKH_TT.DataMember = "frmMoTaiKhoanKH_InfoCustomer";
            this.bdsKH_TT.DataSource = this.DS;
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH_TT, "MACN", true));
            this.txtMACN.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMACN.Location = new System.Drawing.Point(209, 111);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.ReadOnly = true;
            this.txtMACN.Size = new System.Drawing.Size(240, 28);
            this.txtMACN.TabIndex = 19;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH_TT, "CMND", true));
            this.txtCMND.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(209, 35);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.ReadOnly = true;
            this.txtCMND.Size = new System.Drawing.Size(240, 28);
            this.txtCMND.TabIndex = 17;
            // 
            // gcTK
            // 
            this.gcTK.ContextMenuStrip = this.contextMenuStrip1;
            this.gcTK.DataSource = this.bdsTK;
            this.gcTK.Location = new System.Drawing.Point(350, 244);
            this.gcTK.MainView = this.gridView2;
            this.gcTK.Name = "gcTK";
            this.gcTK.Size = new System.Drawing.Size(890, 131);
            this.gcTK.TabIndex = 16;
            this.gcTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsTHEM,
            this.cmsHIEUCHINH,
            this.cmsLUU,
            this.cmsXOA,
            this.cmsTAILAI,
            this.cmsPHUCHOI,
            this.cmsTHOAT});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 172);
            // 
            // cmsTHEM
            // 
            this.cmsTHEM.Name = "cmsTHEM";
            this.cmsTHEM.Size = new System.Drawing.Size(180, 24);
            this.cmsTHEM.Text = "Thêm tài khoản";
            this.cmsTHEM.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // cmsHIEUCHINH
            // 
            this.cmsHIEUCHINH.Name = "cmsHIEUCHINH";
            this.cmsHIEUCHINH.Size = new System.Drawing.Size(180, 24);
            this.cmsHIEUCHINH.Text = "Hiệu chỉnh";
            this.cmsHIEUCHINH.Click += new System.EventHandler(this.hiệuChỉnhToolStripMenuItem_Click);
            // 
            // cmsLUU
            // 
            this.cmsLUU.Name = "cmsLUU";
            this.cmsLUU.Size = new System.Drawing.Size(180, 24);
            this.cmsLUU.Text = "Lưu";
            this.cmsLUU.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // cmsXOA
            // 
            this.cmsXOA.Name = "cmsXOA";
            this.cmsXOA.Size = new System.Drawing.Size(180, 24);
            this.cmsXOA.Text = "Xoá";
            this.cmsXOA.Click += new System.EventHandler(this.xoáToolStripMenuItem_Click);
            // 
            // cmsTAILAI
            // 
            this.cmsTAILAI.Name = "cmsTAILAI";
            this.cmsTAILAI.Size = new System.Drawing.Size(180, 24);
            this.cmsTAILAI.Text = "Tải lại trang";
            this.cmsTAILAI.Click += new System.EventHandler(this.cmsTAILAI_Click);
            // 
            // cmsPHUCHOI
            // 
            this.cmsPHUCHOI.Name = "cmsPHUCHOI";
            this.cmsPHUCHOI.Size = new System.Drawing.Size(180, 24);
            this.cmsPHUCHOI.Text = "Phục hồi";
            this.cmsPHUCHOI.Click += new System.EventHandler(this.phụcHồiToolStripMenuItem_Click);
            // 
            // cmsTHOAT
            // 
            this.cmsTHOAT.Name = "cmsTHOAT";
            this.cmsTHOAT.Size = new System.Drawing.Size(180, 24);
            this.cmsTHOAT.Text = "Thoát";
            this.cmsTHOAT.Click += new System.EventHandler(this.cmsTHOAT_Click);
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "FK_frmMoTaiKhoanKH_InfoCustomer_TaiKhoan";
            this.bdsTK.DataSource = this.bdsKH_TT;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.FocusedCell.BackColor = System.Drawing.Color.Lime;
            this.gridView2.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView2.Appearance.FocusedRow.BackColor = System.Drawing.Color.Lime;
            this.gridView2.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colSODU,
            this.colMACN1,
            this.colNGAYMOTK});
            this.gridView2.GridControl = this.gcTK;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colSOTK
            // 
            this.colSOTK.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSOTK.AppearanceHeader.Options.UseFont = true;
            this.colSOTK.Caption = "Số tài khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            // 
            // colSODU
            // 
            this.colSODU.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colSODU.AppearanceHeader.Options.UseFont = true;
            this.colSODU.Caption = "Số dư";
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.GroupFormat.FormatString = "n0";
            this.colSODU.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 1;
            // 
            // colMACN1
            // 
            this.colMACN1.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colMACN1.AppearanceHeader.Options.UseFont = true;
            this.colMACN1.Caption = "Chi nhánh đăng ký";
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 2;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.AppearanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNGAYMOTK.AppearanceHeader.Options.UseFont = true;
            this.colNGAYMOTK.Caption = "Ngày mở";
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(569, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(368, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Danh sách tài khoản của khách hàng";
            // 
            // pnlThongTinTaiKhoan
            // 
            this.pnlThongTinTaiKhoan.Controls.Add(this.teMACN);
            this.pnlThongTinTaiKhoan.Controls.Add(this.txtSOTK);
            this.pnlThongTinTaiKhoan.Controls.Add(sOTKLabel);
            this.pnlThongTinTaiKhoan.Controls.Add(sODULabel);
            this.pnlThongTinTaiKhoan.Controls.Add(mACNLabel);
            this.pnlThongTinTaiKhoan.Controls.Add(this.teCMND);
            this.pnlThongTinTaiKhoan.Controls.Add(this.numbSODU);
            this.pnlThongTinTaiKhoan.Controls.Add(cMNDLabel);
            this.pnlThongTinTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlThongTinTaiKhoan.Location = new System.Drawing.Point(330, 389);
            this.pnlThongTinTaiKhoan.Name = "pnlThongTinTaiKhoan";
            this.pnlThongTinTaiKhoan.Size = new System.Drawing.Size(928, 128);
            this.pnlThongTinTaiKhoan.TabIndex = 21;
            this.pnlThongTinTaiKhoan.TabStop = false;
            this.pnlThongTinTaiKhoan.Text = "Thông tin tài khoản";
            // 
            // teMACN
            // 
            this.teMACN.Location = new System.Drawing.Point(663, 45);
            this.teMACN.Name = "teMACN";
            this.teMACN.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teMACN.Properties.Appearance.Options.UseFont = true;
            this.teMACN.Properties.ReadOnly = true;
            this.teMACN.Size = new System.Drawing.Size(245, 26);
            this.teMACN.TabIndex = 17;
            // 
            // txtSOTK
            // 
            this.txtSOTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SOTK", true));
            this.txtSOTK.Location = new System.Drawing.Point(204, 40);
            this.txtSOTK.Name = "txtSOTK";
            this.txtSOTK.Size = new System.Drawing.Size(243, 30);
            this.txtSOTK.TabIndex = 16;
            // 
            // teCMND
            // 
            this.teCMND.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "CMND", true));
            this.teCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCMND.Location = new System.Drawing.Point(663, 79);
            this.teCMND.Name = "teCMND";
            this.teCMND.ReadOnly = true;
            this.teCMND.Size = new System.Drawing.Size(245, 27);
            this.teCMND.TabIndex = 14;
            // 
            // numbSODU
            // 
            this.numbSODU.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsTK, "SODU", true));
            this.numbSODU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbSODU.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numbSODU.Location = new System.Drawing.Point(205, 77);
            this.numbSODU.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.numbSODU.Name = "numbSODU";
            this.numbSODU.Size = new System.Drawing.Size(243, 27);
            this.numbSODU.TabIndex = 13;
            this.numbSODU.ThousandsSeparator = true;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // khachHang_TTTableAdapter
            // 
            this.khachHang_TTTableAdapter.ClearBeforeFill = true;
            // 
            // bds_CTC
            // 
            this.bds_CTC.DataMember = "FK_GD_CHUYENTIEN_TaiKhoan";
            this.bds_CTC.DataSource = this.bdsTK;
            // 
            // gD_CHUYENTIENTableAdapter
            // 
            this.gD_CHUYENTIENTableAdapter.ClearBeforeFill = true;
            // 
            // bds_CTN
            // 
            this.bds_CTN.DataMember = "FK_GD_CHUYENTIEN_TaiKhoan1";
            this.bds_CTN.DataSource = this.bdsTK;
            // 
            // bds_GR
            // 
            this.bds_GR.DataMember = "FK_GD_GOIRUT_TaiKhoan";
            this.bds_GR.DataSource = this.bdsTK;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(129, 7);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(325, 30);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1573, 43);
            this.panelControl1.TabIndex = 5;
            // 
            // frmMoTaiKhoanKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 701);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmMoTaiKhoanKH";
            this.Text = "Mở Tài Khoản Cho Khách Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMoTaiKhoanKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.grbThongTinKH.ResumeLayout(false);
            this.grbThongTinKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH_TT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.pnlThongTinTaiKhoan.ResumeLayout(false);
            this.pnlThongTinTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teMACN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numbSODU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_CTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds_GR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DS DS;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsTHEM;
        private System.Windows.Forms.ToolStripMenuItem cmsXOA;
        private System.Windows.Forms.ToolStripMenuItem cmsLUU;
        private System.Windows.Forms.ToolStripMenuItem cmsHIEUCHINH;
        private System.Windows.Forms.ToolStripMenuItem cmsTAILAI;
        private System.Windows.Forms.ToolStripMenuItem cmsPHUCHOI;
        private System.Windows.Forms.ToolStripMenuItem cmsTHOAT;
        private System.Windows.Forms.NumericUpDown numbSODU;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private System.Windows.Forms.TextBox teCMND;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource bdsKH_TT;
        private DSTableAdapters.frmMoTaiKhoanKH_InfoCustomerTableAdapter khachHang_TTTableAdapter;
        private DevExpress.XtraGrid.GridControl gcTK;
        private System.Windows.Forms.BindingSource bdsTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCMNDKhachHang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMACN;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtSOTK;
        private System.Windows.Forms.GroupBox grbThongTinKH;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.GroupBox pnlThongTinTaiKhoan;
        private DevExpress.XtraEditors.TextEdit teMACN;
        private System.Windows.Forms.BindingSource bds_CTC;
        private DSTableAdapters.GD_CHUYENTIENTableAdapter gD_CHUYENTIENTableAdapter;
        private System.Windows.Forms.BindingSource bds_CTN;
        private System.Windows.Forms.BindingSource bds_GR;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}