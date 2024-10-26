using PiecesOfArt.Models;

namespace PiecesOfArt.Interface
{
    public interface ILoyaltyCardRepository
    {
        Task<LoyaltyCard> GetByIdAsync(int id);
        Task<IEnumerable<LoyaltyCard>> GetAllAsync();
        Task AddAsync(LoyaltyCard loyaltyCard);
        Task UpdateAsync(LoyaltyCard loyaltyCard);
        Task DeleteAsync(int id);
    }
}
