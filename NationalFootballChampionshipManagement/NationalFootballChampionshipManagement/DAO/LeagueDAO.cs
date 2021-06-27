using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalFootballChampionshipManagement.DAO
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace NationalFootballChampionshipManagement.DAO
    {
        public class LeagueDAO
        {
            private static LeagueDAO instance;
            public static LeagueDAO Instance
            {
                get { if (instance == null) instance = new LeagueDAO(); return instance; }
                set => instance = value;
            }

            public void AddLeague(string name, int year, Image img)
            {
                byte[] byteArr = ImageProcessing.Instance.convertImgToByte(img);
                string query =
                     "INSERT INTO MuaGiai(TenMG, Nam, MuaGiaiHienTai, TrangThai) " +
                     "VALUES(N'" + name + "'," + year.ToString() + ", 0, 0)";

                DataProvider.Instance.ExecuteQuery(query);

                // them logo

                query = "UPDATE MuaGiai SET Logo = @img WHERE IDMG = (SELECT MAX(IDMG) FROM MuaGiai)";
                DataProvider.Instance.ExecuteQuery(query, new object[] { byteArr });

                // Neu la mua giai dau tien thi gan la mua giai hien tai

                if (LeagueDAO.Instance.GetCurrIDMG() == -1)
                {
                    query = "UPDATE MuaGiai SET MuaGiaiHienTai = 1";
                    DataProvider.Instance.ExecuteQuery(query);
                }

                // Tu dong them quy dinh cho giai dau

                query = "SELECT TOP 1 IDMG FROM MuaGiai ORDER BY IDMG DESC";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                int idmg = (int)data.Rows[0]["IDMG"];

                query = "INSERT INTO QuyDinh(IDMG) VALUES(" + idmg.ToString() + ")";
                DataProvider.Instance.ExecuteQuery(query);

                query = "INSERT INTO QuyDinhDiemSo(IDMG) VALUES(" + idmg.ToString() + ")";
                DataProvider.Instance.ExecuteQuery(query);

                query = "INSERT INTO QuyDinhXepHang(Ten, ThuTuUuTien, IDMG) VALUES(";

                string QD1 = "Điểm";
                string QD2 = "Hiệu số đối đầu";
                string QD3 = "Hiệu số bàn thắng";
                string QD4 = "Tổng số bàn thắng";
                string QD5 = "Tổng số trận thắng";

                DataProvider.Instance.ExecuteQuery(query + "N'" + QD1 + "', 1," + idmg + ")");
                DataProvider.Instance.ExecuteQuery(query + "N'" + QD2 + "', 2," + idmg + ")");
                DataProvider.Instance.ExecuteQuery(query + "N'" + QD3 + "', 3," + idmg + ")");
                DataProvider.Instance.ExecuteQuery(query + "N'" + QD4 + "', 4," + idmg + ")");
                DataProvider.Instance.ExecuteQuery(query + "N'" + QD5 + "', 5," + idmg + ")");

            }

            public void ChangeLeagueByID(int idmg)
            {
                string query = "UPDATE MuaGiai SET MuaGiaiHienTai = 0 WHERE 1 = 1";
                DataProvider.Instance.ExecuteQuery(query);
                query = "UPDATE MuaGiai SET MuaGiaiHienTai = 1 WHERE IDMG = " + idmg.ToString();
                DataProvider.Instance.ExecuteQuery(query);
            }

            public int GetCurrIDMG()
            {
                string query = "SELECT IDMG FROM MuaGiai WHERE MuaGiaiHienTai = 1";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                if (data.Rows.Count == 0) return -1;
                return (int) data.Rows[0]["IDMG"];
            }

            public string GetCurrLeagueName()
            {
                string query = "SELECT TenMG FROM MuaGiai WHERE MuaGiaiHienTai = 1";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                if (data.Rows.Count == 0) return "No League Selected";
                return data.Rows[0]["TenMG"].ToString();
            }

            public string GetCurrLeagueYear()
            {
                string query = "SELECT Nam FROM MuaGiai WHERE MuaGiaiHienTai = 1";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                if (data.Rows.Count == 0) return "No League Selected";
                return data.Rows[0]["Nam"].ToString();
            }

            public string GetCurrLeagueStatus()
            {
                string query = "SELECT TrangThai FROM MuaGiai WHERE MuaGiaiHienTai = 1";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                if (data.Rows.Count == 0) return "No League Selected";
                int status =  (int) data.Rows[0]["TrangThai"];
                switch (status)
                {
                    case 0: return "Trạng thái: Đang đăng ký";
                        break;
                    case 1: return "Trạng thái: Chuẩn bị bắt đầu";
                        break;
                    case 2: return "Trạng thái: Đã bắt đầu";
                        break;
                }
                return "No League Selected";
            }

            public void UpdateStatus(int status)
            {
                string query = "UPDATE MuaGiai SET TrangThai = " + status.ToString() + "WHERE MuaGiaiHienTai = 1";
                try
                {
                    DataProvider.Instance.ExecuteQuery(query);
                }
                catch
                {
                    MessageBox.Show("Lỗi không xác định");
                }
            }

            public Image GetCurrLeagueImage()
            {
                string query = "SELECT Logo FROM MuaGiai WHERE MuaGiaiHienTai = 1";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);

                if (data.Rows.Count == 0) return null;
                return ImageProcessing.Instance.ByteToImg((byte[])data.Rows[0]["Logo"]); 
            }
            public DataTable GetLeagueList()
            {
                string query = "SELECT * FROM MuaGiai WHERE MuaGiaiHienTai = 0";
                return DataProvider.Instance.ExecuteQuery(query);
            }
        }
    }

}
