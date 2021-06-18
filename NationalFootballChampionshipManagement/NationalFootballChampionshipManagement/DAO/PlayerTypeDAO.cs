using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalFootballChampionshipManagement.DAO
{
    public class PlayerTypeDAO
    {
        private static PlayerTypeDAO instance;
        public static PlayerTypeDAO Instance
        {
            get { if (instance == null) instance = new PlayerTypeDAO(); return instance; }
            set => instance = value;
        }

        public int GetCountPlayerByIDLCT(int idct, int idlct, int iddb) // Get count of players have idlct in team, except this idct
        {
            string query = "USP_GetCountPlayerByIDLCT @idLCT = " + idlct.ToString() + ", @idDB = " + iddb.ToString() + ", @idCT = " + idct.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count == 0) return 0;
            return (int)data.Rows[0]["SL"];
        }

        public int GetMax(int idlct) // Get max player count is possible in this type
        {
            string query = "SELECT SLTD FROM LoaiCauThu WHERE IDLCT = " + idlct.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count == 0) return 1000;
            return (int)data.Rows[0]["SLTD"];
        }

        public void AddNewType(string name, int sltd, int idmg)
        {
            string query = "INSERT INTO LoaiCauThu(TenLCT, SLTD, idmg) VALUES(N'" + name + "', " + sltd.ToString() + ", " + idmg.ToString() +")";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetPlayerTypeList()
        {
            int IDMG = LeagueDAO.Instance.GetCurrIDMG();
            string query = "EXEC USP_GetPlayerTypeListByIDMG @idmg = " + IDMG.ToString();
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void DeleteByID(int idlct)
        {
            string query = "DELETE FROM CauThu WHERE IDLCT = " + idlct.ToString();
            DataProvider.Instance.ExecuteQuery(query);

            query = "DELETE FROM LoaiCauThu WHERE IDLCT = " + idlct.ToString();
            DataProvider.Instance.ExecuteQuery(query);
        }
        public string GetNameByID(int id)
        {
            string query = "SELECT Tenlct FROM LoaiCauThu WHERE IDLCT = " + id.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count == 0) return "Unknown";
            return data.Rows[0]["TenLCT"].ToString();
        }
        public List<PlayerType> GetPlayerTypes()
        {
            List<PlayerType> playerTypes = new List<PlayerType>();
            DataTable dataTable = GetPlayerTypeList();
            int idmg = LeagueDAO.Instance.GetCurrIDMG();
            foreach (DataRow row in dataTable.Rows)
            {
                PlayerType playerType = new PlayerType(row[1].ToString(), idmg, (int)row[2], (int)row[0]);
                playerTypes.Add(playerType);
            }    
            return playerTypes;
        }
    }
}
