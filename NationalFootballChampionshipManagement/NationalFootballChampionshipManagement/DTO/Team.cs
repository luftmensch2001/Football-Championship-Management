﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NationalFootballChampionshipManagement.DTO
{
    public class Team
    {
        string teamName;
        string coachName;
        string hostName;
        int iD;

        public string TeamName { get => teamName; set => teamName = value; }
        public string CoachName { get => coachName; set => coachName = value; }
        public string HostName { get => hostName; set => hostName = value; }
        public int ID { get => iD; set => iD = value; }

        public Team(string team, string coach, string host, int id)
        {
            this.teamName = team;
            this.coachName = coach;
            this.hostName = host;
            this.iD = id;
        }

        public Team(DataRow row)
        {
            this.teamName = row["TenDB"].ToString();
            this.coachName = row["TenHLV"].ToString();
            this.hostName = row["SanNha"].ToString();
            this.iD = (int)row["IDDB"];
        }

    }
}