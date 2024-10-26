using Microsoft.EntityFrameworkCore;
using PiecesOfArt.Interface;
using PiecesOfArt.Models;

namespace PiecesOfArt.Repo
{
    public class LoyaltyCardRepository : ILoyaltyCardRepository
    {
        private readonly ApppDbContext _context;

        public LoyaltyCardRepository(ApppDbContext context)
        {
            _context = context;
        }

        public async Task<LoyaltyCard> GetByIdAsync(int id)
        {
            return await _context.LoyaltyCards.FindAsync(id);
        }

        public async Task<IEnumerable<LoyaltyCard>> GetAllAsync()
        {
            return await _context.LoyaltyCards.ToListAsync();
        }

        public async Task AddAsync(LoyaltyCard loyaltyCard)
        {
            await _context.LoyaltyCards.AddAsync(loyaltyCard);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(LoyaltyCard loyaltyCard)
        {
            _context.LoyaltyCards.Update(loyaltyCard);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var loyaltyCard = await GetByIdAsync(id);
            if (loyaltyCard != null)
            {
                _context.LoyaltyCards.Remove(loyaltyCard);
                await _context.SaveChangesAsync();
            }
        }
    }

}
