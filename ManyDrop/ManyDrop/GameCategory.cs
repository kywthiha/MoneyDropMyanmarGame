using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace ManyDrop
{
    class GameCategory
    {
        private int categoryId;
        private string categoryName;
        public GameCategory() { 
        
        }
        public GameCategory(int id, string name)
        {
            CategoryId = id;
            CategoryName = name;
        }
        public string CategoryName
        {
            get { return categoryName; }
            set { categoryName = value; }
        }


        public int CategoryId
        {
            get { return categoryId; }
            set { categoryId = value; }
        }
        public List<GameCategory> CategoryGetAll()
        {
            List<GameCategory> categoryList = new List<GameCategory>();
            GameDB.createConnection();
            string query = "SELECT * FROM category";
            OleDbCommand cmd ;

            OleDbDataReader res;
            try
            {
                GameDB.Conn.Open();
                cmd = new OleDbCommand(query, GameDB.Conn); 
                Console.WriteLine("Conn OK");
                res = cmd.ExecuteReader();
                while (res.Read())
                {
                    categoryList.Add(new GameCategory(res.GetInt32(0), res.GetString(1)));
                }
                
            }
            finally
            {
                GameDB.Conn.Close();
            }

            return categoryList;
        }
        public void insertCategory(int categoryId,string categoryName)
        {
            GameDB.createConnection();
            try
            {
                GameDB.Conn.Open();
                string query = "INSERT INTO category (ID,name) VALUES (@id,@name)";
              OleDbCommand  cmd = new OleDbCommand(query,GameDB.Conn);
              cmd.Parameters.AddWithValue("@id", categoryId);
              cmd.Parameters.AddWithValue("@name", categoryName);
              cmd.ExecuteNonQuery();
                GameDB.Conn.Close();
             
            }
            finally
            {
                GameDB.Conn.Close();
            }
        }

    }
}
