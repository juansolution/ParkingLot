using System.ComponentModel.DataAnnotations;

namespace ParkingLot.Infrastructure.Entity
{
    public class personas
    {
        [Key]
        public int id { get; set; }
        [MaxLength(250)]
        public string usuario { get; set; }
        [MaxLength(50)]
        public string clave { get; set; }
        public int cedula { get; set; }
        [MaxLength(50)]
        public string nombre { get; set; }
        [MaxLength(50)]
        public string apellido { get; set; }


    }
}