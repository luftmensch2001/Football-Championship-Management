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
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

            customizeDesing();
            //activeFullScreenMode();

            openChildForm(new formHome());
        }

        private void activeFullScreenMode()
        {
            // Full màn hình
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
        private void customizeDesing()
        {
            this.pnlSubResultMenu.Visible = false;
            this.pnlSubFileMenu.Visible = false;
            this.pnlSubToolsMenu.Visible = false;
        }

        private void hideSubMenu()
        {
            if (this.pnlSubResultMenu.Visible == true)
                this.pnlSubResultMenu.Visible = false;
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

        private void resetButtonColor()
        {

            this.btnCompetitionSchedule.BackColor = Color.Transparent;
            this.btnCompetitionSchedule.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnCompetitionSchedule.IconColor = Color.FromArgb(89, 113, 121);

            this.btnResult.BackColor = Color.Transparent;
            this.btnResult.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnResult.IconColor = Color.FromArgb(89, 113, 121);

            this.btnRecordResult.BackColor = Color.Transparent;
            this.btnRecordResult.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnRecordResult.IconColor = Color.FromArgb(89, 113, 121);

            this.btnResultHistory.BackColor = Color.Transparent;
            this.btnResultHistory.ForeColor = Color.FromArgb(89, 113, 121);
            this.btnResultHistory.IconColor = Color.FromArgb(89, 113, 121);

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
            openChildForm(new formRanking());
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            openChildForm(new formHelp());
            hideSubMenu();
            highlightButton(this.btnHelp);
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
            openChildForm(new formScoresTools());
            highlightButton(this.btnScoresTools);
        }

        private void btnRankingTools_Click(object sender, EventArgs e)
        {
            openChildForm(new formRankingTools());
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
            showSubMenu(this.pnlSubResultMenu);
            highlightButton(this.btnResult);
        }

        private void btnRecordResult_Click(object sender, EventArgs e)
        {
            openChildForm(new formRecordResult(this));
            highlightButton(this.btnRecordResult);
        }

        private void btnResultHistory_Click(object sender, EventArgs e)
        {
            openChildForm(new formResultHistory(this));
            highlightButton(this.btnResultHistory);
        }

        
    }
}
