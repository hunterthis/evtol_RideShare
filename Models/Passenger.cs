using System.ComponentModel.DataAnnotations;

namespace evtol_RideShare.Models
{
    public class Passenger
    {
        [Key]
        public string Email { get; set; } = null!;
        [Required]
        public string? Name { get; set; }
        public string? password { get; set; }
    }
    public class LoginViewModel
    {
        [Key]
        public string Email { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
    }
}
