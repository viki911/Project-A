using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TRM.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string ?EmpName { get; set; }
        public int Age { get; set; }
        public string ?Location { get; set; }
        
        public double Phone { get; set; }

        [ForeignKey("RouteStop")]
        public int RouteStopId { get; set; }
        public RouteStop? RouteStop { get; set; }
        
    }
}
