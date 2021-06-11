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
            string query = "INSERT INTO DSDoiBong (TenDB, TenHLV, SanNha) VALUES(N'" + name + "',N'" + coach + "',N'"+ host +"')";
            DataProvider.Instance.ExecuteQuery(query);
        }

        public List<Team> LoadTeamList()
        {
            List<Team> teamList = new List<Team>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTeamList");

            foreach (DataRow item in data.Rows)
            {
                Team team = new Team(item);
                teamList.Add(team);
            }

            return teamList;
        }
    }
}
