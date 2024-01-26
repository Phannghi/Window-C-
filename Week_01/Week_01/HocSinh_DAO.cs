using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_01
{
    internal class HocSinh_DAO
    {
        public HocSinh_DAO() { }

        public DataTable Load()
        {
            string sqlStr = string.Format("SELECT *FROM HocSinh");
            DBconnection db = new DBconnection(sqlStr);
            return db.Load();
        }

        public void thucThi(string sqlStr)
        {
            DBconnection db = new DBconnection(sqlStr);
            db.thucThi();
        }
        public void Them(HocSinh hs)
        {
            string sqlStr = string.Format("INSERT INTO HocSinh(Ten , Diachi, Cmnd, NgaySinh) VALUES ('{0}', '{1}', '{2}', '{3}')", hs.Ten, hs.DiaChi, hs.Cmnd, hs.NgaySinh);
            thucThi(sqlStr);
        }
        public void Xoa(HocSinh hs)
        {
            string sqlStr = string.Format("DELETE FROM HocSinh WHERE Cmnd = ('{0}')", hs.Cmnd);
            thucThi(sqlStr);
        }
        public void Sua(HocSinh hs)
        {
            string sqlStr = string.Format("UPDATE HocSinh SET Ten = '{0}', DiaChi ='{1}', Cmnd = '{2}', NgaySinh = '{3}' WHERE Cmnd = {2}", hs.Ten, hs.DiaChi, hs.Cmnd, hs.NgaySinh);
            thucThi(sqlStr);
        }
    }
}
