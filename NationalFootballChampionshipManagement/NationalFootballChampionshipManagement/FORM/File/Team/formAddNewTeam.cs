using NationalFootballChampionshipManagement.DAO;
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

        public formAddNewTeam(formMain f)
        {
            this.formFather = f;

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formTeam(this.formFather));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TeamDAO.Instance.AddTeam(tbTeamName.Text, tbCoachName.Text, tbHost.Text);
                MessageBox.Show("Thêm đội bóng thành công!", "Thành công");
            }
            catch
            {
                MessageBox.Show("Thêm đội bóng thất bại!", "Lỗi");
            }
        }
    }
}
