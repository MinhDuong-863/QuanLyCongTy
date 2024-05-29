namespace QuanLyCongTy
{
    partial class FXinNghiNV
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
            this.shape = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnTT = new Guna.UI2.WinForms.Guna2Button();
            this.btnTaoXN = new Guna.UI2.WinForms.Guna2Button();
            this.flp = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // shape
            // 
            this.shape.BorderThickness = 1;
            this.shape.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.shape.LineThickness = 2;
            this.shape.Location = new System.Drawing.Point(341, 90);
            this.shape.Name = "shape";
            this.shape.PolygonSkip = 1;
            this.shape.Rotate = 0F;
            this.shape.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.shape.Size = new System.Drawing.Size(341, 10);
            this.shape.TabIndex = 46;
            this.shape.Text = "guna2Shapes1";
            this.shape.Zoom = 100;
            // 
            // btnTT
            // 
            this.btnTT.BackColor = System.Drawing.Color.Transparent;
            this.btnTT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnTT.BorderRadius = 10;
            this.btnTT.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTT.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnTT.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTT.FillColor = System.Drawing.Color.White;
            this.btnTT.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnTT.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTT.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnTT.Location = new System.Drawing.Point(516, 40);
            this.btnTT.Name = "btnTT";
            this.btnTT.Size = new System.Drawing.Size(166, 44);
            this.btnTT.TabIndex = 45;
            this.btnTT.Text = "Tình trạng";
            this.btnTT.UseTransparentBackground = true;
            this.btnTT.CheckedChanged += new System.EventHandler(this.btnTT_CheckedChanged);
            // 
            // btnTaoXN
            // 
            this.btnTaoXN.BackColor = System.Drawing.Color.Transparent;
            this.btnTaoXN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnTaoXN.BorderRadius = 10;
            this.btnTaoXN.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnTaoXN.Checked = true;
            this.btnTaoXN.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnTaoXN.CheckedState.ForeColor = System.Drawing.Color.White;
            this.btnTaoXN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoXN.FillColor = System.Drawing.Color.White;
            this.btnTaoXN.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoXN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnTaoXN.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnTaoXN.ImageOffset = new System.Drawing.Point(10, 0);
            this.btnTaoXN.Location = new System.Drawing.Point(341, 40);
            this.btnTaoXN.Name = "btnTaoXN";
            this.btnTaoXN.Size = new System.Drawing.Size(166, 44);
            this.btnTaoXN.TabIndex = 47;
            this.btnTaoXN.Text = "Tạo xin nghỉ";
            this.btnTaoXN.UseTransparentBackground = true;
            this.btnTaoXN.CheckedChanged += new System.EventHandler(this.btnTaoXN_CheckedChanged);
            // 
            // flp
            // 
            this.flp.AutoScroll = true;
            this.flp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flp.Location = new System.Drawing.Point(0, 124);
            this.flp.Name = "flp";
            this.flp.Size = new System.Drawing.Size(1000, 586);
            this.flp.TabIndex = 48;
            // 
            // FXinNghiNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 710);
            this.Controls.Add(this.flp);
            this.Controls.Add(this.btnTaoXN);
            this.Controls.Add(this.shape);
            this.Controls.Add(this.btnTT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FXinNghiNV";
            this.Text = "s";
            this.Load += new System.EventHandler(this.FXinNghiNV_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Shapes shape;
        private Guna.UI2.WinForms.Guna2Button btnTT;
        private Guna.UI2.WinForms.Guna2Button btnTaoXN;
        private System.Windows.Forms.FlowLayoutPanel flp;
    }
}