﻿using NationalFootballChampionshipManagement.DAO;
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
    public partial class formAddNewTeam : Form
    {
        formMain formFather = null;

        Team team;

        public formAddNewTeam(formMain f)
        {
            this.formFather = f;

            InitializeComponent();
        }

        public formAddNewTeam(formMain f, Team team)
        {
            this.formFather = f;
            this.team = team;
            InitializeComponent();
            btnAdd.Text = "Lưu";
            lTitle.Text = "SỬA THÔNG TIN ĐỘI BÓNG";
            tbTeamName.Text = team.TeamName;
            tbCoachName.Text = team.CoachName;
            tbHost.Text = team.HostName;
            pbTeamImage.Image = team.Image;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formTeam(this.formFather));
        }

        bool isSpace(string str)
        {
            while (str != "" && str[0] == ' ')
                str = str.Remove(0, 1);
            while (str != "" && str[str.Length - 1] == ' ')
                str = str.Remove(str.Length - 1, 1);
            return (str == "");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isSpace(tbTeamName.Text) || isSpace(tbCoachName.Text) || isSpace(tbHost.Text))
            {
                MessageBox.Show("Thông tin không được là khoảng trắng", "Lỗi");
                return;
            }
            if (pbTeamImage.Image == null)
            {
                MessageBox.Show("Vui lòng thêm hình ảnh", "Lỗi");
                return;
            }

            if (btnAdd.Text == "Thêm")
                try
                {
                    TeamDAO.Instance.AddTeam(tbTeamName.Text, tbCoachName.Text, tbHost.Text, pbTeamImage.Image);
                    MessageBox.Show("Thêm đội bóng thành công!", "Thành công");
                    this.formFather.openChildForm(new formTeam(this.formFather));
                }
                catch
                {
                    MessageBox.Show("Thêm đội bóng thất bại!", "Lỗi");
                }
            else 
                try
                {
                    TeamDAO.Instance.ChangeInforByIDDB(tbTeamName.Text, tbCoachName.Text, tbHost.Text, team.ID, pbTeamImage.Image);
                    MessageBox.Show("Sửa thông tin thành công!", "Thành công");
                    this.formFather.openChildForm(new formTeam(this.formFather));
                }
                catch
                {
                    MessageBox.Show("Sửa thông tin thất bại!", "Lỗi");
                }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "Image files(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png", Multiselect = false };
            openFileDialog.ShowDialog();
            string path = openFileDialog.FileName;
            if (path != "")
                try
                {
                    pbTeamImage.Image = Image.FromFile(path);
                }
                catch
                {
                    MessageBox.Show("File không hợp lệ, vui lòng chọn lại", "Lỗi");
                }
        }
    }
}
