using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
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
    public class TeamDAO
    {
        private static TeamDAO instance;
        public static TeamDAO Instance
        {
            get { if (instance == null) instance = new TeamDAO(); return instance; }
            set => instance = value;
        }

        int idmg = LeagueDAO.Instance.GetCurrIDMG();

        public void AddTeam(string name, string coach, string host, Image img)
        {
            int idmg = LeagueDAO.Instance.GetCurrIDMG();
            string query = "INSERT INTO DoiBong (TenDB, TenHLV, SanNha, IDMG) VALUES(N'" + name + "',N'" + coach + "',N'" + host + "'," + idmg.ToString() + ")";
            DataProvider.Instance.ExecuteQuery(query);

            byte[] byteArr = ImageProcessing.Instance.convertImgToByte(img);
            query = "UPDATE DoiBong SET HinhAnh = @img WHERE IDDB = (SELECT MAX(IDDB) FROM DoiBong)";
            DataProvider.Instance.ExecuteQuery(query, new object[] { byteArr });
        }

        public void ChangeInforByIDDB(string name, string coach, string host, int IDDB, Image img)
        {
            string query = "EXEC USP_ChangeTeamInforByIDDB";
            query += " @iddb = " + IDDB.ToString();
            query += ", @name = N'" + name + "'";
            query += ", @coach = N'" + coach + "'";
            query += ", @host = N'" + host + "'";
            DataProvider.Instance.ExecuteQuery(query);

            byte[] byteArr = ImageProcessing.Instance.convertImgToByte(img);
            query = "UPDATE DoiBong SET HinhAnh = @img WHERE IDDB = @iddb";
            DataProvider.Instance.ExecuteQuery(query, new object[] { byteArr, IDDB });
        }
        
        public int GetCountPlayer(int iddb)
        {
            string query = "EXEC USP_CountOfPlayer @iddb = " + iddb.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 0) return 0;
            return (int)data.Rows[0]["SL"];
        }

        public int GetCountTeam()
        {
            string query = "EXEC USP_CountOfTeam @idmg = " + this.idmg.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 0) return 0;
            return (int)data.Rows[0]["SL"];
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
        public DataTable LoadTeamListToDataTable()
        {
            int idmg = LeagueDAO.Instance.GetCurrIDMG();
            return DataProvider.Instance.ExecuteQuery("EXEC USP_GetTeamListByIDMG @idmg = " + idmg.ToString());
        }
        public List<Team> LoadValidTeam() // Load team du thanh vien
        {
            List<Team> teams = LoadTeamList();
            int minimumPlayer = RulesDAO.Instance.GetRules().SLTT; // so cau thu toi thieu

            for (int i=0; i<teams.Count; i++)
            {
                if (GetCountPlayer(teams[i].ID) < minimumPlayer)
                {
                    teams.RemoveAt(i);
                    i--;
                }
            }

            return teams;
        }

        public string GetTeamNameByID(int idTeam)
        {
            string query = "SELECT TenDB FROM DoiBong WHERE IDDB = " + idTeam.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count == 0) return "Unknown";
            return data.Rows[0]["TenDB"].ToString();
        }

        public Team GetTeamInforByID(int idTeam)
        {
            string query = "SELECT * FROM DoiBong WHERE IDDB = " + idTeam.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            if (data.Rows.Count == 0) return null;
            return new Team(data.Rows[0]);
        }
        public List<Team> GetNameAndIdTeam()
        {
            List<Team> teams = new List<Team>();

            string query = "SELECT TenDb,iddb FROM DoiBong where idmg =" + idmg.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow dataRow in data.Rows)
            {
                Team team =new Team((int)dataRow[1],dataRow[0].ToString());
                teams.Add(team);
            }
            return teams;
        }
        
    }
}
