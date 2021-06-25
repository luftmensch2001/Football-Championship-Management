﻿using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
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
            int idmg = LeagueDAO.Instance.GetCurrIDMG();
            string query = "Select * From LoaiBanThang Where IDMG = " + idmg;
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            List<GoalType> goalTypes = new List<GoalType>();

            foreach (DataRow row in data.Rows)
            {
                GoalType goalType = new GoalType((int)row[0], row[1].ToString());
                goalTypes.Add(goalType);
            }
            return goalTypes;
        }
        public void AddNewGoalType(string name)
        {
                int idmg = LeagueDAO.Instance.GetCurrIDMG();
                string query = "INSERT INTO LoaiBanThang(TenLBT, idmg) VALUES(N'" + name + "', " + idmg.ToString() + ")";
                DataProvider.Instance.ExecuteQuery(query);
        }
        public void DeleteGoalTypeByName(string name)
        {
                int idmg = LeagueDAO.Instance.GetCurrIDMG();
                string query = "DELETE FROM LoaiBanThang WHERE TenLBT = N'" + name + "' AND IDMG =" + idmg;
                DataProvider.Instance.ExecuteQuery(query);
        }

    }
}