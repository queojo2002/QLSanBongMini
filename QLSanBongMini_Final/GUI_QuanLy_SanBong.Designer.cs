
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
            this.btn_reload = new DevExpress.XtraEditors.SimpleButton();
            this.de_NgayLoc = new DevExpress.XtraEditors.DateEdit();
            this.btn_loc = new DevExpress.XtraEditors.SimpleButton();
            this.ce_loaisan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panel_fill = new DevExpress.XtraEditors.PanelControl();
            this.flow_1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panel_top)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.group_search)).BeginInit();
            this.group_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayLoc.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_NgayLoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ce_loaisan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_fill)).BeginInit();
            this.panel_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.group_search);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1167, 113);
            this.panel_top.TabIndex = 3;
            // 
            // group_search
            // 
            this.group_search.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.group_search.Controls.Add(this.labelControl1);
            this.group_search.Controls.Add(this.btn_reload);
            this.group_search.Controls.Add(this.de_NgayLoc);
            this.group_search.Controls.Add(this.btn_loc);
            this.group_search.Controls.Add(this.ce_loaisan);
            this.group_search.Controls.Add(this.labelControl2);
            this.group_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.group_search.Location = new System.Drawing.Point(2, 2);
            this.group_search.Name = "group_search";
            this.group_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.group_search.Size = new System.Drawing.Size(1163, 109);
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
            this.labelControl1.Location = new System.Drawing.Point(10, 46);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = " Lọc theo ngày: ";
            // 
            // btn_reload
            // 
            this.btn_reload.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_reload.Appearance.Options.UseFont = true;
            this.btn_reload.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_reload.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_reload.ImageOptions.SvgImage")));
            this.btn_reload.Location = new System.Drawing.Point(1034, 30);
            this.btn_reload.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.btn_reload.Name = "btn_reload";
            this.btn_reload.Size = new System.Drawing.Size(113, 41);
            this.btn_reload.TabIndex = 5;
            this.btn_reload.Text = "Tải lại !!";
            // 
            // de_NgayLoc
            // 
            this.de_NgayLoc.EditValue = null;
            this.de_NgayLoc.Location = new System.Drawing.Point(128, 43);
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
            this.de_NgayLoc.Size = new System.Drawing.Size(326, 28);
            this.de_NgayLoc.TabIndex = 1;
            // 
            // btn_loc
            // 
            this.btn_loc.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_loc.Appearance.Options.UseFont = true;
            this.btn_loc.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btn_loc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_loc.ImageOptions.SvgImage")));
            this.btn_loc.Location = new System.Drawing.Point(915, 30);
            this.btn_loc.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.btn_loc.Name = "btn_loc";
            this.btn_loc.Size = new System.Drawing.Size(113, 41);
            this.btn_loc.TabIndex = 2;
            this.btn_loc.Text = "Lọc !!";
            // 
            // ce_loaisan
            // 
            this.ce_loaisan.Location = new System.Drawing.Point(630, 39);
            this.ce_loaisan.Name = "ce_loaisan";
            this.ce_loaisan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ce_loaisan.Properties.Appearance.Options.UseFont = true;
            this.ce_loaisan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.ce_loaisan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ce_loaisan.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ce_loaisan.Size = new System.Drawing.Size(279, 28);
            this.ce_loaisan.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(460, 42);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(164, 25);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = " Lọc theo loại sân bóng: ";
            // 
            // panel_fill
            // 
            this.panel_fill.Controls.Add(this.flow_1);
            this.panel_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fill.Location = new System.Drawing.Point(0, 113);
            this.panel_fill.Name = "panel_fill";
            this.panel_fill.Size = new System.Drawing.Size(1167, 443);
            this.panel_fill.TabIndex = 4;
            // 
            // flow_1
            // 
            this.flow_1.AutoScroll = true;
            this.flow_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_1.Location = new System.Drawing.Point(2, 2);
            this.flow_1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 4);
            this.flow_1.Name = "flow_1";
            this.flow_1.Size = new System.Drawing.Size(1163, 439);
            this.flow_1.TabIndex = 0;
            // 
            // frmQuanLy_SanBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 556);
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
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel_top;
        private DevExpress.XtraEditors.GroupControl group_search;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_reload;
        private DevExpress.XtraEditors.DateEdit de_NgayLoc;
        private DevExpress.XtraEditors.SimpleButton btn_loc;
        private DevExpress.XtraEditors.ComboBoxEdit ce_loaisan;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panel_fill;
        private System.Windows.Forms.FlowLayoutPanel flow_1;
        private System.Windows.Forms.Timer timer1;
    }
}