using System.ComponentModel.DataAnnotations;

namespace rp_ef_maria.Models;

public class Game
{
    public uint GameId { get; set; }

    // = "" makes the default an empty string
    public string Title { get; set; } = "";

    [Display(Name = "Release Date")]
    // data type for the ReleaseDate
    [DataType(DataType.Date)]
    public DateTime ReleaseDate { get; set; }

    public string Genre { get; set; } = "";

    public decimal Price { get; set; }
}