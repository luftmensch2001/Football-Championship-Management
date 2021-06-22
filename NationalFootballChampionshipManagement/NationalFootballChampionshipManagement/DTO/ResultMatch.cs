using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using NationalFootballChampionshipManagement.DAO;

namespace NationalFootballChampionshipManagement.DTO
{
    class ResultMatch
    {
        int idTranDau;
        int vongDau;
        int idDoi1;
        int idDoi2;
        int kqDoi1;
        int kqDoi2;
        string san;
        DateTime thoiGian;
        string tenDoi1;
        string tenDoi2;
        Image imageDoi1;
        Image imageDoi2;

        public int IdTranDau { get => idTranDau; set => idTranDau = value; }
        public int VongDau { get => vongDau; set => vongDau = value; }
        public int IdDoi1 { get => idDoi1; set => idDoi1 = value; }
        public int IdDoi2 { get => idDoi2; set => idDoi2 = value; }
        public int KQDoi1 { get => kqDoi1; set => kqDoi1 = value; }
        public int KQDoi2 { get => kqDoi2; set => kqDoi2 = value; }

        public string San { get => san; set => san = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public string TenDoi1 { get => tenDoi1; set => tenDoi1 = value; }
        public string TenDoi2 { get => tenDoi2; set => tenDoi2 = value; }

        public Image ImageDoi1 { get => imageDoi1; set => imageDoi1 = value; }
        public Image ImageDoi2 { get => imageDoi2; set => imageDoi2 = value; }

        public ResultMatch(int idTranDau, int vongDau, int idDoi1, int idDoi2, string tenDoi1, string tenDoi2, string san, DateTime thoiGian, Image imageDoi1, Image imageDoi2, int kqDoi1 = -1, int kqDoi2 = -1)
        {
            this.idTranDau = idTranDau;
            this.vongDau = vongDau;
            this.idDoi1 = idDoi1;
            this.idDoi2 = idDoi2;
            this.tenDoi1 = tenDoi1;
            this.tenDoi2 = tenDoi2;
            this.san = san;
            this.thoiGian = thoiGian;
            this.kqDoi1 = kqDoi1;
            this.kqDoi2 = kqDoi2;
            this.imageDoi1 = imageDoi1;
            this.imageDoi2 = imageDoi2;
        }
        public ResultMatch(DataRow row)
        {
            this.idTranDau = (int) row["IDTranDau"];
            this.vongDau = (int) row["VongDau"];
            this.idDoi1 = (int) row["IDDOI1"];
            this.idDoi2 = (int)row["IDDOI2"];
            this.tenDoi1 = row["TENDOI1"].ToString();
            this.tenDoi2 = row["TENDOI2"].ToString();
            this.san = row["SanVanDong"].ToString();
            this.kqDoi1 = (int)row["KQDoi1"];
            this.kqDoi2 = (int)row["KQDoi2"];
         //   this.imageDoi1 = ImageProcessing.Instance.ByteToImg((byte[])row["HinhAnhDoi1"]);
         //   this.imageDoi2 = ImageProcessing.Instance.ByteToImg((byte[])row["HinhAnhDoi2"]);
            this.thoiGian = (DateTime)row["ThoiGian"];
        }
    }
}
