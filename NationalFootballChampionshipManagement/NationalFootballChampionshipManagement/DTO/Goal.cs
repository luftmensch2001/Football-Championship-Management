using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalFootballChampionshipManagement.DTO
{
    class Goal
    {
        int idBanThang = -1;
        int idTranDau;
        int idCauThu;
        int idDoiBong;
        int idLoaiBanThang;
        string thoiDiem;

        public int IdBanThang { get => idBanThang; set => idBanThang = value; }
        public int IdTranDau { get => idTranDau; set => idTranDau = value; }
        public int IdCauThu { get => idCauThu; set => idCauThu = value; }
        public int IdDoiBong { get => idDoiBong; set => idDoiBong = value; }
        public int IdLoaiBanThang { get => idLoaiBanThang; set => idLoaiBanThang = value; }
        public string IdThoiDiem { get => thoiDiem; set => thoiDiem = value; }

        public Goal(int idTranDau, int idCauThu, int idDoiBong, int idLoaiBanThang, string thoiDiem,int idBanThang =-1)
        {
            this.idBanThang = idBanThang;
            this.idTranDau = idTranDau;
            this.idCauThu = idCauThu;
            this.idDoiBong = idDoiBong;
            this.idLoaiBanThang = idLoaiBanThang;
            this.thoiDiem = thoiDiem;
        }
    }
}
