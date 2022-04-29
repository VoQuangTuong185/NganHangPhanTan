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
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMoTaiKhoanKH));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnSave = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnReload = new DevExpress.XtraBars.BarButtonItem();
            this.btnUndo = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnExit = new DevExpress.XtraBars.BarButtonItem();
            this.btnChuyenNV = new DevExpress.XtraBars.BarButtonItem();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DS = new NganHang.DS();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new NganHang.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gcTK = new DevExpress.XtraGrid.GridControl();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.gvTK = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.numbSODU = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMACN = new System.Windows.Forms.TextBox();
            this.dateNgayMoTK = new DevExpress.XtraEditors.DateEdit();
            this.txtSOTK = new System.Windows.Forms.TextBox();
            this.teCMND = new DevExpress.XtraEditors.TextEdit();
            this.gcKH = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.taiKhoanTableAdapter = new NganHang.DSTableAdapters.TaiKhoanTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsTHEM = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHIEUCHINH = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLUU = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXOA = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTAILAI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPHUCHOI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTHOAT = new System.Windows.Forms.ToolStripMenuItem();
            cMNDLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbSODU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayMoTK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayMoTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.Location = new System.Drawing.Point(61, 148);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(62, 23);
            cMNDLabel.TabIndex = 0;
            cMNDLabel.Text = "CMND";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.Location = new System.Drawing.Point(59, 200);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(125, 23);
            mACNLabel.TabIndex = 2;
            mACNLabel.Text = "Mã chi nhánh";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(61, 49);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(114, 23);
            sOTKLabel.TabIndex = 4;
            sOTKLabel.Text = "Số tài khoản";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(61, 97);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(60, 23);
            sODULabel.TabIndex = 6;
            sODULabel.Text = "Số dư";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Location = new System.Drawing.Point(61, 257);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(168, 23);
            nGAYMOTKLabel.TabIndex = 8;
            nGAYMOTKLabel.Text = "Ngày mở tài khoản";
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
            this.btnAdd,
            this.btnSave,
            this.btnDelete,
            this.btnReload,
            this.btnUndo,
            this.btnExit,
            this.btnUpdate,
            this.btnChuyenNV,
            this.barButtonItem1});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 9;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.FloatLocation = new System.Drawing.Point(-95, 296);
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1)});
            this.bar1.Offset = 139;
            this.bar1.Text = "Tools";
            this.bar1.Visible = false;
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnAdd, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUpdate, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnDelete, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnReload, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btnUndo, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            this.bar2.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Caption = "Thêm";
            this.btnAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("btnAdd.Glyph")));
            this.btnAdd.Id = 0;
            this.btnAdd.Name = "btnAdd";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Hiệu chỉnh";
            this.btnUpdate.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUpdate.Glyph")));
            this.btnUpdate.Id = 6;
            this.btnUpdate.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUpdate.LargeGlyph")));
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnSave
            // 
            this.btnSave.Caption = "Lưu";
            this.btnSave.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSave.Glyph")));
            this.btnSave.Id = 1;
            this.btnSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSave.LargeGlyph")));
            this.btnSave.Name = "btnSave";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xoá";
            this.btnDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnDelete.Glyph")));
            this.btnDelete.Id = 2;
            this.btnDelete.Name = "btnDelete";
            // 
            // btnReload
            // 
            this.btnReload.Caption = "Tải lại";
            this.btnReload.Glyph = ((System.Drawing.Image)(resources.GetObject("btnReload.Glyph")));
            this.btnReload.Id = 3;
            this.btnReload.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnReload.LargeGlyph")));
            this.btnReload.Name = "btnReload";
            // 
            // btnUndo
            // 
            this.btnUndo.Caption = "Phục Hồi";
            this.btnUndo.Glyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.Glyph")));
            this.btnUndo.Id = 4;
            this.btnUndo.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnUndo.LargeGlyph")));
            this.btnUndo.Name = "btnUndo";
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
            this.barDockControlTop.Size = new System.Drawing.Size(1206, 30);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 702);
            this.barDockControlBottom.Size = new System.Drawing.Size(1206, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 30);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 672);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1206, 30);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 672);
            // 
            // btnExit
            // 
            this.btnExit.Caption = "Thoát";
            this.btnExit.Glyph = ((System.Drawing.Image)(resources.GetObject("btnExit.Glyph")));
            this.btnExit.Id = 5;
            this.btnExit.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnExit.LargeGlyph")));
            this.btnExit.Name = "btnExit";
            // 
            // btnChuyenNV
            // 
            this.btnChuyenNV.Caption = "Chuyển nhân viên";
            this.btnChuyenNV.Glyph = ((System.Drawing.Image)(resources.GetObject("btnChuyenNV.Glyph")));
            this.btnChuyenNV.Id = 7;
            this.btnChuyenNV.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnChuyenNV.LargeGlyph")));
            this.btnChuyenNV.Name = "btnChuyenNV";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1206, 41);
            this.panelControl1.TabIndex = 5;
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
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 71);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1206, 30);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "Danh sách khách hàng thuộc chi nhánh";
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
            this.tableAdapterManager.TaiKhoanTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gcTK);
            this.panelControl3.Controls.Add(this.panelControl2);
            this.panelControl3.Controls.Add(this.gcKH);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl3.Location = new System.Drawing.Point(0, 101);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1206, 601);
            this.panelControl3.TabIndex = 20;
            // 
            // gcTK
            // 
            this.gcTK.DataSource = this.bdsTK;
            this.gcTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTK.Location = new System.Drawing.Point(557, 248);
            this.gcTK.MainView = this.gvTK;
            this.gcTK.MenuManager = this.barManager1;
            this.gcTK.Name = "gcTK";
            this.gcTK.Size = new System.Drawing.Size(647, 351);
            this.gcTK.TabIndex = 2;
            this.gcTK.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvTK});
            this.gcTK.Click += new System.EventHandler(this.gcTK_Click);
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "FK_KhachHang_TaiKhoan";
            this.bdsTK.DataSource = this.bdsKH;
            // 
            // gvTK
            // 
            this.gvTK.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND1,
            this.colSODU,
            this.colMACN1,
            this.colNGAYMOTK});
            this.gvTK.GridControl = this.gcTK;
            this.gvTK.Name = "gvTK";
            this.gvTK.OptionsBehavior.ReadOnly = true;
            this.gvTK.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.OptionsColumn.AllowEdit = false;
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.OptionsColumn.AllowEdit = false;
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 1;
            // 
            // colSODU
            // 
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.Name = "colSODU";
            this.colSODU.OptionsColumn.AllowEdit = false;
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            // 
            // colMACN1
            // 
            this.colMACN1.FieldName = "MACN";
            this.colMACN1.Name = "colMACN1";
            this.colMACN1.OptionsColumn.AllowEdit = false;
            this.colMACN1.Visible = true;
            this.colMACN1.VisibleIndex = 3;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.OptionsColumn.AllowEdit = false;
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 4;
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelControl2.Appearance.Options.UseFont = true;
            this.panelControl2.Controls.Add(this.numbSODU);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.txtMACN);
            this.panelControl2.Controls.Add(nGAYMOTKLabel);
            this.panelControl2.Controls.Add(this.dateNgayMoTK);
            this.panelControl2.Controls.Add(sODULabel);
            this.panelControl2.Controls.Add(sOTKLabel);
            this.panelControl2.Controls.Add(this.txtSOTK);
            this.panelControl2.Controls.Add(mACNLabel);
            this.panelControl2.Controls.Add(cMNDLabel);
            this.panelControl2.Controls.Add(this.teCMND);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl2.Location = new System.Drawing.Point(2, 248);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(555, 351);
            this.panelControl2.TabIndex = 1;
            // 
            // numbSODU
            // 
            this.numbSODU.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bdsTK, "SODU", true));
            this.numbSODU.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numbSODU.Location = new System.Drawing.Point(246, 95);
            this.numbSODU.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numbSODU.Name = "numbSODU";
            this.numbSODU.Size = new System.Drawing.Size(243, 29);
            this.numbSODU.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Thông tin tài khoản";
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "MACN", true));
            this.txtMACN.Location = new System.Drawing.Point(246, 197);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.ReadOnly = true;
            this.txtMACN.Size = new System.Drawing.Size(243, 29);
            this.txtMACN.TabIndex = 10;
            // 
            // dateNgayMoTK
            // 
            this.dateNgayMoTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "NGAYMOTK", true));
            this.dateNgayMoTK.EditValue = null;
            this.dateNgayMoTK.Location = new System.Drawing.Point(245, 252);
            this.dateNgayMoTK.MenuManager = this.barManager1;
            this.dateNgayMoTK.Name = "dateNgayMoTK";
            this.dateNgayMoTK.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayMoTK.Properties.Appearance.Options.UseFont = true;
            this.dateNgayMoTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayMoTK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayMoTK.Size = new System.Drawing.Size(244, 28);
            this.dateNgayMoTK.TabIndex = 9;
            // 
            // txtSOTK
            // 
            this.txtSOTK.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SOTK", true));
            this.txtSOTK.Location = new System.Drawing.Point(245, 46);
            this.txtSOTK.Name = "txtSOTK";
            this.txtSOTK.Size = new System.Drawing.Size(245, 29);
            this.txtSOTK.TabIndex = 5;
            // 
            // teCMND
            // 
            this.teCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "CMND", true));
            this.teCMND.Location = new System.Drawing.Point(246, 145);
            this.teCMND.MenuManager = this.barManager1;
            this.teCMND.Name = "teCMND";
            this.teCMND.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCMND.Properties.Appearance.Options.UseFont = true;
            this.teCMND.Properties.ReadOnly = true;
            this.teCMND.Size = new System.Drawing.Size(244, 28);
            this.teCMND.TabIndex = 1;
            this.teCMND.EditValueChanged += new System.EventHandler(this.teCMND_EditValueChanged);
            // 
            // gcKH
            // 
            this.gcKH.DataSource = this.bdsKH;
            this.gcKH.Dock = System.Windows.Forms.DockStyle.Top;
            this.gcKH.Location = new System.Drawing.Point(2, 2);
            this.gcKH.MainView = this.gridView1;
            this.gcKH.MenuManager = this.barManager1;
            this.gcKH.Name = "gcKH";
            this.gcKH.Size = new System.Drawing.Size(1202, 246);
            this.gcKH.TabIndex = 0;
            this.gcKH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colNGAYCAP,
            this.colSODT,
            this.colMACN});
            this.gridView1.GridControl = this.gcKH;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
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
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "Ngày cấp";
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 5;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "Số điện thoại";
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 6;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Mã chi nhánh";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 7;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(158, 172);
            // 
            // cmsTHEM
            // 
            this.cmsTHEM.Name = "cmsTHEM";
            this.cmsTHEM.Size = new System.Drawing.Size(157, 24);
            this.cmsTHEM.Text = "Thêm";
            this.cmsTHEM.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // cmsHIEUCHINH
            // 
            this.cmsHIEUCHINH.Name = "cmsHIEUCHINH";
            this.cmsHIEUCHINH.Size = new System.Drawing.Size(157, 24);
            this.cmsHIEUCHINH.Text = "Hiệu chỉnh";
            this.cmsHIEUCHINH.Click += new System.EventHandler(this.hiệuChỉnhToolStripMenuItem_Click);
            // 
            // cmsLUU
            // 
            this.cmsLUU.Name = "cmsLUU";
            this.cmsLUU.Size = new System.Drawing.Size(157, 24);
            this.cmsLUU.Text = "Lưu";
            this.cmsLUU.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // cmsXOA
            // 
            this.cmsXOA.Name = "cmsXOA";
            this.cmsXOA.Size = new System.Drawing.Size(157, 24);
            this.cmsXOA.Text = "Xoá";
            this.cmsXOA.Click += new System.EventHandler(this.xoáToolStripMenuItem_Click);
            // 
            // cmsTAILAI
            // 
            this.cmsTAILAI.Name = "cmsTAILAI";
            this.cmsTAILAI.Size = new System.Drawing.Size(157, 24);
            this.cmsTAILAI.Text = "Tải lại trang";
            this.cmsTAILAI.Click += new System.EventHandler(this.cmsTAILAI_Click);
            // 
            // cmsPHUCHOI
            // 
            this.cmsPHUCHOI.Name = "cmsPHUCHOI";
            this.cmsPHUCHOI.Size = new System.Drawing.Size(157, 24);
            this.cmsPHUCHOI.Text = "Phục hồi";
            this.cmsPHUCHOI.Click += new System.EventHandler(this.phụcHồiToolStripMenuItem_Click);
            // 
            // cmsTHOAT
            // 
            this.cmsTHOAT.Name = "cmsTHOAT";
            this.cmsTHOAT.Size = new System.Drawing.Size(157, 24);
            this.cmsTHOAT.Text = "Thoát";
            this.cmsTHOAT.Click += new System.EventHandler(this.cmsTHOAT_Click);
            // 
            // frmMoTaiKhoanKH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 727);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMoTaiKhoanKH";
            this.Text = "Mở Tài Khoản Cho Khách Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMoTaiKhoanKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numbSODU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayMoTK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayMoTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnAdd;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnSave;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraBars.BarButtonItem btnReload;
        private DevExpress.XtraBars.BarButtonItem btnUndo;
        private DevExpress.XtraBars.BarButtonItem btnChuyenNV;
        private DevExpress.XtraBars.BarButtonItem btnExit;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.BindingSource bdsKH;
        private DS DS;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DSTableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gcKH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private DevExpress.XtraGrid.GridControl gcTK;
        private DevExpress.XtraGrid.Views.Grid.GridView gvTK;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsTHEM;
        private System.Windows.Forms.ToolStripMenuItem cmsXOA;
        private DevExpress.XtraEditors.TextEdit teCMND;
        private System.Windows.Forms.ToolStripMenuItem cmsLUU;
        private System.Windows.Forms.TextBox txtSOTK;
        private System.Windows.Forms.TextBox txtMACN;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateNgayMoTK;
        private System.Windows.Forms.ToolStripMenuItem cmsHIEUCHINH;
        private System.Windows.Forms.ToolStripMenuItem cmsTAILAI;
        private System.Windows.Forms.ToolStripMenuItem cmsPHUCHOI;
        private System.Windows.Forms.ToolStripMenuItem cmsTHOAT;
        private System.Windows.Forms.NumericUpDown numbSODU;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}