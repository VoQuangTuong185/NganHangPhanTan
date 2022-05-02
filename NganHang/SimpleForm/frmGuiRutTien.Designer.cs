namespace NganHang.SimpleForm
{
    partial class frmGuiRutTien
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
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label lOAIGDLabel;
            System.Windows.Forms.Label sOTIENLabel;
            System.Windows.Forms.Label mANVLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.DS = new NganHang.DS();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.khachHangTableAdapter = new NganHang.DSTableAdapters.KhachHangTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.gD_GOIRUTTableAdapter = new NganHang.DSTableAdapters.GD_GOIRUTTableAdapter();
            this.taiKhoanTableAdapter = new NganHang.DSTableAdapters.TaiKhoanTableAdapter();
            this.khachHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYCAP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.taiKhoanGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gD_GOIRUTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gD_GOIRUTGridControl = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsTHEM = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsHIEUCHINH = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLUU = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsXOA = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTAILAI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsPHUCHOI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTHOAT = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTK1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlGD = new DevExpress.XtraEditors.PanelControl();
            this.txtSOTK = new DevExpress.XtraEditors.TextEdit();
            this.txtMANV = new DevExpress.XtraEditors.TextEdit();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtSoTien = new System.Windows.Forms.NumericUpDown();
            this.cmbLoaiGD = new System.Windows.Forms.ComboBox();
            sOTKLabel = new System.Windows.Forms.Label();
            lOAIGDLabel = new System.Windows.Forms.Label();
            sOTIENLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGD)).BeginInit();
            this.pnlGD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien)).BeginInit();
            this.SuspendLayout();
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.Location = new System.Drawing.Point(37, 26);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(59, 20);
            sOTKLabel.TabIndex = 2;
            sOTKLabel.Text = "SOTK:";
            // 
            // lOAIGDLabel
            // 
            lOAIGDLabel.AutoSize = true;
            lOAIGDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOAIGDLabel.Location = new System.Drawing.Point(37, 66);
            lOAIGDLabel.Name = "lOAIGDLabel";
            lOAIGDLabel.Size = new System.Drawing.Size(78, 20);
            lOAIGDLabel.TabIndex = 4;
            lOAIGDLabel.Text = "LOAIGD:";
            // 
            // sOTIENLabel
            // 
            sOTIENLabel.AutoSize = true;
            sOTIENLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTIENLabel.Location = new System.Drawing.Point(403, 26);
            sOTIENLabel.Name = "sOTIENLabel";
            sOTIENLabel.Size = new System.Drawing.Size(75, 20);
            sOTIENLabel.TabIndex = 8;
            sOTIENLabel.Text = "SOTIEN:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mANVLabel.Location = new System.Drawing.Point(403, 66);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(62, 20);
            mANVLabel.TabIndex = 10;
            mANVLabel.Text = "MANV:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1586, 41);
            this.panelControl1.TabIndex = 6;
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
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 41);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1586, 30);
            this.groupControl1.TabIndex = 12;
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
            this.tableAdapterManager.GD_GOIRUTTableAdapter = this.gD_GOIRUTTableAdapter;
            this.tableAdapterManager.KhachHangTableAdapter = this.khachHangTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.TaiKhoanTableAdapter = this.taiKhoanTableAdapter;
            this.tableAdapterManager.UpdateOrder = NganHang.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // gD_GOIRUTTableAdapter
            // 
            this.gD_GOIRUTTableAdapter.ClearBeforeFill = true;
            // 
            // taiKhoanTableAdapter
            // 
            this.taiKhoanTableAdapter.ClearBeforeFill = true;
            // 
            // khachHangGridControl
            // 
            this.khachHangGridControl.DataSource = this.bdsKH;
            this.khachHangGridControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.khachHangGridControl.Location = new System.Drawing.Point(0, 71);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(1586, 174);
            this.khachHangGridControl.TabIndex = 13;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colNGAYCAP,
            this.colSODT});
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
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
            // colDIACHI
            // 
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 3;
            // 
            // colNGAYCAP
            // 
            this.colNGAYCAP.FieldName = "NGAYCAP";
            this.colNGAYCAP.Name = "colNGAYCAP";
            this.colNGAYCAP.Visible = true;
            this.colNGAYCAP.VisibleIndex = 4;
            // 
            // colSODT
            // 
            this.colSODT.FieldName = "SODT";
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 5;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "FK_KhachHang_TaiKhoan";
            this.bdsTK.DataSource = this.bdsKH;
            // 
            // taiKhoanGridControl
            // 
            this.taiKhoanGridControl.DataSource = this.bdsTK;
            this.taiKhoanGridControl.Location = new System.Drawing.Point(12, 290);
            this.taiKhoanGridControl.MainView = this.gridView2;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(656, 150);
            this.taiKhoanGridControl.TabIndex = 13;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colCMND1,
            this.colSODU,
            this.colMACN});
            this.gridView2.GridControl = this.taiKhoanGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm;
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colSOTK
            // 
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            // 
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 1;
            // 
            // colSODU
            // 
            this.colSODU.DisplayFormat.FormatString = "n0";
            this.colSODU.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.FieldName = "SODU";
            this.colSODU.GroupFormat.FormatString = "n0";
            this.colSODU.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 2;
            // 
            // colMACN
            // 
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 3;
            // 
            // panelControl2
            // 
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl2.Location = new System.Drawing.Point(0, 245);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(1586, 39);
            this.panelControl2.TabIndex = 14;
            // 
            // gD_GOIRUTBindingSource
            // 
            this.gD_GOIRUTBindingSource.DataMember = "FK_GD_GOIRUT_TaiKhoan";
            this.gD_GOIRUTBindingSource.DataSource = this.bdsTK;
            // 
            // gD_GOIRUTGridControl
            // 
            this.gD_GOIRUTGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.gD_GOIRUTGridControl.DataSource = this.gD_GOIRUTBindingSource;
            this.gD_GOIRUTGridControl.Location = new System.Drawing.Point(808, 290);
            this.gD_GOIRUTGridControl.MainView = this.gridView3;
            this.gD_GOIRUTGridControl.Name = "gD_GOIRUTGridControl";
            this.gD_GOIRUTGridControl.Size = new System.Drawing.Size(693, 150);
            this.gD_GOIRUTGridControl.TabIndex = 14;
            this.gD_GOIRUTGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 200);
            // 
            // cmsTHEM
            // 
            this.cmsTHEM.Name = "cmsTHEM";
            this.cmsTHEM.Size = new System.Drawing.Size(175, 24);
            this.cmsTHEM.Text = "Thêm";
            this.cmsTHEM.Click += new System.EventHandler(this.cmsTHEM_Click);
            // 
            // cmsHIEUCHINH
            // 
            this.cmsHIEUCHINH.Name = "cmsHIEUCHINH";
            this.cmsHIEUCHINH.Size = new System.Drawing.Size(175, 24);
            this.cmsHIEUCHINH.Text = "Hiệu chỉnh";
            // 
            // cmsLUU
            // 
            this.cmsLUU.Name = "cmsLUU";
            this.cmsLUU.Size = new System.Drawing.Size(175, 24);
            this.cmsLUU.Text = "Lưu";
            this.cmsLUU.Click += new System.EventHandler(this.cmsLUU_Click);
            // 
            // cmsXOA
            // 
            this.cmsXOA.Name = "cmsXOA";
            this.cmsXOA.Size = new System.Drawing.Size(175, 24);
            this.cmsXOA.Text = "Xoá";
            // 
            // cmsTAILAI
            // 
            this.cmsTAILAI.Name = "cmsTAILAI";
            this.cmsTAILAI.Size = new System.Drawing.Size(175, 24);
            this.cmsTAILAI.Text = "Tải lại trang";
            this.cmsTAILAI.Click += new System.EventHandler(this.cmsTAILAI_Click);
            // 
            // cmsPHUCHOI
            // 
            this.cmsPHUCHOI.Name = "cmsPHUCHOI";
            this.cmsPHUCHOI.Size = new System.Drawing.Size(175, 24);
            this.cmsPHUCHOI.Text = "Phục hồi";
            this.cmsPHUCHOI.Click += new System.EventHandler(this.cmsPHUCHOI_Click);
            // 
            // cmsTHOAT
            // 
            this.cmsTHOAT.Name = "cmsTHOAT";
            this.cmsTHOAT.Size = new System.Drawing.Size(175, 24);
            this.cmsTHOAT.Text = "Thoát";
            this.cmsTHOAT.Click += new System.EventHandler(this.cmsTHOAT_Click);
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAGD,
            this.colSOTK1,
            this.colLOAIGD,
            this.colNGAYGD,
            this.colSOTIEN,
            this.colMANV});
            this.gridView3.GridControl = this.gD_GOIRUTGridControl;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colMAGD
            // 
            this.colMAGD.FieldName = "MAGD";
            this.colMAGD.Name = "colMAGD";
            this.colMAGD.Visible = true;
            this.colMAGD.VisibleIndex = 0;
            // 
            // colSOTK1
            // 
            this.colSOTK1.FieldName = "SOTK";
            this.colSOTK1.Name = "colSOTK1";
            this.colSOTK1.Visible = true;
            this.colSOTK1.VisibleIndex = 1;
            // 
            // colLOAIGD
            // 
            this.colLOAIGD.FieldName = "LOAIGD";
            this.colLOAIGD.Name = "colLOAIGD";
            this.colLOAIGD.Visible = true;
            this.colLOAIGD.VisibleIndex = 2;
            // 
            // colNGAYGD
            // 
            this.colNGAYGD.FieldName = "NGAYGD";
            this.colNGAYGD.Name = "colNGAYGD";
            this.colNGAYGD.Visible = true;
            this.colNGAYGD.VisibleIndex = 3;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.DisplayFormat.FormatString = "n0";
            this.colSOTIEN.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.GroupFormat.FormatString = "n0";
            this.colSOTIEN.GroupFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 4;
            // 
            // colMANV
            // 
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 5;
            // 
            // pnlGD
            // 
            this.pnlGD.Controls.Add(this.txtSOTK);
            this.pnlGD.Controls.Add(this.txtMANV);
            this.pnlGD.Controls.Add(this.btnXacNhan);
            this.pnlGD.Controls.Add(mANVLabel);
            this.pnlGD.Controls.Add(sOTIENLabel);
            this.pnlGD.Controls.Add(this.txtSoTien);
            this.pnlGD.Controls.Add(lOAIGDLabel);
            this.pnlGD.Controls.Add(this.cmbLoaiGD);
            this.pnlGD.Controls.Add(sOTKLabel);
            this.pnlGD.Location = new System.Drawing.Point(534, 457);
            this.pnlGD.Name = "pnlGD";
            this.pnlGD.Size = new System.Drawing.Size(631, 151);
            this.pnlGD.TabIndex = 15;
            // 
            // txtSOTK
            // 
            this.txtSOTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gD_GOIRUTBindingSource, "SOTK", true));
            this.txtSOTK.Location = new System.Drawing.Point(126, 21);
            this.txtSOTK.Name = "txtSOTK";
            this.txtSOTK.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOTK.Properties.Appearance.Options.UseFont = true;
            this.txtSOTK.Properties.ReadOnly = true;
            this.txtSOTK.Size = new System.Drawing.Size(121, 26);
            this.txtSOTK.TabIndex = 14;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.gD_GOIRUTBindingSource, "MANV", true));
            this.txtMANV.Location = new System.Drawing.Point(497, 63);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANV.Properties.Appearance.Options.UseFont = true;
            this.txtMANV.Properties.ReadOnly = true;
            this.txtMANV.Size = new System.Drawing.Size(100, 26);
            this.txtMANV.TabIndex = 13;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.Location = new System.Drawing.Point(250, 107);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(140, 39);
            this.btnXacNhan.TabIndex = 12;
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtSoTien
            // 
            this.txtSoTien.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.gD_GOIRUTBindingSource, "SOTIEN", true));
            this.txtSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTien.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtSoTien.Location = new System.Drawing.Point(497, 24);
            this.txtSoTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtSoTien.Name = "txtSoTien";
            this.txtSoTien.Size = new System.Drawing.Size(120, 27);
            this.txtSoTien.TabIndex = 9;
            this.txtSoTien.ThousandsSeparator = true;
            // 
            // cmbLoaiGD
            // 
            this.cmbLoaiGD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.gD_GOIRUTBindingSource, "LOAIGD", true));
            this.cmbLoaiGD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoaiGD.FormattingEnabled = true;
            this.cmbLoaiGD.Items.AddRange(new object[] {
            "Gửi tiền",
            "Rút tiền"});
            this.cmbLoaiGD.Location = new System.Drawing.Point(126, 63);
            this.cmbLoaiGD.Name = "cmbLoaiGD";
            this.cmbLoaiGD.Size = new System.Drawing.Size(121, 28);
            this.cmbLoaiGD.TabIndex = 5;
            this.cmbLoaiGD.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiGD_SelectedIndexChanged);
            // 
            // frmGuiRutTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1586, 656);
            this.Controls.Add(this.pnlGD);
            this.Controls.Add(this.gD_GOIRUTGridControl);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.khachHangGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmGuiRutTien";
            this.Text = "frmGuiRutTien";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmGuiRutTien_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gD_GOIRUTGridControl)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGD)).EndInit();
            this.pnlGD.ResumeLayout(false);
            this.pnlGD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoTien)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYCAP;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DSTableAdapters.TaiKhoanTableAdapter taiKhoanTableAdapter;
        private System.Windows.Forms.BindingSource bdsTK;
        private DevExpress.XtraGrid.GridControl taiKhoanGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DSTableAdapters.GD_GOIRUTTableAdapter gD_GOIRUTTableAdapter;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.BindingSource gD_GOIRUTBindingSource;
        private DevExpress.XtraGrid.GridControl gD_GOIRUTGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colMAGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK1;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGD;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraEditors.PanelControl pnlGD;
        private System.Windows.Forms.NumericUpDown txtSoTien;
        private System.Windows.Forms.ComboBox cmbLoaiGD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsTHEM;
        private System.Windows.Forms.ToolStripMenuItem cmsHIEUCHINH;
        private System.Windows.Forms.ToolStripMenuItem cmsLUU;
        private System.Windows.Forms.ToolStripMenuItem cmsXOA;
        private System.Windows.Forms.ToolStripMenuItem cmsTAILAI;
        private System.Windows.Forms.ToolStripMenuItem cmsPHUCHOI;
        private System.Windows.Forms.ToolStripMenuItem cmsTHOAT;
        private System.Windows.Forms.Button btnXacNhan;
        private DevExpress.XtraEditors.TextEdit txtMANV;
        private DevExpress.XtraEditors.TextEdit txtSOTK;
    }
}