using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalFootballChampionshipManagement.DTO
{
    class Score
    {
        int tHANG = 0;
        int hOA = 0;
        int tHUA = 0;

        public int THANG { get => tHANG; set => tHANG = value; }
        public int HOA { get => hOA; set => hOA = value; }
        public int THUA { get => tHUA; set => tHUA = value; }

        public Score()
        {

        }

        public Score(DataRow row)
        {
            this.THANG = (int)row["THANG"];
            this.HOA = (int)row["HOA"];
            this.THUA = (int)row["THUA"];
        }
    }
}
