using System;
using NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DAO.NationalFootballChampionshipManagement.DAO;
using NationalFootballChampionshipManagement.DTO;
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
    public partial class formResultHistory : Form
    {
        List<ResultMatch> listResultMatch;// = new List<ResultMatch>();
        List<Team> listNameTeam;// = new List<string>();

        formMain formFather = null;

        List<bool> listCheckedRound = new List<bool>();
        List<bool> listCheckedTeam = new List<bool>();

        List<int> tt = new List<int>();
        public formResultHistory(formMain f)
        {
            InitializeComponent();

            this.formFather = f;
            addInformationColumn();



            listResultMatch = ResultMatchDAO.Instance.LoadResultMatch();

            listNameTeam = TeamDAO.Instance.GetNameAndIdTeam();


            GetListTeamName();
            LoadRound();
            LoadListResultMatch();
        }
        public void GetListTeamName()
        {
            checkedListBox2.Items.Clear();
            foreach (Team team in listNameTeam)
            {
                checkedListBox2.Items.Add(team.TeamName);
                listCheckedTeam.Add(false);
                checkedListBox2.SetItemChecked(checkedListBox2.Items.Count - 1, true);
            }
        }
        private void CheckedBox1_Check(object sender, ItemCheckEventArgs e)
        {
            listCheckedRound[e.Index] = !listCheckedRound[e.Index];
            LoadListResultMatch();
        }
        private void checkedListBox2_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            listCheckedTeam[e.Index] = !listCheckedTeam[e.Index];
            LoadListResultMatch();
        }
        private void dgvResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5 && e.RowIndex<dgvResult.Rows.Count)
            {
                if (dgvResult.Rows.Count == 0 || e.RowIndex==-1) return;
                int index = (int)dgvResult.Rows[e.RowIndex].Cells[0].Value - 1;
                this.formFather.openChildForm(new formDetailsResult(this.formFather,
                    listResultMatch[tt[index]].IdTranDau,listResultMatch[tt[index]].VongDau, listResultMatch[tt[index]].IdDoi1, listResultMatch[tt[index]].IdDoi2, listResultMatch[tt[index]].San, listResultMatch[tt[index]].KQDoi1, listResultMatch[tt[index]].KQDoi2, listResultMatch[tt[index]].ThoiGian));
            }
        }

        public void LoadListResultMatch()
        {
            int i = 1, j = 0 ;
            dgvResult.Rows.Clear();
            tt.Clear();
            foreach (ResultMatch item in listResultMatch)
            {
                string tiSo = "";
                if (item.KQDoi1 < 0 || item.KQDoi2 < 0)
                    tiSo = "-:-";
                else
                    tiSo = item.KQDoi1.ToString() + ":" + item.KQDoi2.ToString();
                if (IsInListCheckedBoxRound(item.VongDau.ToString()) && (IsInListCheckedBoxTeam(item.TenDoi1.ToString())||IsInListCheckedBoxTeam(item.TenDoi2.ToString())))
                {
                    tt.Add(j);
                    dgvResult.Rows.Add(i, item.VongDau, item.TenDoi1, tiSo, item.TenDoi2);
                    i++;
                }
                j++;
            }
            foreach (DataGridViewRow row in dgvResult.Rows)
            {
                if (row.Cells[3].Value!=null)
                if (row.Cells[3].Value.ToString()[0] =='-')
                    row.DefaultCellStyle.BackColor = Color.LightGray;
                else
                    row.DefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
        public bool IsInListCheckedBoxRound(string s)
        {
            //return true;
            for (int i = 0; i < listCheckedRound.Count; i++)
            {
                if (listCheckedRound[i] && "Vòng " + s == checkedListBox1.Items[i].ToString())
                    return true;
            }
            return false;
        }
        public bool IsInListCheckedBoxTeam(string s)
        {
            //return true;
            for (int i = 0; i < listCheckedTeam.Count; i++)
            {
                if (listCheckedTeam[i] && s == checkedListBox2.Items[i].ToString())
                    return true;
            }
            return false;
        }
        public void LoadRound()
        {
            int soVongDau = TeamDAO.Instance.GetCountTeam();
            if (soVongDau % 2 == 0)
                soVongDau = (soVongDau -1) * 2;
            else
                soVongDau = soVongDau * 2;
            for (int i = 1; i <= soVongDau; i++)
            {
                checkedListBox1.Items.Add("Vòng " + i.ToString());
                listCheckedRound.Add(false);
                checkedListBox1.SetItemChecked(i - 1, true);
            }
        }
        private void addInformationColumn()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Thông tin chi tiết";
            btn.Name = "btnInformation";
            btn.Text = "Thông tin chi tiết";
            btn.UseColumnTextForButtonValue = true;
            this.dgvResult.Columns.Add(btn);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.formFather.openChildForm(new formHome(this.formFather));
        }
    }
}
