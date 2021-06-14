using NationalFootballChampionshipManagement.DAO;
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
    public partial class formAddTypeOfPlayer : Form
    {
        formMain formFather = null;

        public formAddTypeOfPlayer(formMain f)
        {
            this.formFather = f;

            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formChampionshipTools(this.formFather));

            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tbName.Text;
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

                PlayerTypeDAO.Instance.AddNewType(name, (int) nudNumber.Value, LeagueDAO.Instance.GetCurrIDMG());
                MessageBox.Show("Thêm loại cầu thủ thành công", "Thành công");
            }
            catch
            {
                MessageBox.Show("Thêm loại cầu thủ thất bại", "Lỗi");
            } 
            
            
        }
    }
}
