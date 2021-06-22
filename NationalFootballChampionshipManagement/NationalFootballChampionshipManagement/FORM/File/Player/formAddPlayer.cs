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
        }

<<<<<<< Updated upstream
=======
        public formAddPlayer(formMain f, int idct)
        {
            this.formFather = f;
            InitializeComponent();
            LoadCombobox();
            lTitle.Text = "Sửa thông tin cầu thủ";
            btnAdd.Text = "Lưu";
            player = PlayerDAO.Instance.GetPlayerByIDCT(idct);
            tbName.Text = player.PlayName;
            tbNationality.Text = player.Nationlity;
            dtpBirthday.Value = player.DayOfBirth;
            cbGender.SelectedIndex = player.Gender == "Nam" ? 0 : 1;
            cbCLB.Enabled = false;
            tbNote.Text = player.Notes;
            pbPlayerImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbPlayerImage.Image = PlayerDAO.Instance.GetImageByIDCT(idct);
        }

        void LoadCombobox()
        {
            // ComboBox PlayerType

            cbTypeOfPlayer.DataSource = PlayerTypeDAO.Instance.GetListPlayerType();
            cbTypeOfPlayer.DisplayMember = "Tên loại cầu thủ";
            cbTypeOfPlayer.ValueMember = "Số thứ tự";

            //ComboBox CLB

            cbCLB.DataSource = TeamDAO.Instance.LoadTeamListToDataTable();
            cbCLB.DisplayMember = "TenDB";
            cbCLB.ValueMember = "IDDB";
        }
>>>>>>> Stashed changes
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formPlayerList(this.formFather));

            this.Close();
        }
    }
}
