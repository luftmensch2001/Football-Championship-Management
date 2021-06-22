using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalFootballChampionshipManagement.DTO
{
    public class Rules
    {
        int iDMG;
        int sLDB;
        int sLVD;
        int tuoiTT;
        int tuoiTD;
        int sLTT;
        int sLTD;
        string timeGoalsMax;

        public int IDMG { get => iDMG; set => iDMG = value; }
        public int SLDB { get => sLDB; set => sLDB = value; }
        public int SLVD { get => sLVD; set => sLVD = value; }
        public int TuoiTT { get => tuoiTT; set => tuoiTT = value; }
        public int TuoiTD { get => tuoiTD; set => tuoiTD = value; }
        public int SLTT { get => sLTT; set => sLTT = value; }
        public int SLTD { get => sLTD; set => sLTD = value; }
        public String TimeGoalMax { get => timeGoalsMax; set => timeGoalsMax = value; }
        
        public Rules()
        {

        }
        public Rules(DataRow row)
        {
            this.IDMG = (int)row["IDMG"];
            this.SLDB = (int)row["SLDB"];
            this.SLVD = (int)row["SLVD"];
            this.TuoiTT = (int)row["TuoiTT"];
            this.TuoiTD = (int)row["TuoiTD"];
            this.SLTT = (int)row["SLTT"];
            this.SLTD = (int)row["SLTD"];
            this.timeGoalsMax = row["TGGBTD"].ToString();
        }
    }
}
