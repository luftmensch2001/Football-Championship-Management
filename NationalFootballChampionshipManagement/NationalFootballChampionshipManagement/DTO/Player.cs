using NationalFootballChampionshipManagement.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalFootballChampionshipManagement.DTO
{
    public class Player
    {
        int iD;
        int iDLCT;
        string playName;
        string gender;
        string nationlity;
        DateTime dayOfBirth;
        string notes;
        int iDDB;
        int countGoal;
        Image img;

        public int ID { get => iD; set => iD = value; }
        public int IDLCT { get => iDLCT; set => iDLCT = value; }
        public string PlayName { get => playName; set => playName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Nationlity { get => nationlity; set => nationlity = value; }
        public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public string Notes { get => notes; set => notes = value; }
        public int IDDB { get => iDDB; set => iDDB = value; }
        public Image Img { get => img; set => img = value; }

        public int CountGoal { get => countGoal; set => countGoal = value; }

        public Player(int id, int idlct, string playName, string gender, string nationlity, DateTime dayOfBirth, string notes)
        {
            this.ID = id;
            this.IDLCT = idlct;
            this.PlayName = playName;
            this.Gender = gender;
            this.Nationlity = nationlity;
            this.DayOfBirth = dayOfBirth;
            this.Notes = notes;
        }

        public Player(DataRow row)
        {
            this.ID = (int)row["idct"];
            this.IDLCT = (int)row["IDLCT"];
            this.PlayName = row["Ten"].ToString();
            this.Gender = row["GioiTinh"].ToString();
            this.Nationlity = row["QuocTich"].ToString();
            //this.DayOfBirth = DateTime.Parse(row["NgaySinh"].ToString());
            this.DayOfBirth = (DateTime)row["NgaySinh"];
            this.Notes = row["GhiChu"].ToString();
            this.IDDB = (int)row["IDDB"];
            this.Img = ImageProcessing.Instance.ByteToImg((byte[])row["HinhAnh"]);
        }
        public Player(int id, string name)
        {
            this.ID = id;
            this.playName = name;
        }
        public Player(int id, string name, int countGoal)
        {
            this.ID = id;
            this.playName = name;
            this.countGoal = countGoal;
        }
        public Player(int id, string name, int iddb, int idLCT, int countGoal )
        {
            this.ID = id;
            this.playName = name;
            this.iDDB = iddb;
            this.IDLCT = idLCT;
            this.countGoal = countGoal;
        }

        public Player(int id, DateTime dob)
        {
            this.ID = id;
            this.DayOfBirth = dob;
        }
    }
}
