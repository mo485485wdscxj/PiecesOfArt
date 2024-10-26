using PiecesOfArt.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace PiecesOfArt.Models
{
    public class LoyaltyCard
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List <User> Users { get; set; }
    }

}
