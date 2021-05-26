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
    public partial class frmCars : Form
    {
        DBConnection db = null;
        int rcount = 0;
        List<Cardetails> list = new List<Cardetails>();
        public frmCars()
        {
            InitializeComponent();
        }

        private void frmCars_Load(object sender, EventArgs e)
        {

            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(this.txtvehicleregno, "Enter Vehicle regno");
            tooltip.SetToolTip(this.txtmake, "Enter Make");
            tooltip.SetToolTip(this.txtenginesize, "Enter Enginesize");
            tooltip.SetToolTip(this.txtdateregistered, "Enter date Registered");
            tooltip.SetToolTip(this.txtrentalperday, "Enter Rental per day");

            ConnectDatabase();  //connecting to database//
            ListUpdate();      // Adding all records to list//
            DisplayItems(list[rcount]);   // Displaying first code//
        }


        //   Database connection function//

        private void ConnectDatabase()
        {

            this.db = new DBConnection("localhost", "hire", "csharp", "password");
            if (this.db.Connect()==false)
            {
                MessageBox.Show("Problem connecting to mysql server");
            }

        }

        //function to read from databse and add to the list//

        private void ListUpdate()
        {
            list.Clear();
            DBCars dbcars = new DBCars();
            MySqlDataReader reader = dbcars.GetCars(this.db.Connection);

            while (reader.Read())
            {
                Cardetails details = new Cardetails();
                details.Vehicleregno = reader.GetString(0);
                details.Make = reader.GetString(1);
                details.Enginesize = reader.GetString(2);
                details.Dateregistered = reader.GetDateTime(3);
                details.Rentalperday = reader.GetDouble(4);
                details.Available = reader.GetInt32(5);

                list.Add(details);
            }
            reader.Close();

        }


        // function to display records//

        private void DisplayItems(Cardetails details)
        {

            
            txtvehicleregno.Text = details.Vehicleregno;
            txtmake.Text = details.Make;
            txtenginesize.Text = details.Enginesize;
            txtdateregistered.Text = $"{details.Dateregistered:dd-MM-yyyy}";
            txtrentalperday.Text = $"€{details.Rentalperday:n2}";
            int status = details.Available;
            if (status == 0)
                chkavailable.Checked = false;
            else
                chkavailable.Checked = true;
            this.txtrecord.Text = this.NavigationStatus();
        }

        // function to show the index of records//

        private string NavigationStatus()
        {
            string recordstatus = $"{rcount + 1} of {list.Count}";
            return recordstatus;
        }

        // function to get car details from form//

        private Cardetails CreateCarFromForm()
        {
            DBCars dbcars = new DBCars();
            string vehicleregno=txtvehicleregno.Text;
            if (ValidateVehicleRegno(vehicleregno)==false)
            {
                return null;
            }

            string make = txtmake.Text;
            string enginesize = txtenginesize.Text;
            DateTime dateregistered;
            if(DateTime.TryParse(this.txtdateregistered.Text,out dateregistered)==false)
            {
                MessageBox.Show("Enter a valid date", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            string costsubstring = "";
            if(this.txtrentalperday.Text.Length>0)
            {
                costsubstring = this.txtrentalperday.Text.Substring(1);
            }
            Double rentalperday;
            if(double.TryParse(costsubstring,out rentalperday)==false)
            {
                MessageBox.Show("Enter a valid rental per day" , "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            int available;
            if (chkavailable.Checked == true)
                available = 1;
            else
                available = 0;

            Cardetails cardetails = new Cardetails(vehicleregno, make, enginesize, dateregistered, rentalperday, available);
            return cardetails;
        }

        private bool ValidateVehicleRegno(string vehicleregno)
        {
            if((vehicleregno.Length>0) && (vehicleregno.Length<20))
            {
                return true;
            }
            MessageBox.Show("Enter a valid Registration number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return false;
        }


        //update function//
        private void txtupdate_Click(object sender, EventArgs e)
        {
           
            DBCars dbcars = new DBCars();

            Cardetails cardetails = CreateCarFromForm();

            string originalvehicleregno=(this.list[this.rcount]).Vehicleregno;
            
            if(cardetails==null)
            {
                return;
            }

            if (dbcars.Update(this.db.Connection,originalvehicleregno,cardetails)==true)
            {
                this.list[this.rcount] = cardetails;
                MessageBox.Show("Record updated");
            }
           
        }

        private void txtadd_Click(object sender, EventArgs e)
        {
            DBCars dbcars = new DBCars();
            Cardetails cardetails = CreateCarFromForm();

            if (cardetails == null)
            {
                return;
            }


            if (dbcars.Insert(this.db.Connection, cardetails) == true)
            {
                this.list.Add(cardetails);
                int count = list.Count;
                rcount = count - 1;
                MessageBox.Show("Record has been inserted");
                ListUpdate();
            }

        }


        private void txtdelete_Click(object sender, EventArgs e)
        {
            
            DBCars dbcars = new DBCars();
            Cardetails cardetails = new Cardetails();
            string vehicleregno = txtvehicleregno.Text;
            DialogResult result = MessageBox.Show($"You are going to delete a record.Are you want to continue?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if(result==DialogResult.No)
            {
                return;
            }
            if (dbcars.Delete(this.db.Connection, cardetails))
            {
                MessageBox.Show("Record is deleted");
                this.list.RemoveAt(this.rcount);
                if (this.rcount == this.list.Count)
                {
                    this.rcount--;
                }
                DisplayItems(list[rcount]);
            }
           
        }

       

        private void buttonfirst_Click(object sender, EventArgs e)
        {
            rcount = 0;
            DisplayItems(list[rcount]);


        }





        private void buttonlast_Click(object sender, EventArgs e)
        {
            int n = list.Count;
            rcount = n - 1;
            DisplayItems(list[rcount]);
            
        }

        private void buttonnext_Click(object sender, EventArgs e)
        {
            int n = this.list.Count;
            if (rcount > n - 1)
                rcount = n - 1;
            else
                rcount = rcount + 1;
            DisplayItems(list[rcount]);
            
        }

       

        private void txtexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonprevious_Click(object sender, EventArgs e)
        {
            if (rcount == 0)
                rcount = 0;
            else
                rcount = rcount - 1;
            DisplayItems(list[rcount]);
            


        }

        private void txtsearch_Click(object sender, EventArgs e)
        {
            frmreport reportform = new frmreport();
            reportform.ShowDialog();
        }

        private void txtcancel_Click(object sender, EventArgs e)
        {


        }
    }
    
}
