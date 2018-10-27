using ManyDrop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyDrop
{
    public partial class GameAdmin : Form
    {
        public GameAdmin()
        {
            InitializeComponent();
        }
        List<GameCategory> categoryList = new List<GameCategory>();
        GameQuestion gq;
        GameCategory gc;
        private void GameAdmin_Load(object sender, EventArgs e)
        {
           
            gq = new GameQuestion();
            gc = new GameCategory();
           // dataGridView1 .DataSource= gq.getTableViewQuestion();
            categoryList = gc.CategoryGetAll();
            txtId.Text =(gq.getQuestionLastId()+1).ToString();
            int i = 0;
            for (i = 1; i < 9; i++) {
                cmboLevel.Items.Add(i);
            }
            foreach (GameCategory tempgc in categoryList) {
                cmboCategory.Items.Add(tempgc.CategoryName);
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                GameQuestion gq = new GameQuestion();
                int questionId = Convert.ToInt32(txtId.Text);
                int level = Convert.ToInt32(cmboLevel.Text);
                string categoryName = cmboCategory.Text;
                var query = from cl in categoryList where cl.CategoryName.Equals(categoryName) select cl.CategoryId;
                int categoryId = 0;
                foreach (int id in query)
                {
                    categoryId = id;
                }
                string question = txtQuestion.Text;
                string correctans = txtCorrectAns.Text;
                string ans1 = txtAns1.Text;
                string ans2 = txtAns2.Text;
                string ans3 = txtAns3.Text;
                int error = gq.insetQuestion(questionId, level, categoryId, question, correctans, ans1, ans2, ans3);
                if (error == 1)
                {
                    MessageBox.Show("Insert Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtId.Text = (gq.getQuestionLastId()+1).ToString();
                cmboLevel.Text = "";
                cmboCategory.Text = "";
                txtQuestion.Text = "";
                txtCorrectAns.Text = "";
                txtAns1.Text = "";
                txtAns2.Text = "";
                txtAns3.Text = "";
                MessageBox.Show("Save Question Successfully", "OK", MessageBoxButtons.OK);
            }
            catch (Exception msgerr) {
                MessageBox.Show(msgerr.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void cmboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GameWin w = new GameWin(240);
            w.Show();
            this.Hide();
        }

      
    }
}
