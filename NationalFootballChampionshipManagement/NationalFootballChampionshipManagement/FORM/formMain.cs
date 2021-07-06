using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalFootballChampionshipManagement
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

            customizeDesing();
            //activeFullScreenMode();

            try
            {
                LoadStatus();

                int idmg = LeagueDAO.Instance.GetCurrIDMG();

                openChildForm(new formHome(this));

                if (idmg == -1)
                {
                    DisableButton();
                    MessageBox.Show("Chào mừng bạn đến với phần mềm. Hãy tạo cho mình mùa giải đầu tiên nhé!", "Chào mừng!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    openChildForm(new formAddMuaGiai(this));
                }
                else
                {
                    LoadLogo();
                }
            }
            catch
            {
                if (File.Exists(@".\Data\Create database.bat"))
                {
                    String batDir = @".\Data\";
                    Process proc = new Process();
                    proc.StartInfo.WorkingDirectory = batDir;
                    proc.StartInfo.FileName = "Create database.bat";
                    proc.StartInfo.CreateNoWindow = false;
                    proc.Start();
                    proc.WaitForExit();

                    DisableButton();
                    MessageBox.Show("Chào mừng bạn đến với phần mềm. Hãy tạo cho mình mùa giải đầu tiên nhé!", "Chào mừng!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    openChildForm(new formAddMuaGiai(this));
                } else
                {
                    MessageBox.Show("Có vẻ như bạn đã xóa mất file Create database.bat, hãy cài lại phần mềm nhé!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Environment.Exit(1);
                }
            }
        }

        private void DisableButton()
        {
            btnCompetitionSchedule.Enabled = false;
            btnResult.Enabled = false;
            btnRankingChart.Enabled = false;
            btnFile.Enabled = false;
            btnTools.Enabled = false;
        }

        public void EnableButton()
        {
            btnCompetitionSchedule.Enabled = true;
            btnResult.Enabled = true;
            btnRankingChart.Enabled = true;
            btnFile.Enabled = true;
            btnTools.Enabled = true;
        }

        public void LoadStatus()
        {
            lbStatus.Text = LeagueDAO.Instance.GetCurrLeagueStatus();
            CheckStatusResultRanking();
        }
        public void LoadLogo()
        {
            panelChampionshipLogo.BackgroundImage = LeagueDAO.Instance.GetCurrLeagueImage();
        }

        public void CheckStatusResultRanking()
        {
            if (lbStatus.Text == "Trạng thái: Đang đăng ký")
            {
                btnResult.Enabled = false;
                btnRankingChart.Enabled = false;
            }  else
            {
                btnResult.Enabled = true;
                btnRankingChart.Enabled = true;
            }    
        }

        private void activeFullScreenMode()
        {
            // Full màn hình
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void customizeDesing()
        {
            this.pnlSubFileMenu.Visible = false;
            this.pnlSubToolsMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (this.pnlSubFileMenu.Visible == true)
                this.pnlSubFileMenu.Visible = false;
            if (this.pnlSubToolsMenu.Visible == true)
                this.pnlSubToolsMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        public void resetButtonColor()
        {

            this.btnCompetitionSchedule.BackColor = Color.Transparent;
            this.btnCompetitionSchedule.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnCompetitionSchedule.IconColor = Color.FromArgb(89, 113, 121);

            this.btnResult.BackColor = Color.Transparent;
            this.btnResult.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnResult.IconColor = Color.FromArgb(89, 113, 121);

            this.btnRankingChart.BackColor = Color.Transparent;
            this.btnRankingChart.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnRankingChart.IconColor = Color.FromArgb(89, 113, 121);

            this.btnFile.BackColor = Color.Transparent;
            this.btnFile.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnFile.IconColor = Color.FromArgb(89, 113, 121);

            this.btnTeamFile.BackColor = Color.Transparent;
            this.btnTeamFile.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnTeamFile.IconColor = Color.FromArgb(89, 113, 121);

            this.btnPlayerFile.BackColor = Color.Transparent;
            this.btnPlayerFile.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnPlayerFile.IconColor = Color.FromArgb(89, 113, 121);

            this.btnTools.BackColor = Color.Transparent;
            this.btnTools.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnTools.IconColor = Color.FromArgb(89, 113, 121);

            this.btnChampionshipTools.BackColor = Color.Transparent;
            this.btnChampionshipTools.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnChampionshipTools.IconColor = Color.FromArgb(89, 113, 121);

            this.btnScoresTools.BackColor = Color.Transparent;
            this.btnScoresTools.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnScoresTools.IconColor = Color.FromArgb(89, 113, 121);

            this.btnRankingTools.BackColor = Color.Transparent;
            this.btnRankingTools.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnRankingTools.IconColor = Color.FromArgb(89, 113, 121);

            this.btnHelp.BackColor = Color.Transparent;
            this.btnHelp.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnHelp.IconColor = Color.FromArgb(89, 113, 121);

            this.btnTournaments.BackColor = Color.Transparent;
            this.btnTournaments.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnTournaments.IconColor = Color.FromArgb(89, 113, 121);
        }

        private void highlightButton(FontAwesome.Sharp.IconButton btn)
        {
            resetButtonColor();

            btn.BackColor = Color.FromArgb(89, 113, 121);
            btn.ForeColor = Color.White;
            btn.IconColor = Color.White;
            
        }

        private void btnCompetitionSchedule_Click(object sender, EventArgs e)
        {
            openChildForm(new formCompetitionSchedule(this));
            hideSubMenu();
            highlightButton(btnCompetitionSchedule);
        }

        private void btnRankingChart_Click(object sender, EventArgs e)
        {
            openChildForm(new formRanking(this));
            hideSubMenu();
            highlightButton(btnRankingChart);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            //..
            // code
            //..
            showSubMenu(this.pnlSubFileMenu);
            highlightButton(this.btnFile);
        }

        private void btnTools_Click(object sender, EventArgs e)
        {
            //..
            // code
            //..
            showSubMenu(this.pnlSubToolsMenu);
            highlightButton(this.btnTools);
        }

        private void btnTeamFile_Click(object sender, EventArgs e)
        {
            openChildForm(new formTeam(this));
            highlightButton(this.btnTeamFile);
        }

        private void btnPlayerFile_Click(object sender, EventArgs e)
        {
            openChildForm(new formPlayerList(this));   
            highlightButton(this.btnPlayerFile);
        }

        private void btnChampionshipTools_Click(object sender, EventArgs e)
        {
            openChildForm(new formChampionshipTools(this));
            highlightButton(this.btnChampionshipTools);
        }

        private void btnScoresTools_Click(object sender, EventArgs e)
        {
            openChildForm(new formScoresTools(this));
            highlightButton(this.btnScoresTools);
        }

        private void btnRankingTools_Click(object sender, EventArgs e)
        {
            openChildForm(new formRankingTools(this));
            highlightButton(this.btnRankingTools);
        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            openChildForm(new formResultHistory(this));
            highlightButton(this.btnResult);
        }

        private void btnTournaments_Click(object sender, EventArgs e)
        {
            highlightButton(this.btnTournaments);
            openChildForm(new formMuaGiai(this));
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new formHelp(this));
            hideSubMenu();
            highlightButton(this.btnHelp);
        }
    }
}
