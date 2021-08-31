using System.ComponentModel.DataAnnotations;

namespace LearnValidation
{
    public class User
    {
        [Required(ErrorMessage = "User id not set")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Username not specified")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Invalid name length")]
        public string Name { get; set; }
        
        [Required]
        [Range(1, 100, ErrorMessage = "Invalid age")]
        public int Age { get; set; }
    }
}
