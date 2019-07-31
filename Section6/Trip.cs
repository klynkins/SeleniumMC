using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    class Trip
    {
        private string destination;
        private double distanceTravelled;
        private decimal fuelCost;
        private double gallonsConsumed;

        public Trip(string dest, double distance, decimal cost, double gallons)
        {
            Destination = dest;
            DistanceTravelled = distance;
            FuelCost = cost;
            GallonsConsumed = gallons;
        }



        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }

        }
        public double DistanceTravelled
        {
            get
            {
                return distanceTravelled;
            }
            set
            {
                distanceTravelled = value;
            }

        }
        public decimal FuelCost
        {
            get
            {
                return fuelCost;
            }
            set
            {
                fuelCost = value;
            }

        }
        public double GallonsConsumed
        {
            get
            {
                return gallonsConsumed;
            }
            set
            {
                gallonsConsumed = value;
            }
        }
        public double MilesPerGallon()
        {
            return DistanceTravelled / GallonsConsumed;
        }

        public decimal CostPerMile()
        {
            return FuelCost / Convert.ToDecimal(DistanceTravelled);
        }

        public override string ToString()
        {
            return "Destination: " + Destination +
                "\nTotal Miles: " + DistanceTravelled +
                "\nFuel Consumed: " + GallonsConsumed.ToString("f1") + " gallons" +
                "\nCost: " + FuelCost.ToString("c") +
                "\nMPG: " + MilesPerGallon().ToString("f0") +
                "\nCost Per Mile: " + CostPerMile().ToString("c");
        }
    }
}

