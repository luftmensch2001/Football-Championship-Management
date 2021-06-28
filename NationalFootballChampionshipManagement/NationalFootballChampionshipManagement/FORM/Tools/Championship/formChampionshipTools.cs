using NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
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
            LoadInforLeague();
            LoadRules();
            lockValue();
            LoadDgvPlayerType();
            LoadDgvGoalType();
            dgvGoalType.ClearSelection();
        }

        void LoadInforLeague()
        {
            lbLeagueName.Text = LeagueDAO.Instance.GetCurrLeagueName();
            lbLeagueYear.Text = LeagueDAO.Instance.GetCurrLeagueYear();
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
            this.formFather.openChildForm(new formAddTypeOfPlayer(this.formFather));

            this.Close();
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
            this.formFather.openChildForm(new formAddTypeOfGoal(this.formFather));

            this.Close();
        }
        private void btnRemoveTypeOfGoal_Click(object sender, EventArgs e)
        {

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
            //Check logic

            //NumberOfTeams
            if (nudNumberOfTeams.Value < TeamDAO.Instance.GetCountTeam())
            {
                MessageBox.Show("Số lượng đội bóng phải lớn hơn số lượng đội đang có", "Lỗi");
                return;
            }
            if (nudNumberOfTeams.Value < 2)
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
            if (IsLowerThanMaxPlayer())
            {
                MessageBox.Show("Hiện tại có đội có số lượng cầu thủ mượt mức này\nVui lòng xoá và thử lại", "Lỗi");
                return;
            }    

            DialogResult dialogResult = MessageBox.Show("Chú ý: Sau khi lưu thay đổi, các cầu thủ có tuổi không hợp lệ sẽ bị xoá khỏi danh sách\nLưu những thay đổi này ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;



            //Save to DB
            try
            {
                //update rules
                RulesDAO.Instance.UpdateRules(
                nudNumberOfTeams.Value.ToString(),
                nudMinAge.Value.ToString(),
                nudMaxAge.Value.ToString(),
                nudMinPlayer.Value.ToString(),
                nudMaxPlayer.Value.ToString(),
                nudTimeGoalsMax.Value.ToString()
                );

                //remove player
                List<Player> listPlayer = PlayerDAO.Instance.GetListNameAndDoBPlayer();
                foreach (Player p in listPlayer)
                {
                    int age = DateTime.Now.Year - p.DayOfBirth.Year;
                    if (DateTime.Now.DayOfYear < p.DayOfBirth.DayOfYear)
                        age = age - 1;
                    if (age > nudMaxAge.Value || age < nudMinAge.Value)
                    {
                        try
                        {
                            PlayerDAO.Instance.DeletePlayerByID(p.ID);
                        }
                        catch
                        {
                            MessageBox.Show("Có lỗi trong quá trình xoá cầu thủ không hợp lệ", "Lỗi");
                        }
                    }
                }

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

        private void lockValue()
        {
            if (roundCount > 0)
            {
                nudMaxAge.Enabled = false;
                nudMinAge.Enabled = false;
                nudMaxPlayer.Enabled = false;
                nudMinPlayer.Enabled = false;
                nudNumberOfTeams.Enabled = false;
                nudTimeGoalsMax.Enabled = false;
                btnAddTypeOfGoal.Enabled = false;
                btnAddTypeOfPlayer.Enabled = false;
                btnRemoveTypeOfGoal.Enabled = false;
                btnRemoveTypeOfPlayer.Enabled = false;
                btnSave.Enabled = false;
                MessageBox.Show("Không thể thay đổi quy định giải đấu khi đã tạo lịch thi đấu", "Thông báo");
            }
        }

        private bool IsLowerThanMaxPlayer()
        {
            List<Team> team = TeamDAO.Instance.GetNameAndIdTeam();
            foreach (Team i in team)
            {
                if (TeamDAO.Instance.GetCountPlayer(i.ID) > nudMaxPlayer.Value)
                    return true;
            }
            return false;
        }
    }
}
