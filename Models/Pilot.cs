using System.ComponentModel.DataAnnotations;
namespace evtol_RideShare.Models
{
    public class Pilot
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        private string? FAANumber;
        /// <summary>
        /// Federal Aviation Administration
        /// </summary>
       // public string FAANumber { get => FAANumber; set => FAANumber = value; }
        // TO DO: implement FAA number restrictions
    }

        

    /// <summary>
    /// Creates cookies model for passengers to retrieve pilot information including FAA Number 
    /// </summary>

}
