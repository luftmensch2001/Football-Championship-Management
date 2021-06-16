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
    public partial class formCompetitionSchedule : Form
    {
        formMain formFather = null;

        List<int> listIDTranDau = new List<int>();
        public formCompetitionSchedule(formMain f)
        {
            InitializeComponent();

            this.formFather = f;

            LoadRadioButton();

            LoadDgv(MatchDAO.Instance.GetAllMatches());
        }

        void LoadRadioButton()
        {
            RadioButton radio = new RadioButton();
            RadioButton lastButton = radio;
            radio.Text = "Tất cả";
            radio.Tag = null;
            radio.Checked = true;
            flpRound.Controls.Add(radio);
            int roundCount = MatchDAO.Instance.GetRoundCount();
            for (int i=1; i<=roundCount; i++)
            {
                radio = new RadioButton();
                radio.Text = "Vòng " + i.ToString();
                radio.Top = lastButton.Location.Y + 30;
                radio.Height = 30;
                lastButton = radio;
                flpRound.Controls.Add(radio);
            }
        }

        void LoadDgv(DataTable data)
        {
            dgvSchedule.ReadOnly = true;
            dgvSchedule.DataSource = data;
            dgvSchedule.RowTemplate.Height = 30;
            // Luu lai danh sach ID Tran dau 
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
                ScheduleDAO.Instance.GenerateNewSchedule();
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
                // xoa tat ca tran dau va cac bang co khoa lien quan, hien tai t moi chi xoa bang tran dau
                ScheduleDAO.Instance.CancelSchedule();     
                MessageBox.Show("Huỷ lịch thi đấu thành công", "Thành công");
            }
            catch
            {
                MessageBox.Show("Huỷ thi đấu thất bại", "Lỗi");
            }
        }
    }
}
