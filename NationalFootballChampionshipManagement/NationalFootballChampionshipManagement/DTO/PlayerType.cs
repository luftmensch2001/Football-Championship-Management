using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalFootballChampionshipManagement.DTO
{
    public class PlayerType
    {
        string typeName;
        int iDMG;
        int sLTD;
        int iD;

        public string TypeName { get => typeName; set => typeName = value; }
        public int IDMG { get => iDMG; set => iDMG = value; }
        public int SLTD { get => sLTD; set => sLTD = value; }
        public int ID { get => iD; set => iD = value; }

        public PlayerType(string typeName, int idmg, int sltd, int id)
        {
            this.typeName = typeName;
            this.iDMG = idmg;
            this.sLTD = sltd;
            this.iD = id;
        }
    }
}
