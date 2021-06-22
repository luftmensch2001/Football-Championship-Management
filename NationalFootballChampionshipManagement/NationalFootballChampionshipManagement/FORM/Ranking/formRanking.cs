using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalFootballChampionshipManagement
{
    public partial class formRanking : Form
    {
        formMain formFather = null;
        List<ResultMatch> listResultMatch;
        List<Team> listNameTeam;
        List<TeamScoreDetails> listTeamScoreDetails = new List<TeamScoreDetails>();
        int idmg = LeagueDAO.Instance.GetCurrIDMG();

        const string Pts = "Điểm";
        const string GD = "Hiệu số bàn thắng";
        const string Vs = "Hiệu số đối đầu";
        const string F = "Tổng số bàn thắng";
        const string W = "Tổng số trận thắng";
        public formRanking(formMain f)
        {
            InitializeComponent();

            this.formFather = f;

            addColumnsToDatagridviews();
            InitListTeam();
            CaculateDetails();
            CaculateRanking();
            LoadRanking();
        }

        void InitListTeam()
        {
            listNameTeam = TeamDAO.Instance.GetNameAndIdTeam();
            int i = 1;
            foreach (Team item in listNameTeam)
            {
                listTeamScoreDetails.Add(new TeamScoreDetails(item.TeamName));
                i++;
            }
        }
        void CaculateDetails()
        {
            listResultMatch = ResultMatchDAO.Instance.LoadResultMatch();
            //Tinh team 1
            foreach (ResultMatch match in listResultMatch)
            {
                //Tinh team 1
                if (match.KQDoi1 != -1)
                    foreach (TeamScoreDetails team in listTeamScoreDetails)
                    {
                        if (team.Name == match.TenDoi1)
                        {
                            team.CaculateDetailsTeam1(match, idmg);
                        }
                    }
                // Tinh team 2
                if (match.KQDoi2 != -1)
                    foreach (TeamScoreDetails team in listTeamScoreDetails)
                    {
                        if (team.Name == match.TenDoi2)
                        {
                            team.CaculateDetailsTeam2(match, idmg);
                        }
                    }
            }
        }
        void CaculateRanking()
        {
            List<PriorityRank> listPriorRank = PriorityRankDAO.Instance.GetListPriorityRank();
            TeamScoreDetails tmp;
            int index = listNameTeam.Count();
            for (int i = 0; i < index - 1; i++)
                for (int j = i + 1; j < index; j++)
                {
                    foreach (PriorityRank condition in listPriorRank)
                    {
                        int res = CheckCondition(condition.Name, listTeamScoreDetails[i], listTeamScoreDetails[j]);
                        if (res == 0)
                            continue;
                        if (res == 2)
                        {
                            tmp = listTeamScoreDetails[i];
                            listTeamScoreDetails[i] = listTeamScoreDetails[j];
                            listTeamScoreDetails[j] = tmp;
                        }
                        break;
                    }
                }
        }
        void LoadRanking()
        {
            var column = dgvRanking.Columns[0];
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            foreach (TeamScoreDetails item in listTeamScoreDetails)
            {
                dgvRanking.Rows.Add(
                    item.Name,
                    item.M,
                    item.W,
                    item.D,
                    item.L,
                    item.F,
                    item.A,
                    item.GD,
                    item.Pts,
                    item.FLM);
            }
        }
        int CheckCondition(string condition, TeamScoreDetails team1, TeamScoreDetails team2)
        {
            switch (condition)
            {
                case Pts:
                    if (team1.Pts == team2.Pts)
                        return 0;
                    if (team1.Pts < team2.Pts)
                        return 2;
                    break;
                case GD:
                    if (team1.GD == team2.GD)
                        return 0;
                    if (team1.GD < team2.GD)
                        return 2;
                    break;
                case F:
                    if (team1.F == team2.F)
                        return 0;
                    if (team1.F < team2.F)
                        return 2;
                    break;
                case W:
                    if (team1.W == team2.W)
                        return 0;
                    if (team1.W < team2.W)
                        return 2;
                    break;
                case Vs:
                    return CheckDoiDau(team1, team2);
            }
            return 1;
        }
        int CheckDoiDau(TeamScoreDetails team1, TeamScoreDetails team2)
        {
            List<ResultMatch> listMatch = ResultMatchDAO.Instance.LoadResultMatchByName(team1.Name, team2.Name);
            int g11 = 0; int g21 = 0; //tran 1
            int g12 = 0; int g22 = 0; //tran 2
            int w1 = 0; int w2 = 0; // tong win
            foreach (ResultMatch match in listMatch)
            {
                if (match.TenDoi1 == team1.Name)
                {
                    g11 += match.KQDoi1;
                    g21 += match.KQDoi2;
                    if (match.KQDoi1 > match.KQDoi2)
                        w1++;
                }
                else
                {
                    g12 += match.KQDoi1;
                    g22 += match.KQDoi2;
                    if (match.KQDoi1 < match.KQDoi2)
                        w2++;
                }
            }
            if (w1 < w2) // tong so tran thang
                return 2;
            if (w1 == w2)
            {
                if (g11 + g12 < g21 + g22) // tong so ban thang
                    return 2;
                if (g11 + g12 == g21 + g22)
                {
                    if (g12 < g21) // ban thang san khach
                        return 2;
                    if (g12 == g21)
                        return 0;
                }
            }
            return 1;
        }
        private void addColumnsToDatagridviews()
        {
            return;
            //this.dgvRanking.AutoSize = false;

            this.dgvRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Câu lạc bộ
            DataGridViewColumn newCol = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Câu lạc bộ";
            newCol.Name = "colCLB";
            newCol.Visible = true;
            newCol.Width = 200;

            this.dgvRanking.Columns.Add(newCol);


            // Trận
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Trận";
            newCol.Name = "colMatches";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);


            // Thắng
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Thắng";
            newCol.Name = "colWin";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Hòa
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Hòa";
            newCol.Name = "colEqual";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Thua
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Thua";
            newCol.Name = "colLose";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Số bàn thắng
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "B.Thắng";
            newCol.Name = "colGoalsFor";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Số bàn thua
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "B.Thua";
            newCol.Name = "colGoalsAgainst";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Hệ số
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Hiệu Số";
            newCol.Name = "colGoalsDifference";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Điểm
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Điểm";
            newCol.Name = "colPoints";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // 5 trận gần nhất
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "5 trận gần nhất";
            newCol.Name = "colFiveLatestMatches";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome());
        }
    }
}
