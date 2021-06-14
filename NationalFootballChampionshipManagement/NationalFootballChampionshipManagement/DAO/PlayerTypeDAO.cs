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

        public List<PlayerType> LoadPlayerTypeList()
        {
            List<PlayerType> playerTypeList = new List<PlayerType>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetPlayerTypeList");

            foreach (DataRow item in data.Rows)
            {
                PlayerType playerType = new PlayerType(item);
                playerTypeList.Add(playerType);
            }

            return playerTypeList;
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
    }
}
