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
    public partial class formScoresTools : Form
    {
        formMain formFather = null;
        Score score;
        public formScoresTools(formMain f)
        {
            InitializeComponent();
            this.formFather = f;
            LoadScoreRule();
        }
        void LoadScoreRule()
        {
            try
            {
                score = ScoreDAO.Instance.GetScoreRule();
                nudWinScore.Value = score.THANG;
                nudDrawScore.Value = score.HOA;
                nudLoseScore.Value = score.THUA;
            }
            catch
            {
                MessageBox.Show("Lỗi khi tải dữ liệu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Check Logic
            if (nudWinScore.Value > nudDrawScore.Value && nudDrawScore.Value > nudLoseScore.Value)
            {
                DialogResult dialogResult = MessageBox.Show("Lưu những thay đổi này ?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.No) return;
                try
                {
                    ScoreDAO.Instance.UpdateScoreRule((int)nudWinScore.Value, (int)nudDrawScore.Value, (int)nudLoseScore.Value);
                    MessageBox.Show("Cập nhật quy định điểm số thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Điểm thắng > Điểm hoà > Điểm thua", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
