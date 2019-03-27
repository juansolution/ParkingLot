using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingLot.Core.Domain
{
    public class Parking
    {
        public Parking()
        {

        }
        public string Name { get; set; }

        public string Adress { get; set; }

        public int City { get; set; }

        public int Department { get; set; }

        public float Longitude { get; set; }

        public int Latitude { get; set; }

    }
}
