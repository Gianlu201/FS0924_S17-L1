using System.ComponentModel.DataAnnotations;

namespace FS0924_S17_L1.ViewModels
{
    public class AddBookViewModel
    {
        [Required]
        [StringLength(
            50,
            ErrorMessage = "Name must contain from 2 to 50 chars!",
            MinimumLength = 2
        )]
        [Display(Name = "Title")]
        public required string Title { get; set; }

        [Required]
        [StringLength(
            50,
            ErrorMessage = "Author must contain from 2 to 50 chars!",
            MinimumLength = 2
        )]
        [Display(Name = "Author")]
        public required string Author { get; set; }

        [Required]
        [StringLength(
            50,
            ErrorMessage = "Category must contain from 2 to 50 chars!",
            MinimumLength = 2
        )]
        [Display(Name = "Category")]
        public required string Category { get; set; }

        [Display(Name = "Available")]
        public required bool Available { get; set; }

        [Display(Name = "Cover")]
        public string? Cover { get; set; }
    }
}
