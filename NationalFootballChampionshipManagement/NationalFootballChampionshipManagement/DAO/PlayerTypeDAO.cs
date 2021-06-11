using NationalFootballChampionshipManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalFootballChampionshipManagement.DAO
{
    public class PlayerTypeDAO
    {
        private static PlayerTypeDAO instance;
        public static PlayerTypeDAO Instance
        {
            get { if (instance == null) instance = new PlayerTypeDAO(); return instance; }
            set => instance = value;
        }

        public List<PlayerType> LoadPlayerTypeList()
        {
            List<PlayerType> playerTypeList = new List<PlayerType>();

            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetPlayerTypeList");

            foreach (DataRow item in data.Rows)
            {
                PlayerType playerType = new PlayerType(item);
                playerTypeList.Add(playerType);
            }

            return playerTypeList;
        }
    }
}
