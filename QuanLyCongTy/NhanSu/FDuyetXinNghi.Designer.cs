namespace QuanLyCongTy
{
    partial class FDuyetXinNghi
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
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.shape = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnDaDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.btnChuaDuyet = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp.Location = new System.Drawing.Point(0, 78);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(1036, 663);
            this.flp.TabIndex = 0;
            // 
            // shape
            // 
            this.shape.BorderThickness = 1;
            this.shape.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.shape.LineThickness = 2;
            this.shape.Location = new System.Drawing.Point(330, 62);
            this.shape.Name = "shape";
            this.shape.PolygonSkip = 1;
            this.shape.Rotate = 0F;
            this.shape.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.shape.Size = new System.Drawing.Size(341, 10);
            this.shape.TabIndex = 43;
            this.shape.Text = "guna2Shapes1";
            this.shape.Zoom = 100;
            // 
            // btnDaDuyet
            // 
            this.btnDaDuyet.BackColor = System.Drawing.Color.Transparent;
            this.btnDaDuyet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnDaDuyet.BorderRadius = 10;
            this.btnDaDuyet.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnDaDuyet.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDaDuyet.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnDaDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDaDuyet.FillColor = System.Drawing.Color.White;
            this.btnDaDuyet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaDuyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDaDuyet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDaDuyet.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnDaDuyet.Location = new System.Drawing.Point(505, 12);
            this.btnDaDuyet.Name = "btnDaDuyet";
            this.btnDaDuyet.Size = new System.Drawing.Size(166, 44);
            this.btnDaDuyet.TabIndex = 42;
            this.btnDaDuyet.Text = "Đã duyệt";
            this.btnDaDuyet.UseTransparentBackground = true;
            this.btnDaDuyet.CheckedChanged += new System.EventHandler(this.btnDaDuyet_CheckedChanged);
            // 
            // btnChuaDuyet
            // 
            this.btnChuaDuyet.BackColor = System.Drawing.Color.Transparent;
            this.btnChuaDuyet.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnChuaDuyet.BorderRadius = 10;
            this.btnChuaDuyet.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnChuaDuyet.Checked = true;
            this.btnChuaDuyet.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnChuaDuyet.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnChuaDuyet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChuaDuyet.FillColor = System.Drawing.Color.White;
            this.btnChuaDuyet.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChuaDuyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnChuaDuyet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnChuaDuyet.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnChuaDuyet.Location = new System.Drawing.Point(333, 12);
            this.btnChuaDuyet.Name = "btnChuaDuyet";
            this.btnChuaDuyet.Size = new System.Drawing.Size(166, 44);
            this.btnChuaDuyet.TabIndex = 41;
            this.btnChuaDuyet.Text = "Chưa duyệt";
            this.btnChuaDuyet.UseTransparentBackground = true;
            this.btnChuaDuyet.CheckedChanged += new System.EventHandler(this.btnChuaDuyet_CheckedChanged);
            // 
            // FDuyetXinNghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 741);
            this.Controls.Add(this.shape);
            this.Controls.Add(this.btnDaDuyet);
            this.Controls.Add(this.btnChuaDuyet);
            this.Controls.Add(this.flp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FDuyetXinNghi";
            this.Text = "FDuyetXinNghi";
            this.Load += new System.EventHandler(this.FXinNghi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp;
        private Guna.UI2.WinForms.Guna2Shapes shape;
        private Guna.UI2.WinForms.Guna2Button btnDaDuyet;
        private Guna.UI2.WinForms.Guna2Button btnChuaDuyet;
    }
}