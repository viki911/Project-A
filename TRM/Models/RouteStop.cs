using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing.Printing;

namespace TRM.Models
{
    public class RouteStop
    {
        [Key] 
        public int RouteStopId { get; set; }
        public string ?RouteStopName1 { get; set;}
        public string? RouteStopName2 { get; set; }
        public string? RouteStopName3 { get; set; }

      

    }

}
