using System.ComponentModel.DataAnnotations;
namespace gendarazorpages.Pages.Dances
{
    public class Dances
    {
        public int ID { get; set; }
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; } = string.Empty;
        public decimal Price { get; set; }

    }
}
