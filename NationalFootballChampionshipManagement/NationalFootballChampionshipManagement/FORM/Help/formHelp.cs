using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NationalFootballChampionshipManagement
{
    public partial class formHelp : Form
    {
        formMain formFather = null;

        public formHelp(formMain f)
        {
            this.formFather = f;

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }

        private void btnError_Click(object sender, EventArgs e)
        {
            Process.Start("https://forms.gle/Y6LfA6rYZEQRCps19");
        }

        private void btnContactToDevelopers_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.facebook.com/ductrungg01/");
        }

        private void btnHowToUse_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/luftmensch2001/Football-Championship-Management");
        }
    }
}
