using NationalFootballChampionshipManagement.DAO;
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
        List<int> listIDLCT = new List<int>();
        int SelectedIDLCT = 0;
        public formChampionshipTools(formMain f)
        {
            this.formFather = f;

            InitializeComponent();

            LoadDgvPlayerType();
        }

        void LoadDgvPlayerType()
        {
            dgvPlayerType.DataSource = PlayerTypeDAO.Instance.GetPlayerTypeList();
            dgvPlayerType.ReadOnly = true;
            dgvPlayerType.RowTemplate.Height = 30;
            listIDLCT.Clear();
            for (int i = 0; i < dgvPlayerType.Rows.Count - 1; i++)
            {
                listIDLCT.Add(Int32.Parse(dgvPlayerType.Rows[i].Cells[0].Value.ToString()));
                dgvPlayerType.Rows[i].Cells[0].Value = i + 1;
            }
            dgvPlayerType.CellClick +=
                new DataGridViewCellEventHandler(dgvPlayerType_CellClick);
        }
        void dgvPlayerType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvPlayerType.Rows.Count - 1) return;
            this.SelectedIDLCT = listIDLCT[e.RowIndex];
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

        private void btnRemoveTypeOfPlayer_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tất cả cầu thủ thuộc loại này cũng bị xoá. Bạn có chắc muốn xoá loại cầu thủ này không ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            try
            {
                PlayerTypeDAO.Instance.DeleteByID(SelectedIDLCT);
                MessageBox.Show("Xoá thành công", "Thành công");
                LoadDgvPlayerType();
            }
            catch 
            {

                MessageBox.Show("Xoá thất bại", "Lỗi");
            }
            
        }
    }
}
