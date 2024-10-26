using System.ComponentModel.DataAnnotations;

namespace PiecesOfArt.Models
{
    public class Category
    {
        
        public int Id { get; set; }
        public string Description { get; set; }

        [Required]
        public string Name { get; set; }


        public List<PieceOfArt> PiecesOfArt { get; set; }
    }
}
