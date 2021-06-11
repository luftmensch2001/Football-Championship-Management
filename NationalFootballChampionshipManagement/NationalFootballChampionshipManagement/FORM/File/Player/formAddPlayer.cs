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
            LoadPlayerType();
            LoadCLB();
        }

        void LoadPlayerType()
        {
            string query = "EXEC USP_GetPlayerTypeList";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
           // cbTypeOfPlayer.DataSource = data;
           //cbTypeOfPlayer.SelectedItem = data.Rows[0];
            cbTypeOfPlayer.DataSource = DataProvider.Instance.ExecuteQuery(query);
            cbTypeOfPlayer.DisplayMember = "TenLCT";
            cbTypeOfPlayer.ValueMember = "IDLCT";
        }

        void LoadCLB()
        {
            string query = "EXEC USP_GetTeamList";
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
                PlayerDAO.Instance.AddPlayer(nameCT, genderCT, nationalityCT, idLCT, dob, idDB, notes);
                MessageBox.Show("Thêm cầu thủ thành công!", "Thành công");
            }
            catch
            {
                MessageBox.Show("Thêm cầu thủ thất bại! Vui lòng kiểm tra lại thông tin", "Lỗi");
            } 
            
            
        }
    }
}
