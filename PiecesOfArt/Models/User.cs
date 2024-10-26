using PiecesOfArt.Models;
using System.ComponentModel.DataAnnotations;

namespace PiecesOfArt.Models
{
    public class User
    {
        [Key]
        public string Name { get; set; }
        public int Id { get; set; }

        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string Email { get; set; }
        public int Age { get; set; }

        public ICollection<PieceOfArt> PiecesOfArt { get; set; }

        public int LoyaltyCardId { get; set; }
        public LoyaltyCard LoyaltyCard { get; set; }
    }
}