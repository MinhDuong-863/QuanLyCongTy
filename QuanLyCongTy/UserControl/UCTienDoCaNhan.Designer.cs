namespace QuanLyCongTy
{
    partial class UCTienDoCaNhan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTen = new System.Windows.Forms.Label();
            this.prgTD = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.lblTD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTen
            // 
            this.lblTen.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(14, 14);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(299, 24);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Họ tên";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgTD
            // 
            this.prgTD.Location = new System.Drawing.Point(319, 15);
            this.prgTD.Name = "prgTD";
            this.prgTD.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(135)))), ((int)(((byte)(222)))));
            this.prgTD.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(85)))), ((int)(((byte)(173)))));
            this.prgTD.Size = new System.Drawing.Size(422, 23);
            this.prgTD.TabIndex = 1;
            this.prgTD.Text = "guna2ProgressBar1";
            this.prgTD.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.prgTD.Value = 100;
            // 
            // lblTD
            // 
            this.lblTD.AutoSize = true;
            this.lblTD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTD.Location = new System.Drawing.Point(747, 14);
            this.lblTD.Name = "lblTD";
            this.lblTD.Size = new System.Drawing.Size(24, 24);
            this.lblTD.TabIndex = 2;
            this.lblTD.Text = "%";
            // 
            // UCTienDoCaNhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTD);
            this.Controls.Add(this.prgTD);
            this.Controls.Add(this.lblTen);
            this.Name = "UCTienDoCaNhan";
            this.Size = new System.Drawing.Size(800, 50);
            this.Load += new System.EventHandler(this.UCTienDoCaNhan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTen;
        private Guna.UI2.WinForms.Guna2ProgressBar prgTD;
        private System.Windows.Forms.Label lblTD;
    }
}
