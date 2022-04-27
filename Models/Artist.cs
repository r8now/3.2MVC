using System.ComponentModel.DataAnnotations;

namespace Moment32.Models
{
    public class Artist
    {
        //Properies
        [Display(Name = "Artist")]
        public int ArtistID { get; set; }

        [Required]
        public string? ArtistName { get; set; }

    }
}
