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
    public class PlayerDAO
    {
        private static PlayerDAO instance;
        public static PlayerDAO Instance
        {
            get { if (instance == null) instance = new PlayerDAO(); return instance; }
            set => instance = value;
        }
        private static int CalculateAge(DateTime dateOfBirth)
        {
            int age = 0;
            age = DateTime.Now.Year - dateOfBirth.Year;
            if (DateTime.Now.DayOfYear < dateOfBirth.DayOfYear)
                age = age - 1;

            return age;
        }
        public int AddPlayer(string name, string gender, string nationality, int idLCT, DateTime dob, int idTeam, string notes)
        {
            Rules rules = RulesDAO.Instance.GetRules();
            if (CalculateAge(dob) < rules.TuoiTT || CalculateAge(dob) > rules.TuoiTD)
            {
                MessageBox.Show("Tuổi cầu thủ phải nằm trong khoảng từ " + rules.TuoiTT.ToString() + " đến " + rules.TuoiTD.ToString(), "Lỗi");
                return 0; // them cau thu that bai
            }
            string query =
                 "INSERT INTO CauThu(Ten, GioiTinh, QuocTich, IDLCT, NgaySinh, IDDB, GhiChu) VALUES(N'"
                 + name + "', N'" + gender + "', N'" + nationality + "', '" + idLCT.ToString()
                 + "', '" + dob.ToString("MM/dd/yyyy") + "', '" + idTeam.ToString() + "', N'" + notes + "')";
            DataProvider.Instance.ExecuteQuery(query);
            return 1; //them cau thu thanh cong
        }

        public int UpdatePlayer(int idct, string name, string gender, string nationality, int idLCT, DateTime dob, int idTeam, string notes)
        {
            Rules rules = RulesDAO.Instance.GetRules();
            if (CalculateAge(dob) < rules.TuoiTT || CalculateAge(dob) > rules.TuoiTD)
            {
                MessageBox.Show("Tuổi cầu thủ phải nằm trong khoảng từ " + rules.TuoiTT.ToString() + " đến " + rules.TuoiTD.ToString(), "Lỗi");
                return 0; // cap nhat that bai
            }

            string query = "EXEC USP_UpdatePlayerInfor ";
            name = "N'" + name + "'";
            gender = "N'" + gender + "'";
            nationality = "N'" + nationality + "'";
            notes = "N'" + notes + "'"; // convert to Nvarchar
            string strDob = "N'" + dob.ToString("MM/dd/yyyy") + "'";

            query += "@idct = " + idct.ToString();
            query += ", @name = " + name;
            query += ", @gender = " + gender;
            query += ", @nationality = " + nationality;
            query += ", @dob = " + strDob;
            query += ", @note = " + notes;

            DataProvider.Instance.ExecuteQuery(query);
            return 1; //cap nhat thanh cong
        }

        public DataTable GetPlayerListByIDDB(int iddb)
        {
            string query = "EXEC USP_GetPlayerListByIDDB @iddb =" + iddb.ToString();
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public Player GetPlayerByIDCT(int idct)
        {
            string query = "SELECT * FROM CauThu WHERE IDCT = " + idct.ToString();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return new Player(data.Rows[0]);
        }

        public int DeletePlayerByID(int idct)
        {
            try
            {
                string query = "DELETE FROM CauThu WHERE IDCT = " + idct.ToString();
                DataProvider.Instance.ExecuteQuery(query);
                MessageBox.Show("Xoá cầu thủ thành công", "Thành công");
                return 1;
            }
            catch
            {
                MessageBox.Show("Xoá cầu thủ thất bại", "Lỗi");
                return 0;
            }
        }
    }
}
