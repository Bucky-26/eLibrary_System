using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eLibrary_System
{
    public partial class frmStudentList : Form
    {
        FrmAddborrowBook NewMebersInfo;
        public frmStudentList(FrmAddborrowBook newMebersInfo)
        {
            InitializeComponent();
            this.NewMebersInfo = newMebersInfo;
        }
        public void LoadStudent()
        {
            try
            {
                dgviewStudents.Rows.Clear();
                MembersData membersData = new MembersData();
                var members = membersData.LoadMembers(txtBoxQSearch.Text);
                foreach (var member in members)
                {
                    dgviewStudents.Rows.Add(member.LC_Num, member.LRN_Num, member.NAME, member.GRADE_LEVEL, member.Section);
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "PNS eLibrary [ ERROR ]", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgviewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string CoLName = dgviewStudents.Columns[e.ColumnIndex].Name;
            if(CoLName == "select")
            {
                NewMebersInfo.txtstuLcNum.Text = dgviewStudents.Rows[e.RowIndex].Cells[0].Value.ToString();
                NewMebersInfo.txtStuFullName.Text = dgviewStudents.Rows[e.RowIndex].Cells[2].Value.ToString();
                NewMebersInfo.txtGrade.Text = dgviewStudents.Rows[e.RowIndex].Cells[3].Value.ToString();
                NewMebersInfo.txtStuBlock.Text = dgviewStudents.Rows[e.RowIndex].Cells[4].Value.ToString();
                this.Close();


            }
        }
    }
}
