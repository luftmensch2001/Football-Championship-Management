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
    public partial class formRanking : Form
    {
        formMain formFather = null;
        public formRanking(formMain f)
        {
            InitializeComponent();

            this.formFather = f;

            addColumnsToDatagridviews();
        }

        private void addColumnsToDatagridviews()
        {
            return;
            //this.dgvRanking.AutoSize = false;

            this.dgvRanking.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            // Câu lạc bộ
            DataGridViewColumn newCol = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Câu lạc bộ";
            newCol.Name = "colCLB";
            newCol.Visible = true;
            newCol.Width = 200;

            this.dgvRanking.Columns.Add(newCol);

            
            // Trận
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Trận";
            newCol.Name = "colMatches";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            
            // Thắng
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Thắng";
            newCol.Name = "colWin";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Hòa
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Hòa";
            newCol.Name = "colEqual";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Thua
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Thua";
            newCol.Name = "colLose";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Số bàn thắng
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "BT";
            newCol.Name = "colNumberOfGoals";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Số bàn thua
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "SBT";
            newCol.Name = "colNumberOfGoalsConceded";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Hệ số
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "HS";
            newCol.Name = "colCoefficient";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // Điểm
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "Đ";
            newCol.Name = "colScores";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);

            // 5 trận gần nhất
            newCol = new DataGridViewColumn();
            cell = new DataGridViewTextBoxCell();
            newCol.CellTemplate = cell;

            newCol.HeaderText = "5 trận gần nhất";
            newCol.Name = "col5History";
            newCol.Visible = true;
            newCol.Width = 10;

            this.dgvRanking.Columns.Add(newCol);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }
    }
}
