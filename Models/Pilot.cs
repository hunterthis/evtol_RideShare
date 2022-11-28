using System.ComponentModel.DataAnnotations;
namespace evtol_RideShare.Models
{
    public class Pilot
    {
        private readonly string? FAANumber;

        [Key]
        public int FTN { get; set; }
        public string? Name { get; set; }
        /// <summary>
        /// Federal Aviation Administration
        /// </summary>
       // public string FAA tracking number (FTN) { get => FTN; set => FTN = value; }
        // TO DO: implement FAA number restrictions
    }

        

    /// <summary>
    /// Creates cookies model for passengers to retrieve pilot information including FAA Number 
    /// </summary>

}
