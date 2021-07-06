using NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalFootballChampionshipManagement
{
    // formAddCompetition
    public partial class formChangeTime : Form
    {
        formMain formFather = null;
        int idTranDau;
        Matches match;

        public formChangeTime(formMain f, int idTranDau)
        {
            this.formFather = f;
            this.idTranDau = idTranDau;

            InitializeComponent();
            LoadControl();
        }

        private void LoadControl()
        {
            lbLeague.Text =  LeagueDAO.Instance.GetCurrLeagueName();
            this.match = new Matches(this.idTranDau);
            Team team1 = TeamDAO.Instance.GetTeamInforByID(match.IdTeam1);
            Team team2 = TeamDAO.Instance.GetTeamInforByID(match.IdTeam2);
            lbTeam1.Text = team1.TeamName;
            lbTeam2.Text = team2.TeamName;
            pbTeam1.Image = team1.Image;
            pbTeam2.Image = team2.Image;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formCompetitionSchedule(this.formFather));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {  
            try
            {
                DateTime time = dtpDate.Value;
                string timeString = time.ToString("MM-dd-yyyy");
                timeString += " " + nudHour.Value.ToString() + ":" + nudMinute.Value.ToString();
                timeString = "'" + timeString + "'";
                MatchDAO.Instance.UpdateTime(match.IDTranDau, timeString);
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.formFather.openChildForm(new formCompetitionSchedule(this.formFather));
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
