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

            public void AddLeague(string name, int year)
            {
                string query =
                     "INSERT INTO MuaGiai(TenMG, Nam, MuaGiaiHienTai) " + 
                     "VALUES(N'" + name + "'," + year.ToString() + ", 0)";

                DataProvider.Instance.ExecuteQuery(query);

                // Them quy dinh cho giai dau

                query = "SELECT TOP 1 IDMG FROM MuaGiai ORDER BY IDMG DESC";
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                int idmg = (int) data.Rows[0]["IDMG"];

                query = "INSERT INTO QuyDinh(IDMG, SLDB, SLVD) VALUES(" + idmg.ToString() + ",16, 30)";
                DataProvider.Instance.ExecuteQuery(query);
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
            public DataTable GetLeagueList()
            {
                string query = "SELECT * FROM MuaGiai WHERE MuaGiaiHienTai = 0";
                return DataProvider.Instance.ExecuteQuery(query);
            }
        }
    }

}
