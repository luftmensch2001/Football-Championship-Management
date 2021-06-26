using NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
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
    public partial class formMuaGiai : Form
    {
        formMain formFather = null;

        public formMuaGiai(formMain f)
        {
            this.formFather = f;

            InitializeComponent();
            LoadMuaGiai();
        }

        void LoadMuaGiai()
        {
            lbNowTournament.Text = LeagueDAO.Instance.GetCurrLeagueName();
            cbLeague.DataSource = LeagueDAO.Instance.GetLeagueList();
            cbLeague.DisplayMember = "TenMG";
            cbLeague.ValueMember = "IDMG";
        }

        private void btnAddNewTournaments_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formAddMuaGiai(this.formFather));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cbLeague.SelectedValue == null) return;
            try
            {
                LeagueDAO.Instance.ChangeLeagueByID(Int32.Parse(cbLeague.SelectedValue.ToString()));
                lbNowTournament.Text = LeagueDAO.Instance.GetCurrLeagueName();
                this.formFather.LoadLogo();
                this.formFather.LoadStatus();
                this.formFather.openChildForm(new formMuaGiai(this.formFather));
                MessageBox.Show("Chuyển mùa giải thành công", "Thành công");
            }
            catch
            {
                MessageBox.Show("Chuyển mùa giải thất bại", "Lỗi");
            } 
            
            
        }
    }
}
