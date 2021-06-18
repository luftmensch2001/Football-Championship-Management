using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalFootballChampionshipManagement.DAO
{
    public class MatchDAO
    {
        public static MatchDAO instance;

        public static MatchDAO Instance
        {
            get { if (instance == null) instance = new MatchDAO(); return instance; }
            set => instance = value;
        }

        public void AddMatch(Team team1, Team team2, int round)
        {
            int idmg = LeagueDAO.Instance.GetCurrIDMG(); // Lay id mua giai hien tai
            string query = "EXEC USP_InsertMatch ";
            query += "@idmg = " + idmg.ToString();
            query += ", @vongdau = " + round.ToString();
            query += ", @id1 = " + team1.ID.ToString();
            query += ", @id2 = " + team2.ID.ToString();
            query += ", @stadium = N'" + team1.HostName + "'";
            DataProvider.Instance.ExecuteNonQuery(query);

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetNewIdTranDau @MuaGiai =" + idmg.ToString());
            int newIDTranDau = (int)data.Rows[0][0];
            MessageBox.Show(newIDTranDau.ToString());
            ResultMatchDAO.Instance.AddMatch(newIDTranDau);
        }

        public void DeleteAllMatches()
        {
            string query = "DELETE FROM TranDau";
            ResultMatchDAO.Instance.DeleteAllResultMatch();
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public int GetRoundCount()
        {
            int idmg = LeagueDAO.Instance.GetCurrIDMG();
            string query = "SELECT TOP 1 VongDau FROM TranDau WHERE IDMG = " + idmg.ToString() + " ORDER BY VongDau DESC";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 0) return 0;
            return (int)data.Rows[0]["VongDau"];
        }
        public DataTable GetAllMatches()
        {
            string query = "EXEC USP_GetAllMatches @idmg = " + LeagueDAO.Instance.GetCurrIDMG().ToString();
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable GetMatchesByVongDau(int vongDau)
        {
            string query = "EXEC USP_GetMatchesByVongDau @idmg = " + LeagueDAO.Instance.GetCurrIDMG().ToString();
            query += ", @vongDau = " + vongDau.ToString();
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void UpdateTime(int idTranDau, string timeString)
        {
            string query = "UPDATE TranDau SET ThoiGian = " + timeString + "WHERE IDTranDau = " + idTranDau.ToString();
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
