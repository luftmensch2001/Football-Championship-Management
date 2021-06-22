<<<<<<< Updated upstream
﻿using System;
=======
﻿using NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
using System;
>>>>>>> Stashed changes
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

        List<PlayerType> listPlayerType = new List<PlayerType>();
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
<<<<<<< Updated upstream
=======

        private void btnAddPlayerType_Click(object sender, EventArgs e)
        {
            //Check Logic

            if (nudMaxNumber.Value < 1)
            {
                MessageBox.Show("Số lượng tối đa phải lớn hơn 0", "Lỗi");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Thêm loại cầu thủ mới ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No) return;
            try
            {
                string name = tbNameOfPlayerType.Text;
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
                listPlayerType = PlayerTypeDAO.Instance.GetPlayerTypes();
                foreach (PlayerType playerType in listPlayerType)
                {
                    if (name == playerType.TypeName)
                    {
                        MessageBox.Show("Loại cầu thủ đã tồn tại", "Thất bại");
                        return;
                    }
                }
                PlayerTypeDAO.Instance.AddNewType(name, (int)nudMaxNumber.Value, LeagueDAO.Instance.GetCurrIDMG());
                MessageBox.Show("Thêm loại cầu thủ thành công", "Thành công");
            }
            catch
            {
                MessageBox.Show("Thêm loại cầu thủ thất bại", "Lỗi");
            }
        }
>>>>>>> Stashed changes
    }
}
