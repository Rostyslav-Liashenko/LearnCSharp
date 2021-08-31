using System.ComponentModel.DataAnnotations;

namespace LearnValidation
{
    [UserValidation]
    public class User
    {
        [Required(ErrorMessage = "User id not set")]
        public string Id { get; set; }

        [Required(ErrorMessage = "Username not specified")]
        [UserName]
        public string Name { get; set; }
        
        [Required]
        [Range(1, 100, ErrorMessage = "Invalid age")]
        public int Age { get; set; }
    }
}
