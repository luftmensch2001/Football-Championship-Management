using NationalFootballChampionshipManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalFootballChampionshipManagement.DTO
{
    public class Matches
    {
        int iDMG;
        int iDTranDau;
        int vongDau;
        int idTeam1;
        int idTeam2;
        string sanVanDong;
        DateTime thoiGian = DateTime.Now;

        public int IDMG { get => iDMG; set => iDMG = value; }
        public int IDTranDau { get => iDTranDau; set => iDTranDau = value; }
        public int VongDau { get => vongDau; set => vongDau = value; }
        public int IdTeam1 { get => idTeam1; set => idTeam1 = value; }
        public int IdTeam2 { get => idTeam2; set => idTeam2 = value; }
        public string SanVanDong { get => sanVanDong; set => sanVanDong = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }

        public Matches(int idTranDau)
        {
            string query = "SELECT * FROM TranDau WHERE IDTranDau = " + idTranDau.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 0) return;
            this.IDMG = (int)data.Rows[0]["IDMG"];
            this.iDTranDau = (int)data.Rows[0]["IDTranDau"];
            this.VongDau = (int)data.Rows[0]["VongDau"];
            this.IdTeam1 = (int)data.Rows[0]["Doi1"];
            this.IdTeam2 = (int)data.Rows[0]["Doi2"];
            this.SanVanDong = data.Rows[0]["SanVanDong"].ToString();
            this.ThoiGian = (DateTime)(data.Rows[0]["ThoiGian"]);
        }
    }
}
