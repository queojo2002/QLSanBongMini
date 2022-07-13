
namespace QLSanBongMini_Final
{
    partial class frmQuanLy_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy_KhachHang));
            this.flow_fill = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flow_fill
            // 
            this.flow_fill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flow_fill.Location = new System.Drawing.Point(0, 0);
            this.flow_fill.Name = "flow_fill";
            this.flow_fill.Size = new System.Drawing.Size(1126, 584);
            this.flow_fill.TabIndex = 0;
            // 
            // frmQuanLy_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 584);
            this.Controls.Add(this.flow_fill);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("frmQuanLy_KhachHang.IconOptions.LargeImage")));
            this.Name = "frmQuanLy_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý khách hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmQuanLy_KhachHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flow_fill;
    }
}