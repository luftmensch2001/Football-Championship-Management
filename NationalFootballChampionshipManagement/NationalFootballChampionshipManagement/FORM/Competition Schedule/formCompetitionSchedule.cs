﻿using System;
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
    public partial class formCompetitionSchedule : Form
    {
        formMain formFather = null;

        public formCompetitionSchedule(formMain f)
        {
            InitializeComponent();

            this.formFather = f;
        }

        private void addEditColumn()
        {
            /*
            
             */

            //
            // Code
            //
        }

        private void btnAddNewCompetiton_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formAddCompetition(this.formFather));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }
    }
}
