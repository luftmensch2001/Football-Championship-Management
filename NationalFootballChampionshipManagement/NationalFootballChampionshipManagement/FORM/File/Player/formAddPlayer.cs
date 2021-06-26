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

        Player player = null;
        public formAddPlayer()
        {
            InitializeComponent();
        }

        public formAddPlayer(formMain f)
        {
            this.formFather = f;
            InitializeComponent();
            LoadCombobox();
            btnDelete.Hide();
            pbPlayerImage.SizeMode = PictureBoxSizeMode.StretchImage;
        }

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
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formTeam(this.formFather));

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbCLB.SelectedValue == null || cbTypeOfPlayer.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đẩy đủ thông tin", "Lỗi");
                return;
            }
            try
            {
                string nameCT = tbName.Text;
                while (nameCT != "" && nameCT[0] == ' ')
                    nameCT = nameCT.Remove(0, 1);
                while (nameCT != "" && nameCT[nameCT.Length - 1] == ' ') 
                    nameCT = nameCT.Remove(nameCT.Length - 1, 1);
                // chuan hoa ten
                string genderCT = cbGender.SelectedItem.ToString();

                string nationalityCT = tbNationality.Text;
                while (nationalityCT != "" && nationalityCT[0] == ' ')
                    nationalityCT = nationalityCT.Remove(0, 1);
                while (nationalityCT != "" && nationalityCT[nationalityCT.Length - 1] == ' ')
                    nationalityCT = nationalityCT.Remove(nationalityCT.Length - 1, 1);

                int idLCT = (int)cbTypeOfPlayer.SelectedValue;
                DateTime dob = dtpBirthday.Value;
                int idDB = (int)cbCLB.SelectedValue;
                string notes = tbNote.Text;

                int idct = player == null ? 0 : player.ID;

                int countOfThisPlayerType = PlayerTypeDAO.Instance.GetCountPlayerByIDLCT(idct, idLCT, idDB);
                // Dem xem trong team da co bao nhieu cau thu loai nay, khong tinh ban than
                int maxCount = PlayerTypeDAO.Instance.GetMax(idLCT);
                if (countOfThisPlayerType >= maxCount)
                {
                    MessageBox.Show("Số lượng loại cầu thủ này trong đội bóng đã đạt tối đa", "Lỗi");
                    return;
                }

                if (nameCT == "" || nationalityCT == "")
                {
                    MessageBox.Show("Vui lòng nhập đẩy đủ thông tin", "Lỗi");
                    return;
                }

                if (btnAdd.Text == "Thêm")
                {
                    if (pbPlayerImage.Image == null)
                    {
                        MessageBox.Show("Vui lòng thêm hình ảnh", "Lỗi");
                        return;
                    } 
                        
                    Rules rules = RulesDAO.Instance.GetRules();                 

                    if (TeamDAO.Instance.GetCountPlayer(idDB) >= rules.SLTD)
                    {
                        MessageBox.Show("Đội bóng đã đạt số lượng cầu thủ tối đa", "Lỗi");
                        return;
                    }

                    int status = PlayerDAO.Instance.AddPlayer(nameCT, genderCT, nationalityCT, idLCT, dob, idDB, notes, pbPlayerImage.Image);
                    if (status == 1)
                    {
                        MessageBox.Show("Thêm cầu thủ thành công!", "Thành công");
                        this.formFather.openChildForm(new formTeam(this.formFather));
                        this.Close();
                    }
                } 
                else
                {
                    int status = PlayerDAO.Instance.UpdatePlayer(player.ID, nameCT, genderCT, nationalityCT, idLCT, dob, idDB, notes, pbPlayerImage.Image);
                    if (status == 1)
                    {
                        MessageBox.Show("Cập nhật thành công!", "Thành công");
                        this.formFather.openChildForm(new formTeam(this.formFather));
                        this.Close();
                    }
                }

                
            }
            catch
            {
                if (btnAdd.Text == "Thêm")
                    MessageBox.Show("Thêm cầu thủ thất bại! Vui lòng kiểm tra lại thông tin", "Lỗi");
                else
                    MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại thông tin", "Lỗi");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn xoá cầu thủ này không ?","Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            if (PlayerDAO.Instance.DeletePlayerByID(player.ID) == 1) // xoa thanh cong
            {
                this.formFather.openChildForm(new formTeam(this.formFather));
                this.Close();
            }
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter="Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png", Multiselect = false };
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            if (path != "")
                try
                {
                    pbPlayerImage.Image = Image.FromFile(path);
                }
                catch
                {
                    MessageBox.Show("File không hợp lệ, vui lòng chọn lại", "Lỗi");
                }
        }
    }
}
