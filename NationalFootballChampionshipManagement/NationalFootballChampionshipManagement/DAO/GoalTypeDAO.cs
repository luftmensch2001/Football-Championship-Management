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
    class GoalTypeDAO
    {
        private static GoalTypeDAO instance;
        public static GoalTypeDAO Instance
        {
            get { if (instance == null) instance = new GoalTypeDAO(); return instance; }
            set => instance = value;
        }

        public List<GoalType> GetListGoalType()
        {
            string query = "Select * From LoaiBanThang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<GoalType> goalTypes = new List<GoalType>();

            foreach (DataRow row in data.Rows)
            {
                GoalType goalType = new GoalType((int)row[0], row[1].ToString());
                goalTypes.Add(goalType);
            }
            return goalTypes;
        }
        public void SetTimeGoalMax(string time)
        {
            string query = "Update QuyDinh +" +
                "Set TGGBTD= " +time;
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
