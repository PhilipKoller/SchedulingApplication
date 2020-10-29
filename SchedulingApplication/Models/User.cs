
using System.ComponentModel.DataAnnotations;

namespace SchedulingApplication.Models
{
    public class User
    {

        public int Id { get; set; }
       
        [Required]
        [EmailAddress]
     
        public string Email { get; set; }


        [Required, MaxLength(50)]
        public string Password { get; set; }

        public string Phone { get; set; }

        [Required]
        public Area? Area { get; set; }

        [Required]
        public Rank? Rank { get; set; }

        [Required, MaxLength(50)]
        public string FirstName { get; set; }

        [Required, MaxLength(50)]
        public string LastName { get; set; }

  



    }
}
