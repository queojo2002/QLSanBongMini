﻿
namespace QLSanBongMini_Final
{
    partial class frmQuanLy_FWA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_FWA));
            this.panel_top = new DevExpress.XtraEditors.PanelControl();
            this.btnTaiLai = new DevExpress.XtraEditors.SimpleButton();
            this.btnLoc = new DevExpress.XtraEditors.SimpleButton();
            this.lblXemTheoLoai = new DevExpress.XtraEditors.LabelControl();
            this.cbeLoaiFWA = new DevExpress.XtraEditors.ComboBoxEdit();
            this.flow_ShowFWA = new System.Windows.Forms.FlowLayoutPanel();
            this.panel_fill = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panel_top)).BeginInit();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiFWA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_fill)).BeginInit();
            this.panel_fill.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_top
            // 
            this.panel_top.Controls.Add(this.btnTaiLai);
            this.panel_top.Controls.Add(this.btnLoc);
            this.panel_top.Controls.Add(this.lblXemTheoLoai);
            this.panel_top.Controls.Add(this.cbeLoaiFWA);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(2, 2);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(1151, 61);
            this.panel_top.TabIndex = 0;
            // 
            // btnTaiLai
            // 
            this.btnTaiLai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnTaiLai.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTaiLai.Appearance.Options.UseFont = true;
            this.btnTaiLai.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnTaiLai.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaiLai.ImageOptions.SvgImage")));
            this.btnTaiLai.Location = new System.Drawing.Point(643, 3);
            this.btnTaiLai.Name = "btnTaiLai";
            this.btnTaiLai.Size = new System.Drawing.Size(141, 52);
            this.btnTaiLai.TabIndex = 3;
            this.btnTaiLai.Text = "Tải lại !!!";
            this.btnTaiLai.Click += new System.EventHandler(this.btnTaiLai_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnLoc.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLoc.Appearance.Options.UseFont = true;
            this.btnLoc.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnLoc.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnLoc.ImageOptions.SvgImage")));
            this.btnLoc.Location = new System.Drawing.Point(496, 5);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(141, 50);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.Text = "Lọc !!!";
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // lblXemTheoLoai
            // 
            this.lblXemTheoLoai.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblXemTheoLoai.Appearance.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblXemTheoLoai.Appearance.Options.UseFont = true;
            this.lblXemTheoLoai.Appearance.Options.UseTextOptions = true;
            this.lblXemTheoLoai.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblXemTheoLoai.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblXemTheoLoai.Location = new System.Drawing.Point(10, 16);
            this.lblXemTheoLoai.Name = "lblXemTheoLoai";
            this.lblXemTheoLoai.Size = new System.Drawing.Size(167, 32);
            this.lblXemTheoLoai.TabIndex = 1;
            this.lblXemTheoLoai.Text = "Xem theo loại FWA: ";
            // 
            // cbeLoaiFWA
            // 
            this.cbeLoaiFWA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbeLoaiFWA.Location = new System.Drawing.Point(183, 16);
            this.cbeLoaiFWA.Name = "cbeLoaiFWA";
            this.cbeLoaiFWA.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbeLoaiFWA.Properties.Appearance.Options.UseFont = true;
            this.cbeLoaiFWA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbeLoaiFWA.Properties.Items.AddRange(new object[] {
            "Thức ăn",
            "Nước uống",
            "Phụ kiện"});
            this.cbeLoaiFWA.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbeLoaiFWA.Size = new System.Drawing.Size(307, 32);
            this.cbeLoaiFWA.TabIndex = 1;
            // 
            // flow_ShowFWA
            // 
            this.flow_ShowFWA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_ShowFWA.Location = new System.Drawing.Point(2, 63);
            this.flow_ShowFWA.Name = "flow_ShowFWA";
            this.flow_ShowFWA.Size = new System.Drawing.Size(1151, 764);
            this.flow_ShowFWA.TabIndex = 1;
            // 
            // panel_fill
            // 
            this.panel_fill.Controls.Add(this.flow_ShowFWA);
            this.panel_fill.Controls.Add(this.panel_top);
            this.panel_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_fill.Location = new System.Drawing.Point(0, 0);
            this.panel_fill.Name = "panel_fill";
            this.panel_fill.Size = new System.Drawing.Size(1155, 829);
            this.panel_fill.TabIndex = 2;
            // 
            // frmQuanLy_FWA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 829);
            this.Controls.Add(this.panel_fill);
            this.IconOptions.Image = global::QLSanBongMini_Final.Properties.Resources.image_food;
            this.MaximizeBox = false;
            this.Name = "frmQuanLy_FWA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý fwa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLy_FWA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_top)).EndInit();
            this.panel_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cbeLoaiFWA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel_fill)).EndInit();
            this.panel_fill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel_top;
        private System.Windows.Forms.FlowLayoutPanel flow_ShowFWA;
        private DevExpress.XtraEditors.PanelControl panel_fill;
        private DevExpress.XtraEditors.LabelControl lblXemTheoLoai;
        private DevExpress.XtraEditors.ComboBoxEdit cbeLoaiFWA;
        private DevExpress.XtraEditors.SimpleButton btnTaiLai;
        private DevExpress.XtraEditors.SimpleButton btnLoc;
    }
}