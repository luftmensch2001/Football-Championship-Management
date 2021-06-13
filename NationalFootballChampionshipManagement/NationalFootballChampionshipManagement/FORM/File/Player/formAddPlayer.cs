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
    public partial class formAddPlayer : Form
    {
        formMain formFather = null;

        public formAddPlayer()
        {
            InitializeComponent();
        }

        public formAddPlayer(formMain f)
        {
            this.formFather = f;
            InitializeComponent();
            LoadCombobox();
        }

        void LoadCombobox()
        {
            // ComboBox PlayerType
            int idmg = LeagueDAO.Instance.GetCurrIDMG();
            string query = "USP_GetPlayerTypeByIDMG " + idmg.ToString() ;

            cbTypeOfPlayer.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbTypeOfPlayer.DisplayMember = "TenLCT";
            cbTypeOfPlayer.ValueMember = "IDLCT";

            //ComboBox CLB

            query = "USP_GetTeamListByIDMG " + idmg.ToString();

            cbCLB.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbCLB.DisplayMember = "TenDB";
            cbCLB.ValueMember = "IDDB";
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formPlayerList(this.formFather));

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string nameCT = tbName.Text;
                string genderCT = cbGender.SelectedItem.ToString();
                string nationalityCT = tbNationality.Text;
                int idLCT = (int)cbTypeOfPlayer.SelectedValue;
                DateTime dob = dtpBirthday.Value;
                int idDB = (int)cbCLB.SelectedValue;
                string notes = tbNote.Text;

                Rules rules = RulesDAO.Instance.GetRules();

                if (TeamDAO.Instance.GetCountPlayer(idDB) >= rules.SLTD)
                {
                    MessageBox.Show("Đội bóng đã đạt số lượng cầu thủ tối đa", "Lỗi");
                    return;
                }

                int status = PlayerDAO.Instance.AddPlayer(nameCT, genderCT, nationalityCT, idLCT, dob, idDB, notes);
                if (status == 1) MessageBox.Show("Thêm cầu thủ thành công!", "Thành công");
            }
            catch
            {
                MessageBox.Show("Thêm cầu thủ thất bại! Vui lòng kiểm tra lại thông tin", "Lỗi");
            }
        }
    }
}
