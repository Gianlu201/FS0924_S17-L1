using System.ComponentModel.DataAnnotations;

namespace FS0924_S17_L1.Models
{
    public class Book
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(50)]
        public required string Title { get; set; }

        [Required]
        [StringLength(50)]
        public required string Author { get; set; }

        [Required]
        [StringLength(50)]
        public required string Category { get; set; }

        [Required]
        public required bool Available { get; set; }

        public string? Cover { get; set; }
    }
}
