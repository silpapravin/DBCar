using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarsDatabase
{
    class DBConnection
    {
        MySqlConnection connection = null;
        string connectionstring;

        public MySqlConnection Connection { get => connection; }

        public DBConnection(string Servername, string Databasename, string username, string password)
        {
            this.connectionstring = string.Format($"SERVER={Servername};DATABASE={Databasename};UID={username};PASSWORD={password};");

        }
        public bool Connect()
        {
            bool succed = true;
            try
            {
                this.connection = new MySqlConnection(this.connectionstring);
                this.connection.Open();
            }
            catch(MySqlException ex)
            {
                succed = false;
                switch(ex.Number)
                {
                    case 0:
                        MessageBox.Show("Authentication failed");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid login credentials");
                        break;
                    default:
                        MessageBox.Show("Exception found");
                        break;
                }
            }
            return succed;
        }
        public bool Close()
        {
            bool suceed = true;
            try
            {
                this.connection.Close();

            }
            catch(MySqlException )
            {
                suceed = false;
                MessageBox.Show("Exception found");

            }
            return suceed;

        }
    }
}
