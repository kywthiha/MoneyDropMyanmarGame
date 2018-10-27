using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data.OleDb;
namespace ManyDrop
{
    class GameDB
    {
        private static OleDbConnection conn;

        public static OleDbConnection Conn
        {
            get { return GameDB.conn; }
            set { GameDB.conn = value; }
        }

        public static void createConnection()
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\\DB\\MoneyDropGrame.accdb;Persist Security Info=True;Jet OLEDB:Database Password=400kyaw";
            conn = new OleDbConnection(connectionString);
        }
       
    }
          
           
}
