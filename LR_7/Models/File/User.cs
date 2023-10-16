using System.ComponentModel.DataAnnotations;

namespace LR_7.Models.File
{
    public class User
    {
        [Required(ErrorMessage = "User's name is required")]
        [MinLength(2, ErrorMessage = "User's name must have at least 2 characters")]
        public string Name { get; set; } = String.Empty;

        [Required(ErrorMessage = "User's surname is required")]
        [MinLength(2, ErrorMessage = "User's surname must have at least 2 characters")]
        public string Surname { get; set; } = String.Empty;
    }
}
