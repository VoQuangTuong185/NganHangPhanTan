namespace NganHang
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnCreateLogin = new DevExpress.XtraBars.BarButtonItem();
            this.btnLogout = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerManage = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmployeeManage = new DevExpress.XtraBars.BarButtonItem();
            this.btnOpenCustomerAccount = new DevExpress.XtraBars.BarButtonItem();
            this.btnSaveCashService = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransferService = new DevExpress.XtraBars.BarButtonItem();
            this.btnTransactionReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnOpenedAccountReport = new DevExpress.XtraBars.BarButtonItem();
            this.btnCustomerInfoReport = new DevExpress.XtraBars.BarButtonItem();
            this.frmLogin = new DevExpress.XtraBars.BarButtonItem();
            this.ribHeThong = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_DanhMuc = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_NghiepVu = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rib_BaoCao = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MANV = new System.Windows.Forms.ToolStripStatusLabel();
            this.HOTEN = new System.Windows.Forms.ToolStripStatusLabel();
            this.NHOM = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.ForeColor = System.Drawing.Color.Fuchsia;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnLogin,
            this.btnCreateLogin,
            this.btnLogout,
            this.btnCustomerManage,
            this.btnEmployeeManage,
            this.btnOpenCustomerAccount,
            this.btnSaveCashService,
            this.btnTransferService,
            this.btnTransactionReport,
            this.btnOpenedAccountReport,
            this.btnCustomerInfoReport,
            this.frmLogin});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ribbonControl1.MaxItemId = 22;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribHeThong,
            this.rib_DanhMuc,
            this.rib_NghiepVu,
            this.rib_BaoCao});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2010;
            this.ribbonControl1.Size = new System.Drawing.Size(1263, 180);
            // 
            // btnLogin
            // 
            this.btnLogin.Caption = "Đăng Nhập";
            this.btnLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogin.Glyph")));
            this.btnLogin.Id = 19;
            this.btnLogin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLogin.LargeGlyph")));
            this.btnLogin.Name = "btnLogin";
            // 
            // btnCreateLogin
            // 
            this.btnCreateLogin.Caption = "Tạo tài khoản";
            this.btnCreateLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCreateLogin.Glyph")));
            this.btnCreateLogin.Id = 6;
            this.btnCreateLogin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCreateLogin.LargeGlyph")));
            this.btnCreateLogin.LargeWidth = 110;
            this.btnCreateLogin.Name = "btnCreateLogin";
            this.btnCreateLogin.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnCreateLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCreateLogin_ItemClick);
            // 
            // btnLogout
            // 
            this.btnLogout.Caption = "Đăng xuất";
            this.btnLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.Glyph")));
            this.btnLogout.Id = 10;
            this.btnLogout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnLogout.LargeGlyph")));
            this.btnLogout.LargeWidth = 100;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnLogout_ItemClick);
            // 
            // btnCustomerManage
            // 
            this.btnCustomerManage.Caption = "Khách hàng";
            this.btnCustomerManage.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCustomerManage.Glyph")));
            this.btnCustomerManage.Id = 11;
            this.btnCustomerManage.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCustomerManage.LargeGlyph")));
            this.btnCustomerManage.LargeWidth = 100;
            this.btnCustomerManage.Name = "btnCustomerManage";
            this.btnCustomerManage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomerManage_ItemClick);
            // 
            // btnEmployeeManage
            // 
            this.btnEmployeeManage.Caption = "Nhân viên";
            this.btnEmployeeManage.Glyph = ((System.Drawing.Image)(resources.GetObject("btnEmployeeManage.Glyph")));
            this.btnEmployeeManage.Id = 12;
            this.btnEmployeeManage.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnEmployeeManage.LargeGlyph")));
            this.btnEmployeeManage.LargeWidth = 100;
            this.btnEmployeeManage.Name = "btnEmployeeManage";
            this.btnEmployeeManage.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnEmployeeManage_ItemClick_1);
            // 
            // btnOpenCustomerAccount
            // 
            this.btnOpenCustomerAccount.Caption = "Mở tài khoản";
            this.btnOpenCustomerAccount.Glyph = ((System.Drawing.Image)(resources.GetObject("btnOpenCustomerAccount.Glyph")));
            this.btnOpenCustomerAccount.Id = 13;
            this.btnOpenCustomerAccount.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnOpenCustomerAccount.LargeGlyph")));
            this.btnOpenCustomerAccount.LargeWidth = 100;
            this.btnOpenCustomerAccount.Name = "btnOpenCustomerAccount";
            this.btnOpenCustomerAccount.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOpenCustomerAccount_ItemClick);
            // 
            // btnSaveCashService
            // 
            this.btnSaveCashService.Caption = "Gửi và rút tiền";
            this.btnSaveCashService.Glyph = ((System.Drawing.Image)(resources.GetObject("btnSaveCashService.Glyph")));
            this.btnSaveCashService.Id = 14;
            this.btnSaveCashService.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnSaveCashService.LargeGlyph")));
            this.btnSaveCashService.LargeWidth = 110;
            this.btnSaveCashService.Name = "btnSaveCashService";
            this.btnSaveCashService.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnSaveCashService.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSaveCashService_ItemClick);
            // 
            // btnTransferService
            // 
            this.btnTransferService.Caption = "Chuyển khoản";
            this.btnTransferService.Glyph = ((System.Drawing.Image)(resources.GetObject("btnTransferService.Glyph")));
            this.btnTransferService.Id = 15;
            this.btnTransferService.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTransferService.LargeGlyph")));
            this.btnTransferService.LargeWidth = 100;
            this.btnTransferService.Name = "btnTransferService";
            this.btnTransferService.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTransferService_ItemClick);
            // 
            // btnTransactionReport
            // 
            this.btnTransactionReport.Caption = "Sao kê tài khoản";
            this.btnTransactionReport.Id = 16;
            this.btnTransactionReport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnTransactionReport.LargeGlyph")));
            this.btnTransactionReport.LargeWidth = 100;
            this.btnTransactionReport.Name = "btnTransactionReport";
            // 
            // btnOpenedAccountReport
            // 
            this.btnOpenedAccountReport.Caption = "Danh sách tài khoản mở";
            this.btnOpenedAccountReport.Glyph = ((System.Drawing.Image)(resources.GetObject("btnOpenedAccountReport.Glyph")));
            this.btnOpenedAccountReport.Id = 17;
            this.btnOpenedAccountReport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnOpenedAccountReport.LargeGlyph")));
            this.btnOpenedAccountReport.LargeWidth = 100;
            this.btnOpenedAccountReport.Name = "btnOpenedAccountReport";
            this.btnOpenedAccountReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnOpenedAccountReport_ItemClick);
            // 
            // btnCustomerInfoReport
            // 
            this.btnCustomerInfoReport.Caption = "Thống kê thông tin khách hàng";
            this.btnCustomerInfoReport.Glyph = ((System.Drawing.Image)(resources.GetObject("btnCustomerInfoReport.Glyph")));
            this.btnCustomerInfoReport.Id = 18;
            this.btnCustomerInfoReport.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnCustomerInfoReport.LargeGlyph")));
            this.btnCustomerInfoReport.LargeWidth = 120;
            this.btnCustomerInfoReport.Name = "btnCustomerInfoReport";
            this.btnCustomerInfoReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCustomerInfoReport_ItemClick);
            // 
            // frmLogin
            // 
            this.frmLogin.Caption = "Đăng Nhập";
            this.frmLogin.Glyph = ((System.Drawing.Image)(resources.GetObject("frmLogin.Glyph")));
            this.frmLogin.Id = 20;
            this.frmLogin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("frmLogin.LargeGlyph")));
            this.frmLogin.LargeWidth = 100;
            this.frmLogin.Name = "frmLogin";
            this.frmLogin.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.frmLogin_ItemClick);
            // 
            // ribHeThong
            // 
            this.ribHeThong.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribHeThong.Appearance.Options.UseFont = true;
            this.ribHeThong.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribHeThong.Name = "ribHeThong";
            this.ribHeThong.Text = "Hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.frmLogin);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnLogout);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnCreateLogin);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // rib_DanhMuc
            // 
            this.rib_DanhMuc.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rib_DanhMuc.Appearance.Options.UseFont = true;
            this.rib_DanhMuc.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.rib_DanhMuc.Name = "rib_DanhMuc";
            this.rib_DanhMuc.Text = "Danh mục";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnCustomerManage);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEmployeeManage);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // rib_NghiepVu
            // 
            this.rib_NghiepVu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rib_NghiepVu.Appearance.Options.UseFont = true;
            this.rib_NghiepVu.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.rib_NghiepVu.Name = "rib_NghiepVu";
            this.rib_NghiepVu.Text = "Nghiệp vụ";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnOpenCustomerAccount);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnSaveCashService);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnTransferService);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // rib_BaoCao
            // 
            this.rib_BaoCao.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rib_BaoCao.Appearance.Options.UseFont = true;
            this.rib_BaoCao.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.rib_BaoCao.Name = "rib_BaoCao";
            this.rib_BaoCao.Text = "Báo cáo";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnTransactionReport);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnOpenedAccountReport);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnCustomerInfoReport);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.MaxItemId = 0;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(1263, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 554);
            this.barDockControlBottom.Size = new System.Drawing.Size(1263, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 554);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1263, 0);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 554);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MANV,
            this.HOTEN,
            this.NHOM});
            this.statusStrip1.Location = new System.Drawing.Point(0, 526);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1263, 28);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MANV
            // 
            this.MANV.BackColor = System.Drawing.Color.Transparent;
            this.MANV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MANV.ForeColor = System.Drawing.Color.Black;
            this.MANV.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.MANV.Name = "MANV";
            this.MANV.Size = new System.Drawing.Size(60, 23);
            this.MANV.Text = "MANV";
            // 
            // HOTEN
            // 
            this.HOTEN.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOTEN.ForeColor = System.Drawing.Color.Black;
            this.HOTEN.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Size = new System.Drawing.Size(65, 23);
            this.HOTEN.Text = "HOTEN";
            // 
            // NHOM
            // 
            this.NHOM.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHOM.ForeColor = System.Drawing.Color.Black;
            this.NHOM.Margin = new System.Windows.Forms.Padding(2, 3, 2, 2);
            this.NHOM.Name = "NHOM";
            this.NHOM.Size = new System.Drawing.Size(63, 23);
            this.NHOM.Text = "NHOM";
            // 
            // frmMain
            // 
            this.AccessibleDescription = "s";
            this.ActiveGlowColor = System.Drawing.Color.White;
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 554);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbonControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Ribbon = this.ribbonControl1;
            this.Text = "Quản Lý Ngân Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.fMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribHeThong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_DanhMuc;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_NghiepVu;
        private DevExpress.XtraBars.Ribbon.RibbonPage rib_BaoCao;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarButtonItem btnLogin;
        private DevExpress.XtraBars.BarButtonItem btnCreateLogin;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnLogout;
        private DevExpress.XtraBars.BarButtonItem btnCustomerManage;
        private DevExpress.XtraBars.BarButtonItem btnEmployeeManage;
        private DevExpress.XtraBars.BarButtonItem btnOpenCustomerAccount;
        private DevExpress.XtraBars.BarButtonItem btnSaveCashService;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem btnTransferService;
        private DevExpress.XtraBars.BarButtonItem btnTransactionReport;
        private DevExpress.XtraBars.BarButtonItem btnOpenedAccountReport;
        private DevExpress.XtraBars.BarButtonItem btnCustomerInfoReport;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem frmLogin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel MANV;
        public System.Windows.Forms.ToolStripStatusLabel HOTEN;
        public System.Windows.Forms.ToolStripStatusLabel NHOM;
    }
}

