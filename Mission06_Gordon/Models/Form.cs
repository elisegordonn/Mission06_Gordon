using System.ComponentModel.DataAnnotations;

namespace Mission06_Gordon.Models
{
    public class Form
    {
        // set the id to MovieID; generate for each row
        [Key]
        [Required]
        public int MovieID { get; set; }
        [Required(ErrorMessage = "Category is required.")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Year is required.")]
        public string Year { get; set; }
        [Required(ErrorMessage = "Direcctor is required.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "Rating is required.")]
        public string Rating { get; set; }
        public bool ? Edited { get; set; }
        public string ? LentTo { get; set; }
        
        [StringLength(25, ErrorMessage = "Notes must be at most 25 characters long.")]
        public string ? Notes { get; set; }

    }
}

