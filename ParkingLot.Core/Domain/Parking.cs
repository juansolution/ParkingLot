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
        public string nombre { get; set; }

        public string direccion { get; set; }

        public int ciudad { get; set; }

        public int departamento { get; set; }

        public float longitud { get; set; }

        public int latitud { get; set; }

    }
}
