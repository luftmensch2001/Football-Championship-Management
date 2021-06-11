using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalFootballChampionshipManagement.DAO
{
    public class PlayerDAO
    {
        private static PlayerDAO instance;
        public static PlayerDAO Instance
        {
            get { if (instance == null) instance = new PlayerDAO(); return instance; }
            set => instance = value;
        }

        public void AddPlayer(string name, string gender, string nationality, int idLCT, DateTime dob, int idTeam, string notes)
        {
            string query =
                 "INSERT INTO CauThu(Ten, GioiTinh, QuocTich, IDLCT, NgaySinh, IDDB, GhiChu) VALUES(N'" 
                 + name + "', N'" + gender + "', N'" + nationality + "', '" + idLCT.ToString() 
                 + "', '" + dob.ToString("MM/dd/yyyy") + "', '" + idTeam.ToString() + "', N'" + notes + "')";
            DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
