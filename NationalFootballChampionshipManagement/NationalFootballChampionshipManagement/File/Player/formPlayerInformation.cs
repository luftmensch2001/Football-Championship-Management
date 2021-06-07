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
    public partial class formPlayerInformation: Form
    {
        formMain formFather = null;

        public formPlayerInformation()
        {
            InitializeComponent();
        }
        public formPlayerInformation(formMain f)
        {
            this.formFather = f;
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formPlayerList(formFather));
            this.Close();
        }
    }
}
