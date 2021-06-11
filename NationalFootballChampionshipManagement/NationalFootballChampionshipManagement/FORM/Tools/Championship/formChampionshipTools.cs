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
    public partial class formChampionshipTools : Form
    {
        formMain formFather = null;

        public formChampionshipTools(formMain f)
        {
            this.formFather = f;

            InitializeComponent();
        }

        private void btnAddTypeOfPlayer_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formAddTypeOfPlayer(this.formFather));

            this.Close();
        }

        private void btnAddTypeOfGoal_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formAddTypeOfGoal(this.formFather));

            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }
    }
}
