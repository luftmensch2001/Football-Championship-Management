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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalFootballChampionshipManagement
{
    public partial class formTeam : Form
    {
        formMain formFather = null;

        Button lastButton = null;

        Team curTeam = null; // Team hien tai dang show

        public formTeam(formMain f)
        {
            InitializeComponent();

            this.formFather = f;

            lastButton = iconButton1;

            iconButton1.Hide();

            LoadTeam();

            addInformationColumn();

            dgvPlayerList.RowTemplate.Height = 30;
        }


        void AddButton(Team team)
        {
            FontAwesome.Sharp.IconButton mybtn = new FontAwesome.Sharp.IconButton();
            mybtn.BackColor = Color.FromArgb(11, 130, 142);
            mybtn.Text = team.TeamName;
            mybtn.Height = 50;
            mybtn.Width = panel1.Width;
            if (lastButton == iconButton1)
                mybtn.Top = lbTeamList.Location.Y + lbTeamList.Height + 6;
            else
                mybtn.Top = lastButton.Location.Y + lastButton.Height;
            mybtn.IconChar = FontAwesome.Sharp.IconChar.Newspaper;
            mybtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            mybtn.ForeColor = Color.White;
            mybtn.Font = lastButton.Font;
            mybtn.IconColor = Color.White;
            mybtn.IconSize = 35;
            mybtn.Click += Mybtn_Click;
            mybtn.Tag = team;
            lastButton = mybtn;
            this.panel1.Controls.Add(mybtn);
        }

        void LoadTeam()
        {
            List<Team> teamList = TeamDAO.Instance.LoadTeamList();

            foreach (Team item in teamList)
            {
                AddButton(item);
            }
        }

        private void Mybtn_Click(object sender, EventArgs e)
        {
            this.curTeam = (sender as Button).Tag as Team;
            int teamID = this.curTeam.ID;
            string teamName = this.curTeam.TeamName;
            string coachName = this.curTeam.CoachName;
            string hostName = this.curTeam.HostName;
            
            tbTeam.Text = teamName;
            lbSanNha.Text = hostName;
            lbHLV.Text = coachName;

            dgvPlayerList.DataSource = PlayerDAO.Instance.GetPlayerListByIDDB(teamID);
            for (int i=0; i<dgvPlayerList.Rows.Count - 1; i++)
            {
                dgvPlayerList.Rows[i].Cells[1].Value = i+1;
            }

            dgvPlayerList.Columns["btnInformation"].DisplayIndex = 6;
        }
        private void addInformationColumn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "";
            btn.Name = "btnInformation";
            btn.Text = "Chỉnh sửa";
            btn.UseColumnTextForButtonValue = true;
            this.dgvPlayerList.Columns.Add(btn);
        }

        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formPlayerList(this.formFather));
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formAddNewTeam(this.formFather));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Mở form thêm đội bóng mới lên và đôi button "Thêm" thành button "Lưu", 
            // và đổi tiêu đề thành "THay đổi thông tin đội bóng"
            if (curTeam == null)
            {
                MessageBox.Show("Vui lòng chọn đội bóng");
                return;
            }
            this.formFather.openChildForm(new formAddNewTeam(this.formFather, curTeam));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formAddPlayer(this.formFather));

            this.Close();
        }
    }
}
