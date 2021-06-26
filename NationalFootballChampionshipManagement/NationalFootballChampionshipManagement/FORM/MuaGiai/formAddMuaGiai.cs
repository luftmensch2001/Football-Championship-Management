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
    public partial class formAddMuaGiai : Form
    {
        formMain formFather = null;
        public formAddMuaGiai(formMain f)
        {
            this.formFather = f;

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formMuaGiai(this.formFather));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (pbImage.Image == null)
            {
                MessageBox.Show("Vui lòng thêm logo cho mùa giải", "Lỗi");
                return;
            }

            try
            {
                bool firstLeague = (LeagueDAO.Instance.GetCurrIDMG() == -1);
                LeagueDAO.Instance.AddLeague(tbName.Text, Int32.Parse(tbYear.Text), pbImage.Image);
                MessageBox.Show("Thêm mùa giải thành công", "Thành công");
                if (firstLeague) this.formFather.EnableButton();
            }
            catch
            {
                MessageBox.Show("Thêm mùa giải thất bại", "Lỗi");
            }

        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg|*.jpeg|*.png", Multiselect = false };
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            if (path != "")
                try
                {
                    pbImage.Image = Image.FromFile(path);
                }
                catch
                {
                    MessageBox.Show("File không hợp lệ, vui lòng chọn lại", "Lỗi");
                }
        }
    }
}
