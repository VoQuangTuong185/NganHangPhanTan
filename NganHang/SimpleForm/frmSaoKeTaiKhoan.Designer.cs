namespace NganHang
{
    partial class frmSaoKeTaiKhoan
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
            System.Windows.Forms.Label cMNDLabel;
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ketthuc = new DevExpress.XtraEditors.DateEdit();
            this.batdau = new DevExpress.XtraEditors.DateEdit();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.DS = new NganHang.DS();
            this.thongTinKH_TKSaoKeTableAdapter = new NganHang.DSTableAdapters.ThongTinKH_TKSaoKeTableAdapter();
            this.tableAdapterManager = new NganHang.DSTableAdapters.TableAdapterManager();
            this.cmbHoTenKhSk = new System.Windows.Forms.ComboBox();
            this.thongTinKHTKSaoKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cMNDTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SoTKSaoKe = new DevExpress.XtraEditors.TextEdit();
            hOTENLabel = new System.Windows.Forms.Label();
            cMNDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketthuc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketthuc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batdau.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.batdau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinKHTKSaoKeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoTKSaoKe.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hOTENLabel.ForeColor = System.Drawing.Color.Black;
            hOTENLabel.Location = new System.Drawing.Point(571, 78);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(416, 25);
            hOTENLabel.TabIndex = 23;
            hOTENLabel.Text = "Họ tên và Số tài khoản khách hàng cần sao kê";
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cMNDLabel.ForeColor = System.Drawing.Color.Black;
            cMNDLabel.Location = new System.Drawing.Point(711, 148);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(72, 25);
            cMNDLabel.TabIndex = 24;
            cMNDLabel.Text = "CMND";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.cmbChiNhanh);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1528, 54);
            this.panelControl1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi Nhánh";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(191, 9);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(325, 39);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(711, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 25);
            this.label4.TabIndex = 22;
            this.label4.Text = "Kết thúc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(711, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Bắt đầu";
            // 
            // ketthuc
            // 
            this.ketthuc.EditValue = null;
            this.ketthuc.Location = new System.Drawing.Point(638, 340);
            this.ketthuc.Name = "ketthuc";
            this.ketthuc.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ketthuc.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.ketthuc.Properties.Appearance.Options.UseFont = true;
            this.ketthuc.Properties.Appearance.Options.UseForeColor = true;
            this.ketthuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ketthuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ketthuc.Size = new System.Drawing.Size(219, 32);
            this.ketthuc.TabIndex = 20;
            // 
            // batdau
            // 
            this.batdau.EditValue = null;
            this.batdau.Location = new System.Drawing.Point(638, 253);
            this.batdau.Name = "batdau";
            this.batdau.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batdau.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.batdau.Properties.Appearance.Options.UseFont = true;
            this.batdau.Properties.Appearance.Options.UseForeColor = true;
            this.batdau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.batdau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.batdau.Size = new System.Drawing.Size(219, 32);
            this.batdau.TabIndex = 19;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.Black;
            this.btnXacNhan.Location = new System.Drawing.Point(683, 401);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(143, 37);
            this.btnXacNhan.TabIndex = 17;
            this.btnXacNhan.Text = "Xem trước";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // DS
            // 
            this.DS.DataSetName = "DS";
            this.DS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongTinKH_TKSaoKeTableAdapter
            // 
            this.thongTinKH_TKSaoKeTableAdapter.ClearBeforeFill = true;
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
            // cmbHoTenKhSk
            // 
            this.cmbHoTenKhSk.DataSource = this.thongTinKHTKSaoKeBindingSource;
            this.cmbHoTenKhSk.DisplayMember = "HOTEN";
            this.cmbHoTenKhSk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHoTenKhSk.ForeColor = System.Drawing.Color.Black;
            this.cmbHoTenKhSk.FormattingEnabled = true;
            this.cmbHoTenKhSk.Location = new System.Drawing.Point(548, 106);
            this.cmbHoTenKhSk.Name = "cmbHoTenKhSk";
            this.cmbHoTenKhSk.Size = new System.Drawing.Size(451, 33);
            this.cmbHoTenKhSk.TabIndex = 24;
            this.cmbHoTenKhSk.ValueMember = "HOTEN";
            // 
            // thongTinKHTKSaoKeBindingSource
            // 
            this.thongTinKHTKSaoKeBindingSource.DataMember = "ThongTinKH_TKSaoKe";
            this.thongTinKHTKSaoKeBindingSource.DataSource = this.DS;
            // 
            // cMNDTextEdit
            // 
            this.cMNDTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongTinKHTKSaoKeBindingSource, "CMND", true));
            this.cMNDTextEdit.Location = new System.Drawing.Point(638, 176);
            this.cMNDTextEdit.Name = "cMNDTextEdit";
            this.cMNDTextEdit.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cMNDTextEdit.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.cMNDTextEdit.Properties.Appearance.Options.UseFont = true;
            this.cMNDTextEdit.Properties.Appearance.Options.UseForeColor = true;
            this.cMNDTextEdit.Properties.ReadOnly = true;
            this.cMNDTextEdit.Size = new System.Drawing.Size(219, 32);
            this.cMNDTextEdit.TabIndex = 25;
            // 
            // SoTKSaoKe
            // 
            this.SoTKSaoKe.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.thongTinKHTKSaoKeBindingSource, "SOTK", true));
            this.SoTKSaoKe.Location = new System.Drawing.Point(0, 609);
            this.SoTKSaoKe.Name = "SoTKSaoKe";
            this.SoTKSaoKe.Size = new System.Drawing.Size(10, 22);
            this.SoTKSaoKe.TabIndex = 26;
            // 
            // frmSaoKeTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1528, 633);
            this.Controls.Add(this.SoTKSaoKe);
            this.Controls.Add(this.cMNDTextEdit);
            this.Controls.Add(cMNDLabel);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.cmbHoTenKhSk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ketthuc);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.batdau);
            this.Name = "frmSaoKeTaiKhoan";
            this.Text = "frmSaoKeTaiKhoan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSaoKeTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ketthuc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ketthuc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batdau.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.batdau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thongTinKHTKSaoKeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cMNDTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoTKSaoKe.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit ketthuc;
        private DevExpress.XtraEditors.DateEdit batdau;
        private System.Windows.Forms.Button btnXacNhan;
        private DS DS;
        private DSTableAdapters.ThongTinKH_TKSaoKeTableAdapter thongTinKH_TKSaoKeTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox cmbHoTenKhSk;
        private System.Windows.Forms.BindingSource thongTinKHTKSaoKeBindingSource;
        private DevExpress.XtraEditors.TextEdit cMNDTextEdit;
        private DevExpress.XtraEditors.TextEdit SoTKSaoKe;
    }
}