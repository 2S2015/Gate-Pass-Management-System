using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPMS
{
    public class Conn
    {
        public MySqlConnection connect;
       private string server;
        private string database;
        private string user_id;
        private string password;
        public Conn()
        {
            server = "localhost";
            database = "gpms";
            user_id = "root";
            password = "";
            string ConnectionString;
            ConnectionString = "SERVER=" + server + ";" + "DATABASE=" +database + ";" + "USERID=" + user_id + ";" + "PASSWORD=" + password + ";";

            connect = new MySqlConnection(ConnectionString);

        }
        public void executeQuery(string query) {
            OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, connect);

        }

        public bool OpenConnection()
        {
            try
            {
                connect.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, mother fucker try again");
                        break;
                }
                return false;

            }
        }
        public bool CloseConnection()
        {
            try
            {
                connect.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return false;
        }
    }
      
}


