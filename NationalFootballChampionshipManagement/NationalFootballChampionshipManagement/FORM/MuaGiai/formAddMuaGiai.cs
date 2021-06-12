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
            try
            {
                LeagueDAO.Instance.AddLeague(tbName.Text, Int32.Parse(tbYear.Text));
                MessageBox.Show("Thêm mùa giải thành công", "Thành công");
            }
            catch
            {
                MessageBox.Show("Thêm mùa giải thất bại", "Lỗi");
            }

        }
    }
}
