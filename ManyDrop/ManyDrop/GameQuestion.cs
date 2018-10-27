using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace ManyDrop
{
    class GameQuestion
    {
        private int questionId;
        private bool status;
        private string question;
        private string correctans;
        private string ans1;
        private string ans2;
        private string ans3;
        private int level;
        private int categoryId;
        public GameQuestion()
        {
        }
        public bool Status
        {
            get { return status; }
            set { status = value; }
        }



        public int QuestionId
        {
            get { return questionId; }
            set { questionId = value; }
        }
        public GameQuestion(int id,int l, int catId, string q, string cans, string ans1, string ans2, string ans3,bool status)
        {
            questionId = id;
            Level = l;
            CategoryId = catId;
            Question = q;
            Correctans = cans;
            Ans1 = ans1;
            Ans2 = ans2;
            Ans3 = ans3;
            Status = status;

        }
        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        public string Ans3
        {
            get { return ans3; }
            set { ans3 = value; }
        }
        public string Ans2
        {
            get { return ans2; }
            set { ans2 = value; }
        }
        public string Ans1
        {
            get { return ans1; }
            set { ans1 = value; }
        }
        public string Correctans
        {
            get { return correctans; }
            set { correctans = value; }
        }

        public string Question
        {
            get { return question; }
            set { question = value; }
        }
        public List<GameQuestion> GetQuestionInfoAll() {
            List<GameQuestion> questionList = new List<GameQuestion>();
            string query = "SELECT * FROM question WHERE status=0";
            GameDB.createConnection();
            
            OleDbDataReader res;
            try {
                GameDB.Conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, GameDB.Conn);
                Console.WriteLine("Conn OK");
                res = cmd.ExecuteReader();
                while (res.Read()) { 
                questionList.Add(new GameQuestion(res.GetInt32(0),res.GetInt32(1),res.GetInt32(2),res.GetString(3),res.GetString(4),res.GetString(5),res.GetString(6),res.GetString(7),res.GetBoolean(8)));
                }
            }
            finally {
                GameDB.Conn.Close();
            }
            return questionList;
        }
        public int insetQuestion(int id,int level,int categoryId,string question,string correctans,string ans1,string ans2,string ans3)
        {
            int error = 0;
            try
            {
                GameDB.createConnection();
                GameDB.Conn.Open();
                string query = "INSERT INTO question (ID, [level], category_id, question, correctanswer, answer1, answer2, answer3) VALUES (@id,@level,@categoryId,@question,@correctans,@ans1,@ans2,@ans3)";

                OleDbCommand cmd = new OleDbCommand(query, GameDB.Conn);
                cmd.Parameters.AddWithValue("@id",id);
                cmd.Parameters.AddWithValue("@level", level);
                cmd.Parameters.AddWithValue("@categoryId", categoryId);
                cmd.Parameters.AddWithValue("@question",question);
                cmd.Parameters.AddWithValue("@correctans", correctans);
                cmd.Parameters.AddWithValue("@ans1", ans1);
                cmd.Parameters.AddWithValue("@ans2", ans2);
                cmd.Parameters.AddWithValue("@ans3", ans3);
                cmd.ExecuteNonQuery();
                GameDB.Conn.Close();
                error = 0;
            }
            catch(OleDbException msgex){
                Console.WriteLine(msgex);
                GameDB.Conn.Close();
                error = 1;
            }
            return error;
        }
        public int getQuestionLastId()
        {
            int lastId = 0;
            
            try
            {
                GameDB.createConnection();
                GameDB.Conn.Open();
                string query = "SELECT ID FROM question ORDER BY ID ASC";
                OleDbCommand cmd = new OleDbCommand(query,GameDB.Conn);
                OleDbDataReader res = cmd.ExecuteReader();
               
                while (res.Read()) {
                    lastId = res.GetInt32(0);
                   // Console.WriteLine(lastId);
                }
                GameDB.Conn.Close();
            }
            catch (OleDbException msgerr) {
                Console.WriteLine(msgerr);
                GameDB.Conn.Close();
            }
         //   Console.WriteLine(lastId);
            return lastId;

        }
        public int deleteQuestion(int id){
            int error = 0;
            try
            {
                GameDB.createConnection();
                GameDB.Conn.Open();
                string query = "DELETE FROM question WHERE ID=@id";
                OleDbCommand cmd = new OleDbCommand(query, GameDB.Conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                GameDB.Conn.Close();
                error = 0;
            }
            catch (OleDbException msgerr) {
                error = 1;
                GameDB.Conn.Close();
                Console.WriteLine(msgerr);
            }
            return error;
        }
        public List<int> getQuestionId()
        {
            List<int> idList = new List<int>();

            try
            {
                GameDB.createConnection();
                GameDB.Conn.Open();
                string query = "SELECT ID FROM question ORDER BY ID ASC";
                OleDbCommand cmd = new OleDbCommand(query, GameDB.Conn);
                OleDbDataReader res = cmd.ExecuteReader();

                while (res.Read())
                {
                   idList.Add (res.GetInt32(0));
                }
                GameDB.Conn.Close();
            }
            catch (OleDbException msgerr)
            {
                Console.WriteLine(msgerr);
                GameDB.Conn.Close();
            }
            return idList;

        }
        public void gameReset() {
            GameDB.createConnection();
            GameDB.Conn.Open();
            string query = "UPDATE question SET status=0";
            OleDbCommand cmd = new OleDbCommand(query, GameDB.Conn);
            cmd.ExecuteNonQuery();
        }
        public void UpdateStatus(int id)
        {
            
                GameDB.createConnection();
                GameDB.Conn.Open();
                string query = "UPDATE question SET status=1 WHERE ID=@id";
                OleDbCommand cmd = new OleDbCommand(query, GameDB.Conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
        }
        public DataTable getTableViewQuestion() {
            OleDbCommand cmd;
            DataTable dt = new DataTable();
            try
            {
                GameDB.createConnection();
                GameDB.Conn.Open();
                cmd = new OleDbCommand("SELECT question.ID,category.name,question.level,question.question,question.correctanswer,question.answer1,question.answer2,question.answer3 FROM question,category WHERE category.ID=question.category_id ORDER BY question.ID ASC", GameDB.Conn);
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
                GameDB.Conn.Close();
            }
            catch (OleDbException msgerr){
                Console.WriteLine(msgerr);
                GameDB.Conn.Close();
            }
            return dt;
        }
    }
}
