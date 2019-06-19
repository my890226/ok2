using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20190507datagird
{
    /*
     * c언어 ms-sql
     * java - oracle - my-sql
     * php mysql
     * alt + shift + enter
     */

    public partial class Form1 : Form
    {
        private int select_idx = 0;
        DBManager dbm = new DBManager();

        public Form1()
        {
            InitializeComponent();
            //this.IsMdiContainer = true;
        }

        public void doView()
        {
            DataSet ds = dbm.doSelect();
            myTable.DataSource = ds.Tables[0].DefaultView;
        }
        /// <summary>
        /// 조회버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            DataSet ds = dbm.doSelect();
            myTable.DataSource = ds.Tables[0].DefaultView;
        }
        /// <summary>
        /// 등록
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;
            if (male_radio.Checked)
                gender = "남자";
            else
                gender = "여자";

            bool result = dbm.doInsert(name_txt.Text, pw_text.Text, gender, remark_text.Text, age_text.Value.ToString() );
            if(result == true)
                MessageBox.Show("등록 성공하였습니다.");
            doView();
        }
        /// <summary>
        /// 수정버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            string gender = string.Empty;
            if (male_radio.Checked)
                gender = "남자";
            else
                gender = "여자";
            if (select_idx != 0)
            {
                dbm.doupdate(select_idx , name_txt.Text, pw_text.Text, gender, remark_text.Text, age_text.Value.ToString());
                MessageBox.Show("update 완료");
                select_idx = 0;
            }
            else
            {
                MessageBox.Show("행을 더블클릭하셔야 선택이 됩니다.");
            }
            doView();
        }

        /// <summary>
        /// 삭제 student
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteStudent_Click(object sender, EventArgs e)
        {
            if (select_idx != 0)
            {
                dbm.dodelete(select_idx);
                MessageBox.Show("delete 완료");
                select_idx = 0;
            }
            else
            {
                MessageBox.Show("행을 더블클릭하셔야 선택이 됩니다.");
            }
            doView();
        }

        private void myTable_CellDbClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show("더블클릭했네" + myTable.Rows[e.RowIndex].Cells[0]);
            //MessageBox.Show("idx = " + myTable.Rows[e.RowIndex].Cells[0].Value);
            myTable.RowsDefaultCellStyle.SelectionBackColor = Color.Green;

            select_idx = int.Parse(myTable.Rows[e.RowIndex].Cells[0].Value.ToString());

            name_txt.Text = myTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            pw_text.Text = myTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            String gender = myTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (gender.Equals("남자"))
                male_radio.Checked = true;
            else
                female_radio.Checked = true;
            remark_text.Text = myTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            //age_text.Value = decimal.Parse(myTable.Rows[e.RowIndex].Cells[4].Value.ToString());
        }
    }
}
