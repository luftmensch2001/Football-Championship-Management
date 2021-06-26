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
    public partial class formChampionshipTools : Form
    {
        formMain formFather = null;
        List<int> listIDLCT = new List<int>();
        List<GoalType> listGoalType = new List<GoalType>();
        int SelectedIDLCT = 0;
        Rules rules = null;
        int selectedGoalTypeRow = -1;
        int selectedPlayerTypeRow = -1;
        int roundCount;
        public formChampionshipTools(formMain f)
        {
            this.formFather = f;

            InitializeComponent();
            try
            {
                roundCount = MatchDAO.Instance.GetRoundCount();
            }
            catch
            {
                roundCount = -1;
            }
            LoadRules();
            LoadDgvPlayerType();
            LoadDgvGoalType();
            dgvGoalType.ClearSelection();
        }

        void LoadRules()
        {
            try
            {
                rules = RulesDAO.Instance.GetRules();

                nudNumberOfTeams.Value = rules.SLDB;
                nudTimeGoalsMax.Value = Int32.Parse(rules.TimeGoalMax);
                nudMinAge.Value = rules.TuoiTT;
                nudMaxAge.Value = rules.TuoiTD;
                nudMinPlayer.Value = rules.SLTT;
                nudMaxPlayer.Value = rules.SLTD;
            }
            catch
            {
                MessageBox.Show("Lỗi khi tải quy định", "Lỗi");
            }
        }
        void LoadDgvPlayerType()
        {
            try
            {
                dgvPlayerType.DataSource = PlayerTypeDAO.Instance.GetListPlayerType();
                dgvPlayerType.ReadOnly = true;
                dgvPlayerType.RowTemplate.Height = 30;
                listIDLCT.Clear();
                for (int i = 0; i < dgvPlayerType.Rows.Count; i++)
                {
                    listIDLCT.Add(Int32.Parse(dgvPlayerType.Rows[i].Cells[0].Value.ToString()));
                    dgvPlayerType.Rows[i].Cells[0].Value = i + 1;
                }
                dgvPlayerType.CellClick +=
                    new DataGridViewCellEventHandler(dgvPlayerType_CellClick);
            }
            catch
            {
                MessageBox.Show("Lỗi khi tải danh sách loại cầu thủ", "Lỗi");
            }
        }
        void LoadDgvGoalType()
        {
            try
            {
                listGoalType = GoalTypeDAO.Instance.GetListGoalType();
                int i = 1;
                foreach (GoalType goalType in listGoalType)
                {
                    dgvGoalType.Rows.Add(i, goalType.Name);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi tải danh sách loại bàn thắng", "Lỗi");
            }
        }
        private void dgvPlayerType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvPlayerType.Rows.Count) return;
            this.SelectedIDLCT = listIDLCT[e.RowIndex];
        }
        private void dgvGoalType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedGoalTypeRow = e.RowIndex;
        }
        private void btnAddTypeOfPlayer_Click(object sender, EventArgs e)
        {
            // kiểm tra mùa giải
            if (roundCount == -1)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu\nVui lòng thử lại sau", "Lỗi kết nối");
                return;
            }
            if (roundCount > 0)
            {
                MessageBox.Show("Không thể thay đổi quy định này khi mùa giải đã bắt đầu");
                return;
            }
            this.formFather.openChildForm(new formAddTypeOfPlayer(this.formFather));

            this.Close();
        }
        private void btnRemoveTypeOfPlayer_Click(object sender, EventArgs e)
        {
            // kiểm tra mùa giải
            if (roundCount == -1)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu\nVui lòng thử lại sau", "Lỗi kết nối");
                return;
            }
            if (roundCount > 0)
            {
                MessageBox.Show("Không thể thay đổi quy định này khi mùa giải đã bắt đầu");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Tất cả cầu thủ thuộc loại này cũng bị xoá. Bạn có chắc muốn xoá loại cầu thủ này không ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            try
            {
                PlayerTypeDAO.Instance.DeleteByID(SelectedIDLCT);
                MessageBox.Show("Xoá loại cầu thủ thành công", "Thành công");
                LoadDgvPlayerType();
            }
            catch
            {

                MessageBox.Show("Xoá loại cầu thủ thất bại", "Lỗi");
            }
        }
        private void btnAddTypeOfGoal_Click(object sender, EventArgs e)
        {
            // kiểm tra mùa giải
            if (roundCount == -1)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu\nVui lòng thử lại sau", "Lỗi kết nối");
                return;
            }
            if (roundCount > 0)
            {
                MessageBox.Show("Không thể thay đổi quy định này khi mùa giải đã bắt đầu");
                return;
            }
            this.formFather.openChildForm(new formAddTypeOfGoal(this.formFather));

            this.Close();
        }
        private void btnRemoveTypeOfGoal_Click(object sender, EventArgs e)
        {
            // kiểm tra mùa giải
            if (roundCount == -1)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu\nVui lòng thử lại sau", "Lỗi kết nối");
                return;
            }    
            if (roundCount > 0)
            {
                MessageBox.Show("Không thể thay đổi quy định này khi mùa giải đã bắt đầu");
                return;
            }

            //thực hiện
            if (selectedGoalTypeRow < 0 || selectedGoalTypeRow >= dgvGoalType.Rows.Count)
            {
                MessageBox.Show("Vui lòng chọn loại bàn thắng cần xoá", "Lỗi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Xoá loại bàn thắng này ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;
            try
            {
                string name = dgvGoalType[1, selectedGoalTypeRow].Value.ToString();
                GoalTypeDAO.Instance.DeleteGoalTypeByName(name);
                dgvGoalType.Rows.Clear();
                LoadDgvGoalType();
                dgvGoalType.ClearSelection();
                MessageBox.Show("Xoá loại bàn thắng thành công", "Thành công");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại", "Lỗi");
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            // kiểm tra mùa giải
            if (roundCount == -1)
            {
                MessageBox.Show("Có lỗi khi tải dữ liệu\nVui lòng thử lại sau", "Lỗi kết nối");
                return;
            }
            if (roundCount > 0)
            {
                MessageBox.Show("Không thể thay đổi quy định này khi mùa giải đã bắt đầu");
                return;
            }
            //Check logic

            //NumberOfTeams
            if (nudMinAge.Value < 2)
            {
                MessageBox.Show("Số lượng đội bóng phải lớn hơn 1", "Lỗi");
                return;
            }

            //Age
            if (nudMinAge.Value < 1)
            {
                MessageBox.Show("Số tuổi phải lớn hơn 0", "Lỗi");
                return;
            }
            if (nudMinAge.Value > nudMaxAge.Value)
            {
                MessageBox.Show("Tuổi tối thiểu không được lớn hơn tuổi tối đa", "Lỗi");
                return;
            }

            //Player
            if (nudMinPlayer.Value < 1)
            {
                MessageBox.Show("Số lượng cầu thủ tối thiểu phải lớn hơn 0", "Lỗi");
                return;
            }
            if (nudMinPlayer.Value > nudMaxPlayer.Value)
            {
                MessageBox.Show("Số lượng cầu thủ tối thiểu không được lớn hơn số lượng cầu thủ tối đa", "Lỗi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Lưu những thay đổi này ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;
            //Save to DB
            try
            {
                    RulesDAO.Instance.UpdateRules(
                    nudNumberOfTeams.Value.ToString(),
                    nudMinAge.Value.ToString(),
                    nudMaxAge.Value.ToString(),
                    nudMinPlayer.Value.ToString(),
                    nudMaxAge.Value.ToString(),
                    nudTimeGoalsMax.Value.ToString()
                    );
                MessageBox.Show("Cập nhật quy định thành công", "Thành công");
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại", "Lỗi");
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }
    }
}
