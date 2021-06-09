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
    }
}
