using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRM.Models
{
    public class RouteStop
    {
        [Key] 
        public int RouteStopId { get; set; }
        public string ?RouteStopName1 { get; set;}
        public string? RouteStopName2 { get; set; }
        public string? RouteStopName3 { get; set; }

        [ForeignKey("Vehicle")]
        public int VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

    }
}
