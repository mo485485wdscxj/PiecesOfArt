using PiecesOfArt.Models;
using System.ComponentModel.DataAnnotations;

    public class PieceOfArt
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public DateTime PublicationDate { get; set; }
        [Required]
        public decimal Price { get; set; }


        // ForeignKey
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }



