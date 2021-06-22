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
    class PriorityRankDAO
    {
        private static PriorityRankDAO instance;

        public static PriorityRankDAO Instance
        {
            get { if (instance == null) instance = new PriorityRankDAO(); return instance; }
            set => instance = value;
        }

        public List<PriorityRank> GetListPriorityRank()
        {
            try
            {
                List<PriorityRank> PriorityRankList = new List<PriorityRank>();
                int idmg = LeagueDAO.Instance.GetCurrIDMG();

                DataTable data = DataProvider.Instance.ExecuteQuery("EXEC USP_GetPriorityRankList_By_IDMG @idmg = " + idmg.ToString());

                foreach (DataRow item in data.Rows)
                {
                    PriorityRank PriorityRank = new PriorityRank(item);
                    PriorityRankList.Add(PriorityRank);
                }

                return PriorityRankList;
            }
            catch
            {
                MessageBox.Show("Có lỗi khi tải danh sách điều kiện ưu tiên xếp hạng", "Lỗi");
                List<PriorityRank> priorityRanks = new List<PriorityRank>();
                return priorityRanks;
            }
        }

        public void UpdateListPriorityRankByThuTuUuTien(string Ten, int ThuTuUuTien)
        {
            try
            {
                int idmg = LeagueDAO.Instance.GetCurrIDMG();
                string query = "EXEC USP_UpdatePriorityRankList_By_ThuTuUuTien";
                query += " @idmg = " + idmg;
                query += ", @Ten = N'" + Ten + "'";
                query += ", @ThuTuUuTien = " + ThuTuUuTien.ToString();
                DataProvider.Instance.ExecuteQuery(query);
            }
            catch
            {
                MessageBox.Show("Có lỗi khi cập nhật thứ tự điều kiện ưu tiên xếp hạng", "Lỗi");
            }
        }
    }
}
