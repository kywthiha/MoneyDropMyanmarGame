using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using MoneyDrop;


namespace ManyDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        List<GameCategory> categoryList = new List<GameCategory>();
        List<GameQuestion> questionList = new List<GameQuestion>();
        GameCategory gameCa1;
        GameCategory gameCa2;
        SoundPlayer openSound=new SoundPlayer();
            SoundPlayer waitsound=new SoundPlayer();
        SoundPlayer click=new SoundPlayer();
        int levelupMoney = 0;
        int originalMoney = 250;
        String correctAnswer = "over 7 billions";
        TableLayoutPanel randomPanel;
        TableLayoutPanel correctPanel;
        TableLayoutPanel zerocorrectPanel;
        TableLayoutPanel largeMoneyPanel;
        List<String> qlist = new List<string>();
        int countTime = 0, tempkey1 = 0, tempkey2 = 0, tempkey3 = 0, tempkey4 = 0;
        int level = 1;
        private bool AddAvailable(Label lb)
        {
            bool ok = true;
            int count = 0;
            int tempnum = Convert.ToInt32(lb.Text);
            int num1 = Convert.ToInt32(lbMoneyShow1.Text);
            int num2 = Convert.ToInt32(lbMoneyShow2.Text);
            int num3 = Convert.ToInt32(lbMoneyShow3.Text);
            int num4 = Convert.ToInt32(lbMoneyShow4.Text);
            List<int> num = new List<int>();
            if (level <= 7)
            {
                if(level<=4)


                num.Add(num1);
                num.Add(num4);
            }
            num.Add(num2);
            num.Add(num3);
            
            foreach (int a in num)
            {
                if (a == 0)
                    count++;
            }
            if (count == 1 && tempnum == 0)
            {
                ok = false;
            }
            return ok;
        }

        private void buttonAddAction(Label lbMoneyShow,Label lblMShow)
        {
            if (originalMoney >= 5 && AddAvailable(lbMoneyShow))
            {
                originalMoney -= 5;
                int tempMoney = Convert.ToInt32(lbMoneyShow.Text) + 5;
                lbMoneyShow.Text = tempMoney.ToString();
                lbOriginalMoneyShow.Text = originalMoney.ToString();
                lblMShow.Text = lbMoneyShow.Text + " သိန်း";

            }
        }
        private void buttonRemoveAction(Label lbMoneyShow,Label lblMShow)
        {
            int tempnum = Convert.ToInt32(lbMoneyShow.Text);
            if (tempnum >= 5)
            {
                originalMoney += 5;
                lbMoneyShow.Text = (tempnum - 5).ToString();
                lbOriginalMoneyShow.Text = originalMoney.ToString();
                lblMShow.Text = lbMoneyShow.Text + " သိန်း";
            }
        }
        private void btnAdd1_Click(object sender, EventArgs e)
        {

            buttonAddAction(lbMoneyShow1, lblMShow1);

        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            buttonAddAction(lbMoneyShow2,lblMShow2);
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            buttonAddAction(lbMoneyShow3, lblMShow3);
          
        }

        private void btnAdd4_Click(object sender, EventArgs e)
        {
            buttonAddAction(lbMoneyShow4, lblMShow4);
          
        }
        
        

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            buttonRemoveAction(lbMoneyShow1, lblMShow1);
          

        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            buttonRemoveAction(lbMoneyShow2, lblMShow2);
        }

        private void btnRemove3_Click(object sender, EventArgs e)
        {
            buttonRemoveAction(lbMoneyShow3, lblMShow3);
        }

        private void btnRemove4_Click(object sender, EventArgs e)
        {
            buttonRemoveAction(lbMoneyShow4, lblMShow4);
        }
        private void falseAction(TableLayoutPanel p,String align,Label lbMoneyShowX,Label lbMoneyShowX0,Label lblMShowXX)
        {
            if(align.Equals("left"))
            p.BackgroundImage = MoneyDrop.Properties.Resources.openboxleft;
            else
            p.BackgroundImage=MoneyDrop.Properties.Resources.openboxright;
            lbMoneyShowX.Visible = false;
            lbMoneyShowX0.Visible = false;
            lblMShowXX.Text = "Money Drop";
            lblMShowXX.BackColor = Color.Red;
            lblMShowXX.ForeColor = Color.Blue;
        }
     
       
        private void trueAction(TableLayoutPanel p, String align, Label lbMoneyShowX, Label lbMoneyShowX0, Label lblMShowXX)
        {
            Random r=new Random();
            if (align.Equals("left"))
                p.BackgroundImage = MoneyDrop.Properties.Resources.closeboxleft;
            else
                p.BackgroundImage = MoneyDrop.Properties.Resources.closeboxright;
            lbMoneyShowX.Visible = true;
            lbMoneyShowX0.Visible = true;
            lblMShowXX.BackColor = Color.Blue;
            lblMShowXX.ForeColor = Color.White;
            int ra=r.Next(qlist.Count);
            lblMShowXX.Text = qlist[ra];
            qlist.RemoveAt(ra);
        }
        private void largeMoney() {
            int num1=0;
            int num4=0;
            if (level <=7)
            {
                if(level<=4)
                num1 = Convert.ToInt32(lbMoneyShow1.Text);
                num4 = Convert.ToInt32(lbMoneyShow4.Text);
            }
            int num2 = Convert.ToInt32(lbMoneyShow2.Text);
            int num3 = Convert.ToInt32(lbMoneyShow3.Text);
           
            List<int> moneyList = new List<int>();
            List<TableLayoutPanel> panelList = new List<TableLayoutPanel>();
            if (level <= 7) {
                if(level<=4)
                moneyList.Add(1);
                panelList.Add(p1);
                moneyList.Add(num4);
                panelList.Add(p4);
            }
            
            moneyList.Add(num2);
            panelList.Add(p2);
            moneyList.Add(num3);
            panelList.Add(p3);

            int maxmoney = moneyList.IndexOf(moneyList.Max());

            if (maxmoney == 0) {
                largeMoneyPanel=panelList[0];
            }
            else if (maxmoney == 1)
            {
                largeMoneyPanel = panelList[1];
            }
            else if (maxmoney == 2)
            {
                largeMoneyPanel = panelList[2];
            }
            else
            {
                largeMoneyPanel = panelList[3];
            }
       
        }
        private void correctBox()
        {
            String ans1 = lblMShow11.Text;
            String ans2 = lblMShow22.Text;
            String ans3 = lblMShow33.Text;
            String ans4 = lblMShow44.Text;

            if (ans1.Equals(correctAnswer))
            {
                correctPanel = p1;
                levelupMoney = Convert.ToInt32(lbMoneyShow1.Text);
            }
            else if (ans2.Equals(correctAnswer))
            {
                correctPanel = p2;
                levelupMoney = Convert.ToInt32(lbMoneyShow2.Text);
            }
            else if (ans3.Equals(correctAnswer))
            {
                correctPanel = p3;
                levelupMoney = Convert.ToInt32(lbMoneyShow3.Text);
            }
            else
            {
                correctPanel = p4;
                levelupMoney = Convert.ToInt32(lbMoneyShow4.Text);
            }
        }
        private TableLayoutPanel randomBox()
        {
            String ans1 = lblMShow11.Text;
            String ans2 = lblMShow22.Text;
            String ans3 = lblMShow33.Text;
            String ans4 = lblMShow44.Text;
            List<TableLayoutPanel> plist = new List<TableLayoutPanel>();
            Random r = new Random();
            if ((!(ans1==correctAnswer)) && level<=4 )
                plist.Add(p1);
            if (!(ans2==correctAnswer))
                plist.Add(p2);
            if (!(ans3==correctAnswer))
                plist.Add(p3);
            if ((!(ans4==correctAnswer)) && level<=7)
                plist.Add(p4);
            return plist[r.Next(plist.Count)];
        }
        private void openboxtime_Tick(object sender, EventArgs e)
        {
            
            openboxtime.Stop();
           
           
        }

        private void buttonOnOff(bool ok) {
            btnAdd1.Enabled = ok;
            btnRemove1.Enabled = ok;
            btnAdd2.Enabled = ok;
            btnRemove2.Enabled = ok;
            btnAdd3.Enabled = ok;
            btnRemove3.Enabled = ok;
            btnAdd4.Enabled = ok;
            btnRemove4.Enabled = ok;
            btnTest.Enabled = ok;
        }
        private void gamePlay()
        {
            oktime.Start();
            randomPanel = randomBox();
            correctBox();
            largeMoney();
            buttonOnOff(false);
        }
        private void nextLevelUp(GameQuestion gQ)
        {
            GameQuestion gqn = new GameQuestion();
         
           
            if (level > 1)
            {
                originalMoney = levelupMoney;
                lbOriginalMoneyShow.Text = originalMoney.ToString();
            }

            if (originalMoney == 0) {
                this.Close();
            }
            if (level == 9) {
                this.Close();
            }
            if (level <= 8)
            {
                lblLevel.Text = "Q" + level;
                levelup.Stop();
                oktime.Stop();
                okcontinuetime.Stop();
                SecondDisplay.Stop();
                buttonOnOff(true);
                lblSecond.Text = "60";
                lblTimeCount.Text = "2:0";
                countTime = 0;
                tempkey1 = 0;
                tempkey2 = 0;
                tempkey3 = 0;
                tempkey4 = 0;
                lblQustion.Text = gQ.Question;
                lblMShow1.Text = "0 သိန်း";
                lblMShow2.Text = "0 သိန်း";
                lblMShow3.Text = "0 သိန်း";
                lblMShow4.Text = "0 သိန်း";
                lbMoneyShow1.Text = "0";
                lbMoneyShow2.Text = "0";
                lbMoneyShow3.Text = "0";
                lbMoneyShow4.Text = "0";
                qlist.Add(gQ.Correctans);
                qlist.Add(gQ.Ans1);
                if (level <= 7)
                {
                   
                    qlist.Add(gQ.Ans2);
                    if (level <= 4)
                    qlist.Add(gQ.Ans3);
                }
                correctAnswer = gQ.Correctans;
                if (level <= 7)
                {
                    if (level <= 4)
                        trueAction(p1, "left", lbMoneyShow1, lbMoneyShow10, lblMShow11);
                    trueAction(p4, "right", lbMoneyShow4, lbMoneyShow40, lblMShow44);
                }
                trueAction(p3, "right", lbMoneyShow3, lbMoneyShow30, lblMShow33);
                trueAction(p2, "left", lbMoneyShow2, lbMoneyShow20, lblMShow22);
               
                levelInitialize();
                gqn.UpdateStatus(gQ.QuestionId);
                var query = from gqupdate in questionList where gqupdate.QuestionId == gQ.QuestionId select gqupdate;
                foreach (GameQuestion qq in query) {
                    qq.Status = true;
                }
                SecondDisplay.Start();
                waitsound.Play();
            }
         
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            gamePlay();
            checkTime.Start();
            lblSecond.Text = "0";
            SecondDisplay.Stop();

            
        }
        private void zerocorrectBox()
        {
            int num1 = Convert.ToInt32(lbMoneyShow1.Text);
            int num2 = Convert.ToInt32(lbMoneyShow2.Text);
            int num3 = Convert.ToInt32(lbMoneyShow3.Text);
            int num4 = Convert.ToInt32(lbMoneyShow4.Text);
            if (correctPanel.Equals(p1) && num1 == 0 && level<=4)
            {
                zerocorrectPanel = p1;
            }
           else if (correctPanel.Equals(p2) && num2 == 0) {
                zerocorrectPanel = p2;
            }
            else if (correctPanel.Equals(p3) && num3 == 0)
            {
                zerocorrectPanel = p3;
            }
            else if (correctPanel.Equals(p4) && num4 == 0 && level<=7) {
                zerocorrectPanel = p4;
            }

        }

        private bool twoDropCheck(TableLayoutPanel p) {
            if (zerocorrectPanel != null)
            {
                if (correctPanel.Equals(p))
                    return true;
                else if (randomPanel.Equals(p))
                    return true;
                else
                    return false;
            }
            else {

                if (correctPanel.Equals(p))
                    return true;
                else if (largeMoneyPanel.Equals(p))
                    return true;
                else
                    return false;

            }
        }
        private int closeBoxCount(){
        List<string> panellist=new List<String>();
        if (level <= 7)
        {
            if(level<=4)
            panellist.Add(lblMShow11.Text);
            panellist.Add(lblMShow44.Text);
        }
            panellist.Add(lblMShow22.Text);
            panellist.Add(lblMShow33.Text);
          
            int count=0;
            foreach(String ss in panellist){
                if (ss == "Money Drop")
                    count++;

            }
            return count;
        }
        private void levelInitialize() {
            if (level <= 4) {
                return;
            }
            if (level <= 7) {
                lblMShow11.Text = "Close Box";
                p1.BackgroundImage = MoneyDrop.Properties.Resources.levelclose;
                lbMoneyShow1.Visible = false;
                lbMoneyShow10.Visible = false;
                btnAdd1.Enabled = false;
                btnRemove1.Enabled = false;
                return;
            }
            if (level == 8)
            {
                lblMShow11.Text = "Close Box";
                p1.BackgroundImage = MoneyDrop.Properties.Resources.levelclose;
                lblMShow44.Text = "Close Box";
                p4.BackgroundImage = MoneyDrop.Properties.Resources.levelclose;
                lbMoneyShow4.Visible = false;
                lbMoneyShow40.Visible = false;
                lbMoneyShow1.Visible = false;
                lbMoneyShow10.Visible = false;
                btnAdd1.Enabled = false;
                btnRemove1.Enabled = false;
                btnAdd4.Enabled = false;
                btnRemove4.Enabled = false;
                return;
            }
        }
        private void levelChangeData()
        {
          try{
                List<GameCategory> tempCategoryList = new List<GameCategory>();

                var query = from ca in categoryList join qe in questionList on ca.CategoryId equals qe.CategoryId where qe.Status==false && qe.Level == level select ca;
                foreach (GameCategory gc in query)
                {
                    if (tempCategoryList.IndexOf(gc) == -1)
                    {
                        tempCategoryList.Add(gc);
                    }
                }

                Random r = new Random();
               
                    int r1 = r.Next(tempCategoryList.Count);
                    gameCa1 = tempCategoryList[r1];
                    lbCa1.Text = gameCa1.CategoryName;

                    categoryList.Remove(gameCa1);
                    tempCategoryList.RemoveAt(r1);
                    //MessageBox.Show(tempCategoryList.Count().ToString());
                    //  MessageBox.Show("Count"+tempCategoryList.Count.ToString());
                
               
                    // MessageBox.Show(tempCategoryList.Count().ToString());
                    int r2 = r.Next(tempCategoryList.Count);
                    gameCa2 = tempCategoryList[r2];
                    lbCa2.Text = gameCa2.CategoryName;

                    categoryList.Remove(gameCa2);

                    tempCategoryList.RemoveAt(r2);
                    // MessageBox.Show("Count"+tempCategoryList.Count().ToString());
                 }
            catch (Exception e)
            {
               DialogResult res= MessageBox.Show("Please Game Data Reset", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
               if (res.Equals(DialogResult.OK))
               {
                   GameQuestion newGQ = new GameQuestion();
                   newGQ.gameReset();
                   Form2 f2 = new Form2();
                   this.Close();
                   f2.Show();
               }
               else
               {
                   MessageBox.Show("Thank You");
                   this.Close();
               }
            }
           
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GameCategory c = new GameCategory();
            GameQuestion q = new GameQuestion();
            categoryList = c.CategoryGetAll();
            questionList = q.GetQuestionInfoAll();
            level = 1;
            levelChangeData();
            levelInitialize();
            pGameBoxPlay.Visible = false;
            pGameChooseCategory.Visible = true;
           openSound= new SoundPlayer();
           waitsound = new SoundPlayer();
           click = new SoundPlayer();
           waitsound.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "//music//waitgame.wav";
            openSound.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "//music//opensound.wav";
            click.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "//music//click.wav";
            
        }

        private void oktime_Tick(object sender, EventArgs e)
        {

            
            buttonOnOff(false);
            

                if (!twoDropCheck(p1) && !(tempkey1==1) && level<=4)
                {
                    falseAction(p1, "left", lbMoneyShow1, lbMoneyShow10, lblMShow11);
                    tempkey1= 1;
                    countTime++;
                    openSound.Play();
                    return;
                }
                if (!twoDropCheck(p2) && !(tempkey2==2))
                {
                    falseAction(p2, "left", lbMoneyShow2, lbMoneyShow20, lblMShow22);
                    tempkey2 = 2;
                    openSound.Play();
                    countTime++;
                    return;
                }
                if (!twoDropCheck(p3) && !(tempkey3==3))
                {
                    falseAction(p3, "right", lbMoneyShow3, lbMoneyShow30, lblMShow33);
                    tempkey3 = 3;
                    openSound.Play();
                    countTime++;
                    return;
                }
                if (!twoDropCheck(p4) && !(tempkey4==4) && level<=7)
                {
                    falseAction(p4, "right", lbMoneyShow4, lbMoneyShow40, lblMShow44);
                    tempkey4 = 4;
                    openSound.Play();
                    countTime++;
                    return;
                 
                }
                if (level <= 4 && closeBoxCount() == 3 && countTime==3)
                {
                    levelup.Start();
                }
                if (level >= 5 && level <= 7 && closeBoxCount() == 2 && countTime == 2)
                {
                    levelup.Start();
                }

                if (level == 8 && closeBoxCount() == 1 && countTime == 1)
                {

                    levelup.Start();
                }
                Console.WriteLine(closeBoxCount());
                if (level <= 4)
                {
                    if (countTime == 2 && closeBoxCount() == 2)
                    {
                        okcontinuetime.Start();
                    }
                }
                if (level >=5 && level <= 7)
                {
                    if (countTime == 1 && closeBoxCount() == 1)
                    {
                        okcontinuetime.Start();
                    }
                }
                if (level == 8)
                {
                    if (countTime == 0 && closeBoxCount() == 0)
                    {
                        okcontinuetime.Start();
                    }
                }
                if (countTime == 1 && level == 8) {
                    oktime.Stop();
                }
             if (countTime == 3 && level<=4)
                oktime.Stop();
             if (countTime == 2 && level >= 5 && level <= 7)
                 oktime.Stop();

        }

        private void btnTryAgain_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        private void TwoCheckCorrectBox(int t, TableLayoutPanel p, Label lbMoneyShowX, Label lbMoneyShowX0, Label lblMShowXX,string align)
        {
            if (t == 0 && !correctPanel.Equals(p))
            {
                falseAction(p, align, lbMoneyShowX, lbMoneyShowX0, lblMShowXX);
                t = 1;
                countTime++;
                openSound.Play();
                if (level <= 4 && closeBoxCount() == 3) {
                    levelup.Start();
                }
                if (level >= 5 && level <= 7 && closeBoxCount() == 2) {
                    levelup.Start();
                }
             
                if ( level==8 && closeBoxCount() == 1 )
                {
                   
                    levelup.Start();
                }
                return;
            }
        }
        private void okcontinuetime_Tick(object sender, EventArgs e)
        {
            if (level <= 7)
            {
                if(level<=4)
                TwoCheckCorrectBox(tempkey1, p1, lbMoneyShow1, lbMoneyShow10, lblMShow11,"left");
                TwoCheckCorrectBox(tempkey4, p4, lbMoneyShow4, lbMoneyShow40, lblMShow44,"right");
            }
            TwoCheckCorrectBox(tempkey2, p2, lbMoneyShow2, lbMoneyShow20, lblMShow22,"left");
            TwoCheckCorrectBox(tempkey3, p3, lbMoneyShow3, lbMoneyShow30, lblMShow33,"right");
           
            if (countTime == 1 && level == 8)
                okcontinuetime.Stop();
             if (countTime == 3 && level<=4)
                okcontinuetime.Stop();
             if (countTime == 2 && level >= 5 && level <= 7)
                 okcontinuetime.Stop();

        }

       

        private void SecondDisplay_Tick(object sender, EventArgs e)
        {
           
            int secInt=Convert.ToInt32(lblSecond.Text)-1;
            Console.WriteLine(secInt+"second"); 
            lblSecond.Text =secInt+"";
            if (secInt == 30) {
                waitsound.Play();
            }
            if (secInt == 0) {
                SecondDisplay.Stop();
                checkTime.Start();
                gamePlay();
            }

        }

        private void levelup_Tick(object sender, EventArgs e)
        {
            countTime = 0;
            levelup.Stop();
            level++;
            originalMoney = levelupMoney;
            
            lblLevel1.Text = "Level " + level;
            lblLevel2.Text = "level " + level;
            lblMoneyHas.Text = originalMoney+"00000";
            if (level == 9) {
                GameWin gw = new GameWin(originalMoney);
                gw.Show();
                this.Hide();
                checkTime.Stop();
                levelup.Stop();
                SecondDisplay.Stop();
                okcontinuetime.Stop();
                oktime.Stop();
                openboxtime.Stop();
                openSound.Stop();
                waitsound.Stop();
                click.Stop();
                return;
            }
            if(originalMoney==0){
                GameOver go = new GameOver();
                
                checkTime.Stop();
                levelup.Stop();
                SecondDisplay.Stop();
                okcontinuetime.Stop();
                oktime.Stop();
                openboxtime.Stop();
                openSound.Stop();
                waitsound.Stop();
                click.Stop();
                go.Show();
                this.Hide();
            }
            levelChangeData();
            pGameChooseCategory.Visible = true;
            pGameBoxPlay.Visible = false;
            
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRemove4_Click_1(object sender, EventArgs e)
        {
            buttonRemoveAction(lbMoneyShow4, lblMShow4);
        }

        private void checkTime_Tick(object sender, EventArgs e)
        {
            String [] numString=lblTimeCount.Text.Split(':');
            int min = Convert.ToInt32(numString[0]);
            int mili = Convert.ToInt32(numString[1]);
            if (mili == 0) {
                mili = 60;
            }
            mili--;
            if (mili == 0) {
                min--;
            }
            if (min == 0) {

                checkTime.Stop();
                
            }
            lblTimeCount.Text = min + ":" + mili;
        }

        private void lbCa2_Click(object sender, EventArgs e)
        {
            click.Play();
            var query = from tempquestion in questionList where tempquestion.CategoryId == gameCa2.CategoryId && tempquestion.Level==level select tempquestion;
            GameQuestion temp = null ;
            foreach(GameQuestion ta in query){
                temp=ta;
            }
            nextLevelUp(temp);
            pGameChooseCategory.Visible = false;
            pGameBoxPlay.Visible = true;
        }

        private void lbCa1_Click(object sender, EventArgs e)
        {
            click.Play();
            var query = from tempquestion in questionList where tempquestion.CategoryId == gameCa1.CategoryId && tempquestion.Level==level select tempquestion;
            GameQuestion temp = null;
            foreach (GameQuestion ta in query)
            {
                temp = ta;
            }
            nextLevelUp(temp);
            pGameChooseCategory.Visible = false;
            pGameBoxPlay.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            checkTime.Stop();
            levelup.Stop();
            SecondDisplay.Stop();
            okcontinuetime.Stop();
            oktime.Stop();
            openboxtime.Stop();
            openSound.Stop();
            waitsound.Stop();
            click.Stop();
        }

        

        

        
      

       

        
       

        

      

       
    }
}
