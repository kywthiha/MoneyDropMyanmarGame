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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        List<GameCategory> categoryList = new List<GameCategory>();
        List<GameQuestion> questionList = new List<GameQuestion>();
        GameQuestion gq;
        GameCategory gc;
        private void reLoad()
        {
            cmboLevel.Items.Clear();
            cmboCategory.Items.Clear();
            cmboID.Items.Clear();
            gq = new GameQuestion();
            gc = new GameCategory();
            questionTableView.DataSource = gq.getTableViewQuestion();
            categoryList = gc.CategoryGetAll();
            questionList = gq.GetQuestionInfoAll();
            txtId.Text = (gq.getQuestionLastId() + 1).ToString();
            int ii = gq.getQuestionLastId();
            Console.WriteLine(ii);
            txtCategoryId.Text = (categoryList[categoryList.Count - 1].CategoryId + 1).ToString();
            int i = 0;
           
            for (i = 1; i < 9; i++)
            {
                cmboLevel.Items.Add(i);
            }
            foreach (GameCategory tempgc in categoryList)
            {
                cmboCategory.Items.Add(tempgc.CategoryName);

            }
            List<int> idList=gq.getQuestionId();
            foreach (int a in idList)
            {
                cmboID.Items.Add(a);

            }
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'moneyDropGrameDataSet.question' table. You can move, or remove it, as needed.
            reLoad();
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
                int error;
                if (level > 0)
                {
                    if(categoryName!=null && !categoryName.Trim().Equals("")){
                        if (!question.Trim().Equals(""))
                        {
                            List<String> tempAns = new List<string>();
                            
                            if (((level <= 4 && !ans3.Trim().Equals("") && !ans2.Trim().Equals("")) || (level <=7 && !ans2.Trim().Equals("")) && !correctans.Trim().Equals("") || level==8) && !ans1.Trim().Equals(""))
                            {
                                tempAns.Add(correctans);
                                tempAns.Add(ans1);
                                if (!ans3.Trim().Equals(""))
                                {
                                    tempAns.Add(ans3);
                                }
                                if (!ans2.Trim().Equals(""))
                                {
                                    tempAns.Add(ans2);
                                }
                                for (int i = 0; i < tempAns.Count ;i++ )
                                {
                                    for (int j = i+1; j < tempAns.Count ; j++) { 
                                    if(tempAns[i].Equals(tempAns[j])){
                                        MessageBox.Show("Please enter different answers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                    }
                                }
                                error = gq.insetQuestion(questionId, level, categoryId, question, correctans, ans1, ans2, ans3);
                            }
                            else
                            {
                                MessageBox.Show("Please enter complete "+(level<=4?4:level<=7?3:2)+" answer", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        else {
                            MessageBox.Show("Please enter question", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                    }
                    else{
                     MessageBox.Show("Please select category name","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        return;
                    }
                }
                else {
                    MessageBox.Show("Please select level","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }
                if (error == 1)
                {
                    MessageBox.Show("Insert Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                txtId.Text = (gq.getQuestionLastId() + 1).ToString();
                cmboLevel.Text = "";
                cmboCategory.Text = "";
                txtQuestion.Text = "";
                txtCorrectAns.Text = "";
                txtAns1.Text = "";
                txtAns2.Text = "";
                txtAns3.Text = "";
                MessageBox.Show("Save Question Successfully", "OK", MessageBoxButtons.OK);
                reLoad();
            }
            catch (Exception msgerr)
            {
                MessageBox.Show(msgerr.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtId.Text = (gq.getQuestionLastId() + 1).ToString();
            cmboLevel.Text = "";
            cmboCategory.Text = "";
            txtQuestion.Text = "";
            txtCorrectAns.Text = "";
            txtAns1.Text = "";
            txtAns2.Text = "";
            txtAns3.Text = "";
        }

        private void insertQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PInsertQuestion.Visible = true;
            PInsertCategory.Visible = false;
            pData.Visible = false;
        }

        private void insertCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PInsertQuestion.Visible = false;
            PInsertCategory.Visible = true;
            pData.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!txtCategoryName.Text.Trim().Equals(""))
            {
                try
                {
                    GameCategory gc = new GameCategory();
                    int catId = Convert.ToInt32(txtCategoryId.Text);
                    string catName = txtCategoryName.Text;
                    gc.insertCategory(catId, catName);
                    txtCategoryName.Text = "";
                    reLoad();
                    MessageBox.Show("Insert Successful", "OK Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception numerr)
                {
                    MessageBox.Show(numerr.ToString() + "\nSave Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter cmplete fill form", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCategoryName.Text = "";
            gc = new GameCategory();
            reLoad();
        }

      
        private void button5_Click(object sender, EventArgs e)
        {
            if (cmboID.Text.Trim() != "" ) {
                
                int id = 0;
                try
                {
                    id = Convert.ToInt32(cmboID.Text);
                    if (!cmboID.Items.Contains(id))
                    {
                        MessageBox.Show("No ID", "Error ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception err) {
                    MessageBox.Show("Please Number fill"+err,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                if (gq.deleteQuestion(id) == 0)
                {
                    MessageBox.Show("Delete Success", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cmboID.Text = "";
                    reLoad();
                }
                else {
                    MessageBox.Show("Delete Error","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PInsertQuestion.Visible = false;
            PInsertCategory.Visible = false;
            questionTableView.Visible = true;
            pData.Visible = true;
            pData.Visible = true;
           

        }

        private void cmboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            int l=Convert.ToInt32(cmboLevel.Text) ;
            if (l<= 4) {
                txtCorrectAns.Enabled = true;
                txtAns1.Enabled = true;
                txtAns2.Enabled = true;
                txtAns3.Enabled = true;
                return;
            }
            if (l <= 7)
            {
                txtCorrectAns.Enabled = true;
                txtAns1.Enabled = true;
                txtAns2.Enabled = true;
                txtAns3.Enabled = false;
                return;
            }
            if (l <= 8)
            {
                txtCorrectAns.Enabled = true;
                txtAns1.Enabled = true;
                txtAns2.Enabled = false;
                txtAns3.Enabled = false;
                return;
            }
        }

       

    }
}
