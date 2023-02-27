using System.ComponentModel.DataAnnotations;

namespace TRM.Models
{
    public class Vehicle
    {
        [Key]public int VehicleId { get; set; }
        public int Capacity { get; set; }
        public int AvailSeats { get; set; }
        public bool Isoperable { get; set; }

      
    }
}
