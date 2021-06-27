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
            int idmg = LeagueDAO.Instance.GetCurrIDMG();
            List<ResultMatch> listResultMatch = new List<ResultMatch>();
            string query = "EXEC USP_LoadResultMatchByName @idmg = " + idmg;
            query += ", @TENDOI1 = N'" + team1 + "'";
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
        public void DeleteAllResultMatch(List<int> listIDTD)
        {
            foreach (int item in listIDTD)
            {
                DataProvider.Instance.ExecuteQuery("Delete from KetQuaThiDau Where IDTranDau = " + item.ToString());
            }        
        }
        public int GetCountResultMatch(int idmg)
        {
            DataTable dataTable = DataProvider.Instance.ExecuteQuery("Select Count(trandau.idmg) from ketquathidau join trandau on ketquathidau.idtrandau = trandau.idtrandau" +
                                                                " where kqdoi1<>-1 and idmg =" + idmg.ToString());
            return (int)dataTable.Rows[0][0];
        }
    }
}
