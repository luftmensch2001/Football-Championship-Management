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
    public partial class formTeam : Form
    {
        formMain formFather = null;

        public formTeam(formMain f)
        {
            InitializeComponent();

            this.formFather = f;

            addInformationColumn();
        }

        private void addInformationColumn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Thông tin chi tiết";
            btn.Name = "btnInformation";
            btn.Text = "Thông tin chi tiết";
            btn.UseColumnTextForButtonValue = true;
            this.dgvPlayerList.Columns.Add(btn);
        }

        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            // Lúc này mở thêm 1 cột checkbox ở cột cuối cùng của Datagridview, rồi click chọn cầu thủ được add.
            // Đồng thời đổi chữ Lưu thành chữ "Thêm"
            // Lưu ý: các cầu thủ đã có clb rồi cần hỏi lại một lần nữa có chắc chắc là thêm vào đội này hay không, nếu thêm nhớ xóa cầu thủ đó khỏi clb cũ
            // 

            this.formFather.openChildForm(new formPlayerList(this.formFather));
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formAddNewTeam(this.formFather));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Mở form thêm đội bóng mới lên và đôi button "Thêm" thành button "Lưu", 
            // và đổi tiêu đề thành "THay đổi thông tin đội bóng"

            this.formFather.openChildForm(new formAddNewTeam(this.formFather));
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome());
        }
    }
}
