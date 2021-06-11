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
    public partial class formPlayerList : Form
    {
        formMain formFather = null;

        public formPlayerList(formMain f)
        {
            InitializeComponent();
            this.formFather = f;

            addExampleRow();
        }

        private void addExampleRow()
        {
            DataGridViewRow row = (DataGridViewRow)dgvPlayerList.Rows[0].Clone();
            row.Cells[0].Value = "1";
            row.Cells[1].Value = "Nguyễn Văn A";
            row.Cells[2].Value = "Team 01";
            row.Cells[3].Value = "Trong nước";
            row.Cells[4].Value = 5;

            this.dgvPlayerList.Rows.Add(row);

            /*TextBox inf = new TextBox();
            inf.Text = "Thông tin chi tiết";
            inf.Font = new Font("Segoe UI Semibold", 8.75F, FontStyle.Underline);
            inf.Cursor = Cursors.Hand;

            inf.Click += Inf_Click;

            row.Cells[5].Value = inf;*/
            /*Button btn = new Button();
            btn.Name = "btnInformation";
            btn.Text = "Thông tin chi tiết";
            btn.Click += Btn_Click;
            row.Cells[5].Value = btn;*/

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Thông tin chi tiết";
            btn.Name = "btnInformation";
            btn.Text = "Thông tin chi tiết";
            btn.UseColumnTextForButtonValue = true;
            this.dgvPlayerList.Columns.Add(btn);    
        


            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formPlayerInformation());
        }

        private void Inf_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formPlayerInformation());
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formAddPlayer(this.formFather));

            this.Close();
        }

        private void dgvPlayerList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                this.formFather.openChildForm(new formPlayerInformation(formFather));
            }    
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formTeam(this.formFather));
        }
    }
}
