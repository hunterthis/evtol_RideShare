using System.ComponentModel.DataAnnotations;
namespace evtol_RideShare.Models
{
    public class Pilot
    {
        [Key]
        public int FTN { get; set; }
        public string? Name { get; set; }
        /// <summary>
        /// Federal Aviation Administration
        /// </summary>
    }

        

    /// <summary>
    /// Creates cookies model for pilots storing FAA tracking number as int and Name combo
    /// </summary>

}
