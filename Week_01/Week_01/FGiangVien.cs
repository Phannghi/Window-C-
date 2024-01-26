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

namespace Week_01
{
    public partial class FGiangVien : Form
    {
        //SqlConnection conn = new SqlConnection(Properties.Settings.Default.connStr);
        public FGiangVien()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            GiangVien_DAO gvDao = new GiangVien_DAO();
            DataTable dt = gvDao.Load();
            dgvwGiangVien.DataSource = dt;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiangVien_DAO gvDao = new GiangVien_DAO();
            GiangVien gv = new GiangVien(tbxHoVaTen.Text, tbxDiaChi.Text, tbxCMND.Text, dtpkrNgaySinh.Value.ToShortDateString());
            gvDao.Them(gv);
            Form2_Load(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiangVien_DAO gvDao = new GiangVien_DAO();
            GiangVien gv = new GiangVien(tbxCMND.Text);
            gvDao.Xoa(gv);
            Form2_Load(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            GiangVien_DAO gvDao = new GiangVien_DAO();
            GiangVien gv = new GiangVien(tbxHoVaTen.Text, tbxDiaChi.Text, tbxCMND.Text, dtpkrNgaySinh.Value.ToShortDateString());
            gvDao.Sua(gv);
            Form2_Load(sender, e);
        }
    }
}
