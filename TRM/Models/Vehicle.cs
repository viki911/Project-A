using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRM.Models
{
    public class Vehicle
    {
        [Key]public string? VehicleId { get; set; }
        public int Capacity { get; set; }
        public int AvailSeats { get; set; }
        public bool Isoperable { get; set; }
        [ForeignKey("RouteStop")]
        public int RouteStopId { get; set; }
        public RouteStop ?RouteStop { get; set; }

    }
}
