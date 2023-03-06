using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRM.Models
{
    public class Allocate
    {
        [Key] public int AllocateId { get; set; }
        [ForeignKey("Vehicle")]
        public string? VehicleId { get; set; }
        public Vehicle ?Vehicle { get; set; }
        [ForeignKey("Employee")]
        public int EmpId { get; set; }
        public Employee ?Employee { get; set; }
        [ForeignKey("RouteStop")]
        public int RouteStopId { get; set; }
        public RouteStop? RouteStop { get; set; }

   
    }
  
}
