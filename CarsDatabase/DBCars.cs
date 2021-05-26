
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CarsDatabase
{
    class DBCars
    {
        public string Registrationno { get; set; }
        public string Make { get; set; }
        public string Enginesize { get; set; }
        public DateTime Dateregistered { get; set; }
        public double Rentalperday { get; set; }
        public int Available { get; set; }

        public string printdetails;

        public MySqlDataReader GetCars(MySqlConnection connection)
        {
            string sql = "select * from car;";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataReader reader= null;

            try
            {
                reader = cmd.ExecuteReader();
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Exception found", ex.Message);
            }

            return reader;
        }

        public bool Insert(MySqlConnection connection,Cardetails cardetails)
        {
            string sql = "INSERT into car(vehicleregno,make,enginesize,dateregistered,rentalperday,available) values(@vehicleregno,@make,@enginesize,@dateregistered" +
                "" +
                ",@rentalperday,@available);";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@vehicleregno", cardetails.Vehicleregno);
            cmd.Parameters.AddWithValue("@make", cardetails.Make);
            cmd.Parameters.AddWithValue("@enginesize", cardetails.Enginesize);
            cmd.Parameters.AddWithValue("@dateregistered", cardetails.Dateregistered);
            cmd.Parameters.AddWithValue("@rentalperday", cardetails.Rentalperday);
            cmd.Parameters.AddWithValue("@available", cardetails.Available);
            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Exception found", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool Update(MySqlConnection connection, string originalvehicleregno, Cardetails cardetails)
        {
            string sql = "UPDATE car SET vehicleregno=@vehicleregno,make=@make,enginesize=@enginesize,dateregistered=@dateregistered,rentalperday=@rentalperday,available=@available where vehicleregno=@originalvehicleregno;";

            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@originalvehicleregno", originalvehicleregno);
            cmd.Parameters.AddWithValue("@vehicleregno", cardetails.Vehicleregno);
            cmd.Parameters.AddWithValue("@make", cardetails.Make);
            cmd.Parameters.AddWithValue("@enginesize", cardetails.Enginesize);
            cmd.Parameters.AddWithValue("@dateregistered", cardetails.Dateregistered);
            cmd.Parameters.AddWithValue("@rentalperday", cardetails.Rentalperday);
            cmd.Parameters.AddWithValue("@available", cardetails.Available);
            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Exception found", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public bool Delete(MySqlConnection connection,Cardetails cardetails)
        {
            string sql = "Delete from car where vehicleregno=@vehicleregno";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.AddWithValue("@vehicleregno", cardetails.Vehicleregno);
            
            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Exception found", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public MySqlDataReader Tostring(MySqlConnection connection)
        {
            string sql1 = "select * from car;";
            MySqlCommand cmd = new MySqlCommand(sql1, connection);
            MySqlDataReader reader1 = null;

            try
            {
                reader1 = cmd.ExecuteReader();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Exception found", ex.Message);
            }

            return reader1;

        }
    }
}

