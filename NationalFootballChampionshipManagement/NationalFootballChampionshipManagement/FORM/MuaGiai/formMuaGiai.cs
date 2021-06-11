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
        }

        private void btnAddNewTournaments_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formAddMuaGiai(this.formFather));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }
    }
}
