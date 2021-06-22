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
    class TeamScoreDetails
    {
        string name;
        int m;
        int w;
        int d;
        int l;
        int f;
        int a;
        int gD;
        int pts;
        string fLM;
        public string Name { get => name; set => name = value; }
        public int M { get => m; set => m = value; }
        public int W { get => w; set => w = value; }
        public int D { get => d; set => d = value; }
        public int L { get => l; set => l = value; }
        public int F { get => f; set => f = value; }
        public int A { get => a; set => a = value; }
        public int GD { get => gD; set => gD = value; }
        public int Pts { get => pts; set => pts = value; }
        public string FLM { get => fLM; set => fLM = value; }

        public TeamScoreDetails(string teamName)
        {
            this.Name = teamName;
            this.M = 0;
            this.W = 0;
            this.D = 0;
            this.L = 0;
            this.F = 0;
            this.A = 0;
            this.GD = 0;
            this.Pts = 0;
            this.FLM = "";
        }
        public void CaculateDetailsTeam1(ResultMatch match, int idmg)
        {
            Score score = ScoreDAO.Instance.GetScoreRule();

            this.M++;
            this.F += match.KQDoi1;
            this.A += match.KQDoi2;
            this.GD = this.F - this.A;
            if (this.FLM.Length > 4)
                this.FLM.Remove(0, 1);
            
            if (match.KQDoi1 > match.KQDoi2)
            {
                this.W++;
                this.Pts += score.THANG;
                this.FLM += 'V';
            }

            if (match.KQDoi1 == match.KQDoi2)
            {
                this.D++;
                this.Pts += score.HOA;
                this.FLM += '-';
            }

            if (match.KQDoi1 < match.KQDoi2)
            {
                this.L++;
                this.Pts += score.THUA;
                this.FLM += 'X';
            }
        }

        public void CaculateDetailsTeam2(ResultMatch match, int idmg)
        {
            Score score = ScoreDAO.Instance.GetScoreRule();

            this.M++;
            this.F += match.KQDoi2;
            this.A += match.KQDoi1;
            this.GD = this.F - this.A;
            if (this.FLM.Length > 4)
                this.FLM.Remove(0, 1);

            if (match.KQDoi2 > match.KQDoi1)
            {
                this.W++;
                this.Pts += score.THANG;
                this.FLM += 'V';
            }

            if (match.KQDoi2 == match.KQDoi1)
            {
                this.D++;
                this.Pts += score.HOA;
                this.FLM += '-';
            }

            if (match.KQDoi2 < match.KQDoi1)
            {
                this.L++;
                this.Pts += score.THUA;
                this.FLM += 'X';
            }
        }

    }
}
