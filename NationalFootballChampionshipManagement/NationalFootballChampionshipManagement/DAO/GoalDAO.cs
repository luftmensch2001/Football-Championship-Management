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
    class GoalDAO
    {
        private static GoalDAO instance;

        public static GoalDAO Instance
        {
            get { if (instance == null) instance = new GoalDAO(); return instance; }
            set => instance = value;
        }
        public void AddGoal(int idTranDau, int idDoiBong, int idCauThu, int idLoaiBanThang, string thoiDiem)
        {
            string query =
                 "INSERT INTO BANTHANG(idtrandau,iddb,idct,idlbt,thoidiem) VALUES(" + idTranDau.ToString() + ", " + idDoiBong.ToString() + ", " + idCauThu.ToString() + ", " + idLoaiBanThang.ToString() + ", " +"'" +thoiDiem + "')";
            DataProvider.Instance.ExecuteQuery(query);
        }
        public List<Goal> LoadGoads(int idTranDau)
        {
            List<Goal> goals = new List<Goal>();

            DataTable dataTable = DataProvider.Instance.ExecuteQuery("EXEC USP_LoadGoals @IDTRANDAU = " + idTranDau.ToString());
            foreach (DataRow item in dataTable.Rows)
            {
                Goal goal = new Goal((int)item[0], (int)item[1], (int)item[2], (int)item[3], (string)item[4], (int)item[5]);
                goals.Add(goal);
            }
            
            return goals;
        }
        public void UpdateGoal(int idBanThang, int idCauThu, int idLoaiBanThang, string thoiDiem)
        {
            DataProvider.Instance.ExecuteQuery("UPDATE BANTHANG " +
                                                "SET IDCT =" + idCauThu.ToString() + ", IDLBT =" + idLoaiBanThang.ToString() + ",THOIDIEM= '"+ thoiDiem +"'" +
                                                "Where IDBT = " + idBanThang.ToString());
        }
        public void DeleteGoal(int idBanThang)
        {
            DataProvider.Instance.ExecuteQuery("EXEC USP_DELETEGOAL @IDBANTHANG = " + idBanThang.ToString());
        }
    }
}
