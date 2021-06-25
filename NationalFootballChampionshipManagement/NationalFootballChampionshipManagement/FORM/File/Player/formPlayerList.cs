using System;
using NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
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
    public partial class formPlayerList : Form
    {
        formMain formFather = null;
        List<Player> listPlayer = new List<Player>();
        List<Team> teams = new List<Team>();

        List<bool> bTeam = new List<bool>();
        List<bool> bType = new List<bool>();

        List<PlayerType> listPlayerType = new List<PlayerType>();

        public formPlayerList(formMain f)
        {
            InitializeComponent();
            this.formFather = f;
            LoadTypes();
            GetTeams();


            SetDGV();
        }
        void LoadTypes()
        {
            int i = 0;
            listPlayerType = PlayerTypeDAO.Instance.GetPlayerTypes();
            foreach (PlayerType type in listPlayerType)
            {
                bType.Add(false);
                clbLCT.Items.Add(type.TypeName);
                clbLCT.SetItemChecked(i, true);
                i++;
            }
        }
        void GetTeams()
        {
            teams = TeamDAO.Instance.GetNameAndIdTeam();
            int i = 0;
            foreach (Team team in teams)
            {
                clbTeam.Items.Add(team.TeamName);
                bTeam.Add(false);
                clbTeam.SetItemChecked(i, true);
                List<Player> list = PlayerDAO.Instance.GetListPlayerExceptImage(team.ID);
                foreach (Player player in list)
                {
                    listPlayer.Add(player);
                }
                i++;
            }
        }
        String GetNameTeamById(int id)
        {
            foreach (Team team in teams)
            {
                if (id == team.ID)
                    return team.TeamName;
            }
            return "";
        }
        String GetNameTypeById(int id)
        {
            foreach (PlayerType playerType in listPlayerType)
            {
                if (id == playerType.ID)
                    return playerType.TypeName;
            }
            return "";
        }
        void SetDGV()
        {
            dgvPlayerList.Rows.Clear();
            int i = 1;
            foreach (Player player in listPlayer)
            {
                if (IsInListTeamChecked(GetNameTeamById(player.IDDB)) && IsInListTypeChecked(GetNameTypeById(player.IDLCT)))
                {
                    dgvPlayerList.Rows.Add(i, player.PlayName, TeamDAO.Instance.GetTeamNameByID(player.IDDB), PlayerTypeDAO.Instance.GetNameByID(player.IDLCT), player.CountGoal);
                    i++;
                }
            }
        }
        bool IsInListTeamChecked(string s)
        {
            for (int i = 0; i < bTeam.Count; i++)
            {
                if (bTeam[i] && s == clbTeam.Items[i].ToString())
                    return true;
            }
            return false;
        }
        bool IsInListTypeChecked(string s)
        {
            for (int i = 0; i < bType.Count; i++)
            {
                if (bType[i] && s == clbLCT.Items[i].ToString())
                    return true;
            }
            return false;
        }
        void AuToID()
        {
            foreach (DataGridViewRow row in dgvPlayerList.Rows)
            {
                row.Cells[0].Value = row.Index+1;
            }
        }
        void SearchByName(string name)
        {
            SetDGV();
            if (name == "") return;
            for (int i = 0; i < dgvPlayerList.Rows.Count; i++) 
            {
                while ( i<dgvPlayerList.Rows.Count &&!dgvPlayerList.Rows[i].Cells[1].Value.ToString().Contains(name))
                    dgvPlayerList.Rows.RemoveAt(i);
            }
            AuToID();
        }
        private void Btn_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formPlayerInformation());
        }

        private void Inf_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formPlayerInformation());
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formAddPlayer(this.formFather));

            this.Close();
        }

        private void dgvPlayerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                this.formFather.openChildForm(new formPlayerInformation(formFather));
            }    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formTeam(this.formFather));
        }

        private void clbTeam_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bTeam[e.Index] = !bTeam[e.Index];
            SetDGV();
        }

        private void clbLCT_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            bType[e.Index] = !bType[e.Index];
            SetDGV();
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            SearchByName(tbNamePlayer.Text);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvPlayerList.Rows.Count > 0)
            {
                ExportDatagridViewToPDF toPDF = new ExportDatagridViewToPDF(dgvPlayerList);
                toPDF.Export("Danh sách cầu thủ", "Danh sách cầu thủ");
            }
            else
            {
                MessageBox.Show("Không có thông tin để in");
            }
        }
    }
}
