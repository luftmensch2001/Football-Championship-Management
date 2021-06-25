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
    public class RulesDAO
    {
        private static RulesDAO instance;
        public static RulesDAO Instance
        {
            get { if (instance == null) instance = new RulesDAO(); return instance; }
            set => instance = value;
        }

        public Rules GetRules()
        {
                int idmg = LeagueDAO.Instance.GetCurrIDMG();
                string query = "EXEC USP_GetRules_By_IDMG @idmg = " + idmg.ToString();
                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                Rules rules = new Rules(data.Rows[0]);
                return rules;
        }

        public void UpdateRules(string sldb, string tuoitt, string tuoitd, string sltt, string sltd, string timegoalsmax)
        {
                int idmg = LeagueDAO.Instance.GetCurrIDMG(); // Lay id mua giai hien tai
                string query = "EXEC USP_UpdateRules_By_IDMG ";
                query += "@idmg = " + idmg;
                query += ", @SLDB = " + sldb;
                query += ", @TuoiTT = " + tuoitt;
                query += ", @TuoiTD = " + tuoitd;
                query += ", @SLTT = " + sltt;
                query += ", @SLTD = " + sltd;
                query += ", @TGGBTD = " + timegoalsmax;
                DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}