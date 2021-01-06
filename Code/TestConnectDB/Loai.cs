using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConnectDB
{
    class Loai : ConnectDB
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; }
        public string MoTa { get; set; }
        public string Hinh { get; set; }

        public List<Loai> GetDanhSachLoai() {
            List<Loai> LLoai = new List<Loai>();
            string sql = "select * from Loai";

            var res = this.SelectQuery(sql);
            while (res.Read())
            {
                Loai loai = new Loai() { 
                    MaLoai = int.Parse(res["MaLoai"].ToString())
                    ,TenLoai = res["TenLoai"].ToString()
                    ,MoTa = res["MoTa"].ToString()
                    ,Hinh = res["Hinh"].ToString()
                };
                LLoai.Add(loai);
            }
            return LLoai;
        }

        public List<Loai> TimKiemLoai(string text)
        {
            List<Loai> LLoai = new List<Loai>();
            string sql = String.Format(@"select * from Loai  where TenLoai like '%{0}%' or MaLoai like '%{0}%'",text);

            var res = this.SelectQuery(sql);
            while (res.Read())
            {
                Loai loai = new Loai()
                {
                    MaLoai = int.Parse(res["MaLoai"].ToString())
                    ,
                    TenLoai = res["TenLoai"].ToString()
                    ,
                    MoTa = res["MoTa"].ToString()
                    ,
                    Hinh = res["Hinh"].ToString()
                };
                LLoai.Add(loai);
            }
            return LLoai;
        }

        public void ThemLoai()
        {
            string sql =
                 string.Format(@"insert Loai (TenLoai,MoTa,Hinh) values (N'{0}',N'{1}',N'{2}')", TenLoai, MoTa, Hinh);
            this.InsertQuery(sql);    
        }

        public Loai GetLoaiById(int maLoai)
        {
            string sql = 
             string.Format(@"select * from Loai where MaLoai = {0}",maLoai);
            var res = this.SelectQuery(sql);
            res.Read();
            return new Loai()
            {
                MaLoai = int.Parse(res["MaLoai"].ToString())
                ,TenLoai = res["TenLoai"].ToString()
                ,MoTa = res["MoTa"].ToString()
                ,Hinh = res["Hinh"].ToString()
            };
        }

        internal void SuaLoai()
        {
            string sql =
                  string.Format(@"update Loai set
TenLoai = N'{0}',
MoTa = N'{1}',
Hinh = N'{2}'
where MaLoai = {3})", TenLoai, MoTa, Hinh,MaLoai);
            this.InsertQuery(sql);
        }
    }
}
