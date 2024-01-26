namespace Week_01
{
    partial class FHocSinh
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
            this.lblHoVaTen = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblNgayThangNamSinh = new System.Windows.Forms.Label();
            this.tbxHoVaTen = new System.Windows.Forms.TextBox();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.tbxDiaChi = new System.Windows.Forms.TextBox();
            this.dtpkrNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvwHocSinh = new System.Windows.Forms.DataGridView();
            this.hocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGiangVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Location = new System.Drawing.Point(58, 66);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(77, 20);
            this.lblHoVaTen.TabIndex = 0;
            this.lblHoVaTen.Text = "Ho va ten";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(58, 135);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(57, 20);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Dia chi";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(58, 206);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(56, 20);
            this.lblCMND.TabIndex = 2;
            this.lblCMND.Text = "CMND";
            // 
            // lblNgayThangNamSinh
            // 
            this.lblNgayThangNamSinh.AutoSize = true;
            this.lblNgayThangNamSinh.Location = new System.Drawing.Point(58, 274);
            this.lblNgayThangNamSinh.Name = "lblNgayThangNamSinh";
            this.lblNgayThangNamSinh.Size = new System.Drawing.Size(158, 20);
            this.lblNgayThangNamSinh.TabIndex = 3;
            this.lblNgayThangNamSinh.Text = "Ngay thang nam sinh";
            // 
            // tbxHoVaTen
            // 
            this.tbxHoVaTen.Location = new System.Drawing.Point(230, 62);
            this.tbxHoVaTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxHoVaTen.Name = "tbxHoVaTen";
            this.tbxHoVaTen.Size = new System.Drawing.Size(224, 26);
            this.tbxHoVaTen.TabIndex = 1;
            // 
            // tbxCMND
            // 
            this.tbxCMND.Location = new System.Drawing.Point(230, 202);
            this.tbxCMND.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(224, 26);
            this.tbxCMND.TabIndex = 3;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(230, 131);
            this.tbxDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(224, 26);
            this.tbxDiaChi.TabIndex = 2;
            // 
            // dtpkrNgaySinh
            // 
            this.dtpkrNgaySinh.Location = new System.Drawing.Point(230, 268);
            this.dtpkrNgaySinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpkrNgaySinh.Name = "dtpkrNgaySinh";
            this.dtpkrNgaySinh.Size = new System.Drawing.Size(224, 26);
            this.dtpkrNgaySinh.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(62, 355);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 29);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(218, 355);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 29);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(370, 355);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(84, 29);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvwHocSinh
            // 
            this.dgvwHocSinh.AutoGenerateColumns = false;
            this.dgvwHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwHocSinh.DataSource = this.hocSinhBindingSource;
            this.dgvwHocSinh.Location = new System.Drawing.Point(482, 62);
            this.dgvwHocSinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvwHocSinh.Name = "dgvwHocSinh";
            this.dgvwHocSinh.RowHeadersWidth = 51;
            this.dgvwHocSinh.RowTemplate.Height = 24;
            this.dgvwHocSinh.Size = new System.Drawing.Size(495, 232);
            this.dgvwHocSinh.TabIndex = 11;
            // 
            // hocSinhBindingSource
            // 
            this.hocSinhBindingSource.DataMember = "HocSinh";
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGiangVien.Location = new System.Drawing.Point(720, 355);
            this.btnGiangVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(162, 29);
            this.btnGiangVien.TabIndex = 12;
            this.btnGiangVien.Text = "GiangVien";
            this.btnGiangVien.UseVisualStyleBackColor = false;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1086, 540);
            this.Controls.Add(this.btnGiangVien);
            this.Controls.Add(this.dgvwHocSinh);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dtpkrNgaySinh);
            this.Controls.Add(this.tbxDiaChi);
            this.Controls.Add(this.tbxCMND);
            this.Controls.Add(this.tbxHoVaTen);
            this.Controls.Add(this.lblNgayThangNamSinh);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblHoVaTen);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FHocSinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHocSinh";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvwHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblHoVaTen;
        public System.Windows.Forms.Label lblDiaChi;
        public System.Windows.Forms.Label lblCMND;
        public System.Windows.Forms.Label lblNgayThangNamSinh;
        public System.Windows.Forms.TextBox tbxHoVaTen;
        public System.Windows.Forms.TextBox tbxCMND;
        public System.Windows.Forms.TextBox tbxDiaChi;
        public System.Windows.Forms.DateTimePicker dtpkrNgaySinh;
        public System.Windows.Forms.Button btnThem;
        public System.Windows.Forms.Button btnXoa;
        public System.Windows.Forms.Button btnSua;
        public System.Windows.Forms.DataGridView dgvwHocSinh;
        public System.Windows.Forms.Button btnGiangVien;
        public System.Windows.Forms.BindingSource hocSinhBindingSource;
        public System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn diachiDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn cmndDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridViewTextBoxColumn ngaySinhDataGridViewTextBoxColumn;
    }
}

