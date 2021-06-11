using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int ID { get => iD; set => iD = value; }
        public int IDLCT { get => iDLCT; set => iDLCT = value; }
        public string PlayName { get => playName; set => playName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Nationlity { get => nationlity; set => nationlity = value; }
        public DateTime DayOfBirth { get => dayOfBirth; set => dayOfBirth = value; }
        public string Notes { get => notes; set => notes = value; }

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
            this.ID = (int)row["IDCT"];
            this.IDLCT = (int)row["IDLCT"];
            this.PlayName = row["Ten"].ToString(); 
            this.Gender = row["GioiTinh"].ToString();
            this.Nationlity = row["QuocTich"].ToString(); 
            this.DayOfBirth = DateTime.Parse(row["NgaySinh"].ToString());
            this.Notes = row["GhiChu"].ToString(); 
        }
    }
}
