using NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
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
    public partial class formAddTypeOfGoal : Form
    {
        formMain formFather = null;
        List<GoalType> listGoalType = new List<GoalType>();

        public formAddTypeOfGoal(formMain f)
        {
            this.formFather = f;

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formChampionshipTools(this.formFather));
            this.Close();
        }

        private void btnAddGoal_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Thêm loại bàn thắng mới ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;
            try
            {
                string name = tbNameOfGoal.Text;
                while (name != "" && name[0] == ' ')
                    name = name.Remove(0, 1);
                while (name != "" && name[name.Length - 1] == ' ')
                    name = name.Remove(name.Length - 1, 1);
                // chuan hoa ten

                if (name == "")
                {
                    MessageBox.Show("Tên không hợp lệ");
                    return;
                }

                listGoalType = GoalTypeDAO.Instance.GetListGoalType();
                foreach (GoalType goalType in listGoalType)
                {
                    if (name == goalType.Name)
                    {
                        MessageBox.Show("Loại bàn thắng đã tồn tại", "Lỗi");
                        return;
                    }
                }
                GoalTypeDAO.Instance.AddNewGoalType(name);
                MessageBox.Show("Thêm loại bàn thắng thành công", "Thành công");
                this.formFather.openChildForm(new formChampionshipTools(this.formFather));
            }
            catch
            {
                MessageBox.Show("Thêm loại bàn thắng thất bại", "Lỗi");
            }
        }
    }
}
