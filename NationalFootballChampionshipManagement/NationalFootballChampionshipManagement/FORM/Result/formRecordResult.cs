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
    public partial class formRecordResult : Form
    {
        formMain formFather = null;

        public formRecordResult(formMain f)
        {
            InitializeComponent();

            this.formFather = f;
            addInformationColumn();
        }

        private void addInformationColumn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Thông tin chi tiết";
            btn.Name = "btnInformation";
            btn.Text = "Thông tin chi tiết";
            btn.UseColumnTextForButtonValue = true;
            this.dgvResult.Columns.Add(btn);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome());
        }
    }

    
}
