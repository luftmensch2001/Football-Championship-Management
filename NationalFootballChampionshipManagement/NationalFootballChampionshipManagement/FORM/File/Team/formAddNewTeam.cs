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
    public partial class formAddNewTeam : Form
    {
        formMain formFather = null;

        Team team;

        public formAddNewTeam(formMain f)
        {
            this.formFather = f;

            InitializeComponent();
        }

        public formAddNewTeam(formMain f, Team team)
        {
            this.formFather = f;
            this.team = team;
            InitializeComponent();
            btnAdd.Text = "Lưu";
            lTitle.Text = "SỬA THÔNG TIN ĐỘI BÓNG";
            tbTeamName.Text = team.TeamName;
            tbCoachName.Text = team.CoachName;
            tbHost.Text = team.HostName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formTeam(this.formFather));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Thêm")
                try
                {
                    TeamDAO.Instance.AddTeam(tbTeamName.Text, tbCoachName.Text, tbHost.Text);
                    MessageBox.Show("Thêm đội bóng thành công!", "Thành công");
                }
                catch
                {
                    MessageBox.Show("Thêm đội bóng thất bại!", "Lỗi");
                }
            else 
                try
                {
                    TeamDAO.Instance.ChangeInforByIDDB(tbTeamName.Text, tbCoachName.Text, tbHost.Text, team.ID);
                    MessageBox.Show("Sửa thông tin thành công!", "Thành công");
                }
                catch
                {
                    MessageBox.Show("Sửa thông tin thất bại!", "Lỗi");
                }
        }
    }
}
