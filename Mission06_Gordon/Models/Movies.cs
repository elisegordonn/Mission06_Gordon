using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Gordon.Models
{
    public class Movies
    {
        // set the id to MovieId; generate for each row
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Categories? Category { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        [Range(1888, int.MaxValue)]
        public int Year { get; set; }
        public string ? Director { get; set; }
        public string ? Rating { get; set; }
        [Required(ErrorMessage = "Edited is required.")]
        public bool Edited { get; set; }
        public string ? LentTo { get; set; }
        [Required(ErrorMessage = "Copied to Plex is required.")]
        public bool CopiedToPlex { get; set; }
        
        [StringLength(25, ErrorMessage = "Notes must be at most 25 characters long.")]
        public string ? Notes { get; set; }

    }
}

