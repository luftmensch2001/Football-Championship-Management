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
    public partial class formCompetitionSchedule : Form
    {
        formMain formFather = null;

        List<int> listIDTranDau = new List<int>();

        int selectedRow = -1;
        public formCompetitionSchedule(formMain f)
        {
            InitializeComponent();

            this.formFather = f;

            LoadRadioButton();

            LoadDgv(MatchDAO.Instance.GetAllMatches());

            dgvSchedule.CellClick +=
                new DataGridViewCellEventHandler(dgvSchedule_CellClick);
        }

        void dgvSchedule_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedRow = e.RowIndex;
        }

        void LoadRadioButton()
        {
            flpRound.Controls.Clear();
            RadioButton radio;
            RadioButton lastButton = null;

            int roundCount = MatchDAO.Instance.GetRoundCount();
            if (roundCount > 0)
            {
                btnAutoCreate.Enabled = false;
                
            }
            else
            {
                btnCancelSchedule.Enabled = false;
            }
            for (int i=0; i<=roundCount; i++)
            {
                radio = new RadioButton();
                if (lastButton == null)
                {
                    radio.Text = "Tất cả";
                    radio.Checked = true;
                }
                else
                {
                    radio.Text = "Vòng " + i.ToString();
                    radio.Top = lastButton.Location.Y + 30; 
                }
                radio.Height = 30;
                radio.Tag = new int();
                radio.Tag = i;
                radio.CheckedChanged += new EventHandler(radioButtons_CheckedChanged);
                lastButton = radio;
                flpRound.Controls.Add(radio);
            }
        }

        private void radioButtons_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radio = sender as RadioButton;

            if (radio.Checked == true)
            {
                if ((int)radio.Tag == 0)
                    LoadDgv(MatchDAO.Instance.GetAllMatches());
                else
                    LoadDgv(MatchDAO.Instance.GetMatchesByVongDau((int)radio.Tag));

                lbRound.Text = (int)radio.Tag == 0 ? "Tất cả" : radio.Tag.ToString();
            }
            
        }

        void LoadDgv(DataTable data)
        {
            dgvSchedule.ReadOnly = true;
            dgvSchedule.DataSource = data;
            dgvSchedule.RowTemplate.Height = 30;
            dgvSchedule.AllowUserToResizeRows = false;
            // Luu lai danh sach ID Tran dau de chinh sua
            listIDTranDau.Clear();

            for (int i = 0; i < dgvSchedule.Rows.Count - 1; i++)
            {
                listIDTranDau.Add(Int32.Parse(dgvSchedule.Rows[i].Cells[0].Value.ToString()));
                dgvSchedule.Rows[i].Cells[0].Value = i + 1;
                   
                // Chuyen tu ID team -> ten 
                int IDteam = Int32.Parse(dgvSchedule.Rows[i].Cells[2].Value.ToString());
                dgvSchedule.Rows[i].Cells[4].Value = TeamDAO.Instance.GetTeamNameByID(IDteam);
                IDteam = Int32.Parse(dgvSchedule.Rows[i].Cells[3].Value.ToString());              
                dgvSchedule.Rows[i].Cells[5].Value = TeamDAO.Instance.GetTeamNameByID(IDteam);
            }

            dgvSchedule.Columns[2].Visible = false;
            dgvSchedule.Columns[3].Visible = false;
        }


        private void btnAddNewCompetiton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sau khi tạo lịch thi đấu, sẽ không thể thay đổi danh sách đăng ký và quy định giải đấu. Bạn có chắc không ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            dialogResult = MessageBox.Show("Các đội bóng không đạt số cầu thủ tối thiểu sẽ không được tham gia. Tiếp tục ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;
            
            try
            {
                if (ScheduleDAO.Instance.GenerateNewSchedule() == 0) return;
                LoadDgv(MatchDAO.Instance.GetAllMatches());
                LoadRadioButton();
                btnCancelSchedule.Enabled = true;
                LeagueDAO.Instance.UpdateStatus(1);
                this.formFather.LoadStatus();
                MessageBox.Show("Tạo lịch thi đấu thành công. Hãy tuỳ chỉnh thời gian cho các trận đấu!", "Thành công");
            } 
            catch
            {
                MessageBox.Show("Tạo lịch thi đấu thất bại", "Lỗi");
            }
                

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }

        private void btnCancelSchedule_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Dữ liệu về các trận đấu sẽ bị xoá hết. Bạn có chắc không ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;

            try
            {
                // xoa tat ca tran dau va cac bang co khoa lien quan
                ResultMatchDAO.Instance.DeleteAllResultMatch(listIDTranDau);
                ScheduleDAO.Instance.CancelSchedule();
    
                LoadDgv(MatchDAO.Instance.GetAllMatches());
                LoadRadioButton();
                btnAutoCreate.Enabled = true;
                LeagueDAO.Instance.UpdateStatus(0);
                this.formFather.LoadStatus();
                MessageBox.Show("Huỷ lịch thi đấu thành công", "Thành công");
            }
            catch
            {
                MessageBox.Show("Huỷ lịch thi đấu thất bại", "Lỗi");
            }
        }

        private void btnChangeTime_Click(object sender, EventArgs e)
        {
            if (selectedRow < 0 || selectedRow >= dgvSchedule.Rows.Count-1)
            {
                MessageBox.Show("Vui lòng chọn trận đấu");
                return;
            }
            this.formFather.openChildForm(new formChangeTime(this.formFather, listIDTranDau[selectedRow]));
        }
    }
}
