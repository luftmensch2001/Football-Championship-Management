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
    class ResultMatchDAO
    {
        private static ResultMatchDAO instance;

        public static ResultMatchDAO Instance
        {
            get { if (instance == null) instance = new ResultMatchDAO(); return instance; }
            set => instance = value;
        }

        public void AddMatch(int idtrandau)
        {
            string query =
                 "INSERT INTO Ketquathidau(idtrandau) VALUES(" + idtrandau.ToString() + ")";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public List<ResultMatch> LoadResultMatch()
        {
            int idmg = LeagueDAO.Instance.GetCurrIDMG();
            List<ResultMatch> listResultMatch = new List<ResultMatch>();
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("EXEC USP_LoadResultMatch @idmg ="+ idmg.ToString());
            foreach (DataRow item in dataTable.Rows)
            {
                ResultMatch resultMatch = new ResultMatch(item);
                listResultMatch.Add(resultMatch);
            }
            return listResultMatch;
        }
        public List<ResultMatch> LoadResultMatchByName(string team1, string team2)
        {
            List<ResultMatch> listResultMatch = new List<ResultMatch>();
            string query = "EXEC USP_LoadResultMatchByName";
            query += " @TENDOI1 = N'" + team1 + "'";
            query += ", @TENDOI2 = N'" + team2 + "'";
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                ResultMatch resultMatch = new ResultMatch(item);
                listResultMatch.Add(resultMatch);
            }
            return listResultMatch;
        }
        public void SetKQ(int idTranDau, int kqDoi1,int kqDoi2)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE KetQuaThiDau " +
                                    "SET KqDoi1 =" + kqDoi1.ToString() + ", KqDoi2 =" + kqDoi2.ToString() +
                                    "Where IDTRANDAU = " + idTranDau.ToString());
        }
        public void DeleteAllResultMatch()
        {
            int idmg = LeagueDAO.Instance.GetCurrIDMG();
            DataProvider.Instance.ExecuteQuery("Delete from KetQuaThiDau Where IDMG");
        }
    }
}
