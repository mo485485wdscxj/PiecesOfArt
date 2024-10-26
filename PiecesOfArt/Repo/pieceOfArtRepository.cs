using Microsoft.EntityFrameworkCore;
using PiecesOfArt.Interface;
using PiecesOfArt.Models;

namespace PiecesOfArt.Repo
{
    public class PieceOfArtRepository : IPieceOfArtRepository
    {
        private readonly ApppDbContext _context;

        public PieceOfArtRepository(ApppDbContext context)
        {
            _context = context;
        }

        public async Task<PieceOfArt> GetByIdAsync(int id)
        {
            return await _context.PiecesOfArt.FindAsync(id);
        }

        public async Task<IEnumerable<PieceOfArt>> GetAllAsync()
        {
            return await _context.PiecesOfArt.ToListAsync();
        }

        public async Task AddAsync(PieceOfArt pieceOfArt)
        {
            await _context.PiecesOfArt.AddAsync(pieceOfArt);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(PieceOfArt pieceOfArt)
        {
            _context.PiecesOfArt.Update(pieceOfArt);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var pieceOfArt = await GetByIdAsync(id);
            if (pieceOfArt != null)
            {
                _context.PiecesOfArt.Remove(pieceOfArt);
                await _context.SaveChangesAsync();
            }
        }
    }

}
