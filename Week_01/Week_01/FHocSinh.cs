using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Week_01
{
    public partial class FHocSinh : Form
    {
        HocSinh_DAO hsDao = new HocSinh_DAO();
        public FHocSinh()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {            
            DataTable dt = hsDao.Load();
            dgvwHocSinh.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            HocSinh hs = new HocSinh(tbxHoVaTen.Text, tbxDiaChi.Text, tbxCMND.Text, dtpkrNgaySinh.Value.ToShortDateString());
            hsDao.Them(hs);
            Form1_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            HocSinh hs = new HocSinh(tbxCMND.Text);
            hsDao.Xoa(hs);
            Form1_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            HocSinh hs = new HocSinh(tbxHoVaTen.Text, tbxDiaChi.Text, tbxCMND.Text, dtpkrNgaySinh.Value.ToShortDateString());
            hsDao.Sua(hs);
            Form1_Load(sender, e);
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            FGiangVien f2 = new FGiangVien();
            f2.ShowDialog();
        }
    }
}
