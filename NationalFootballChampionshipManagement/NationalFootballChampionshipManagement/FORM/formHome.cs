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
    public partial class formHome : Form
    {
        formMain formFather = null;

        public formHome(formMain f)
        {
            InitializeComponent();

            this.formFather = f;
            this.formFather.resetButtonColor();

            timerNow.Start();
        }

        private void timerNow_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            this.lbTimeNow.Text = datetime.ToString();
        }
    }
}
