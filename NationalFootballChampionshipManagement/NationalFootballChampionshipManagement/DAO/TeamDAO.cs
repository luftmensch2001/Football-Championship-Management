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
    public class TeamDAO
    {
        private static TeamDAO instance;
        public static TeamDAO Instance
        {
            get { if (instance == null) instance = new TeamDAO(); return instance; }
            set => instance = value;
        }

        public void AddTeam(string name, string coach, string host)
        {
            string idmg = LeagueDAO.Instance.GetCurrIDMG().ToString();
            string query = "INSERT INTO DSDoiBong (TenDB, TenHLV, SanNha, IDMG) VALUES(N'" + name + "',N'" + coach + "',N'" + host + "'," + idmg + ")";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public List<Team> LoadTeamList()
        {
            List<Team> teamList = new List<Team>();
            int idmg = LeagueDAO.Instance.GetCurrIDMG();

            DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetTeamListByIDMG @idmg = " + idmg.ToString());

            foreach (DataRow item in data.Rows)
            {
                Team team = new Team(item);
                teamList.Add(team);
            }

            return teamList;
        }
    }
}
