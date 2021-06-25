using NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
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
    public partial class formRankingTools : Form
    {
        formMain formFather = null;
        List<PriorityRank> listPriorityRank = new List<PriorityRank>();
        int selectedRowIndex = -1;
        public formRankingTools(formMain f)
        {
            InitializeComponent();

            this.formFather = f;
            LoadListPriorityRank();
        }

        void LoadListPriorityRank()
        {
            try
            {
                listPriorityRank = PriorityRankDAO.Instance.GetListPriorityRank();

                int cnt = listPriorityRank.Count;
                int stt = 1;
                for (int i = 0; i < cnt; i++)
                {
                    foreach (PriorityRank priorityRank in listPriorityRank)
                        if (priorityRank.Rank == stt)
                        {
                            dgvRankingRule.Rows.Add(priorityRank.Name, stt);
                            stt++;
                        }
                }
		dgvRankingRule.ClearSelection();
            }
            catch
            {
                MessageBox.Show("Lỗi khi tải dữ liệu", "Lỗi");
            }
        }
        private void dgvRankingRule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRowIndex = e.RowIndex;
        }
        private void btUp_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 1 || selectedRowIndex >= dgvRankingRule.Rows.Count)
            {
                return;
            }

            string cellUp = dgvRankingRule[0, selectedRowIndex - 1].Value.ToString();
            dgvRankingRule[0, selectedRowIndex - 1].Value = dgvRankingRule[0, selectedRowIndex].Value.ToString();
            dgvRankingRule[0, selectedRowIndex].Value = cellUp;

            dgvRankingRule.Rows[selectedRowIndex - 1].Selected = true;
            selectedRowIndex--;
        }
        private void btDown_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex < 0 || selectedRowIndex >= dgvRankingRule.Rows.Count - 1)
            {
                return;
            }

            string cellDown = dgvRankingRule[0, selectedRowIndex + 1].Value.ToString();
            dgvRankingRule[0, selectedRowIndex + 1].Value = dgvRankingRule[0, selectedRowIndex].Value.ToString();
            dgvRankingRule[0, selectedRowIndex].Value = cellDown;

            dgvRankingRule.Rows[selectedRowIndex + 1].Selected = true;
            selectedRowIndex++;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string Ten;
            DialogResult dialogResult = MessageBox.Show("Lưu những thay đổi này ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;
            try
            {
                for (int i = 0; i < dgvRankingRule.Rows.Count; i++)
                {
                    Ten = dgvRankingRule[0, i].Value.ToString();
                    PriorityRankDAO.Instance.UpdateListPriorityRankByThuTuUuTien(Ten, i + 1);
                }
                MessageBox.Show("Cập nhật thành công", "Thành công");
            }
            catch
            {
                MessageBox.Show("Có lỗi trong quá trình cập nhật thứ tự \nVui lòng tạo lại giải đấu nếu bị trùng lặp điều kiện", "Lỗi nghiêm trọng");
            }
        }
    }
}
