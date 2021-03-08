
using System.ComponentModel.DataAnnotations;

namespace SchedulingApplication.Models
{
    public class User
    {

        public int Id { get; set; }
       
        [Required]
        [EmailAddress]
     
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string Phone { get; set; }

        [Required]
        public Area? Area { get; set; }

        [Required]
        public Rank? Rank { get; set; }

        [Required(ErrorMessage = "First Name Is Required"), MaxLength(50)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name Required"), MaxLength(50)]
        public string LastName { get; set; }

  



    }
}
