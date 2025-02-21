using System.ComponentModel.DataAnnotations;

namespace JoelHiltonFilmCollection.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public int? CategoryId { get; set; }
        [Required]
        public string Title { get; set; } = null!;
        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "Year must be 1888 or later.")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; }
        public Category? Category { get; set; }
    }
}