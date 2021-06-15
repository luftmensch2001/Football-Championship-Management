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

        public formCompetitionSchedule(formMain f)
        {
            InitializeComponent();

            this.formFather = f;
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
