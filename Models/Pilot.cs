using System.ComponentModel.DataAnnotations;
namespace evtol_RideShare.Models
{
    public class Pilot
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
     //   public string FAANumber { get; set; }
     // uncomment once FAA number is entered into database
    }

    /// <summary>
    /// Creates cookies model for passengers to retrieve pilot information including FAA Number 
    /// </summary>

    public class PilotViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
     //   public string FAANumber { get; set; }
    }
}
