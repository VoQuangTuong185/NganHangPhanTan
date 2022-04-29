namespace NganHang.SimpleForm
{
    partial class frmTaoLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaoLogin));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTrangThai = new DevExpress.XtraEditors.TextEdit();
            this.DS = new NganHang.DS();
            this.bdsNV_X_LOGIN = new System.Windows.Forms.BindingSource(this.components);
            this.lay_NV_Chua_Co_LoginTableAdapter = new NganHang.DSTableAdapters.Lay_NV_Chua_Co_LoginTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.gcNV_X_LOGIN = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThaiXoa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panInput = new DevExpress.XtraEditors.PanelControl();
            this.gc_LGINFO1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsXOA = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTAILAI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTHOAT = new System.Windows.Forms.ToolStripMenuItem();
            this.bds_LGINFO = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTENLOGIN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHOTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colROLE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnCreateAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.label3 = new System.Windows.Forms.Label();
            this.memoLuuY = new DevExpress.XtraEditors.MemoEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.nPass = new System.Windows.Forms.Label();
            this.btnCreateLogin = new System.Windows.Forms.Button();
            this.nName = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.thong_Tin_LoginName1TableAdapter = new NganHang.DSTableAdapters.Thong_Tin_LoginName1TableAdapter();
            this.fillToolStrip = new System.Windows.Forms.ToolStrip();
            this.rOLEToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.rOLEToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV_X_LOGIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV_X_LOGIN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panInput)).BeginInit();
            this.panInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_LGINFO1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds_LGINFO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoLuuY.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.fillToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1478, 41);
            this.panelControl1.TabIndex = 5;
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(148, 8);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(325, 24);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(1, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách nhân viên chưa có tài khoản của chi nhánh";
            // 
            // txtTrangThai
            // 
            this.txtTrangThai.Enabled = false;
            this.txtTrangThai.Location = new System.Drawing.Point(941, 34);
            this.txtTrangThai.Name = "txtTrangThai";
            this.txtTrangThai.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrangThai.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtTrangThai.Properties.Appearance.Options.UseFont = true;
            this.txtTrangThai.Properties.Appearance.Options.UseForeColor = true;
            this.txtTrangThai.Size = new System.Drawing.Size(470, 28);
            this.txtTrangThai.TabIndex = 2;
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsNV_X_LOGIN
            // 
            this.bdsNV_X_LOGIN.DataMember = "Lay_NV_Chua_Co_Login";
            this.bdsNV_X_LOGIN.DataSource = this.DS;
            // 
            // lay_NV_Chua_Co_LoginTableAdapter
            // 
            this.lay_NV_Chua_Co_LoginTableAdapter.ClearBeforeFill = true;
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
            // gcNV_X_LOGIN
            // 
            this.gcNV_X_LOGIN.DataSource = this.bdsNV_X_LOGIN;
            this.gcNV_X_LOGIN.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcNV_X_LOGIN.Enabled = false;
            this.gcNV_X_LOGIN.Location = new System.Drawing.Point(0, 71);
            this.gcNV_X_LOGIN.MainView = this.gridView1;
            this.gcNV_X_LOGIN.Name = "gcNV_X_LOGIN";
            this.gcNV_X_LOGIN.Size = new System.Drawing.Size(1478, 215);
            this.gcNV_X_LOGIN.TabIndex = 6;
            this.gcNV_X_LOGIN.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMANV,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colMACN,
            this.colTrangThaiXoa});
            this.gridView1.GridControl = this.gcNV_X_LOGIN;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsFilter.AllowFilterEditor = false;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "Mã nhân viên";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 0;
            // 
            // colHO
            // 
            this.colHO.Caption = "Họ";
            this.colHO.FieldName = "HO";
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 1;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "Tên";
            this.colTEN.FieldName = "TEN";
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 2;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "Địa chỉ";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "Giới tính";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 4;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 5;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 6;
            // 
            // colTrangThaiXoa
            // 
            this.colTrangThaiXoa.Caption = "Trạng thái xoá";
            this.colTrangThaiXoa.FieldName = "TrangThaiXoa";
            this.colTrangThaiXoa.Name = "colTrangThaiXoa";
            this.colTrangThaiXoa.Visible = true;
            this.colTrangThaiXoa.VisibleIndex = 7;
            // 
            // panInput
            // 
            this.panInput.Controls.Add(this.gc_LGINFO1);
            this.panInput.Controls.Add(this.label3);
            this.panInput.Controls.Add(this.memoLuuY);
            this.panInput.Controls.Add(this.groupBox1);
            this.panInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panInput.Location = new System.Drawing.Point(0, 286);
            this.panInput.Name = "panInput";
            this.panInput.Size = new System.Drawing.Size(1478, 499);
            this.panInput.TabIndex = 7;
            // 
            // gc_LGINFO1
            // 
            this.gc_LGINFO1.ContextMenuStrip = this.contextMenuStrip1;
            this.gc_LGINFO1.DataSource = this.bds_LGINFO;
            this.gc_LGINFO1.Location = new System.Drawing.Point(5, 30);
            this.gc_LGINFO1.MainView = this.gridView2;
            this.gc_LGINFO1.MenuManager = this.barManager1;
            this.gc_LGINFO1.Name = "gc_LGINFO1";
            this.gc_LGINFO1.Size = new System.Drawing.Size(852, 176);
            this.gc_LGINFO1.TabIndex = 12;
            this.gc_LGINFO1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsXOA,
            this.cmsTAILAI,
            this.cmsTHOAT});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 76);
            // 
            // cmsXOA
            // 
            this.cmsXOA.Name = "cmsXOA";
            this.cmsXOA.Size = new System.Drawing.Size(157, 24);
            this.cmsXOA.Text = "Xoá";
            this.cmsXOA.Click += new System.EventHandler(this.cmsXOA_Click);
            // 
            // cmsTAILAI
            // 
            this.cmsTAILAI.Name = "cmsTAILAI";
            this.cmsTAILAI.Size = new System.Drawing.Size(157, 24);
            this.cmsTAILAI.Text = "Tải lại trang";
            this.cmsTAILAI.Click += new System.EventHandler(this.cmsTAILAI_Click);
            // 
            // cmsTHOAT
            // 
            this.cmsTHOAT.Name = "cmsTHOAT";
            this.cmsTHOAT.Size = new System.Drawing.Size(157, 24);
            this.cmsTHOAT.Text = "Thoát";
            // 
            // bds_LGINFO
            // 
            this.bds_LGINFO.DataMember = "Thong_Tin_LoginName1";
            this.bds_LGINFO.DataSource = this.DS;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTENLOGIN,
            this.colMANV1,
            this.colHOTEN,
            this.colROLE});
            this.gridView2.GridControl = this.gc_LGINFO1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colTENLOGIN
            // 
            this.colTENLOGIN.FieldName = "TENLOGIN";
            this.colTENLOGIN.Name = "colTENLOGIN";
            this.colTENLOGIN.Visible = true;
            this.colTENLOGIN.VisibleIndex = 0;
            // 
            // colMANV1
            // 
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 1;
            // 
            // colHOTEN
            // 
            this.colHOTEN.FieldName = "HOTEN";
            this.colHOTEN.Name = "colHOTEN";
            this.colHOTEN.Visible = true;
            this.colHOTEN.VisibleIndex = 2;
            // 
            // colROLE
            // 
            this.colROLE.FieldName = "ROLE";
            this.colROLE.Name = "colROLE";
            this.colROLE.Visible = true;
            this.colROLE.VisibleIndex = 3;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.barButtonItem2,
            this.btnReload,
            this.btnExit,
            this.btnCreateAccount,
            this.barButtonItem3});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.FloatLocation = new System.Drawing.Point(1599, 35);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem2)});
            this.bar1.Offset = 1098;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Tải lại";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Thoát";
            this.barButtonItem2.Id = 1;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnCreateAccount, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Caption = "Tạo tài khoản";
            this.btnCreateAccount.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.Glyph")));
            this.btnCreateAccount.Id = 4;
            this.btnCreateAccount.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCreateAccount.LargeGlyph")));
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateAccount_ItemClick);
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải lại trang";
            this.btnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReload.Glyph")));
            this.btnReload.Id = 2;
            this.btnReload.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnReload.LargeGlyph")));
            this.btnReload.Name = "btnReload";
            this.btnReload.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReload_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Phục hồi";
            this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
            this.barButtonItem3.Id = 5;
            this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExit.Glyph")));
            this.btnExit.Id = 3;
            this.btnExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExit.LargeGlyph")));
            this.btnExit.Name = "btnExit";
            this.btnExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnExit_ItemClick);
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            this.bar3.Visible = false;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1478, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 785);
            this.barDockControlBottom.Size = new System.Drawing.Size(1478, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 755);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1478, 30);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 755);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Danh sách tài khoản của chi nhánh";
            // 
            // memoLuuY
            // 
            this.memoLuuY.EditValue = "";
            this.memoLuuY.Enabled = false;
            this.memoLuuY.Location = new System.Drawing.Point(514, 229);
            this.memoLuuY.Name = "memoLuuY";
            this.memoLuuY.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.memoLuuY.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoLuuY.Properties.Appearance.ForeColor = System.Drawing.Color.Green;
            this.memoLuuY.Properties.Appearance.Options.UseBackColor = true;
            this.memoLuuY.Properties.Appearance.Options.UseFont = true;
            this.memoLuuY.Properties.Appearance.Options.UseForeColor = true;
            this.memoLuuY.Size = new System.Drawing.Size(528, 92);
            this.memoLuuY.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.txtLoginName);
            this.groupBox1.Controls.Add(this.nPass);
            this.groupBox1.Controls.Add(this.btnCreateLogin);
            this.groupBox1.Controls.Add(this.nName);
            this.groupBox1.Controls.Add(this.txtPass);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(889, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 206);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // txtLoginName
            // 
            this.txtLoginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoginName.Location = new System.Drawing.Point(161, 21);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(361, 34);
            this.txtLoginName.TabIndex = 10;
            // 
            // nPass
            // 
            this.nPass.AutoSize = true;
            this.nPass.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nPass.ForeColor = System.Drawing.Color.Black;
            this.nPass.Location = new System.Drawing.Point(20, 105);
            this.nPass.Name = "nPass";
            this.nPass.Size = new System.Drawing.Size(109, 27);
            this.nPass.TabIndex = 10;
            this.nPass.Text = "Mật Khẩu";
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateLogin.ForeColor = System.Drawing.Color.Green;
            this.btnCreateLogin.Location = new System.Drawing.Point(224, 157);
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.Size = new System.Drawing.Size(166, 38);
            this.btnCreateLogin.TabIndex = 12;
            this.btnCreateLogin.Text = "TẠO LOGIN";
            this.btnCreateLogin.UseVisualStyleBackColor = true;
            this.btnCreateLogin.Click += new System.EventHandler(this.btnCreateLogin_Click);
            // 
            // nName
            // 
            this.nName.AutoSize = true;
            this.nName.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nName.ForeColor = System.Drawing.Color.Black;
            this.nName.Location = new System.Drawing.Point(14, 30);
            this.nName.Name = "nName";
            this.nName.Size = new System.Drawing.Size(108, 27);
            this.nName.TabIndex = 8;
            this.nName.Text = "Tài khoản";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(161, 100);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(361, 34);
            this.txtPass.TabIndex = 11;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // thong_Tin_LoginName1TableAdapter
            // 
            this.thong_Tin_LoginName1TableAdapter.ClearBeforeFill = true;
            // 
            // fillToolStrip
            // 
            this.fillToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.fillToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rOLEToolStripLabel,
            this.rOLEToolStripTextBox,
            this.fillToolStripButton});
            this.fillToolStrip.Location = new System.Drawing.Point(0, 286);
            this.fillToolStrip.Name = "fillToolStrip";
            this.fillToolStrip.Size = new System.Drawing.Size(1478, 27);
            this.fillToolStrip.TabIndex = 13;
            this.fillToolStrip.Text = "fillToolStrip";
            this.fillToolStrip.Visible = false;
            // 
            // rOLEToolStripLabel
            // 
            this.rOLEToolStripLabel.Name = "rOLEToolStripLabel";
            this.rOLEToolStripLabel.Size = new System.Drawing.Size(47, 24);
            this.rOLEToolStripLabel.Text = "ROLE:";
            this.rOLEToolStripLabel.Click += new System.EventHandler(this.rOLEToolStripLabel_Click);
            // 
            // rOLEToolStripTextBox
            // 
            this.rOLEToolStripTextBox.Name = "rOLEToolStripTextBox";
            this.rOLEToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            this.rOLEToolStripTextBox.Click += new System.EventHandler(this.rOLEToolStripTextBox_Click);
            // 
            // fillToolStripButton
            // 
            this.fillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillToolStripButton.Name = "fillToolStripButton";
            this.fillToolStripButton.Size = new System.Drawing.Size(32, 24);
            this.fillToolStripButton.Text = "Fill";
            this.fillToolStripButton.Click += new System.EventHandler(this.fillToolStripButton_Click);
            // 
            // frmTaoLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 810);
            this.Controls.Add(this.fillToolStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTrangThai);
            this.Controls.Add(this.panInput);
            this.Controls.Add(this.gcNV_X_LOGIN);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTaoLogin";
            this.Text = "Tạo Login Cho Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaoLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsNV_X_LOGIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcNV_X_LOGIN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panInput)).EndInit();
            this.panInput.ResumeLayout(false);
            this.panInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_LGINFO1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bds_LGINFO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoLuuY.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fillToolStrip.ResumeLayout(false);
            this.fillToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private DS DS;
        private System.Windows.Forms.BindingSource bdsNV_X_LOGIN;
        private DSTableAdapters.Lay_NV_Chua_Co_LoginTableAdapter lay_NV_Chua_Co_LoginTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl gcNV_X_LOGIN;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThaiXoa;
        private DevExpress.XtraEditors.PanelControl panInput;
        private DevExpress.XtraEditors.TextEdit txtTrangThai;
        private DevExpress.XtraEditors.MemoEdit memoLuuY;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label nPass;
        private System.Windows.Forms.Button btnCreateLogin;
        private System.Windows.Forms.Label nName;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsXOA;
        private System.Windows.Forms.ToolStripMenuItem cmsTAILAI;
        private System.Windows.Forms.ToolStripMenuItem cmsTHOAT;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.BarButtonItem btnCreateAccount;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private System.Windows.Forms.ToolStrip fillToolStrip;
        private System.Windows.Forms.ToolStripLabel rOLEToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox rOLEToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillToolStripButton;
        private System.Windows.Forms.BindingSource bds_LGINFO;
        private DSTableAdapters.Thong_Tin_LoginName1TableAdapter thong_Tin_LoginName1TableAdapter;
        private DevExpress.XtraGrid.GridControl gc_LGINFO1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colTENLOGIN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DevExpress.XtraGrid.Columns.GridColumn colHOTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colROLE;
    }
}