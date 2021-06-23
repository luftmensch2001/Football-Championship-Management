using System;
using NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
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
    public partial class formDetailsResult : Form
    {
        bool isChanged = false;
        formMain formFather = null;
        int idTranDau;
        Team Team1 = new Team();
        Team Team2 = new Team();
        List<Player> listPlayerTeam1 = new List<Player>();
        List<Player> listPlayerTeam2 = new List<Player>();
        List<Goal> listGoal = new List<Goal>();
        List<GoalType> listGoalType = new List<GoalType>();

        List<int> listIDGoalDelete = new List<int>();

        Rules rule = new Rules();
        

        public formDetailsResult(formMain form, int idTranDau, int vongDau,int idDoi1,int idDoi2, string san, int kqDoi1, int kqDoi2, DateTime thoiGian)
        {
            InitializeComponent();
            formFather = form;
            this.idTranDau = idTranDau;
            lbVongDau.Text = " Vòng : " +vongDau.ToString();
            nbTeam1.Text = Math.Max(kqDoi1, 0).ToString();
            nbTeam2.Text = Math.Max(kqDoi2, 0).ToString();
            lbSan.Text ="Sân: "+ san;

            Team1 = TeamDAO.Instance.GetTeamInforByID(idDoi1);
            Team2 = TeamDAO.Instance.GetTeamInforByID(idDoi2);

            lbTenDoi1.Text = Team1.TeamName;
            lbTenDoi2.Text = Team2.TeamName;
            ImageTeam1.BackgroundImage = Team1.Image;
            ImageTeam2.BackgroundImage = Team2.Image;
            dateTimeMatch.Value = thoiGian;


            cbbNameTeam.Items.Add(Team1.TeamName);
            cbbNameTeam.Items.Add(Team2.TeamName);

            listPlayerTeam1 = PlayerDAO.Instance.GetListIdAndNamePlayerByIDDB(Team1.ID);
            listPlayerTeam2 = PlayerDAO.Instance.GetListIdAndNamePlayerByIDDB(Team2.ID);


            listGoalType = GoalTypeDAO.Instance.GetListGoalType();
            Reset();
            
            LoadListNamePlayer(0);

            listGoal = GoalDAO.Instance.LoadGoads(idTranDau);
            LoaddgvGoal();

            rule = RulesDAO.Instance.GetRules();
            nbMinute.Maximum = Int32.Parse(rule.TimeGoalMax);

            AutoId(dgvGoalTeam1);
            AutoId(dgvGoalTeam2);

            btDelete.Enabled = false;
            btDelete.BackColor = Color.Gray;
            btFix.Enabled = false;
            btFix.BackColor = Color.Gray;
        }
        void LoaddgvGoal()
        {
            foreach (Goal goal in listGoal)
            {
                if (goal.IdDoiBong == Team1.ID)
                {
                    dgvGoalTeam1.Rows.Add(dgvGoalTeam1.Rows.Count,TenCauThuTeam1(goal.IdCauThu), TenLoaiBanThang(goal.IdLoaiBanThang),goal.IdThoiDiem);
                }else
                {
                    dgvGoalTeam2.Rows.Add(dgvGoalTeam2.Rows.Count, TenCauThuTeam2(goal.IdCauThu), TenLoaiBanThang(goal.IdLoaiBanThang), goal.IdThoiDiem);
                }
            }
        }
        string TenLoaiBanThang(int id)
        {
            foreach (GoalType goalType in listGoalType)
            {
                if (goalType.ID == id)
                    return goalType.Name;
            }
           
            return "";
        }
        string TenCauThuTeam1(int id)
        {
            foreach (Player player in listPlayerTeam1)
                if (player.ID == id)
                    return player.PlayName;
            return "";
        }
        string TenCauThuTeam2(int id)
        {
            foreach (Player player in listPlayerTeam2)
                if (player.ID == id)
                    return player.PlayName;
            return "";
        }
        void LoadListNamePlayer(int id)
        {
            cbbNamePlayer.Items.Clear();
            if (id==0)
                foreach (Player player in listPlayerTeam1)
                {
                    cbbNamePlayer.Items.Add(player.PlayName);
                }
            else
                foreach (Player player in listPlayerTeam2)
                {
                    cbbNamePlayer.Items.Add(player.PlayName);
                }
        }
        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formResultHistory(this.formFather));
            this.Close();
        }

        private void cbbNameTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadListNamePlayer(cbbNameTeam.SelectedIndex);
            tbSTT.Text = "";
        }


        void Reset()
        {
            cbbNameTeam.SelectedIndex = 0;
            Reset2();
        }
        void Reset2()
        {
            tbSTT.Text = "";
            cbbNamePlayer.Items.Clear();
            cbbTypeGoal.Items.Clear();
            LoadListNamePlayer(0);
            foreach (GoalType type in listGoalType)
            {
                cbbTypeGoal.Items.Add(type.Name);
            }
            nbMinute.Value = 0;
        }
        int GetIndexPlayer(string name)
        {
            for (int i = 0; i < cbbNamePlayer.Items.Count; i++)
                if (name == cbbNamePlayer.Items[i].ToString())
                    return i;
            return 0;
        }
        int GetIndexGoalType(string name)
        {
            for (int i = 0; i <cbbTypeGoal.Items.Count; i++)
                if (name == cbbTypeGoal.Items[i].ToString())
                    return i;
            return 0;
        }
        private void dgvGoalTeam1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbNameTeam.SelectedIndex = 0;
            if (e.RowIndex >= 0 && e.RowIndex < dgvGoalTeam1.Rows.Count)
            {
                tbSTT.Text = dgvGoalTeam1.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbbNameTeam.SelectedIndex = 0;
                cbbNamePlayer.SelectedIndex = GetIndexPlayer(dgvGoalTeam1.Rows[e.RowIndex].Cells[1].Value.ToString());
                cbbTypeGoal.SelectedIndex = GetIndexGoalType(dgvGoalTeam1.Rows[e.RowIndex].Cells[2].Value.ToString());
                nbMinute.Value = Int32.Parse(dgvGoalTeam1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            else Reset2();
        }
        private void dgvGoalTeam2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbNameTeam.SelectedIndex = 1;
            if (e.RowIndex >= 0 && e.RowIndex < dgvGoalTeam2.Rows.Count)
            {
                tbSTT.Text = dgvGoalTeam2.Rows[e.RowIndex].Cells[0].Value.ToString();
                cbbNameTeam.SelectedIndex = 1;
                cbbNamePlayer.SelectedIndex = GetIndexPlayer(dgvGoalTeam2.Rows[e.RowIndex].Cells[1].Value.ToString());
                cbbTypeGoal.SelectedIndex = GetIndexGoalType(dgvGoalTeam2.Rows[e.RowIndex].Cells[2].Value.ToString());
                nbMinute.Value = Int32.Parse(dgvGoalTeam2.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            else Reset2();
        }
        private void btAdd_Click(object sender, EventArgs e)
        {
            if (cbbNamePlayer.Text == "" || cbbNameTeam.Text == "" || cbbTypeGoal.Text == "" || cbbTypeGoal.Text == "")
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Lỗi thiếu thông tin");
            else
            {
                if (cbbNameTeam.SelectedIndex == 0)
                {
                    Goal goal = new Goal(idTranDau, listPlayerTeam1[cbbNameTeam.SelectedIndex].ID, Team1.ID, listGoalType[cbbTypeGoal.SelectedIndex].ID, nbMinute.Value.ToString());
                    dgvGoalTeam1.Rows.Add(dgvGoalTeam1.Rows.Count, cbbNamePlayer.SelectedItem.ToString(), cbbTypeGoal.SelectedItem.ToString(), goal.IdThoiDiem);
                    listGoal.Add(goal);
                }
                else
                {
                    Goal goal = new Goal(idTranDau, listPlayerTeam2[cbbNameTeam.SelectedIndex].ID, Team2.ID, listGoalType[cbbTypeGoal.SelectedIndex].ID, nbMinute.Value.ToString());
                    dgvGoalTeam2.Rows.Add(dgvGoalTeam2.Rows.Count, cbbNamePlayer.SelectedItem.ToString(), cbbTypeGoal.SelectedItem.ToString(), goal.IdThoiDiem);
                    listGoal.Add(goal);
                }
                Reset();
                EditGoalNumber();
                MessageBox.Show("Thêm bàn thắng thành công");
                isChanged = true;

            }
        }
        private void btDelete_Click(object sender, EventArgs e)
        {
            if (tbSTT.Text != "")
            {
                if (cbbNameTeam.SelectedIndex == 0)
                {

                    int rowIndex = dgvGoalTeam1.CurrentCell.RowIndex;
                    int index = 0;
                    foreach (Goal goal in listGoal)
                    {
                        if (goal.IdDoiBong == Team1.ID)
                            index++;
                        if ((int) dgvGoalTeam1.Rows[rowIndex].Cells[0].Value == index)
                        {
                            if (goal.IdBanThang != -1)
                                listIDGoalDelete.Add(goal.IdBanThang);
                            listGoal.Remove(goal);
                            break;
                        }
                    }    

                    dgvGoalTeam1.Rows.RemoveAt(rowIndex);
                    Reset();
                    AutoId(dgvGoalTeam1);
                }
                else
                {
                    int rowIndex = dgvGoalTeam2.CurrentCell.RowIndex;
                    int index = 0;
                    foreach (Goal goal in listGoal)
                    {
                        if (goal.IdDoiBong == Team2.ID)
                            index++;
                        if ((int)dgvGoalTeam2.Rows[rowIndex].Cells[0].Value == index)
                        {
                            if (goal.IdBanThang != -1) 
                                listIDGoalDelete.Add(goal.IdBanThang);
                            listGoal.Remove(goal);
                            break;
                        }
                    }

                    dgvGoalTeam2.Rows.RemoveAt(rowIndex);
                    Reset();
                    AutoId(dgvGoalTeam2);
                }
                EditGoalNumber();
                MessageBox.Show("Xóa bàn thắng thành công");
                isChanged = true;
                
            }
        }

        private void btFix_Click(object sender, EventArgs e)
        {
            if (tbSTT.Text!= "" && !(cbbNamePlayer.Text == "" || cbbNameTeam.Text == "" || cbbTypeGoal.Text == "" || cbbTypeGoal.Text == ""))
            {
                if (cbbNameTeam.SelectedIndex == 0)
                {
                    int rowIndex = dgvGoalTeam1.CurrentCell.RowIndex;
                    listGoal[ Int32.Parse(tbSTT.Text)-1] = new Goal(idTranDau, listPlayerTeam1[cbbNameTeam.SelectedIndex].ID, Team1.ID, listGoalType[cbbTypeGoal.SelectedIndex].ID, nbMinute.Value.ToString(), listGoal[Int32.Parse(tbSTT.Text)-1].IdBanThang);
                    DataGridViewRow row = new DataGridViewRow();
                    dgvGoalTeam1.Rows[rowIndex].Cells[1].Value = cbbNamePlayer.SelectedItem.ToString();
                    dgvGoalTeam1.Rows[rowIndex].Cells[2].Value = cbbTypeGoal.SelectedItem.ToString();
                    dgvGoalTeam1.Rows[rowIndex].Cells[3].Value = listGoal[Int32.Parse(tbSTT.Text)-1].IdThoiDiem;
                }else
                { 
                    int rowIndex = dgvGoalTeam1.CurrentCell.RowIndex;
                    listGoal[Int32.Parse(tbSTT.Text) - 1] = new Goal(idTranDau, listPlayerTeam2[cbbNameTeam.SelectedIndex].ID, Team2.ID, listGoalType[cbbTypeGoal.SelectedIndex].ID, nbMinute.Value.ToString(), listGoal[Int32.Parse(tbSTT.Text) - 1].IdBanThang);
                    DataGridViewRow row = new DataGridViewRow();
                    dgvGoalTeam2.Rows[rowIndex].Cells[1].Value = cbbNamePlayer.SelectedItem.ToString();
                    dgvGoalTeam2.Rows[rowIndex].Cells[2].Value = cbbTypeGoal.SelectedItem.ToString();
                    dgvGoalTeam2.Rows[rowIndex].Cells[3].Value = listGoal[Int32.Parse(tbSTT.Text) - 1].IdThoiDiem;
                }
                MessageBox.Show("Sửa bàn thắng thành công");
                EditGoalNumber();
                isChanged = true;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (Save())
            {
                isChanged = false;
                MessageBox.Show("Lưu dữ liệu thành công");
            }
        }
        bool Save()
        {
            ResultMatchDAO.Instance.SetKQ(idTranDau,Int32.Parse(nbTeam1.Text), Int32.Parse(nbTeam2.Text));
            foreach (Goal goal in listGoal)
            {
                if (goal.IdBanThang == -1)
                { 
                    GoalDAO.Instance.AddGoal(idTranDau, goal.IdDoiBong, goal.IdCauThu, goal.IdLoaiBanThang, goal.IdThoiDiem.ToString());
                    goal.IdBanThang = -2;
                }
                else
                    if (goal.IdBanThang!=-2)
                    GoalDAO.Instance.UpdateGoal(goal.IdBanThang, goal.IdCauThu, goal.IdLoaiBanThang, goal.IdThoiDiem);
            }
            foreach (int id in listIDGoalDelete)
            {
                GoalDAO.Instance.DeleteGoal(id);
            }
            listIDGoalDelete.Clear();
            foreach (Player player in listPlayerTeam1)
            {
                int count = 0;
                foreach (DataGridViewRow row in dgvGoalTeam1.Rows)
                    if (row.Index<dgvGoalTeam1.Rows.Count)
                    if (player.PlayName == row.Cells[1].Value.ToString())
                        count++;
                PlayerDAO.Instance.SetCountGoal(player.ID, count);
            }
            foreach (Player player in listPlayerTeam2)
            {
                int count = 0;
                foreach (DataGridViewRow row in dgvGoalTeam2.Rows)
                    if (row.Index < dgvGoalTeam2.Rows.Count)
                        if (player.PlayName == row.Cells[1].Value.ToString())
                        count++;
                PlayerDAO.Instance.SetCountGoal(player.ID, count);
            }
            return true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (!isChanged)
            {
                this.formFather.openChildForm(new formResultHistory(this.formFather));
                this.Close();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Dữ liệu chưa được lưu. Bạn có muốn lưu dữ liệu trước khi thoát", "Xác nhận", MessageBoxButtons.YesNoCancel);
                if (dialogResult == DialogResult.Cancel) return;
                if (dialogResult == DialogResult.Yes) 
                    Save();
                this.formFather.openChildForm(new formResultHistory(this.formFather));
            }
        }
        void AutoId(DataGridView dataGridView)
        {
            foreach (DataGridViewRow dtr in dataGridView.Rows)
            {
                if (dtr.Index<dataGridView.Rows.Count)
                    dtr.Cells[0].Value = dtr.Index + 1;
            }
        }

        private void tbSTT_TextChanged(object sender, EventArgs e)
        {
            if (tbSTT.Text!="")
            {
                btDelete.Enabled = true;
                btFix.Enabled = true;
                btDelete.BackColor = Color.FromArgb(0, 194, 138);
                btFix.BackColor = Color.FromArgb(0,194,138);
            } else
            {
                btDelete.Enabled = false;
                btFix.Enabled = false;
                btDelete.BackColor = Color.Gray;
                btFix.BackColor = Color.Gray;
            }
        }
        void EditGoalNumber()
        {
            nbTeam1.Text = dgvGoalTeam1.Rows.Count.ToString();
            nbTeam2.Text = dgvGoalTeam2.Rows.Count.ToString();
        }
    }
}
