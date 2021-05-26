using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CarsDatabase
{
    public partial class frmreport : Form
    {
        DBConnection db1 = null;
        List<Cardetails> list = new List<Cardetails>();
        public frmreport()
        {
            InitializeComponent();
        }

        private void frmreport_Load(object sender, EventArgs e)
        {
            this.db1 = new DBConnection("localhost", "hire", "csharp", "password");

            if (this.db1.Connect())
            {
               
            }
            DBCars dbcars = new DBCars();
            MySqlDataReader reader1 = dbcars.GetCars(this.db1.Connection);

            List<DBCars> print = new List<DBCars>();


            TextBox textbox1 = new TextBox();
            textbox1.Multiline = true;

            textBox1.Text = "Vehicle regno    Make    Enginesize   Date registered   Rental per day    Availability";
            textBox1.AppendText(Environment.NewLine);
            textbox1.Text = "********************************************************************************************";
            textBox1.AppendText(Environment.NewLine);
            while (reader1.Read())
            {

                DBCars details = new DBCars();

                string regno = reader1.GetString(0);
                string make = reader1.GetString(1);
                string engine = reader1.GetString(2);
                DateTime dateregistered = reader1.GetDateTime(3);
                double rent = reader1.GetInt32(4);
                int available = reader1.GetInt32(5);

                string message = regno + "     " + make + "      " + engine + "    " + dateregistered + "     " + rent + "       " +
                    "" + available ;

                details.printdetails = message;

                print.Add(details);

                textBox1.Text += message;
                textBox1.AppendText(Environment.NewLine);



            }

            reader1.Close();

            foreach(var item in list)
            {
                textBox1.Text = string.Join("", list);
            }
            
        }
    }
}
