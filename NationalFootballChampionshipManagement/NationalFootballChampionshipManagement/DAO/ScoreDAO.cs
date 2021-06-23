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
    class ScoreDAO
    {
        private static ScoreDAO instance;
        public static ScoreDAO Instance
        {
            get { if (instance == null) instance = new ScoreDAO(); return instance; }
            set => instance = value;
        }

        public Score GetScoreRule()
        {
            int idmg = LeagueDAO.Instance.GetCurrIDMG();
            string query = "EXEC USP_GetScoreRule_By_IDMG @idmg = " + idmg.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            Score score = new Score(data.Rows[0]);
            return score;
        }

        public void UpdateScoreRule(int thang, int hoa, int thua)
        {
            int idmg = LeagueDAO.Instance.GetCurrIDMG(); // Lay id mua giai hien tai
            string query = "EXEC USP_UpdateScoreRule_By_IDMG ";
            query += "@idmg = " + idmg;
            query += ", @THANG = " + thang;
            query += ", @HOA = " + hoa;
            query += ", @THUA = " + thua;
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
