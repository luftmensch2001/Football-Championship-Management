using NationalFootballChampionshipManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalFootballChampionshipManagement.DTO
{
    class PriorityRank
    {
        string name;
        int rank;

        public string Name { get => name; set => name = value; }
        public int Rank { get => rank; set => rank = value; }


        public PriorityRank(DataRow row)
        {
            this.Name = row["Ten"].ToString();
            this.Rank = (int)row["ThuTuUuTien"];
        }
    }
}
