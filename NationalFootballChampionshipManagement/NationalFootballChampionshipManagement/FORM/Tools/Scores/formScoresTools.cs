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
            score = ScoreDAO.Instance.GetScoreRule();
            nudWinScore.Value = score.THANG;
            nudDrawScore.Value = score.HOA;
            nudLoseScore.Value = score.THUA;

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Check Logic
            if (nudWinScore.Value > nudDrawScore.Value && nudDrawScore.Value > nudLoseScore.Value)
            {
                DialogResult dialogResult = MessageBox.Show("Lưu những thay đổi này ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No) return;
                try
                {
                    ScoreDAO.Instance.UpdateScoreRule((int)nudWinScore.Value, (int)nudDrawScore.Value, (int)nudLoseScore.Value);
                    MessageBox.Show("Cập nhật quy định điểm số thành công", "Thành công");
                }
                catch
                {
                    MessageBox.Show("Có lỗi xảy ra, vui lòng thử lại", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Điểm thắng > Điểm hoà > Điểm thua", "Lỗi");
                return;
            }
        }
    }
}
