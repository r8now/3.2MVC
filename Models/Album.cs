using System.ComponentModel.DataAnnotations;

namespace Moment32.Models
{
    public class Album
    {

        public int AlbumID { get; set; }

        [Required]
        public string? AlbumName { get; set; }
        public string? Genre { get; set; }

        public double Price { get; set; }

        [Required]
        public int ArtistID { get; set; }
        public Artist? Artist { get; set; }

    }
}
