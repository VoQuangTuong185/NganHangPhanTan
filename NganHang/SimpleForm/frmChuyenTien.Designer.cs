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
            System.Windows.Forms.Label cMNDLabel1;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label label7;
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsTHEM = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTAILAI = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTHOAT = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnlGD = new DevExpress.XtraEditors.GroupControl();
            this.btnUndo = new System.Windows.Forms.Button();
            this.tENTextBox = new System.Windows.Forms.TextBox();
            this.hOTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMANV = new System.Windows.Forms.TextBox();
            this.sODUTextBox = new System.Windows.Forms.TextBox();
            this.cMNDTextBox1 = new System.Windows.Forms.TextBox();
            this.txtSoTKChuyen = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nuSoTien = new System.Windows.Forms.NumericUpDown();
            this.btnChuyenTien = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSoTkNhanTien = new System.Windows.Forms.TextBox();
            this.mACNTextBox = new System.Windows.Forms.TextBox();
            this.frmChuyenTien_InfoReceiverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOTENTextBox = new System.Windows.Forms.TextBox();
            this.cMNDTextBox = new System.Windows.Forms.TextBox();
            this.txtSoTKNhan = new System.Windows.Forms.TextBox();
            this.frmChuyenTien_InfoReceiverTableAdapter = new NganHang.DSTableAdapters.frmChuyenTien_InfoReceiverTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            hOTENLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            cMNDLabel1 = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taiKhoanGridControl)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGD)).BeginInit();
            this.pnlGD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoTien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmChuyenTien_InfoReceiverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.ForeColor = System.Drawing.Color.Black;
            hOTENLabel.Location = new System.Drawing.Point(22, 286);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(114, 25);
            hOTENLabel.TabIndex = 20;
            hOTENLabel.Text = "Họ và Tên: ";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sOTKLabel.ForeColor = System.Drawing.Color.Black;
            sOTKLabel.Location = new System.Drawing.Point(22, 346);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(127, 25);
            sOTKLabel.TabIndex = 21;
            sOTKLabel.Text = "Số tài khoản:";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.ForeColor = System.Drawing.Color.Black;
            cMNDLabel.Location = new System.Drawing.Point(394, 284);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(78, 25);
            cMNDLabel.TabIndex = 22;
            cMNDLabel.Text = "CMND:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mACNLabel.ForeColor = System.Drawing.Color.Black;
            mACNLabel.Location = new System.Drawing.Point(394, 343);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(105, 25);
            mACNLabel.TabIndex = 23;
            mACNLabel.Text = "Chi Nhánh";
            // 
            // cMNDLabel1
            // 
            cMNDLabel1.AutoSize = true;
            cMNDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel1.Location = new System.Drawing.Point(394, 121);
            cMNDLabel1.Name = "cMNDLabel1";
            cMNDLabel1.Size = new System.Drawing.Size(78, 25);
            cMNDLabel1.TabIndex = 31;
            cMNDLabel1.Text = "CMND:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sODULabel.Location = new System.Drawing.Point(395, 173);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(70, 25);
            sODULabel.TabIndex = 32;
            sODULabel.Text = "Số dư:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOLabel.Location = new System.Drawing.Point(19, 121);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(109, 25);
            hOLabel.TabIndex = 36;
            hOLabel.Text = "Họ và Tên:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(19, 171);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(127, 25);
            label7.TabIndex = 39;
            label7.Text = "Số tài khoản:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1541, 41);
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
            this.groupControl1.Size = new System.Drawing.Size(1541, 30);
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
            this.khachHangGridControl.Location = new System.Drawing.Point(0, 97);
            this.khachHangGridControl.MainView = this.gridView1;
            this.khachHangGridControl.Name = "khachHangGridControl";
            this.khachHangGridControl.Size = new System.Drawing.Size(682, 198);
            this.khachHangGridControl.TabIndex = 14;
            this.khachHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.Lime;
            this.gridView1.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.Lime;
            this.gridView1.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colNGAYCAP});
            this.gridView1.GridControl = this.khachHangGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
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
            // colNGAYCAP
            // 
            this.colNGAYCAP.Caption = "Ngày cấp";
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
            this.taiKhoanGridControl.ContextMenuStrip = this.contextMenuStrip1;
            this.taiKhoanGridControl.DataSource = this.bdsTK;
            this.taiKhoanGridControl.Location = new System.Drawing.Point(0, 362);
            this.taiKhoanGridControl.MainView = this.gridView2;
            this.taiKhoanGridControl.Name = "taiKhoanGridControl";
            this.taiKhoanGridControl.Size = new System.Drawing.Size(682, 234);
            this.taiKhoanGridControl.TabIndex = 14;
            this.taiKhoanGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsTHEM,
            this.cmsTAILAI,
            this.cmsTHOAT});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(261, 76);
            // 
            // cmsTHEM
            // 
            this.cmsTHEM.Name = "cmsTHEM";
            this.cmsTHEM.Size = new System.Drawing.Size(260, 24);
            this.cmsTHEM.Text = "Thêm giao dịch chuyển tiền";
            this.cmsTHEM.Click += new System.EventHandler(this.cmsTHEM_Click);
            // 
            // cmsTAILAI
            // 
            this.cmsTAILAI.Name = "cmsTAILAI";
            this.cmsTAILAI.Size = new System.Drawing.Size(260, 24);
            this.cmsTAILAI.Text = "Tải lại trang";
            this.cmsTAILAI.Click += new System.EventHandler(this.cmsTAILAI_Click);
            // 
            // cmsTHOAT
            // 
            this.cmsTHOAT.Name = "cmsTHOAT";
            this.cmsTHOAT.Size = new System.Drawing.Size(260, 24);
            this.cmsTHOAT.Text = "Thoát";
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
            this.colCMND1,
            this.colNGAYMOTK,
            this.colMACN});
            this.gridView2.GridControl = this.taiKhoanGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            this.gridView2.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView2.OptionsFind.AlwaysVisible = true;
            this.gridView2.OptionsFind.FindFilterColumns = "SOTK";
            this.gridView2.OptionsFind.FindNullPrompt = "Nhập vào số tài khoản....";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "Số tài khoản";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            // 
            // colSODU
            // 
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
            // colCMND1
            // 
            this.colCMND1.FieldName = "CMND";
            this.colCMND1.Name = "colCMND1";
            this.colCMND1.Visible = true;
            this.colCMND1.VisibleIndex = 2;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "Ngày mở ";
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 3;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "Chi nhánh mở ";
            this.colMACN.FieldName = "MACN";
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 4;
            // 
            // pnlGD
            // 
            this.pnlGD.Controls.Add(this.btnUndo);
            this.pnlGD.Controls.Add(label7);
            this.pnlGD.Controls.Add(this.tENTextBox);
            this.pnlGD.Controls.Add(hOLabel);
            this.pnlGD.Controls.Add(this.hOTextBox);
            this.pnlGD.Controls.Add(this.label6);
            this.pnlGD.Controls.Add(this.txtMANV);
            this.pnlGD.Controls.Add(sODULabel);
            this.pnlGD.Controls.Add(this.sODUTextBox);
            this.pnlGD.Controls.Add(cMNDLabel1);
            this.pnlGD.Controls.Add(this.cMNDTextBox1);
            this.pnlGD.Controls.Add(this.txtSoTKChuyen);
            this.pnlGD.Controls.Add(this.label5);
            this.pnlGD.Controls.Add(this.nuSoTien);
            this.pnlGD.Controls.Add(this.btnChuyenTien);
            this.pnlGD.Controls.Add(this.label4);
            this.pnlGD.Controls.Add(this.label3);
            this.pnlGD.Controls.Add(this.btnTimKiem);
            this.pnlGD.Controls.Add(mACNLabel);
            this.pnlGD.Controls.Add(this.label2);
            this.pnlGD.Controls.Add(this.txtSoTkNhanTien);
            this.pnlGD.Controls.Add(sOTKLabel);
            this.pnlGD.Controls.Add(this.mACNTextBox);
            this.pnlGD.Controls.Add(this.hOTENTextBox);
            this.pnlGD.Controls.Add(cMNDLabel);
            this.pnlGD.Controls.Add(hOTENLabel);
            this.pnlGD.Controls.Add(this.cMNDTextBox);
            this.pnlGD.Controls.Add(this.txtSoTKNhan);
            this.pnlGD.Location = new System.Drawing.Point(762, 97);
            this.pnlGD.Name = "pnlGD";
            this.pnlGD.ShowCaption = false;
            this.pnlGD.Size = new System.Drawing.Size(734, 499);
            this.pnlGD.TabIndex = 15;
            this.pnlGD.Text = "groupControl2";
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.Black;
            this.btnUndo.Location = new System.Drawing.Point(533, 412);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(143, 33);
            this.btnUndo.TabIndex = 40;
            this.btnUndo.Text = "Thoát giao dịch";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // tENTextBox
            // 
            this.tENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "TEN", true));
            this.tENTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tENTextBox.Location = new System.Drawing.Point(321, 118);
            this.tENTextBox.Name = "tENTextBox";
            this.tENTextBox.ReadOnly = true;
            this.tENTextBox.Size = new System.Drawing.Size(67, 30);
            this.tENTextBox.TabIndex = 38;
            // 
            // hOTextBox
            // 
            this.hOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsKH, "HO", true));
            this.hOTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTextBox.Location = new System.Drawing.Point(155, 118);
            this.hOTextBox.Name = "hOTextBox";
            this.hOTextBox.ReadOnly = true;
            this.hOTextBox.Size = new System.Drawing.Size(160, 30);
            this.hOTextBox.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(253, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 36;
            this.label6.Text = "Mã nhân viên thực hiện: ";
            // 
            // txtMANV
            // 
            this.txtMANV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtMANV.Location = new System.Drawing.Point(419, 463);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.ReadOnly = true;
            this.txtMANV.Size = new System.Drawing.Size(80, 23);
            this.txtMANV.TabIndex = 35;
            // 
            // sODUTextBox
            // 
            this.sODUTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SODU", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.sODUTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sODUTextBox.Location = new System.Drawing.Point(502, 170);
            this.sODUTextBox.Name = "sODUTextBox";
            this.sODUTextBox.ReadOnly = true;
            this.sODUTextBox.Size = new System.Drawing.Size(174, 30);
            this.sODUTextBox.TabIndex = 33;
            // 
            // cMNDTextBox1
            // 
            this.cMNDTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "CMND", true));
            this.cMNDTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMNDTextBox1.Location = new System.Drawing.Point(502, 115);
            this.cMNDTextBox1.Name = "cMNDTextBox1";
            this.cMNDTextBox1.ReadOnly = true;
            this.cMNDTextBox1.Size = new System.Drawing.Size(174, 30);
            this.cMNDTextBox1.TabIndex = 32;
            // 
            // txtSoTKChuyen
            // 
            this.txtSoTKChuyen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdsTK, "SOTK", true));
            this.txtSoTKChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTKChuyen.Location = new System.Drawing.Point(153, 168);
            this.txtSoTKChuyen.Name = "txtSoTKChuyen";
            this.txtSoTKChuyen.ReadOnly = true;
            this.txtSoTKChuyen.Size = new System.Drawing.Size(174, 30);
            this.txtSoTKChuyen.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 32);
            this.label5.TabIndex = 30;
            this.label5.Text = "Thông tin người chuyển tiền: ";
            // 
            // nuSoTien
            // 
            this.nuSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuSoTien.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nuSoTien.Location = new System.Drawing.Point(218, 416);
            this.nuSoTien.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nuSoTien.Name = "nuSoTien";
            this.nuSoTien.Size = new System.Drawing.Size(120, 30);
            this.nuSoTien.TabIndex = 29;
            this.nuSoTien.ThousandsSeparator = true;
            // 
            // btnChuyenTien
            // 
            this.btnChuyenTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuyenTien.ForeColor = System.Drawing.Color.Black;
            this.btnChuyenTien.Location = new System.Drawing.Point(368, 412);
            this.btnChuyenTien.Name = "btnChuyenTien";
            this.btnChuyenTien.Size = new System.Drawing.Size(149, 33);
            this.btnChuyenTien.TabIndex = 28;
            this.btnChuyenTien.Text = "Xác nhận chuyển";
            this.btnChuyenTien.UseVisualStyleBackColor = true;
            this.btnChuyenTien.Click += new System.EventHandler(this.btnChuyenTien_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(68, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Nhập số tiền: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Thông tin người nhận tiền: ";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(588, 20);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(138, 33);
            this.btnTimKiem.TabIndex = 20;
            this.btnTimKiem.Text = "Tìm kiếm...";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(5, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nhập số tài khoản người nhận";
            // 
            // txtSoTkNhanTien
            // 
            this.txtSoTkNhanTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTkNhanTien.ForeColor = System.Drawing.Color.Black;
            this.txtSoTkNhanTien.Location = new System.Drawing.Point(412, 21);
            this.txtSoTkNhanTien.Name = "txtSoTkNhanTien";
            this.txtSoTkNhanTien.Size = new System.Drawing.Size(170, 30);
            this.txtSoTkNhanTien.TabIndex = 17;
            // 
            // mACNTextBox
            // 
            this.mACNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmChuyenTien_InfoReceiverBindingSource, "MACN", true));
            this.mACNTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mACNTextBox.ForeColor = System.Drawing.Color.Black;
            this.mACNTextBox.Location = new System.Drawing.Point(505, 343);
            this.mACNTextBox.Name = "mACNTextBox";
            this.mACNTextBox.ReadOnly = true;
            this.mACNTextBox.Size = new System.Drawing.Size(171, 30);
            this.mACNTextBox.TabIndex = 24;
            // 
            // frmChuyenTien_InfoReceiverBindingSource
            // 
            this.frmChuyenTien_InfoReceiverBindingSource.DataMember = "frmChuyenTien_InfoReceiver";
            this.frmChuyenTien_InfoReceiverBindingSource.DataSource = this.DS;
            // 
            // hOTENTextBox
            // 
            this.hOTENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmChuyenTien_InfoReceiverBindingSource, "HOTEN", true));
            this.hOTENTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hOTENTextBox.ForeColor = System.Drawing.Color.Black;
            this.hOTENTextBox.Location = new System.Drawing.Point(156, 286);
            this.hOTENTextBox.Name = "hOTENTextBox";
            this.hOTENTextBox.ReadOnly = true;
            this.hOTENTextBox.Size = new System.Drawing.Size(171, 30);
            this.hOTENTextBox.TabIndex = 21;
            // 
            // cMNDTextBox
            // 
            this.cMNDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmChuyenTien_InfoReceiverBindingSource, "CMND", true));
            this.cMNDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMNDTextBox.ForeColor = System.Drawing.Color.Black;
            this.cMNDTextBox.Location = new System.Drawing.Point(505, 284);
            this.cMNDTextBox.Name = "cMNDTextBox";
            this.cMNDTextBox.ReadOnly = true;
            this.cMNDTextBox.Size = new System.Drawing.Size(171, 30);
            this.cMNDTextBox.TabIndex = 23;
            // 
            // txtSoTKNhan
            // 
            this.txtSoTKNhan.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.frmChuyenTien_InfoReceiverBindingSource, "SOTK", true));
            this.txtSoTKNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTKNhan.ForeColor = System.Drawing.Color.Black;
            this.txtSoTKNhan.Location = new System.Drawing.Point(156, 343);
            this.txtSoTKNhan.Name = "txtSoTKNhan";
            this.txtSoTKNhan.ReadOnly = true;
            this.txtSoTKNhan.Size = new System.Drawing.Size(171, 30);
            this.txtSoTKNhan.TabIndex = 22;
            // 
            // frmChuyenTien_InfoReceiverTableAdapter
            // 
            this.frmChuyenTien_InfoReceiverTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(8, 332);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 25);
            this.label8.TabIndex = 40;
            this.label8.Text = "Chọn tài khoản chuyển tiền";
            // 
            // frmChuyenTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 717);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlGD);
            this.Controls.Add(this.taiKhoanGridControl);
            this.Controls.Add(this.khachHangGridControl);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmChuyenTien";
            this.Text = "Giao dịch chuyển khoản";
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
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlGD)).EndInit();
            this.pnlGD.ResumeLayout(false);
            this.pnlGD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSoTien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frmChuyenTien_InfoReceiverBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraEditors.GroupControl pnlGD;
        private System.Windows.Forms.TextBox txtSoTkNhanTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource frmChuyenTien_InfoReceiverBindingSource;
        private DSTableAdapters.frmChuyenTien_InfoReceiverTableAdapter frmChuyenTien_InfoReceiverTableAdapter;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox hOTENTextBox;
        private System.Windows.Forms.TextBox txtSoTKNhan;
        private System.Windows.Forms.TextBox cMNDTextBox;
        private System.Windows.Forms.TextBox mACNTextBox;
        private System.Windows.Forms.Button btnChuyenTien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nuSoTien;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND1;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmsTHEM;
        private System.Windows.Forms.ToolStripMenuItem cmsTAILAI;
        private System.Windows.Forms.ToolStripMenuItem cmsTHOAT;
        private System.Windows.Forms.TextBox sODUTextBox;
        private System.Windows.Forms.TextBox cMNDTextBox1;
        private System.Windows.Forms.TextBox txtSoTKChuyen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMANV;
        private System.Windows.Forms.TextBox tENTextBox;
        private System.Windows.Forms.TextBox hOTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUndo;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
    }
}