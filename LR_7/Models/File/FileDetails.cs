using System.ComponentModel.DataAnnotations;

namespace LR_7.Models.File
{
    public class FileDetails
    {
        [Required(ErrorMessage = "File's name is required")]
        [RegularExpression("^\\w(?:[\\w .-]*\\w)?$")]
        public string Name { get; set; } = String.Empty;
    }
}
