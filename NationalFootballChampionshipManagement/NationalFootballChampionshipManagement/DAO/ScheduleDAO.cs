using NationalFootballChampionshipManagement.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalFootballChampionshipManagement.DAO
{
    public class ScheduleDAO
    {
        public static ScheduleDAO instance;

        public static ScheduleDAO Instance 
        { 
            get { if (instance == null) instance = new ScheduleDAO(); return instance; }
            set => instance = value; 
        }

        public int GenerateNewSchedule() // tra ve so vong dau
        {
            List<Team> Teams = TeamDAO.Instance.LoadValidTeam();
            List<Team> Team1 = new List<Team>();
            List<Team> Team2 = new List<Team>();
            int countOfTeam = Teams.Count;
            int countOfMatch = 0;

            if (countOfTeam <= 1)
            {
                MessageBox.Show("Số lượng đội bóng không đủ để tạo lịch", "Lỗi");
                return 0;
            }
            
            for (int i=0; i<countOfTeam; i++) // Tao ra danh sach tat ca cac tran dau luot di
            {
                for (int j=i+1; j<countOfTeam; j++)
                {
                    countOfMatch++;
                    Team1.Add(Teams[i]);
                    Team2.Add(Teams[j]);
                }
            }

            // Sap xep cac tran dau theo thu tu ngau nhien 
            // Giam hien tuong 1 doi thi dau qua nhieu tran trong 1 vong dau
            Team tempTeam;
            Random rand = new Random();
            for (int i=0; i<countOfMatch; i++)
            {
                for (int j=i+1; j<countOfMatch; j++)
                {
                    if (rand.Next(0, 5) >= rand.Next(0, 5))
                    {
                        tempTeam = Team1[i]; Team1[i] = Team1[j]; Team1[j] = tempTeam; // Swap two teams
                        tempTeam = Team2[i]; Team2[i] = Team2[j]; Team2[j] = tempTeam;
                    }
                }
            }

            int round = 0;

            // Luot di
            for (int i=0; i < countOfMatch; i++)
            {
                if (i % (countOfTeam / 2) == 0) round++;
                MatchDAO.Instance.AddMatch(Team1[i], Team2[i], round);
            }
            // Luot ve
            for (int i = 0; i < countOfMatch; i++)
            {
                if (i % (countOfTeam / 2) == 0) round++;
                MatchDAO.Instance.AddMatch(Team2[i], Team1[i], round);
            }

            return round;    
        }

        public void CancelSchedule()
        {
            MatchDAO.Instance.DeleteAllMatches();
        }

    }
}
