
namespace QLSanBongMini_Final
{
    partial class frmQuanLy_SanBong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_SanBong));
            this.panel_top = new DevExpress.XtraEditors.PanelControl();
            this.group_search = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnTaiLai = new DevExpress.XtraEditors.SimpleButton();
            this.de_NgayLoc = new DevExpress.XtraEditors.DateEdit();
            this.btnLoc = new DevExpress.XtraEditors.SimpleButton();
            this.ce_loaisan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel_fill = new DevExpress.XtraEditors.PanelControl();
            this.flow_1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbeTenKH = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbeSDTKH = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_top)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_search)).BeginInit();
            this.group_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayLoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayLoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_loaisan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_fill)).BeginInit();
            this.panel_fill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeTenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSDTKH.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.group_search);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1254, 123);
            this.panel_top.TabIndex = 3;
            // 
            // group_search
            // 
            this.group_search.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.group_search.Controls.Add(this.btnTaiLai);
            this.group_search.Controls.Add(this.labelControl4);
            this.group_search.Controls.Add(this.labelControl3);
            this.group_search.Controls.Add(this.labelControl1);
            this.group_search.Controls.Add(this.de_NgayLoc);
            this.group_search.Controls.Add(this.btnLoc);
            this.group_search.Controls.Add(this.ce_loaisan);
            this.group_search.Controls.Add(this.labelControl2);
            this.group_search.Controls.Add(this.cbeTenKH);
            this.group_search.Controls.Add(this.cbeSDTKH);
            this.group_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_search.Location = new System.Drawing.Point(2, 2);
            this.group_search.Name = "group_search";
            this.group_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.group_search.Size = new System.Drawing.Size(1250, 119);
            this.group_search.TabIndex = 6;
            this.group_search.Text = "Lọc";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(10, 36);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Lọc theo ngày: ";
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaiLai.Appearance.Options.UseFont = true;
            this.btnTaiLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTaiLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_reload.ImageOptions.SvgImage")));
            this.btnTaiLai.Location = new System.Drawing.Point(1130, 36);
            this.btnTaiLai.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(113, 68);
            this.btnTaiLai.TabIndex = 5;
            this.btnTaiLai.Text = "Tải lại !!";
            // 
            // de_NgayLoc
            // 
            this.de_NgayLoc.EditValue = null;
            this.de_NgayLoc.Location = new System.Drawing.Point(128, 35);
            this.de_NgayLoc.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.de_NgayLoc.Name = "de_NgayLoc";
            this.de_NgayLoc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.de_NgayLoc.Properties.Appearance.Options.UseFont = true;
            this.de_NgayLoc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.de_NgayLoc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayLoc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_NgayLoc.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.de_NgayLoc.Size = new System.Drawing.Size(336, 28);
            this.de_NgayLoc.TabIndex = 1;
            // 
            // btnLoc
            // 
            this.btnLoc.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.Appearance.Options.UseFont = true;
            this.btnLoc.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_loc.ImageOptions.SvgImage")));
            this.btnLoc.Location = new System.Drawing.Point(1011, 36);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(113, 68);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.Text = "Lọc !!";
            // 
            // ce_loaisan
            // 
            this.ce_loaisan.Location = new System.Drawing.Point(210, 76);
            this.ce_loaisan.Name = "ce_loaisan";
            this.ce_loaisan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ce_loaisan.Properties.Appearance.Options.UseFont = true;
            this.ce_loaisan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.ce_loaisan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ce_loaisan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ce_loaisan.Size = new System.Drawing.Size(254, 28);
            this.ce_loaisan.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(10, 77);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(194, 25);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Lọc theo khu vực sân bóng: ";
            // 
            // panel_fill
            // 
            this.panel_fill.Controls.Add(this.flow_1);
            this.panel_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fill.Location = new System.Drawing.Point(0, 123);
            this.panel_fill.Name = "panel_fill";
            this.panel_fill.Size = new System.Drawing.Size(1254, 433);
            this.panel_fill.TabIndex = 4;
            // 
            // flow_1
            // 
            this.flow_1.AutoScroll = true;
            this.flow_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_1.Location = new System.Drawing.Point(2, 2);
            this.flow_1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.flow_1.Name = "flow_1";
            this.flow_1.Size = new System.Drawing.Size(1250, 429);
            this.flow_1.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(470, 36);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(186, 25);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Lọc theo tên khách hàng: ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(470, 77);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(186, 25);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Lọc theo sđt khách hàng: ";
            // 
            // cbeTenKH
            // 
            this.cbeTenKH.Location = new System.Drawing.Point(662, 36);
            this.cbeTenKH.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.cbeTenKH.Name = "cbeTenKH";
            this.cbeTenKH.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbeTenKH.Properties.Appearance.Options.UseFont = true;
            this.cbeTenKH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cbeTenKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeTenKH.Properties.DisplayFormat.FormatString = "d";
            this.cbeTenKH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbeTenKH.Properties.EditFormat.FormatString = "d";
            this.cbeTenKH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbeTenKH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeTenKH.Size = new System.Drawing.Size(343, 28);
            this.cbeTenKH.TabIndex = 8;
            // 
            // cbeSDTKH
            // 
            this.cbeSDTKH.Location = new System.Drawing.Point(662, 76);
            this.cbeSDTKH.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.cbeSDTKH.Name = "cbeSDTKH";
            this.cbeSDTKH.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbeSDTKH.Properties.Appearance.Options.UseFont = true;
            this.cbeSDTKH.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cbeSDTKH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeSDTKH.Properties.DisplayFormat.FormatString = "d";
            this.cbeSDTKH.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbeSDTKH.Properties.EditFormat.FormatString = "d";
            this.cbeSDTKH.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.cbeSDTKH.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeSDTKH.Size = new System.Drawing.Size(343, 28);
            this.cbeSDTKH.TabIndex = 9;
            // 
            // frmQuanLy_SanBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 556);
            this.Controls.Add(this.panel_fill);
            this.Controls.Add(this.panel_top);
            this.Name = "frmQuanLy_SanBong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sân bóng";
            this.Load += new System.EventHandler(this.frmQuanLy_SanBong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_top)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.group_search)).EndInit();
            this.group_search.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayLoc.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayLoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_loaisan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_fill)).EndInit();
            this.panel_fill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeTenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbeSDTKH.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel_top;
        private DevExpress.XtraEditors.GroupControl group_search;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnTaiLai;
        private DevExpress.XtraEditors.DateEdit de_NgayLoc;
        private DevExpress.XtraEditors.SimpleButton btnLoc;
        private DevExpress.XtraEditors.ComboBoxEdit ce_loaisan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panel_fill;
        private System.Windows.Forms.FlowLayoutPanel flow_1;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbeTenKH;
        private DevExpress.XtraEditors.ComboBoxEdit cbeSDTKH;
    }
}