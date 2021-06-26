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
        Image imgWin = NationalFootballChampionshipManagement.Properties.Resources.imgWin;
        Image imgDraw = NationalFootballChampionshipManagement.Properties.Resources.imgDraw;
        Image imgLose = NationalFootballChampionshipManagement.Properties.Resources.imgLose;
        Image imgEmpty = NationalFootballChampionshipManagement.Properties.Resources.imgEmpty;

        const string Pts = "Điểm";
        const string GD = "Hiệu số bàn thắng";
        const string Vs = "Hiệu số đối đầu";
        const string F = "Tổng số bàn thắng";
        const string W = "Tổng số trận thắng";
        public formRanking(formMain f)
        {
            InitializeComponent();

            this.formFather = f;

            dgvRanking.RowTemplate.Height = 40;
            dgvRanking.AllowUserToResizeRows = false;

            InitListTeam();
            CaculateDetails();
            CaculateRanking();
            LoadRanking();
        }

        void InitListTeam()
        {
            listNameTeam = TeamDAO.Instance.GetNameAndLogo();
            int i = 1;
            foreach (Team item in listNameTeam)
            {
                listTeamScoreDetails.Add(new TeamScoreDetails(item.TeamName, item.Image));
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
            var column = dgvRanking.Columns[2];
            column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            int stt = 1;
            
            foreach (TeamScoreDetails item in listTeamScoreDetails)
            {
                dgvRanking.Rows.Add(
                    stt,
                    ScaleImage((Bitmap)item.LogoTeam, 40, 40),
                    item.Name,
                    item.M,
                    item.W,
                    item.D,
                    item.L,
                    item.F,
                    item.A,
                    item.GD,
                    item.Pts,
                    ImageFLM(item.FLM));
                stt++;
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
        Image ImageFLM(string res)
        {
            int space = 4;
            int width = imgWin.Width * 6 + space * 7;
            int height = imgWin.Width + space * 2;

            Bitmap imgres = new Bitmap(width, height);
            Graphics g = Graphics.FromImage(imgres);

            for (int i = 0; i < 5; i++)
            {
                //get image
                Image imgResOfMatch = imgWin;
                if (i > res.Length - 1)
                    imgResOfMatch = imgEmpty;
                else
                {
                    if (res[i] == 'V')
                        imgResOfMatch = imgWin;
                    if (res[i] == '-')
                        imgResOfMatch = imgDraw;
                    if (res[i] == 'X')
                        imgResOfMatch = imgLose;
                }
                //draw image
                g.DrawImage(imgResOfMatch, new Point(i * height + space, 2));
            }

            g.Dispose();

            return imgres;
        }
        Bitmap ScaleImage(Bitmap bmp, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / bmp.Width;
            var ratioY = (double)maxHeight / bmp.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(bmp.Width * ratio);
            var newHeight = (int)(bmp.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(bmp, 0, 0, newWidth, newHeight);

            return newImage;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
            if (dgvRanking.Rows.Count > 0)
            {
                
                float[] w = new float[dgvRanking.Columns.Count];
                for (int i = 0; i < dgvRanking.Columns.Count; i++)
                {
                    w[i] = dgvRanking.Columns[i].Width;
                    if (i == 1)
                        w[i] *= 1.5f;
                }
                ExportDatagridViewToPDF toPDF = new ExportDatagridViewToPDF(dgvRanking);
                toPDF.ExportRanking("BXH " + LeagueDAO.Instance.GetCurrLeagueName(), "Bảng xếp hạng", w, listTeamScoreDetails);
            }
            else
            {
                MessageBox.Show("Không có thông tin để in");
            }
        }
    }
}
