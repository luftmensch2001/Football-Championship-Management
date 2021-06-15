using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
using System;
using System.Collections.Generic;
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
        }

        public void DeleteAllMatches()
        {
            string query = "DELETE FROM TranDau";
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
