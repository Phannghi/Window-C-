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
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmndDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaySinhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocSinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnGiangVien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocSinhBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHoVaTen
            // 
            this.lblHoVaTen.AutoSize = true;
            this.lblHoVaTen.Location = new System.Drawing.Point(52, 53);
            this.lblHoVaTen.Name = "lblHoVaTen";
            this.lblHoVaTen.Size = new System.Drawing.Size(64, 16);
            this.lblHoVaTen.TabIndex = 0;
            this.lblHoVaTen.Text = "Ho va ten";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(52, 108);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(48, 16);
            this.lblDiaChi.TabIndex = 1;
            this.lblDiaChi.Text = "Dia chi";
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(52, 165);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(47, 16);
            this.lblCMND.TabIndex = 2;
            this.lblCMND.Text = "CMND";
            // 
            // lblNgayThangNamSinh
            // 
            this.lblNgayThangNamSinh.AutoSize = true;
            this.lblNgayThangNamSinh.Location = new System.Drawing.Point(52, 219);
            this.lblNgayThangNamSinh.Name = "lblNgayThangNamSinh";
            this.lblNgayThangNamSinh.Size = new System.Drawing.Size(132, 16);
            this.lblNgayThangNamSinh.TabIndex = 3;
            this.lblNgayThangNamSinh.Text = "Ngay thang nam sinh";
            // 
            // tbxHoVaTen
            // 
            this.tbxHoVaTen.Location = new System.Drawing.Point(204, 50);
            this.tbxHoVaTen.Name = "tbxHoVaTen";
            this.tbxHoVaTen.Size = new System.Drawing.Size(200, 22);
            this.tbxHoVaTen.TabIndex = 1;
            // 
            // tbxCMND
            // 
            this.tbxCMND.Location = new System.Drawing.Point(204, 162);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(200, 22);
            this.tbxCMND.TabIndex = 3;
            // 
            // tbxDiaChi
            // 
            this.tbxDiaChi.Location = new System.Drawing.Point(204, 105);
            this.tbxDiaChi.Name = "tbxDiaChi";
            this.tbxDiaChi.Size = new System.Drawing.Size(200, 22);
            this.tbxDiaChi.TabIndex = 2;
            // 
            // dtpkrNgaySinh
            // 
            this.dtpkrNgaySinh.Location = new System.Drawing.Point(204, 214);
            this.dtpkrNgaySinh.Name = "dtpkrNgaySinh";
            this.dtpkrNgaySinh.Size = new System.Drawing.Size(200, 22);
            this.dtpkrNgaySinh.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(55, 284);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Them";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(194, 284);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xoa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(329, 284);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sua";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvwHocSinh
            // 
            this.dgvwHocSinh.AutoGenerateColumns = false;
            this.dgvwHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDataGridViewTextBoxColumn,
            this.diachiDataGridViewTextBoxColumn,
            this.cmndDataGridViewTextBoxColumn,
            this.ngaySinhDataGridViewTextBoxColumn});
            this.dgvwHocSinh.DataSource = this.hocSinhBindingSource;
            this.dgvwHocSinh.Location = new System.Drawing.Point(428, 50);
            this.dgvwHocSinh.Name = "dgvwHocSinh";
            this.dgvwHocSinh.RowHeadersWidth = 51;
            this.dgvwHocSinh.RowTemplate.Height = 24;
            this.dgvwHocSinh.Size = new System.Drawing.Size(440, 186);
            this.dgvwHocSinh.TabIndex = 11;
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Ten";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.Width = 125;
            // 
            // diachiDataGridViewTextBoxColumn
            // 
            this.diachiDataGridViewTextBoxColumn.DataPropertyName = "Diachi";
            this.diachiDataGridViewTextBoxColumn.HeaderText = "Diachi";
            this.diachiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diachiDataGridViewTextBoxColumn.Name = "diachiDataGridViewTextBoxColumn";
            this.diachiDataGridViewTextBoxColumn.Width = 125;
            // 
            // cmndDataGridViewTextBoxColumn
            // 
            this.cmndDataGridViewTextBoxColumn.DataPropertyName = "Cmnd";
            this.cmndDataGridViewTextBoxColumn.HeaderText = "Cmnd";
            this.cmndDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cmndDataGridViewTextBoxColumn.Name = "cmndDataGridViewTextBoxColumn";
            this.cmndDataGridViewTextBoxColumn.Width = 125;
            // 
            // ngaySinhDataGridViewTextBoxColumn
            // 
            this.ngaySinhDataGridViewTextBoxColumn.DataPropertyName = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.HeaderText = "NgaySinh";
            this.ngaySinhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngaySinhDataGridViewTextBoxColumn.Name = "ngaySinhDataGridViewTextBoxColumn";
            this.ngaySinhDataGridViewTextBoxColumn.Width = 125;
            // 
            // hocSinhBindingSource
            // 
            this.hocSinhBindingSource.DataMember = "HocSinh";
            // 
            // qLHocSinhDataSet
            // 
            // 
            // btnGiangVien
            // 
            this.btnGiangVien.Location = new System.Drawing.Point(724, 284);
            this.btnGiangVien.Name = "btnGiangVien";
            this.btnGiangVien.Size = new System.Drawing.Size(144, 23);
            this.btnGiangVien.TabIndex = 12;
            this.btnGiangVien.Text = "GiangVien";
            this.btnGiangVien.UseVisualStyleBackColor = true;
            this.btnGiangVien.Click += new System.EventHandler(this.btnGiangVien_Click);
            // 
            // hocSinhTableAdapter
            // 
            // 
            // FHocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 330);
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

