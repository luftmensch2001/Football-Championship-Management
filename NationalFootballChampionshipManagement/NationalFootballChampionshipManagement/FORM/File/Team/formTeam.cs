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
    public partial class formTeam : Form
    {
        formMain formFather = null;

        Button lastButton = null;

        public formTeam(formMain f)
        {
            InitializeComponent();

            this.formFather = f;

            addInformationColumn();

            lastButton = iconButton1;

            iconButton1.Hide();

            LoadTeam();
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
                mybtn.Top= lastButton.Location.Y + lastButton.Height;
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

        private void Mybtn_Click(object sender, EventArgs e)
        {
            int teamID = ((sender as Button).Tag as Team).ID;
            string teamName = ((sender as Button).Tag as Team).TeamName;
            string coachName = ((sender as Button).Tag as Team).CoachName;
            string hostName = ((sender as Button).Tag as Team).HostName;
            tbTeam.Text = teamName;
            tbSanNha.Text = hostName;
            tbHLV.Text = coachName;
        }

        void LoadTeam()
        {
            List<Team> teamList = TeamDAO.Instance.LoadTeamList();

            foreach (Team item in teamList)
            {
                AddButton(item);
            }
        }

        private void addInformationColumn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Thông tin chi tiết";
            btn.Name = "btnInformation";
            btn.Text = "Thông tin chi tiết";
            btn.UseColumnTextForButtonValue = true;
            this.dgvPlayerList.Columns.Add(btn);
        }

        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            // Lúc này mở thêm 1 cột checkbox ở cột cuối cùng của Datagridview, rồi click chọn cầu thủ được add.
            // Đồng thời đổi chữ Lưu thành chữ "Thêm"
            // Lưu ý: các cầu thủ đã có clb rồi cần hỏi lại một lần nữa có chắc chắc là thêm vào đội này hay không, nếu thêm nhớ xóa cầu thủ đó khỏi clb cũ
            // 

            this.formFather.openChildForm(new formPlayerList(this.formFather, true));
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formAddNewTeam(this.formFather));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Mở form thêm đội bóng mới lên và đôi button "Thêm" thành button "Lưu", 
            // và đổi tiêu đề thành "THay đổi thông tin đội bóng"

            this.formFather.openChildForm(new formAddNewTeam(this.formFather));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome());
        }
    }
}
