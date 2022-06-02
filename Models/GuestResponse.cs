using System.ComponentModel.DataAnnotations;
namespace rsvpApplication.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Please Enter Your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Phone Number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please Specify Whether You will Attend")]
        public bool? WillAttend { get; set; }

    }
}
