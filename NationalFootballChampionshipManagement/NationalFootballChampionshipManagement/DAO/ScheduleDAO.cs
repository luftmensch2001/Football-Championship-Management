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
            int countOfMatch = (countOfTeam*(countOfTeam-1))/2;

            if (countOfTeam <= 1)
            {
                MessageBox.Show("Số lượng đội bóng không đủ đê tạo lịch", "Lỗi");
                return 0;
            }
            
            int[] arr = new int[200];
            bool check = true; // check = true neu n chan va nguoc lai

            if (countOfTeam % 2 == 1)
            {
                countOfTeam++;
                check = false;
            }
    
            int center = countOfTeam - 1;
            for (int i=0; i<center*3; i++)
            {
                arr[i] = i % center;
            }

            for (int i = center; i < center*2; i++)
            {
                if (check == true)
                {
                    Team1.Add(Teams[center]);
                    Team2.Add(Teams[arr[i]]);
                }
                
                int l = i - 1;
                int r = i + 1;

                for (int j=0; j < countOfTeam/2 - 1; j++)
                {
                    Team1.Add(Teams[arr[l]]);
                    Team2.Add(Teams[arr[r]]);
                    l--;
                    r++;
                }
            }
            

            int round = 0;
            if (check == false) countOfTeam--;

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
