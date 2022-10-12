using System.ComponentModel.DataAnnotations;
namespace evtol_RideShare.Models
{
    public class Pilot
    {
        private string FAANumber;

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
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
