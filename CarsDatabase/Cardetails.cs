using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsDatabase
{
    class Cardetails
    {
        private string vehicleregno;
        private string make;
        private string enginesize;
        private DateTime dateregistered;
        private double rentalperday;
        private int available;

        public Cardetails()
        {
        }

        public Cardetails(string vehicleregno, string make, string enginesize, DateTime dateregistered, double rentalperday, int available)
        {
            this.vehicleregno = vehicleregno;
            this.make = make;
            this.enginesize = enginesize;
            this.dateregistered = dateregistered;
            this.rentalperday = rentalperday;
            this.available = available;
        }

        public string Vehicleregno { get => vehicleregno; set => vehicleregno = value; }
        public string Make { get => make; set => make = value; }
        public string Enginesize { get => enginesize; set => enginesize = value; }
        public DateTime Dateregistered { get => dateregistered; set => dateregistered = value; }
        public double Rentalperday { get => rentalperday; set => rentalperday = value; }
        public int Available { get => available; set => available = value; }
    }
}
