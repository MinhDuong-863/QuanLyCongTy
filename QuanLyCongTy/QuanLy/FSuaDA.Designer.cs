﻿namespace QuanLyCongTy
{
    partial class FSuaDA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnHuy = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDeadline = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpNgayBD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbTenPB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbl_TenDA = new System.Windows.Forms.Label();
            this.lbl_MoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtDiaDiem = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txtTenDA = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_DeadLine = new System.Windows.Forms.Label();
            this.lbl_NgayBD = new System.Windows.Forms.Label();
            this.lbl_DiaDiem = new System.Windows.Forms.Label();
            this.lbl_TenPB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.gvPhongBanRanh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBanRanh)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHuy
            // 
            this.btnHuy.Animated = true;
            this.btnHuy.BorderRadius = 10;
            this.btnHuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHuy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHuy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHuy.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnHuy.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Location = new System.Drawing.Point(409, 613);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(124, 43);
            this.btnHuy.TabIndex = 80;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnSua
            // 
            this.btnSua.Animated = true;
            this.btnSua.BorderRadius = 10;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSua.Font = new System.Drawing.Font("Calibri", 12F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(279, 613);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(124, 43);
            this.btnSua.TabIndex = 79;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Animated = true;
            this.dtpDeadline.BackColor = System.Drawing.Color.Transparent;
            this.dtpDeadline.BorderRadius = 10;
            this.dtpDeadline.Checked = true;
            this.dtpDeadline.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpDeadline.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.dtpDeadline.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtpDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDeadline.IndicateFocus = true;
            this.dtpDeadline.Location = new System.Drawing.Point(195, 523);
            this.dtpDeadline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDeadline.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDeadline.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(334, 42);
            this.dtpDeadline.TabIndex = 78;
            this.dtpDeadline.UseTransparentBackground = true;
            this.dtpDeadline.Value = new System.DateTime(2023, 5, 11, 0, 25, 48, 267);
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.Animated = true;
            this.dtpNgayBD.BackColor = System.Drawing.Color.Transparent;
            this.dtpNgayBD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.dtpNgayBD.BorderRadius = 10;
            this.dtpNgayBD.BorderThickness = 3;
            this.dtpNgayBD.Checked = true;
            this.dtpNgayBD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayBD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.dtpNgayBD.Font = new System.Drawing.Font("Calibri", 12F);
            this.dtpNgayBD.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpNgayBD.Location = new System.Drawing.Point(195, 441);
            this.dtpNgayBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgayBD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpNgayBD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(334, 42);
            this.dtpNgayBD.TabIndex = 77;
            this.dtpNgayBD.Value = new System.DateTime(2023, 5, 11, 0, 25, 48, 267);
            // 
            // cmbTenPB
            // 
            this.cmbTenPB.BackColor = System.Drawing.Color.Transparent;
            this.cmbTenPB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.cmbTenPB.BorderRadius = 10;
            this.cmbTenPB.BorderThickness = 2;
            this.cmbTenPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTenPB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTenPB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTenPB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenPB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTenPB.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbTenPB.ForeColor = System.Drawing.Color.Black;
            this.cmbTenPB.ItemHeight = 30;
            this.cmbTenPB.Location = new System.Drawing.Point(192, 311);
            this.cmbTenPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTenPB.Name = "cmbTenPB";
            this.cmbTenPB.Size = new System.Drawing.Size(333, 36);
            this.cmbTenPB.TabIndex = 76;
            // 
            // lbl_TenDA
            // 
            this.lbl_TenDA.AutoSize = true;
            this.lbl_TenDA.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenDA.Location = new System.Drawing.Point(47, 82);
            this.lbl_TenDA.Name = "lbl_TenDA";
            this.lbl_TenDA.Size = new System.Drawing.Size(98, 24);
            this.lbl_TenDA.TabIndex = 64;
            this.lbl_TenDA.Text = "Tên dự án:";
            // 
            // lbl_MoTa
            // 
            this.lbl_MoTa.AutoSize = true;
            this.lbl_MoTa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MoTa.Location = new System.Drawing.Point(73, 133);
            this.lbl_MoTa.Name = "lbl_MoTa";
            this.lbl_MoTa.Size = new System.Drawing.Size(65, 24);
            this.lbl_MoTa.TabIndex = 65;
            this.lbl_MoTa.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            this.txtMoTa.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.txtMoTa.BorderRadius = 15;
            this.txtMoTa.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtMoTa.BorderThickness = 2;
            this.txtMoTa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMoTa.DefaultText = "";
            this.txtMoTa.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMoTa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMoTa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMoTa.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtMoTa.ForeColor = System.Drawing.Color.Black;
            this.txtMoTa.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMoTa.Location = new System.Drawing.Point(52, 145);
            this.txtMoTa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.PasswordChar = '\0';
            this.txtMoTa.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMoTa.PlaceholderText = "";
            this.txtMoTa.SelectedText = "";
            this.txtMoTa.Size = new System.Drawing.Size(482, 139);
            this.txtMoTa.TabIndex = 75;
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Shapes2.BorderThickness = 0;
            this.guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.guna2Shapes2.LineEndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            this.guna2Shapes2.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes2.LineThickness = 2;
            this.guna2Shapes2.Location = new System.Drawing.Point(192, 400);
            this.guna2Shapes2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes2.Size = new System.Drawing.Size(334, 12);
            this.guna2Shapes2.TabIndex = 74;
            this.guna2Shapes2.Text = "guna2Shapes2";
            this.guna2Shapes2.UseTransparentBackground = true;
            this.guna2Shapes2.Zoom = 100;
            // 
            // txtDiaDiem
            // 
            this.txtDiaDiem.Animated = true;
            this.txtDiaDiem.BorderColor = System.Drawing.Color.White;
            this.txtDiaDiem.BorderRadius = 10;
            this.txtDiaDiem.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtDiaDiem.BorderThickness = 0;
            this.txtDiaDiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDiaDiem.DefaultText = "";
            this.txtDiaDiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDiaDiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDiaDiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaDiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDiaDiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaDiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtDiaDiem.ForeColor = System.Drawing.Color.Black;
            this.txtDiaDiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDiaDiem.Location = new System.Drawing.Point(192, 370);
            this.txtDiaDiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaDiem.Name = "txtDiaDiem";
            this.txtDiaDiem.PasswordChar = '\0';
            this.txtDiaDiem.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtDiaDiem.PlaceholderText = "";
            this.txtDiaDiem.SelectedText = "";
            this.txtDiaDiem.Size = new System.Drawing.Size(334, 40);
            this.txtDiaDiem.TabIndex = 73;
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Shapes1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2Shapes1.BorderThickness = 0;
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.guna2Shapes1.LineEndCap = System.Drawing.Drawing2D.LineCap.NoAnchor;
            this.guna2Shapes1.LineStartCap = System.Drawing.Drawing2D.LineCap.Round;
            this.guna2Shapes1.LineThickness = 2;
            this.guna2Shapes1.Location = new System.Drawing.Point(145, 102);
            this.guna2Shapes1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(388, 11);
            this.guna2Shapes1.TabIndex = 72;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.UseTransparentBackground = true;
            this.guna2Shapes1.Zoom = 100;
            // 
            // txtTenDA
            // 
            this.txtTenDA.Animated = true;
            this.txtTenDA.BorderColor = System.Drawing.Color.White;
            this.txtTenDA.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.txtTenDA.BorderThickness = 0;
            this.txtTenDA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDA.DefaultText = "";
            this.txtTenDA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDA.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDA.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTenDA.ForeColor = System.Drawing.Color.Black;
            this.txtTenDA.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDA.Location = new System.Drawing.Point(145, 74);
            this.txtTenDA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDA.Name = "txtTenDA";
            this.txtTenDA.PasswordChar = '\0';
            this.txtTenDA.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTenDA.PlaceholderText = "";
            this.txtTenDA.SelectedText = "";
            this.txtTenDA.Size = new System.Drawing.Size(388, 40);
            this.txtTenDA.TabIndex = 71;
            // 
            // lbl_DeadLine
            // 
            this.lbl_DeadLine.AutoSize = true;
            this.lbl_DeadLine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_DeadLine.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DeadLine.Location = new System.Drawing.Point(40, 523);
            this.lbl_DeadLine.Name = "lbl_DeadLine";
            this.lbl_DeadLine.Size = new System.Drawing.Size(90, 24);
            this.lbl_DeadLine.TabIndex = 69;
            this.lbl_DeadLine.Text = "Thời hạn:";
            // 
            // lbl_NgayBD
            // 
            this.lbl_NgayBD.AutoSize = true;
            this.lbl_NgayBD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_NgayBD.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NgayBD.Location = new System.Drawing.Point(40, 450);
            this.lbl_NgayBD.Name = "lbl_NgayBD";
            this.lbl_NgayBD.Size = new System.Drawing.Size(126, 24);
            this.lbl_NgayBD.TabIndex = 68;
            this.lbl_NgayBD.Text = "Ngày bắt đầu:";
            // 
            // lbl_DiaDiem
            // 
            this.lbl_DiaDiem.AutoSize = true;
            this.lbl_DiaDiem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DiaDiem.Location = new System.Drawing.Point(40, 382);
            this.lbl_DiaDiem.Name = "lbl_DiaDiem";
            this.lbl_DiaDiem.Size = new System.Drawing.Size(89, 24);
            this.lbl_DiaDiem.TabIndex = 67;
            this.lbl_DiaDiem.Text = "Địa điểm:";
            // 
            // lbl_TenPB
            // 
            this.lbl_TenPB.AutoSize = true;
            this.lbl_TenPB.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenPB.Location = new System.Drawing.Point(35, 317);
            this.lbl_TenPB.Name = "lbl_TenPB";
            this.lbl_TenPB.Size = new System.Drawing.Size(144, 24);
            this.lbl_TenPB.TabIndex = 66;
            this.lbl_TenPB.Text = "Tên phòng ban: ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 38);
            this.label1.TabIndex = 81;
            this.label1.Text = "Chỉnh sửa dự án     \r\n\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyCongTy.Properties.Resources.pencil;
            this.pictureBox1.Location = new System.Drawing.Point(200, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 21);
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.CustomIconSize = 20F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(101)))), ((int)(((byte)(189)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(1268, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(62, 32);
            this.guna2ControlBox1.TabIndex = 84;
            // 
            // gvPhongBanRanh
            // 
            this.gvPhongBanRanh.AllowUserToAddRows = false;
            this.gvPhongBanRanh.AllowUserToDeleteRows = false;
            this.gvPhongBanRanh.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPhongBanRanh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(70)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(70)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPhongBanRanh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvPhongBanRanh.ColumnHeadersHeight = 50;
            this.gvPhongBanRanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvPhongBanRanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenPB,
            this.TenDA,
            this.NgayBD,
            this.DL});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvPhongBanRanh.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvPhongBanRanh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.Location = new System.Drawing.Point(565, 74);
            this.gvPhongBanRanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gvPhongBanRanh.Name = "gvPhongBanRanh";
            this.gvPhongBanRanh.ReadOnly = true;
            this.gvPhongBanRanh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvPhongBanRanh.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gvPhongBanRanh.RowHeadersVisible = false;
            this.gvPhongBanRanh.RowHeadersWidth = 62;
            this.gvPhongBanRanh.RowTemplate.Height = 28;
            this.gvPhongBanRanh.Size = new System.Drawing.Size(742, 413);
            this.gvPhongBanRanh.TabIndex = 129;
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPhongBanRanh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvPhongBanRanh.ThemeStyle.HeaderStyle.Height = 50;
            this.gvPhongBanRanh.ThemeStyle.ReadOnly = true;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.Height = 28;
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvPhongBanRanh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TenPB
            // 
            this.TenPB.DataPropertyName = "TenPB";
            this.TenPB.FillWeight = 136.3637F;
            this.TenPB.HeaderText = "Phòng ban";
            this.TenPB.MinimumWidth = 8;
            this.TenPB.Name = "TenPB";
            this.TenPB.ReadOnly = true;
            // 
            // TenDA
            // 
            this.TenDA.DataPropertyName = "TenDuAn";
            this.TenDA.HeaderText = "Dự Án";
            this.TenDA.MinimumWidth = 6;
            this.TenDA.Name = "TenDA";
            this.TenDA.ReadOnly = true;
            // 
            // NgayBD
            // 
            this.NgayBD.DataPropertyName = "NgayBD";
            this.NgayBD.HeaderText = "Bắt đầu";
            this.NgayBD.MinimumWidth = 6;
            this.NgayBD.Name = "NgayBD";
            this.NgayBD.ReadOnly = true;
            // 
            // DL
            // 
            this.DL.DataPropertyName = "DeadLine";
            this.DL.FillWeight = 81.81828F;
            this.DL.HeaderText = "Thời hạn";
            this.DL.MinimumWidth = 8;
            this.DL.Name = "DL";
            this.DL.ReadOnly = true;
            // 
            // FSuaDA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1329, 720);
            this.Controls.Add(this.gvPhongBanRanh);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dtpDeadline);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.cmbTenPB);
            this.Controls.Add(this.lbl_TenDA);
            this.Controls.Add(this.lbl_MoTa);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.guna2Shapes2);
            this.Controls.Add(this.txtDiaDiem);
            this.Controls.Add(this.guna2Shapes1);
            this.Controls.Add(this.txtTenDA);
            this.Controls.Add(this.lbl_DeadLine);
            this.Controls.Add(this.lbl_NgayBD);
            this.Controls.Add(this.lbl_DiaDiem);
            this.Controls.Add(this.lbl_TenPB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FSuaDA";
            this.Text = "FSuaDA";
            this.Load += new System.EventHandler(this.FSuaDA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvPhongBanRanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnHuy;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDeadline;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpNgayBD;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTenPB;
        private System.Windows.Forms.Label lbl_TenDA;
        private System.Windows.Forms.Label lbl_MoTa;
        private Guna.UI2.WinForms.Guna2TextBox txtMoTa;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2TextBox txtDiaDiem;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDA;
        private System.Windows.Forms.Label lbl_DeadLine;
        private System.Windows.Forms.Label lbl_NgayBD;
        private System.Windows.Forms.Label lbl_DiaDiem;
        private System.Windows.Forms.Label lbl_TenPB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DataGridView gvPhongBanRanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DL;
    }
}